create database MVCSchoolDb
use MVCSchoolDb

create table Student 
(Id int primary key,
FirstName nvarchar(50) not null,
LastName nvarchar(50) not null,
DateOfBirth date not null,
Gender nvarchar(10) not null,
Address nvarchar(100) not null)

create table Mark
(Id int primary key,
StudentId int not null,
Score float not null,
foreign key (StudentId) references Student(Id))

insert into Student values
(1, 'John', 'Doe', '1998-05-15', 'Male', '123 Main St'),
(2, 'Jane', 'Smith', '1999-03-20', 'Female', '456 Elm St'),
(3, 'Robert', 'Johnson', '1997-08-10', 'Male', '789 Oak St'),
(4, 'Emily', 'Davis', '2000-01-25', 'Female', '101 Maple Ave'),
(5, 'Michael', 'Brown', '1996-11-05', 'Male', '222 Pine Rd')

insert into Mark values
(1, 1, 85.5),
(2, 2, 92.0),
(3, 3, 78.5),
(4, 4, 95.7),
(5, 5, 88.2)

select * from Student
select * from Mark

