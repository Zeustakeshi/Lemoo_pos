using Lemoo_pos.Data;
using Lemoo_pos.Models;
using Lemoo_pos.Models.Entities;
using Lemoo_pos.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lemoo_pos.Services
{
    public class AuthService : IAuthService
    {
        private readonly ApplicationDbContext _db;
        
        public AuthService (ApplicationDbContext db)
        {
            _db = db;
        }

        public void CreateAccount( CreateStoreModel createAccountModel)
        {
            Store existedStore = _db.Stores.Where(s => s.Name.Equals(createAccountModel.StoreName)).FirstOrDefault();

            if (existedStore != null)
            {
                throw new Exception("Tên cửa hàng đã tồn tại");
			}

            // TODO: hash password here

            CreateStoreTmp createStoreTmp = new CreateStoreTmp {
                Email = createAccountModel.Email,
                Password = createAccountModel.Password,
                Phone = createAccountModel.Phone,
                StoreName = createAccountModel.StoreName,
                StoreOwnerName = createAccountModel.StoreOwnerName
            };

            _db.CreateStoreTmps.Add(createStoreTmp);
            _db.SaveChanges();

            // send an email with code to user account 
            Console.WriteLine(createStoreTmp.Code);
        }
    }
}
