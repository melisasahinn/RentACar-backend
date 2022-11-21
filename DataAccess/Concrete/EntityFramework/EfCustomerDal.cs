
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCapContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetailDto()
        {
            using (var context = new ReCapContext())
            {
                var result = from customer in context.Customers
                             join user in context.Users on customer.UserId equals user.Id
                             select new CustomerDetailDto()
                             {
                                 CompanyName = customer.CompanyName,
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 FindeksScore = customer.FindeksScore
                             };
                return result.ToList();
            }
        }
    }
}