using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPICore.IServices;
using WebAPICore.Models;


namespace WebAPICore.Services
{
    public class PolicyService:IPolicyService
    {

        APICoreDBContext dbContext;
        public PolicyService(APICoreDBContext _db)
        {
            dbContext = _db;
        }

        public IEnumerable<Policy> GetListPolicies()
        {
            var policies = dbContext.Policies.ToList();
            return policies;
        }

        public Policy GetPolicyById(string policyno)
        {
            var policyDetails = dbContext.Policies.FirstOrDefault(x => x.PolicyNumber == policyno);
            
            return policyDetails;
        }
    }
}
