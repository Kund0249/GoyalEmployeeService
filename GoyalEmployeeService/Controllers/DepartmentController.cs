using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataLayer.DataRepository;
using DataLayer.DataEntity;

namespace GoyalEmployeeService.Controllers
{
    public class DepartmentController : ApiController
    {
        private DepartmentRepository Db = new DepartmentRepository();

        public IHttpActionResult GetDepartments()
        {
            List<DepartmentEntity> entities = Db.GetDepartments;
            return Ok(entities);
        }

        [HttpPost]
        public IHttpActionResult PostDepartments(DepartmentEntity entity)
        {
            Db.Save(entity);
            return Ok(entity);
        }
    }
}
