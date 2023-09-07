--Data Definition Query Language (DDL)

--Create,Alter, Drop and Truncate

Create table Registration
(

EmpId Int not null,
FirstName varchar(500) not null,
LastName nvarchar(500) not null,
Email nvarchar(100) null

);
--Alter
--adding new column
select * from Registration
Alter table Registration
add Phonenumber bigint not null default(0)
--remove exisiting column
Alter table Registration
drop column lastname
--modify the DataType
Alter table Registration
alter column phonenumber int null

--truncate
truncate table Registration
--Drop
drop table Registration


--Data Manipulation Query Language (DML)
--Select
Select * from Registration

Select 
	* 
from 
	Registration 
where 
	EmpId=6789

select empid,FirstName from Registration

--Insert 
insert into Registration values(1234,'Dinesh','dell','dinesh@gmail.com'),

(1235,'Dinesh123','dell123','dinesh@gmail.com'),

('1235','dinesh123','CSK123','dinesh@gmail.com')

--Update 

update Registration set FirstName ='mahesh' where EmpId=1234

Select * from Registration


update Registration set FirstName ='Dinesh',LastName ='dell123'where EmpId=1234

 --delete

 Delete from Registration where FirstName='dinesh'

  Delete from Registration

  --Alter
--adding new column
select * from Registration
Alter table Registration
add Phonenumber bigint not null default(0)
--remove exisiting column
Alter table Registration
drop column lastname
--modify the DataType
Alter table Registration
alter column phonenumber int null

--truncate
truncate table Registration
--Drop
drop table Registration

