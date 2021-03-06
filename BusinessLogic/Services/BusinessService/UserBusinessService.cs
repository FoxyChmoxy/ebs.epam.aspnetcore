﻿using AutoMapper;
using BusinessLogic.Dto;
using BusinessLogic.Mappings;
using DataAccess.Entities;
using Microsoft.Extensions.Caching.Memory;
using Common;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace BusinessLogic.Services.BusinessService
{
    public interface IUserBusinessService
    {
        Task<UserDto> GetUserById(int? id);
        Task<UserDto> GetUserByEmail(string email);
        Task<List<UserDto>> GetUsersBySearch(string email);
        Task<UserDto> GetUserByEmailAndPassword(string email, string password);
        Task<List<UserDto>> GetUsers();
        Task<UserDto> CreateUser(UserDto entity);
        Task<int> UpdateUser(UserDto entity);
        Task<int> DeleteUser(UserDto entity);
        Task<RoleDto> GetRoleById(Guid? id);
        Task<RoleDto> GetRoleByName(string name);
        Task<List<RoleDto>> GetRoles();
        Task NotifyUser(string email, string message);
    }

    public class UserBusinessService : IUserBusinessService
    {
        #region Initialize

        private readonly IUserService userService;
        private readonly IRoleService roleService;
        private readonly IEmailService emailService;
        private readonly IMemoryCache cache;
        private readonly IMapper mapper;

        public UserBusinessService(IUserService userService, IMemoryCache cache,
            IRoleService roleService, IEmailService emailService)
        {
            this.userService = userService;
            this.roleService = roleService;
            this.emailService = emailService;
            this.cache = cache;
            this.mapper = MapperConfig.MapperInitialize();
        }

        #endregion

        public async Task<UserDto> GetUserByEmail(string email)
        {
            var user = await userService.Find(s => s.Email == email);
            return mapper.Map<User, UserDto> (user);
        }

        public async Task<UserDto> GetUserById(int? id)
        {
            User user = null;
            if (!cache.TryGetValue(id, out user))
            {
                user = await userService.Find(s => s.Id == id);
                if (user != null)
                {
                    cache.Set(user.Id, user,
                    new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromMinutes(30)));
                }
            }

            return mapper.Map<User, UserDto>(user);
        }

        public async Task<List<UserDto>> GetUsers()
        {
            var users = await userService.GetAll();
            var usersDto = mapper.Map<List<User>, List<UserDto>>(users);
            return usersDto;
        }

        public async Task<int> UpdateUser(UserDto dtoModel)
        {
            var entity = mapper.Map<UserDto, User>(dtoModel);
            cache.Set(dtoModel.Id, dtoModel,
                    new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromMinutes(30)));
            return await userService.Update(entity);
        }

        public async Task<UserDto> CreateUser(UserDto dtoModel)
        {
            var entity = mapper.Map<UserDto, User>(dtoModel);
            var result = await userService.Create(entity);
            if (result != null)
            {
                cache.Set(entity.Id, entity, new MemoryCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30)
                });
            }
            return mapper.Map<User, UserDto>(result);
        }

        public async Task<int> DeleteUser(UserDto dtoModel)
        {
            var entity = mapper.Map<UserDto, User>(dtoModel);
            return await userService.Delete(entity);
        }

        public async Task<RoleDto> GetRoleById(Guid? id)
        {
            Role role = null;
            if (!cache.TryGetValue(id, out role))
            {
                role = await roleService.Find(s => s.Id == id);
                if (role != null)
                {
                    cache.Set(role.Id, role,
                    new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromMinutes(30)));
                }
            }

            return mapper.Map<Role, RoleDto>(role);
        }

        public async Task<List<RoleDto>> GetRoles()
        {
            var roles = await roleService.GetAll();
            return mapper.Map<List<Role>, List<RoleDto>>(roles);
        }

        public async Task<UserDto> GetUserByEmailAndPassword(string email, string password)
        {
            var user = await userService.Find(s => s.Email == email &&
                    s.Password == PasswordHelper.Hash(password));
            return mapper.Map<User, UserDto>(user);
        }

        public async Task<RoleDto> GetRoleByName(string name)
        {
            var role = await roleService.Find(s => s.Name == name);
            return mapper.Map<Role, RoleDto>(role);
        }

        public async Task<List<UserDto>> GetUsersBySearch(string email)
        {
            var users = await userService.Filter(s => s.Email.Contains(email.ToLower()));
            return mapper.Map<List<User>, List<UserDto>>(users);
        }

        public async Task NotifyUser(string email, string message)
        {
            await emailService.SendEmailAsync(email, message);
        }
    }
}