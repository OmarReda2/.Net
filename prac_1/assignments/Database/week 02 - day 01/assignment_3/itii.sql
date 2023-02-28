create database iti
use iti

create table Student
(
	ID int primary key,
	Age int,
	FName varchar(10),
	LName varchar(10),
	Address varchar(30),

)

create table Departement
(
	ID int primary key,
	Name varchar(30),
	inst_ID int,  -- alter foreign key(references) for instructor id in instrictor table
	hiring_date date  
)

create table Course
(
	ID int primary key,
	name varchar(30),
	duration smallint,
	description varchar(300),
	topic_ID int -- alter foreign key(references) for topic id in topic table

)

create table Topic
(
	ID int primary key,
	name varchar(50)
)

create table Instructor
(
	ID int primary key,
	sup_ID int references Instructor(ID),
	name varchar(30),
	Address varchar(50),
	Bonus int,
	Rate int,
	salary money,
	dept_ID int references Departement(ID)
)


create table StudentCourse
(
	std_ID int references Student(ID),
	crs_ID int references Course(ID),
	grade smallint,
	primary key(std_ID,crs_ID)

)


create table course_inst
(
	crs_ID int references Course(ID),
	inst_ID int references Instructor(ID),
	evaluation int
)


alter table Departement
add foreign key(inst_ID) references Instructor(ID)

alter table Course
add foreign key(topic_ID) references Topic(ID)



insert into Instructor(ID) values(112233)
insert into Departement(ID) values(30)

insert into Instructor(dept_ID,ID,sup_ID,salary) values(30, 102672, 112233, 3000 )
insert into Instructor(dept_ID,ID) values(30, 102660)


