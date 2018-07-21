using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Neudesic.EmployeeEntityFrame.DataContext;
using Neudesic.EmployeeEntityFrame.Model;
using Microsoft.AspNetCore.Mvc;

namespace Neudesic.EmployeeEntityFrame.Controllers
{
    [Produces("application/json")]
    [Route("api/Employee")]
    public class EmployeeController : Controller
    {
            [HttpGet]
            public ActionResult Get()
            {
                using (var EmpContext = new EmployeeDataContext())
                {
                    var EmployeesList = new List<EmployeeModel>();
                    EmployeesList = EmpContext.EmployeesDetails.ToList();
                    return Ok(EmployeesList);
                }
            }

            [HttpPost]
            public ActionResult Post([FromBody]EmployeeModel EmployeeObject)
            {
                using (var EmpContext = new EmployeeDataContext())
                {
                    EmpContext.EmployeesDetails.Add(EmployeeObject);
                    EmpContext.SaveChanges();
                }
                return Ok("Query processed");
            }

            [HttpPut]
            public ActionResult Put([FromBody]EmployeeModel EmployeeObject)
            {
                using (var EmpContext = new EmployeeDataContext())
                {
                    EmpContext.EmployeesDetails.Update(EmployeeObject);
                    EmpContext.SaveChanges();
                }
                return Ok("Query processed");
            }

            [HttpDelete]
            public ActionResult Delete(EmployeeModel EmployeeObject)
            {
                using (var EmpContext = new EmployeeDataContext())
                {
                    EmpContext.EmployeesDetails.Remove(EmployeeObject);
                    EmpContext.SaveChanges();
                }
                return Ok("Query processed");
            }
    }
}