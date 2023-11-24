using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentoTrack.Common.DTOs.Account;
using TalentoTrack.Common.Entities;
using TalentoTrack.Common.Reposireries;
using TalentoTrack.Dao.DB;


namespace TalentoTrack.Dao.Repositeries
{
    public class AccountRepository : IAccountRepository
    {
        public TalentoTrack_DbContext _DbContext;
        private object _dbContext;

        public AccountRepository(TalentoTrack_DbContext dbContext)
        {
            _DbContext = dbContext;
        }
        public async Task<LoginDetails> GetLoginDetails(string userName, string password)
        {
            var dbRecord= await _dbContext.tbl_login_details. Where(p=>(p.UserName!=null &&  p.UserName.Equals(userName)) && (p.Password!=null && p.Password.Equals(password))).FirstOrDefaultAsync();
           // var dbRecord = await _dbContext.tbl_login_details.Where(p => p.UserName.Equals(request.UserName) && p.Password.Equals(request.Password)).FirstOrDefaultAsync();

            return dbRecord;

        }
    }
}
     