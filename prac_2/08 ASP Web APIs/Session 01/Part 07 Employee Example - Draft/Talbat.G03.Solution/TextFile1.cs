#region P2
//1. Creat 2 projects (Class Library):
// - Data Access Layer/infrastructure(Talbat.DAL)  - Bussiness logic layer/Core(Talabat.BLL)

//2. create Talbat.DAL/Entities
//  a- create Talbat.DAL/Entities/BaseEntity.cs - (common attributes) other entities will implement it
//  b- create Talbat.DAL/Entities/ProductBrand.cs :BaseEntity
//  c- Talbat.DAL/Entities/ProductType.cs(common attributes)  :BaseEntity
//  e- Talbat.DAL/Entities/Product.cs(common attributes)  :BaseEntity
//  f- creatring the relation (Product(1) - (m)ProductBrand/ProductType) in Product.cs (Navigational prop)
//   - add forign key to ProductBrand and ProductType in Product.cs
//  g- validation by fluent api or data annotation (fluent api prefered as clean code)
//   - creating Talbat.DAL/Data
//   - creating Talbat.DAL/Data/StoreContext.cs
//   - installing Microsoft.EntityFrameworkCore.SqlServ package in Talbat.DAL from NuGet package to
//     install the Dbcontext
//   - see steps in Talbat.DAL/Data/StoreContext.cs 
#endregion

#region p3
// go to the Program
#endregion

#region p4
// // p4.1 creat Talabat.DAL/DAL/StoreContextSeed.cs
// // p4.2 go to Talabat.DAL/DAL/StoreContextSeed.cs ...
#endregion

#region p5
/*
 p5:
    - create Talabat.BLL\Interfaces
    - create Talabat.BLL\Interfaces\IGenericRepository.cs(interface)
      as we will use generic code design patterns
    - create Talabat.BLL\Repository as we will implement init the IGenericRepository
    - go to Talabat.BLL\Interfaces\IGenericRepository.cs ...
 
 
 
 
 */
#endregion

#region p6
//p6.1 go to API.Talabatl/ProductController ...
#endregion

#region p7
// p7 this is a draft example if you want to continue this example you need to make the dbsets and the other config
// p7 test this project if achieve "close for modification open for extension"
// p7.1 create departement.cs and employee.cs in Entity
// p7.2 make the prop of each entity 
// - make the relation(Navigation prop) betweem employee and departement 1 to m
// - add the relation(Navigation prop) in one entity only,
//   in emplpoyee make: public Departement Departement { get; set; } : it means the employee work in one departement
//
// p7.3 make EmployeesController.cs in controller
// - inject the IGenericRepository
// - create specification of employee "EmployeeWithDepartementSpecification" in Talabat.BLL/Specfications
// - create endPoints
// 
// - DONT FORGET WE HAVE MOVED "ProductWithTypeAndBrandSpecifaication.cs" 
//     AND "EmployeeWithDepartementSpecification.cs" IN "Products" AND "Employees" RESPECTIVELY



#endregion
