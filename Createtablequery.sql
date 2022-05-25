use NewDatabase
Go

Create table NewStudent
(
Studentid int primary key not null identity(1,1),
 studentName varchar(30) ,
 Age int,
 gender varchar(30),
 course varchar(30),
 university varchar(30),
 city varchar(30),
);

