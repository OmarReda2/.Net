
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
#endregion