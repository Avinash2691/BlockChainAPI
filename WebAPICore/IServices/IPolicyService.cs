using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.Models;

namespace WebAPICore.IServices
{
    public interface IPolicyService
    {
        IEnumerable<Policy> GetListPolicies();
        Policy GetPolicyById(string policyno);
    }
}
