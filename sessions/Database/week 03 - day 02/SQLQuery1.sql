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