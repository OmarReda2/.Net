#region p1
// p1.1 create Talabat.API\DTO
// p1.1 create Talabat.API\DTO\ProductToReturnDTO
// p1.1 go to Talabat.API\DTO\ProductToReturnDTO

// - DTO: data transefer object
// - as this mean : that is the object that will transefer data from database
//   to frontend framework(from server side to client side) as in this case when we get data,
//   or from client side to server side (post data)

// - as the frondend dev will use this class for visualizing data
//   in better way than it come from database like:
//   when it come like nstead object we will convert(mapping) it flat objects
// - this class is the same to viewModel in MVC, so we will use mapping


// - in API projects we use only controller(endpoints) to get data(GET)
//   and we don't need to add data(POST)
// - so we can create dashboard MVC project connect it with the same db
//   and make controller to add data(POST)
#endregion

#region p2
//- the pictureUrl in Api is represented as: images/products/sb-ts1.png"
//- so we want to before pictureUrl the url of my server
//- this thing called "resolver"

// p2.1 create Talabat.Api/Helper/ProductPictureUrlResolver.cs
// p2.1 go to Talabat.Api/Helper/ProductPictureUrlResolver.cs ...
#endregion

#region p3
/*
 p3.1 make Talabat.API/Controller/BuggyController.cs
 p3.1 go to Talabat.API/Controller/BuggyController.cs ...
 - this controller only for demonistration the errors types in API
    as we will write the code in it in the real Controller"ProductController"

 */
#endregion