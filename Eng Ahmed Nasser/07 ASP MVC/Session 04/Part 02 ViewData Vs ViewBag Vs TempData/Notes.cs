
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
/*
  binding:from controller to the view
    - ViewData[""]: strongly typed, from controller to its associated view
    - ViewBag. : dynamic, from controller to its associated view
    - TempData : strongly typed, from request to request(view to another view) but must be consequence
 */
#endregion