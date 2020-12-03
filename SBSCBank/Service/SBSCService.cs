using SBSCBank.Data;
using SBSCBank.Dtos;
using SBSCBank.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBSCBank.Service
{
    public class SBSCService : ISBSCService
    { 
       
        private readonly ApplicationDbContext _context;
        public SBSCService(ApplicationDbContext context)
        {
           
            _context = context;
        }
        public List<UserInfo> GetUsers()
        {
            var list = _context.userInfos.ToList();
            return list;
            
        }
    }
}
