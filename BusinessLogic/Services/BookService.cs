﻿using DataAccess.Models;
using BusinessLogic.Services.Base;
using DataAccess;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BusinessLogic.Loggers;

namespace BusinessLogic.Services
{
    public interface IBookService : IService<Book>
    {
        Task<List<Book>> GetBooksByUserId(int? id);
        Task<List<Book>> GetBooksSortedByDate();
        Task<List<BookGroup>> GetBooksCountByAuthor(string sql);
        Task<List<GoodBookList>> GetBooksByCondition(string sql, bool inGoodCondition);
        Task ViewBook(int bookId, int userId);
    }

    public class BookService : EntityService<Book>, IBookService
    {
        public BookService(EbsContext context) : base(context) { }

        public async Task<List<Book>> GetBooksByUserId(int? id)
        {
            return await DbSet
                .Include(u => u.User)
                .Where(s => s.UserId == id)
                .ToListAsync();
        }

        public override async Task<List<Book>> Filter(Expression<Func<Book, bool>> predicate)
        {
            return await DbSet
                .Include(u => u.User)
                .Where(predicate)
                .ToListAsync();
        }

        public override async Task<Book> Find(Expression<Func<Book, bool>> predicate)
        {
            return await DbSet
                .Include(u => u.User)
                .Where(predicate)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        public async Task<List<Book>> GetBooksSortedByDate()
        {
            return await DbSet
                .Include(u => u.User)
                .OrderByDescending(s => s.CreatedDate)
                .ToListAsync();
        }

        public async Task<List<BookGroup>> GetBooksCountByAuthor(string sql)
        {
            return await context.GetBooksCountByAuthor(sql);
        }

        public async Task<List<GoodBookList>> GetBooksByCondition(string sql, bool inGoodCondition)
        {
            return await context.GetBooksByCondition(sql, inGoodCondition);
        }

        /// <summary>
        /// Пользователь посмотрел эту книгу
        /// </summary>
        /// <param name="userId">Идентификатор пользователя</param>
        public async Task ViewBook(int bookId, int userId)
        {
            var book = await Find(s => s.Id == bookId);
            if(book != null && book.UserId != userId)
            {
                book.СlickCount++;
                await Update(book);
            }
        }
    }
}