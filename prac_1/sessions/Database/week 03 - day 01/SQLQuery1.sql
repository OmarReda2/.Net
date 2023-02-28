-------- Having ---------
select dept_id, Count(id)
from Student
Group by dept_id
having dept_id is not null and Count(id) <= 3


select dept_ID, sum(salary)
from Instructor
Group by dept_ID
Having Count(ID) >= 1




-------- Null Functions --------
-- 1. IsNull 
select LName
from Student
where LName is not null

select IsNull(LName, 'Not Found')
from Student

select IsNull(LName, FName)
from Student

select FName, IsNull(LName, FName)
from Student

-- 2. Coalesce
select FName, Coalesce(FName, LName, Address,'No Data Found')
from Student





-------- Casting Functions --------
-- 1. Convert
select FName + convert(varchar(10), Age)
from Student

select name + convert(varchar(10), salary, 2)
from Instructor

select FName + convert(varchar(10), isnull(Age,0))
from Student

-- 2. Concate
select CONCAT(FName, ' ', Age)
from Student

-- 3. Cast
select CAST(getdate() as varchar(50))

select CONVERT(varchar(50), getdate(), 101)
select CONVERT(varchar(50), getdate(), 102)
select CONVERT(varchar(50), getdate(), 103)
select CONVERT(varchar(50), getdate(), 110)

-- 4. Format
select format(getdate(), 'dd-MM-yyyy')
select format(getdate(), 'ddd MMM yyyy')
select format(getdate(), 'dddd/MMMM/yyyy')
select format(getdate(), 'dddd')
select format(getdate(), 'hh:mm:ss')
select format(getdate(), 'HH:mm:ss tt')
select format(getdate(), 'dddd/MMMM/yyyy HH:mm:ss tt')
select format(getdate(), 'dddd', 'ar')





-------- DateTime Functions --------
select getdate()
select day(getdate())
select eomonth(getdate())
select eomonth('1/1/2005')
select format(eomonth(getdate()), 'dddd')






-------- String Functions --------
select lower(FName), upper(lname)
from student

select fname ,len(fname)
from student

select substring(fname, 1, 3)
from student





-------- String Functions --------
select db_name()
select suser_name()
select @@SERVERNAME





-------- SubQuery --------
select * 
from Student
where Age > (select Avg(Age) from Student)


select ID, (select Count(ID) from student)
from student

-- SubQuery VS Join
select distinct D.Name
from Departement D inner join Student S
on D.ID = S.dept_id

select D.Name
from Departement D
where D.ID in (select S.dept_id
			   from Student S) 

-- SubQuery with DML
-- Delete
delete from StudentCourse
where std_ID in (select ID
				 from Student
				 where Address = 'Cairo')






-------- Top --------
select *
from Student

select Top(3)*
from Student

select Top(3)ID
from Student

select Top(3)*
from Student
order by ID desc



select Max(Salary)
from Instructor

select Max(salary)
from Instructor
where salary not in (select Max(salary) from Instructor)

select Max(salary)
from Instructor
where salary <> (select Max(salary) from Instructor)



select top(2)Salary
from Instructor
order by salary desc

-- Top with ties
select top(5) with ties Age
from Student
order by Age desc

-- Random Select
select newid()

select FName, newid()
from Student

select top(3)*
from Student
order by newid()






-------- Ranking Functions --------
-- 1. Row Number
select FName, Age, row_number() over(order by Age desc) [Rank]
from Student
where Age is not null

-- 2. Dense Rank
select Fname ,Age, dense_rank() over(order by Age desc) [Rank]
from Student
where Age is not null

-- 3. Rank
select FName, Age, rank() over(order by Age desc)
from Student
where Age is not null

-- Get the 2 oldest std in std table
select *
from (select FName, Age, row_number() over(order by Age desc) as ranks
	  from Student) [Rank]
where ranks <= 2

-- Get the youngest std in each dept
select FName, Age, dept_id, row_number() over(partition by dept_id order by Age ) 
from Student 
where FName is not null and Age is not null and dept_id is not null 

select *
from (select FName, Age, dept_id, row_number() over(partition by dept_id order by Age ) as ranks
	  from Student) [Rank]
where FName is not null and Age is not null and dept_id is not null and ranks = 1


-- 4. NTile
select *
from (select *, NTile(2) over(order by Salary) as Gr
	  from Instructor) [Rank]

select *
from (select *, NTile(2) over(order by Salary) as Gr
	  from Instructor) [Rank]
where Gr = 2