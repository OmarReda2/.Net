select dept_id, Count(id)
from Student
Group by dept_id
having dept_id is not null and Count(id) <= 3


select dept_ID, sum(salary)
from Instructor
Group by dept_ID
Having Count(ID) >= 1