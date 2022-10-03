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

#region p4
/*
 - as the different response of the errors type in have different stamp 
   we will create class that make them all have different stamp
 
 p4.1 create Talabat.APIl/Errors
 p4.1 create Talabat.APIl/Errors/ApiResponse
 p4.1 go to Talabat.APIl/Errors/ApiResponse ...
 */
#endregion

#region p5
/*
 - as the validation error have an api response error that have an additional 
   prop (validation Errors) so we will create class that have this additional error
   and imp the ApiResponse
 
  p5.1 create Talabat.API/Errors/ApiValidationErrorResponse
  p5.1 go to Talabat.API/Errors/ApiValidationErrorResponse
 */
#endregion

#region p6
/*
 - when the exception occurs it would show a long exception message
 - that because of the Middleware used in startup "UseDeveloperExceptionPage()"
 - so we will comment it 
 p6.1 go to startup and comment the comment UseDeveloperExceptionPage() .....
 ... p6.2 coming back from Startup

 - so we want to to add an exception message instead of we have commented
 - it will contain the like ApiResponse class (StatusCode & Message) 
   but we will add details prop as it will be shown it devMode only.
 - but there is no built-in Middleware that makes this so we will create a one
 p6.3 create Talabat.API/Middlewares
 p6.3 create Talabat.API/Middlewares/ExceptionMiddleware.cs
 p6.3 go to Talabat.API/Middlewares/ExceptionMiddleware.cs

 */

#endregion

#region p7
// p7.1 adding other end points 
// p7.1 go to ProductController.cs
#endregion

#region p8
// p8.1 we want to improve the swagger documentaion so it can show the possible
//      message responsee when its like: when it success or having errors
//p8.1 go to the ProductController....
#endregion

#region p9
// apply ordering
// p9.1 go ISpecifecation ...
#endregion

#region p10
// filteration
// p10.1 go to ProductController ...
#endregion

#region p11
/*
 - there are to types of connections(between client side and server side):
    a.connected model: open a permenant connection between client side and server side
      so when make 1st request it will return some data and 2nd req will return another some data and so on
 
    b. disconnected model : make a connection only per request (not Permenant)
       so it will return all the data per request.
    
 - so the connected model used for pagination
 - when we make a pagination a request of response should be an object that contain:
    a. index: page number 
    b. pageSize: maximum data per page
    c. count: number of data in page
    e. data

    p11.1 go to productContrroller ...
 */
#endregion

#region p11 p2(12min): p12


/*
 p12 go to ProductSpecParam to add the PageSize and Index


------- Revision -------
ISpecification(Interface) and
BaseSpecification(class): this to set the value of the query ex. Where(P => P.id) or Select(2)
                   so the "P => P.id" and "2" it the value where this class sets

ProductWithTypeAndBrandSpecifaication or
ProductWithFIltersWithCountSpecification : - these classes implement "BaseSpecification" so
                                             They is the actual classes which sets the value
                                             we have mentioned in "BaseSpecification"

                                           - we use them to apply a specific values so they will
                                             build different query.


IGenericRepository(Interface) and
GenericRepository(class): class that use the StoreContext"databse" 
                          and get the data based on logics


SpecificationEvaluator(class): class that GenericRepository use to build the query
                               it uses the "ProductWithFIltersWithCountSpecification"or
                               "ProductWithFIltersWithCountSpecification" to set the values
                                in query ex. context.Set<>,Where(), Include(), Skip(), etc..
                                these linq operators which be use in "SpecificationEvaluator"
                                and it uses "BaseSpecification" to set values in these linq op
                                ex. Where(P => P.id)

ProductContoller: is which the endPoint occurs and we use GenericRepository that uses SpecificationEvaluator
                  to return the request.

ProdcutSpecParams (and the the Path of Request): it contains all params that we passes to the endPoint and these params been set 
                   by the request, and then its been passes as a params to "ProductWithTypeAndBrandSpecifaication"
                   or "ProductWithFIltersWithCountSpecification" and then they use "BaseSpecification" to
                   set values, then ts been passes as a params to "GenericRepository" which use the 
                   "SpecificationEvaluator" to build query


 */
#endregion