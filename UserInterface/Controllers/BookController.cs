﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessLogic.Services.BusinessService;
using Microsoft.AspNetCore.Hosting;
using AutoMapper;
using UserInterface.ViewModels.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using System.IO;
using UserInterface.ViewModels;
using BusinessLogic.Dto;
using UserInterface.Controllers.Base;

namespace UserInterface.Controllers
{
    [Authorize]
    public class BookController : BaseMvcController
    {
        private readonly IUserBusinessService userBusinessService;
        private readonly IBookBusinessService bookBusinessService;

        public BookController(IBookBusinessService bookBusinessService, IMapper mapper,
            IWebHostEnvironment hostEnvironment, IUserBusinessService userBusinessService) 
            : base(mapper, hostEnvironment)
        {
            this.bookBusinessService = bookBusinessService;
            this.userBusinessService = userBusinessService;
        }

        /// <summary>
        /// Страница с поисковиком
        /// </summary>
        /// <param name="search">Объект поиска</param>
        public async Task<IActionResult> Index(string search)
        {
            var books = await bookBusinessService.GetBooksBySearchValue(search);
            var booksVM = mapper.Map<List<BookDto>, List<BookViewModel>>(books);
            ViewBag.Search = search;
            return View(booksVM);
        }

        /// <summary>
        /// Детальная информация о книге
        /// </summary>
        /// <param name="id">Идентификатор книги</param>
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var currentUser = await userBusinessService.GetUserByEmail(User.Identity.Name);
            var book = await bookBusinessService.GetBookById(id, currentUser.Id);
            var bookVM = mapper.Map<BookDto, BookViewModel>(book);
            var user = await userBusinessService.GetUserById(book.UserId);
            ViewBag.IsCurrentUser = user.Email == User.Identity.Name;
            return View(bookVM);
        }

        /// <summary>
        /// Получить список книг по пользователю
        /// </summary>
        /// <param name="id">Идентификатор пользователя</param>
        public async Task<IActionResult> ByUser(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await userBusinessService.GetUserById(id);
            if(user == null)
            {
                return NotFound();
            }

            var books = await bookBusinessService.GetBooksByUserId(id);
            var booksVM = mapper.Map<List<BookDto>, List<BookViewModel>>(
                books.OrderBy(s => s.CreatedDate).ToList());
            ViewBag.Email = user.Email;
            return View(booksVM);
        }


        /// <summary>
        /// Создать книгу
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var user = await userBusinessService.GetUserByEmail(User.Identity.Name);
            if(user == null)
            {
                return NotFound();
            }

            ViewBag.UserId = user.Id;
            return View(new BookViewModel());
        }

        /// <summary>
        /// Редактировать книгу
        /// </summary>
        /// <param name="id">Идентификатор книги</param>
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var book = await bookBusinessService.GetBookById(id, null, false);

            if(book == null)
            {
                return NotFound();
            }

            var user = await userBusinessService.GetUserById(book.UserId);
            if(user.Email != User.Identity.Name)
            {
                return RedirectToAction("Index", "User");
            }

            var bookVM = mapper.Map<BookDto, BookViewModel>(book);
            return View(bookVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, BookViewModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    var entity = await bookBusinessService.GetBookById(model.Id, null, false);
                    entity = mapper.Map(model, entity);

                    if (model.Image != null)
                        entity.ImageSource = CreateFile(model.Image.FileName, model.Image);

                    if (model.RemoveImage)
                        entity.ImageSource = null;

                    await bookBusinessService.UpdateBook(entity);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await BookExists(model.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Details), new { id = model.Id });
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await bookBusinessService.GetBookById(id, null, false);

            if (book == null)
            {
                return NotFound();
            }

            var user = await userBusinessService.GetUserById(book.UserId);
            if (user.Email != User.Identity.Name)
            {
                return RedirectToAction("Index", "User");
            }

            var bookVM = mapper.Map<BookDto, BookViewModel>(book);
            return View(bookVM);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id, BookViewModel model)
        {
            if(id != model.Id)
            {
                return NotFound();
            }

            var entity = await bookBusinessService.GetBookById(model.Id, null, false);

            if(entity.User.Email != User.Identity.Name)
            {
                return NotFound();
            }

            await bookBusinessService.DeleteBook(entity);

            return RedirectToAction("ByUser", new { id = entity.User.Id });
        }

        /// <summary>
        /// Проверка на наличие книги
        /// </summary>
        /// <param name="id">Идентификатор книги</param>
        /// <returns></returns>
        private async Task<bool> BookExists(int id)
        {
            return await bookBusinessService.GetBookById(id, null) != null;
        }
    }
}
