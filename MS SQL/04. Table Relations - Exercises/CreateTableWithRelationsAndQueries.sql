--- TASK 1 --------- ONE-TO-ONE RELATIONSHIP --------------------
CREATE DATABASE TableRelationsDB
GO

USE TableRelationsDB

CREATE TABLE Passport (
            PassportID INT PRIMARY KEY IDENTITY(101,1)
			,PassportNumber VARCHAR(50) UNIQUE
			)
CREATE TABLE Persons (
             PersonID INT PRIMARY KEY IDENTITY
			 ,FirstName NVARCHAR(50)
			 ,Salary DECIMAL(6,2)
			 ,PassportID INT FOREIGN KEY REFERENCES Passport(PassportID)
			 )

INSERT INTO Passport VALUES
         ('N34FG21B')
        ,('K65LO4R7')
        ,('ZE657QP2')

INSERT INTO Persons VALUES
		    ('Roberto', 4330, 102)
		   ,('Tom', 5610, 103)
		   ,('Yana', 6020, 101)
--- TASK 2 --------- ONE-TO-MANY RELATIONSHIP -------------------
CREATE TABLE Manufacturers (
           ManufacturerID INT PRIMARY KEY IDENTITY
		   ,Name VARCHAR(30) UNIQUE NOT NULL
		   ,EstablishedOn DATETIME2 NOT NULL
		   )
CREATE TABLE Models (
            ModelID INT PRIMARY KEY IDENTITY
			,Name VARCHAR(30) UNIQUE NOT NULL
			,ManufacturerID INT FOREIGN KEY REFERENCES Manufacturers(ManufacturerID)
			)

INSERT INTO Manufacturers VALUES
            ('BMW', '1916-03-07')
			,('Tesla', '2003-01-01')
			,('Lada', '1966-05-01')

INSERT INTO Models VALUES
            ('X1', 1)
			,('i6', 1)
			,('Model S', 2)
			,('Model X', 2)
			,('Model 3', 2)
			,('Nova', 3)
--- TASK 3 --------- MANY-TO-MANY RELATIONSHIP ------------------
USE TableRelationsDB

CREATE TABLE Students (
             StudentID INT PRIMARY KEY IDENTITY
			 ,[Name] NVARCHAR(20) NOT NULL
			 )
CREATE TABLE Exams (
			 ExamID INT  PRIMARY KEY IDENTITY(101, 1)
			,[Name] NVARCHAR(50) NOT NULL
             )
CREATE TABLE StudentExams (
            StudentID INT FOREIGN KEY REFERENCES Students(StudentID) NOT NULL
			,ExamID  INT FOREIGN KEY REFERENCES Exams(ExamID) NOT NULL
			PRIMARY KEY(StudentID,ExamID)
			)
INSERT INTO Students VALUES
     ('Mila')
    ,('Toni')
    ,('Ron')

INSERT INTO Exams VALUES
     ('SpringMVC')
    ,('Neo4j')
    ,('Oracle 11g')

INSERT INTO StudentExams VALUES
     (1, 101)
    ,(1, 102)
    ,(2, 101)
    ,(3, 103)
    ,(2, 102)
    ,(2, 103)
--- TASK 4 --------- SELF-REFERENCING ---------------------------
CREATE TABLE Teachers (
            TeacherID INT PRIMARY KEY IDENTITY(101,1)
			,[Name] NVARCHAR NOT NULL
			,ManagerID INT FOREIGN KEY REFERENCES Teachers(TeacherID)
			)
ALTER TABLE Teachers
[Name] NVARCHAR(50)


INSERT INTO Teachers VALUES
			 ('John', 101)
			,('Maya', 105)
			,('Silvia', 106)
			,('Ted', 104)
			,('Mark', 101)
			,('Greta', 101)