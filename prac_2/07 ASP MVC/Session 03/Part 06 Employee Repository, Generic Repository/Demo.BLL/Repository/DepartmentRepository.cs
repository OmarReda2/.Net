using Demo.BLL.Interface;
using Demo.DAL.Contexts;
using Demo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Repository
{
    public class DepartmentRepository : GenericRepository<Department>
    {
        public DepartmentRepository(MVCAppContext context):base(context)
        {

        }

    }
}
