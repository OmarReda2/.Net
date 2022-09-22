
-- Revision
insert into Student values(1,21,'Omar', 'Reda', null),
						  (2,14,'khaled', 'Reda', null),
						  (3,25, 'yasser', null, null)
insert into student values(4,26, 'hazem', null, 'mansoura')




alter table student 
add super int

alter table student 
add foreign key (super) references student(ID)



alter table student
add dept_id int

alter table student
add foreign key (dept_id) references Departement (ID)



	


update student 
set address = 'warraq' 
where age = 14 or age = 21

update student 
set address = 'alex' 
where age = 25 

update student 
set super = 2 
where FName not in ('Omar','khaled')
						

-- DQL => Data Query Language
select * 
from Student

select FName,ID 
from Student

select FName + ' ' + Lname full_name 
from student

select FName + ' ' + Lname [full name] 
from student

select FName + ' ' + Lname 'full name' 
from student

select [full name] = Fname + ' ' + LName 
from student

select 'full name' = Fname + ' ' + LName 
from Student



select * 
from student
where age > 20

select *
from student 
where age > 14 and age < 25

select *
from student 
where age between 15 and 24

select *
from student 
where address = 'warraq' or address = 'alex'

select *
from student 
where address in ('alex','warraq')

select *
from student 
where address in ('alex','warraq','mansoura')

select *
from student 
where address not in ('alex','mansoura')

select *
from student 
where super is not null

select *
from student 
where super is null


---- Pattern => like ---- 

select * 
from Student
where FName like '_h%'

select *
from Student
where FName like '[^yh]%'

select *
from Student
where FName like '[a-k]%'

select *
from Student
where FName like '%[ ]%'

-- Distinct
select distinct fname
from Student

-- Order by
select * 
from student
order by fname

select * 
from student
order by Fname desc

select * 
from student
order by FName,Age

select * 
from Student
order by 1,2

select * 
from Student
order by 1,2

----------- Join -----------
-- Cross Join (Cartesian Product)
select s.FName, d.ID
from Student s, Departement d

-- Cross Join (SQL)
select s.FName, d.ID
from student s cross join departement d 

-- Inner Join (Equi Join)
select s.fname, d.name
from student s, departement d
where d.id = s.dept_id

-- Inner Join (SQL)
select s.fname, d.name
from student s inner join departement d
on d.id = s.dept_id

select s.fname, d.name
from student s join departement d
on d.id = s.dept_id

-- Outer Join
	-- Left Outer Join
	select s.FName, d.Name
	from student s left outer join departement d
	on d.ID = s.dept_id

	-- Right Outer Join
	select s.fname, d.name
	from student s right outer join departement d
	on d.id = s.dept_id

	-- Full Outer Join
	select s.fname, d.name
	from student s full outer join departement d
	on d.ID = s.dept_id

-- Self Join 
select [full name ] = st.fname + ' ' + st.lname , super.*
from student st, student super
where st.ID = super.super 

select st.fname , super.*
from student st, student super
where st.ID = super.super 


select st.fname , super.*
from student st join student super
on st.ID = super.super 

-- Excercise
select S.FName, C.name, STC.grade
from Student S, Course C, StudentCourse STC
where S.ID = STC.std_ID and C.ID = STC.crs_ID

select S.FName, C.name, STC.grade
from Student S, Course C, StudentCourse STC
where S.ID = STC.std_ID and C.ID = STC.crs_ID


select S.FName, C.name, STC.grade
from Student S join StudentCourse STC
on S.ID = STC.std_ID 
join Course C  
on C.ID = STC.crs_ID

-------------
--- Join + DML

-- Update 
update STC
	set grade += 10
from Student S join StudentCourse STC
on S.ID = STC.std_ID and S.Address in ('alex', 'mansoura')

--- insert
insert into Student(ID,FName,dept_id) values(9,'zain',111)
select S.ID, S.FName, D.ID
from Student S join Departement D
on D.ID = S.dept_id

-- Delete => Self Study 

---------------------------------------
---------------- Built-In Functions -----------------------

---------------- Aggregate Functions -----------
---- Min, Max, Count, Avg, Sum 


select COUNT(*) 'Total Student'
from Student


select COUNT(s.LName) 'Total Student'
from Student s

select COUNT(s.FName), COUNT(s.LName)
from Student s

select SUM(salary)
from Instructor

select AVG(Age)
from Student

select SUM(Age)/COUNT(Age)
from Student

select MAX(salary) [max salary],MIN(salary) [min salary]
from Instructor

select MIN(salary), dept_ID
from Instructor
group by dept_ID

select AVG(age), dept_id, age
from Student
group by dept_id, age