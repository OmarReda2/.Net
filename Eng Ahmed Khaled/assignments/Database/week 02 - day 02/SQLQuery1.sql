------------------------------ part 01 (Company_SD)-------------------------------------
-- 1
select * 
from Employee

-- 2
select e.Fname, e.Lname, e.Salary, e.Dno
from Employee e

-- 3
select Pname,Plocation,Dnum
from Project

--4
select Fname + ' ' + Lname [full name] , (Salary * 10)/100 [annual comm]
from Employee

--5
select SSN , Salary
from Employee
where Salary > 1000

--6
select SSN , Salary * 12
from Employee
where Salary * 12 > 10000

--7
select Fname, Salary
from Employee
where Sex = 'F'

--8
select Dnum,Dname,MGRSSN
from Departments 
where MGRSSN = 968574

--9
select Pnumber, Pname, Plocation
from Project
where Dnum = 10
----------------------------------------------------------------------------








----------------------------------- part 02(Route) --------------------------------
-- 1
select *
from Student
where St_Age is not null 

-- 2
select distinct Ins_Name
from Instructor

-- 3
select Ins.Ins_Name, Dep.Dept_Name
from Instructor Ins join Department Dep
on Ins.Dept_Id = Dep.Dept_Id

-- 4
select std.St_Fname + ' ' + std.St_Lname 'FULL NAME',crs.Crs_Name
from Student std  join Stud_Course std_crs 
on std.St_Id = std_crs.St_Id
join Course crs
on crs.Crs_Id = std_crs.Crs_Id

-- 5
select t.Top_Name, COUNT(Crs_Id) 'total course'
from Course c join Topic t
on t.Top_Id = c.Top_Id
group by t.Top_Name

-- 6
select sup.*,std.St_Fname
from student sup join Student std 
on std.St_Id = sup.St_super
----------------------------------------------------------------------------








-------------------------- part 03 (Company_SD) --------------------
-- 1
select d.Dnum, d.Dname, e.Fname + ' ' + e.Lname 'maneger name' 
from Departments d join Employee e
on e.SSN = d.MGRSSN

-- 2
select d.Dname, p.Pname 
from Departments d join Project p
on d.Dnum = p.Dnum

-- 3
select d.*, e.Fname + ' ' + e.Lname 'Employee Name'
from Dependent d join Employee e
on e.SSN = d.ESSN


-- 4
select p.Dnum, p.Pname, p.Plocation
from Project p
where p.City in('Alex','Cairo')

-- 5
select *
from Project p
where p.Pname like 'a%'


-- 6
select *
from Employee e
where e.Dno = 30 and e.Salary between 1000 and 2000

-- 7
select e.Fname
from Employee e join Works_for w
on e.SSN = w.ESSn and e.Dno = 10
join Project p
on p.Pnumber = w.Pno and p.Pname = 'Al Rabwah'

-- 8
 select sup.Fname
 from Employee e join Employee sup
 on e.SSN = sup.Superssn and e.Fname = 'Kamel'

 -- 9
 select e.Fname , p.Pname
 from Employee e join Departments d  
 on d.Dnum = e.Dno 
 join project p 
 on d.Dnum = p.Dnum
 order by p.Pname

 -- 10
 select p.Pnumber , d.Dname, e.Lname, e.Address, e.Bdate
 from Project p join Departments d
 on d.Dnum = p.Dnum and p.City = 'Cairo'
 join Employee e
 on e.SSN = d.MGRSSN

 -- 11
 select *
 from Employee e join Departments d
 on e.SSN = d.MGRSSN

 -- 12
 select e.*, d.*
 from Employee e full outer join Dependent d
 on e.SSN = d.ESSN