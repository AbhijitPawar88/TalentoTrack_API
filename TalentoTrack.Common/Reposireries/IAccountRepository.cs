using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalentoTrack.Common.Entities;

namespace TalentoTrack.Common.Reposireries
{
    public interface IAccountRepository
    {
        Task<LoginDetails> GetLoginDetails(string userName, string password);
    }
}
