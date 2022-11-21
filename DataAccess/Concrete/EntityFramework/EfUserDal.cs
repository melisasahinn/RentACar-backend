
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, ReCapContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new ReCapContext())
            {
                var result = from oc in context.OperationClaims
                             join usc in context.UserOperationClaims
                                 on oc.Id equals usc.OperationClaimId
                             where usc.UserId == user.Id
                             select new OperationClaim { Id = oc.Id, Name = oc.Name };
                return result.ToList();

            }
        }
    }
}