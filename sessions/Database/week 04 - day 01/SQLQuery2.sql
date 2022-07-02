-------------- Stored Procedures --------------
create Procedure SetID @id int
as
	select *
	from HR.Student
	where id = @id 

exec SetID 1

sp_helptext 'SetId'






create proc GetStdByID @id int
with encryption
as
	select ID, FName
	from HR.Student
	where ID = @id

exec GetStuden

sp_helptext 'GetStdByID'

create schema HR

alter schema HR transfer Student

alter schema HR transfer GetStdByID







alter proc DeleteStd @id int
with encryption
as
	begin try
		delete from HR.Student
		where ID = @id
	end try
	begin catch
		select 'Error'
	end catch

DeleteStd 5








create proc SumOfNum @x int, @y int
as
	select @x + @y

SumOfNum 1, 2
SumOfNum @y = 2, @x = 1

alter proc SumOfNum @x int = 1, @y int = 2
as
	select @x + @y

SumOfNum
SumOfNum 6








create proc dynQuery @col varchar(20), @table varchar(20)
as
	--select @col from @table
	execute(' select ' + @col + ' from ' + @table)

exec dynQuery 'Name', 'HR.Instructor'









----------------------------------------
--- Insert Based on Excute
create proc GetStdByAddress @address varchar(20)
as
	select ID, FName
	from HR.Student
	where Address = @address

execute GetStdByAddress 'alex'


create table StudentAddress
(
	ID int Primary key,
	FName varchar(20)
)

select * from StudentAddress


insert into StudentAddress
execute GetStdByAddress 'alex'
-- or
insert into StudentAddress
select ID, FName
from HR.Student
where Address = 'cairo'







----- Return of Sp
create proc Sp_GetStdDataByID @id int, @age int output, @name varchar(20) output
as
	select @age = Age, @name = FName
	from HR.Student
	where ID = @id

declare @age int, @name varchar(20)
execute Sp_GetStdDataByID 1, @age output, @name output
select @age, @name






create proc setValues @data int output, @name varchar(20) output
as
	select @data = age, @name = FName
	from HR.Student
	where ID = @data

declare @data int = 1, @name varchar(20)
execute setValues @data output, @name output
select @data, @name








------------- Trigger -------------
create trigger AFterInsertStd
on HR.Student
after insert
as
	select 'Welcom to ITI'

insert into HR.Student (ID, FName, Address) values(21, 'Ali', 'Tanta')





create trigger AfterUpdateInfo
on HR.Student
after update
as	
	select getdate(), suser_name()

update HR.Student
	   set FName = 'Alaa'
	   where ID = 21





create trigger insteadOfDeleteStudent
on HR.Student
instead of Delete
as
	select 'Deletion is not allowed for User => ' + suser_name()

delete from HR.Student
where ID = 21







alter table HR.Student disable trigger insteadOfDeleteStudent

alter table HR.Student enable trigger insteadOfDeleteStudent

drop trigger insteadOfDeleteStudent

create trigger PreventOpertionOnStudent
on HR.Student
instead of delete, update, insert
as
	select 'Opertion is not allowed for User => ' + suser_name()

delete from HR.Student
where ID = 21

update HR.Student
	   set FName = 'Alaa'
	   where ID = 21






alter trigger HR.PreventOpertionOnStudent
on HR.Student
instead of delete, update, insert
as
	select 'Opertion is not allowed for User => ' + suser_name()

alter schema dbo transfer HR.Student