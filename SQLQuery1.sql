use master 
create database To_Do_List
go 

use To_Do_List
go 

create table Tasks
(
	Id int Identity (1,1) primary key,
	Title NVARCHAR (100),
	T_State NVARCHAR (100),
	Dur_From datetime default Getdate(),
    Dur_To dateTime default GetDate(),
	T_Description NVARCHAR (500)
);

insert into Tasks (Title,T_State,Dur_From,Dur_To,T_Description)
values('c#','Pending',GETDATE(),GETDATE(),'lesson 1 from course c#'),
       ('javascript','Pending',GETDATE(),GETDATE(),'lesson 5 from course javascript'),
	   ('HTML','Pending',GETDATE(),GETDATE(),'lesson 1 from course HTML');