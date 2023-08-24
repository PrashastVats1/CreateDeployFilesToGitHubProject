create database RainbowSchoolDb
use RainbowSchoolDb

create table Subjects
(SubjectID int primary key,
SubjectName nvarchar(50))

create table Classes
(ClassID int primary key,
ClassName nvarchar(50),
SubjectId int foreign key references Subjects(SubjectID))

create table Student
(StudentID int primary key,
FirstName nvarchar(50),
LastName nvarchar(50),
ClassID int foreign key references Classes(ClassID))

insert into Subjects values
(1, 'Mathematics'),
(2, 'Physics'),
(3, 'Chemistry'),
(4, 'English'),
(5, 'Computer Science')

insert into Classes values
(101, 'Class 11A', 1),
(102, 'Class 11A', 2),
(103, 'Class 11B', 3),
(104, 'Class 11C', 4),
(105, 'Class 11B', 5)

insert into Student values
(1, 'John', 'Wick', 101),
(2, 'Erina', 'Nakiri', 101),
(3, 'Erza', 'Scarlet', 101),
(4, 'Peter', 'Parker', 102),
(5, 'Miles', 'Morales', 103),
(6, 'Tony', 'Stark', 103),
(7, 'Stephen', 'Strange', 102),
(8, 'Prashant', 'Saksena', 104),
(9, 'Prasanna', 'Priya', 105),
(10, 'Siduri', 'Lukka', 104)

select * from Subjects
Select * from Classes
Select * from Student