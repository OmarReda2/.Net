﻿using Demo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BLL.Interface
{
    public interface IDepartmentRepository
    {
        Department Get(int? id);
        IEnumerable<Department> GetAll();
        int Add(Department department);
        int Update (Department department);
        int Delete (Department department); 
         
    }
}
