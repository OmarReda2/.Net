
#region session 1 - 3
/*
  ------- DAL ------
  Packeges:
    Microsoft.EntityFrameworkCore.SqlServer => for DbContext

  ------- PL --------
  Packages:
    Microsoft.EntityFrameWorkCore.tools => for Migration 
    - install this package where the connection string is
    - Default project in DAL(to put the migration folder in it)
    - set the Startup project where the connection string is


     DI for Interface in ctor of controller instead of repository : 
           - so the controller will be loosley coupled as it depend on interface       
 */
#endregion

#region session 4
/* vid 02
  binding:send data from controller to the view
    - ViewData[""]: strongly typed, from controller to its associated view
    - ViewBag. : dynamic, from controller to its associated view
    - TempData : strongly typed, from request to request(view to another view) but must be consequence
 */


/* vid 03
    -- partialView: 
        - its part of the view be separated in on other folder and the name only if the partial 
          will provided in the the view

        - use to organize code and avoid duplicate
        <partial name="NameOfPartialView" model="parameters"> 
    

    -- layout: the structure of the page the every view will be render on it



    -- section: its part of the layout be provided in in view(the name only) 
                and the original code in layout

    - ex.
        in layout:
            @await RenderSectionAsync("scriptSection", required: false)

        in view:
            @section scriptSection{
                @*<script src="~/lib/jquery-validation/dist/jquery.validate.min.js"></script>
                <script src="~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"></script>*@

                <partial name="_ValidationScriptsPartial" />
            }
 */



/* vid 04
   -- relation:
     1              to      many
     Department            employee
    - department has many employee, but employee has one department

    -- Departement:
        public virtual ICollection<Employee> Employee { get; set; } = new HashSet<Employee>(); // relation 1 to m
        
    -- Employee:
        public int DepartmentId { get; set; } // forign key by convention we can ignore this line (adding forien key) as when we create navgitional prop it will add the foriegn key for the many in one, so we add as we want to use it in the code
        public virtual Department Department { get; set; } // relation (navigtoinal prop)

    -- eager loading: 
            ex. when we call employee from DB we will have in the same request the departement

    -- lazy loading
            ex. when we call departement from DB we will have the employee in another request 
                as we dont need an additional data to be called 
            - we use virtual to make lazy loading

    -- forieng Key in Entities:
         we may use it as we if want to use it in our code/view

   -- SelectList:
        ex. var Departments = new SelectList(ViewBag.Departments, "Id", "Name"); 
    // SelectList be used in asp-items as it will be rendered as an option in select element
    // takes (variable(must be list/IEnumerable/etc...), SelectedValue from DB, the data will be shown in dropDown )


   -- select, asp-items
        ex. <select asp-for="DepartmentId" asp-items="Departments" class="form-control"> @*Departments must be SelectList*@
                <option>  **Select Department  </option> 
            </select>

   -- ViewBag
         - null when redirected
          

    ex. public IActionResult Create(Employee employee)
         {
            if (ModelState.IsValid)
            {
                EmployeeRepository.Add(employee);

                return RedirectToAction(nameof(Index));
            }
   here >>>>   ViewBag.Departments = DepartmentRepository.GetAll(); 
                // reditect make ViewBag null
                // so we must declare it again
            return View(employee);
        }
 */




/* vid 05
  -- @inject 
        - if we want to use another model in view
        - we can use the Repository or IRepository, 
          but there we use two object of the Dbcontext(the object which connect to Db),
          and the app will only make one obj or more than one bsaed on the service 
          we use in startup to create repository/Dbcontext:
            - AddScoped
            - AddTransient  
            - AddSingelton
        ex. 
            @model Employee
here >>>>   @inject IDepartmentRepository departmentRepository 
            @{
                var Departments =new SelectList(departmentRepository.GetAll(), "Id", "Name"); 
            
                //var Departments =new SelectList(ViewBag.Departments, "Id", "Name"); 
                // //SelectList be used in asp-items as it will be rendered as an option in select element
                // //takes (variable(must be list/IEnumerable/etc...), SelectedValue from DB, the data will be shown in dropDown )
    
    -- ViewImports:
         - When the IDepartment is injected we would import it in the same view or in the ViewImports
         ex.
            @using Demo.BLL.Interface
}
 */

/* vid 06
 
 -- @model
       - be used in view
       - this is the model which will be sent in the parameter of the create action,
         so we use the view to set values of this model and then sent it to the controller
       ex. @model EmployeeViewModel

-- Action
       - when it returns ex. View(employeeReopository.GetAll) it returns it in the view
       - the @model must be the same type or return "IEnumrable" and the "Model" contain the the return

 -- ViewModel
       - entity/model: is the actual data(table) in the Db (action to Db)
       - ViewModel: is the data we want to use/show it in the view (view to action params)
       ex. we want use/show the creationDate of an Employee in the view which will be generated automatically

-- mapping:
      - convert from ViewModel to model and vice virse
      ex. the action receive ViewModel as a parameter from view 
          then we map ViewModel to model so the action sent the model to the DB

      - manual mapping
           ex.
                 var mappedEmp = new Employee()
            {
                Id = employeeVM.Id,
                Name = employeeVM.Name,
                Address = employeeVM.Address,
                Age = employeeVM.Age,
                DepartmentId = employeeVM.DepartmentId,
                Email = employeeVM.Email,
                IsActive = employeeVM.IsActive,
                HireDate = employeeVM.HireDate,
                PhoneNumber = employeeVM.PhoneNumber,
                Salary = employeeVM.Salary,
                //CreationDate => not in the employeeVM, default: Creation.Now
            };
            EmployeeRepository.Add(mappedEmp);
 */



/* vid 07
    see the form in IndexView and Index action in Employee Controller
*/


/* vid 08
  IUnit Of Work:  Make All Repositories(classes has functions that communicate with DB) in one obj by
    1 - make interface and put the repos interfaces (IUnitOfWork)
    2 - make class(UnitOfWork) and imp the interface
    3 - inject the Interface (IUnitOfWork) in the ctor of Controller
    4 - go to startup and define the DI
 */
#endregion

#region session 5
#region vid 1
/*
 - to display navigitional prop : we will use
    eager loading: 
        - ex: 2 classes(tables) each of them have object of the other table - the relation between them 1 to 1
        - so in this example we will use eager for the both classes(1 to 1), so when we get the data we can include the data of the other class 
        - we will use "Include(E(the main class)=> E.Departement(the other class))"
    lazy loading:
        - ex: 2 classes(tables) each of them have object of the other table - the relation between them 1 to m (the one have the class which is man rel.)
        - so in this example we will use lazy loading in the many relation(class) and eager in the the one rel.
 */
#endregion

#region vid 2
/*
 - there are 2 approach to save files 
    DB: we will convert the files to 01s when upload it and retrieve it, 
    this approach is not much better as it well make overhead when convert the files

    server:we will save the file in the server and the image name in the DB, this is much better from the other approach, so we will use it

    1- we will add the imagename prp in the in the emloyee class as we want to add the image name only in the database
    2- we will add the imagename prp and the image prp which will save the file it self (prp datatype is IFileForm)

    3- we will make a static class inside helper folder in the controller which have function to add and delete the img in the server 
    4- wi will add the input element in the create view then and add "enctype"attribute in the form as it submit a file 
    4- we will use these fuction in create and delete action 
     -create: when we submit the data goes to the action and the imagename saved to the database and the file saved into the server, the delete will be the same process of the create
    
    for more see the code
 */
#endregion

#region vid 5
/* security in asp.net (authontication - authorization)
 1 - install identity package in demo.DAL
 2 - context(MVCAppContext): use IdentityDbContext instead off DbContext
 3 - startup : add app.UseAuthentication() addmiddleware before app.UseAuthorization()
 3 - startup : add  services.AddAuthentication() and  services.AddIdentity<>() with the config
 4 - Migration  : add-Migration to add the tables provided by identity
 4 - add AccountController to make action for login sinout signin etc....
 */
#endregion




#endregion