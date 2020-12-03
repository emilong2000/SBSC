using SBSCBank.Data;
using SBSCBank.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBSCBank.IService
{
    public interface ISBSCService
    {
        List<UserInfo> GetUsers();
    }
}
