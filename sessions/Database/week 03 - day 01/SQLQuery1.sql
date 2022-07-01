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





