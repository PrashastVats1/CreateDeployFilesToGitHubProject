create database SchoolManagement

use SchoolManagement

create table Students 
(StudentID int primary key identity(1,1),
FirstName nvarchar(50) not null,
LastName nvarchar(50) not null,
DateOfBirth date,
Gender nvarchar(10),
Address nvarchar(100))

insert into Students (FirstName, LastName, DateOfBirth, Gender, Address) values
('John', 'Doe', '2000-01-15', 'Male', '123 Main Street, Delhi'),
('Jane', 'Smith', '2001-05-20', 'Female', '456 Park Avenue, Mumbai'),
('Amit', 'Patel', '2002-03-10', 'Male', '789 Oak Road, Bangalore'),
('Priya', 'Sharma', '2000-11-08', 'Female', '101 Pine Lane, Kolkata'),
('Rahul', 'Gupta', '2001-09-25', 'Male', '222 Cedar Street, Chennai')
select * from Students