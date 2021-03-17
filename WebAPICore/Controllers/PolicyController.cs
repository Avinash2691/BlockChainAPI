using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http.ModelBinding;
using WebAPICore.IServices;
using WebAPICore.Models;

namespace WebAPICore.Controllers
{
    public class PolicyController
    {
        private readonly IPolicyService policyService;
        public PolicyController(IPolicyService policy)
        {
            policyService = policy;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Policy/GetListPolicies")]
        public IEnumerable<Policy> GetListPolicies()
        {
            return policyService.GetListPolicies();
        }

        [HttpGet, Route("api/Policy/PolicyData")]
        [Route("[action]")]
        public IActionResult PolicyData(string PolicyNumber)
        {
            Policy policy = policyService.GetPolicyById(PolicyNumber);
            if (policy != null && policy.Active)
            {
                var result = new OkObjectResult(new { message = "Policy is Active", PolicyNo = PolicyNumber });
                return result;
            }
            else
            {
                var result = new OkObjectResult(new { message = "Policy is InActive", PolicyNo = PolicyNumber });
                return result;
            }
        }

        [HttpPost, Route("api/Policy/PolicyCreateUpdate")]
        [Route("[action]")]
        public IActionResult PolicyCreateUpdate(Policy policy)
        {
            string policyMessage = policyService.PolicyCreateUpdate(policy);
            var result = new OkObjectResult(new { message = policyMessage });
            return result;
        }
    }
}
