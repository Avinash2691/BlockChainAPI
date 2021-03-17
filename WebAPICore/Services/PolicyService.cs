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
        public string PolicyCreateUpdate(Policy policy)
        {
            string result = string.Empty;
            var policyDetails = dbContext.Policies.FirstOrDefault(x => x.PolicyNumber == policy.PolicyNumber);

            //create policy 
            if (policyDetails == null)
            {
                policyDetails = new Policy();

                policyDetails.PolicyEffectiveDate = policy.PolicyEffectiveDate;
                policyDetails.PolicyExpiryDate = policy.PolicyExpiryDate;
                policyDetails.PolicyName = policy.PolicyName;
                policyDetails.PolicyNumber = policy.PolicyNumber;
                policyDetails.Active = policy.Active;
                dbContext.Policies.Add(policyDetails);
                dbContext.SaveChanges();

                result = "Policy has been created successfully";
            }
            else
            //update policy 
            {
                policyDetails.PolicyEffectiveDate = policy.PolicyEffectiveDate;
                policyDetails.PolicyExpiryDate = policy.PolicyExpiryDate;
                policyDetails.PolicyName = policy.PolicyName;
                policyDetails.PolicyNumber = policy.PolicyNumber;
                policyDetails.Active = policy.Active;
                dbContext.SaveChanges();

                result = "Policy has been updated successfully";
            }

            return result;
        }
    }
}
