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
