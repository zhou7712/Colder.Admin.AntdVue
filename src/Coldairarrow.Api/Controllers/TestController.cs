﻿using Coldairarrow.Entity.Base_Manage;
using EFCore.Sharding;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Coldairarrow.Api.Controllers
{
    [Route("/[controller]/[action]")]
    public class TestController : BaseController
    {
        readonly IRepository _repository;
        public TestController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task PressTest()
        {
            Base_User base_User = new Base_User
            {
                Id = Guid.NewGuid().ToString(),
                Birthday = DateTime.Now,
                CreateTime = DateTime.Now,
                CreatorId = Guid.NewGuid().ToString(),
                DepartmentId = Guid.NewGuid().ToString(),
                Password = Guid.NewGuid().ToString(),
                RealName = Guid.NewGuid().ToString(),
                Sex = Sex.Man,
                UserName = Guid.NewGuid().ToString()
            };

            await _repository.InsertAsync(base_User);
            await _repository.UpdateAsync(base_User);
            await _repository.GetIQueryable<Base_User>().Where(x => x.Id == base_User.Id).FirstOrDefaultAsync();
            await _repository.DeleteAsync(base_User);
        }

        [HttpGet]
        [CheckSign]
        public async Task PressTest2()
        {
            Base_User base_User = new Base_User
            {
                Id = Guid.NewGuid().ToString(),
                Birthday = DateTime.Now,
                CreateTime = DateTime.Now,
                CreatorId = Guid.NewGuid().ToString(),
                DepartmentId = Guid.NewGuid().ToString(),
                Password = Guid.NewGuid().ToString(),
                RealName = Guid.NewGuid().ToString(),
                Sex = Sex.Man,
                UserName = Guid.NewGuid().ToString()
            };

            await _repository.InsertAsync(base_User);
            await _repository.UpdateAsync(base_User);
            await _repository.GetIQueryable<Base_User>().Where(x => x.Id == base_User.Id).FirstOrDefaultAsync();
            await _repository.DeleteAsync(base_User);
        }
    }
}