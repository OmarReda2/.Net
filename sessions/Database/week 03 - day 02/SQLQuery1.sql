-- Excution Order
select FName + ' ' + LName as FullName
from Student
where FullName = 'Omar Reda'

select FName + ' ' + LName as FullName
from Student
order by FullName

select *
from (select FName + ' ' + LName as FullName from Student) as newTable
where FullName = 'Omar Reda'

-- from
-- join
-- where
-- group by
-- having
-- select
-- distinct
-- order by
-- top





-------- Schema --------
select *
from Route.dbo.Course -- dbo => default Schema

create Schema HR
alter schema HR transfer Student
alter schema HR transfer Instructor

select FName + ' ' + LName as FullName
from HR.Student
order by FullName

create schema Sales
alter schema Sales transfer Departement

select *
from Sales.Departement


----------------------
-- Union Family (Union, Union All, Intersect, Except)
select ID, Fname  from HR.Student
-- union 
-- union all 
-- intersect 
-- except
select ID, name  from HR.Instructor




----------------------
-- DDL [Create, Alter, Drop, Select Into]
select * into Student
from HR.Student

select Address, Fname, Age  into AlexStudent
from HR.Student
where Address = 'alex'

select * from AlexStudent

select * into NewTable
from HR.Student
where 1 = 2


insert into NewTable
select * from HR.Student