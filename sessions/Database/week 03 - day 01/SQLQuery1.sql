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

-- 2. Caolesce
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




