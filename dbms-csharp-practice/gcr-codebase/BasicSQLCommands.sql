-- 1. DDL - DATA DEFINITION LANGUAGE
/*CREATE DATABASE
SYNTAX: 
  CREATE DATABASE [database_name];
*/
--- Creating a database ---
CREATE DATABASE HospitalDB;
/*USE DATABASE
SYNTAX: 
  USE [database_name];
*/
--- Using a database ---
USE HospitalDB;
/*CREATE TABLE
SYNTAX: 
  CREATE TABLE [table_name](
    column_name datatype constraints,
    column_name datatype constraints
  );
*/
---Data definition commands---
CREATE TABLE Patients (
    PatientID INT PRIMARY KEY,
    Name VARCHAR(100)
);
/*ALTER TABLE
SYNTAX: 
  ALTER TABLE [table_name] ADD [column_name] [datatype];
  ALTER TABLE [table_name] DROP COLUMN [column_name];
  ALTER TABLE [table_name] ALTER COLUMN [column_name] [new_datatype];
*/
ALTER TABLE Patients ADD Age INT;
ALTER TABLE Patients ADD BloodGroup VARCHAR(5);
ALTER TABLE Patients ADD Gender VARCHAR(10);
/*DROP TABLE
SYNTAX: 
  DROP TABLE [table_name];
*/
-- DROP TABLE Patients;
-- 2. DML - DATA MANIPULATION LANGUAGE
/*INSERT COMMAND
SYNTAX: 
  INSERT INTO [table_name] (column1, column2, ...) VALUES (value1, value2, ...);
*/
---Data manipulation language---
INSERT INTO Patients (PatientID, Name, Age, BloodGroup, Gender) 
VALUES (1, 'Arjun Kumar', 28, 'O+', 'Male');
/*UPDATE COMMAND
SYNTAX: 
  UPDATE [table_name] SET column1 = value1, column2 = value2 WHERE condition;
*/
UPDATE Patients SET Age = 29 WHERE PatientID = 1;
/*DELETE COMMAND
SYNTAX: 
  DELETE FROM [table_name] WHERE condition;
*/
DELETE FROM Patients WHERE PatientID = 1;
-- 3. DQL - DATA QUERY LANGUAGE
-- Used for querying data
/*SELECT COMMAND
SYNTAX: 
  SELECT column1, column2, ... FROM [table_name];
  SELECT * FROM [table_name] WHERE condition;
*/
---Data query language---
INSERT INTO Patients (PatientID, Name, Age, BloodGroup, Gender) 
VALUES (1, 'Kshitiz Agarwal', 22, 'O+', 'Male');
INSERT INTO Patients (PatientID, Name, Age, BloodGroup, Gender) 
VALUES (2, 'Aman Kuamr', 23, 'A+', 'Male');
INSERT INTO Patients (PatientID, Name, Age, BloodGroup, Gender) 
VALUES (3, 'Samarth Shakya', 21, 'B+', 'Male');
INSERT INTO Patients (PatientID, Name, Age, BloodGroup, Gender) 
VALUES (4, 'Shashi Kumar', 23, 'AB-', 'Male');
INSERT INTO Patients (PatientID, Name, Age, BloodGroup, Gender) 
VALUES (5, 'neha Singh', 23, 'O-', 'Female');
-- Select all records
SELECT * FROM Patients;
-- Select specific columns with condition
SELECT Name, Age FROM Patients WHERE Age > 30;
-- 4. DCL - DATA CONTROL LANGUAGE
-- Used to control access/permissions
/*GRANT COMMAND
SYNTAX: 
  GRANT privilege_name ON object_name TO user_name;
*/
---Data control language---
GRANT SELECT ON Patients TO user_name;
/*REVOKE COMMAND
SYNTAX: 
  REVOKE privilege_name ON object_name FROM user_name;
*/
REVOKE SELECT ON Patients FROM user_name;
-- 5. TCL - TRANSACTION CONTROL LANGUAGE
-- Used to manage transactions in a database
/*BEGIN TRANSACTION
SYNTAX: 
  BEGIN TRANSACTION;
  BEGIN TRAN;
*/
/*COMMIT COMMAND
SYNTAX: 
  COMMIT;
  COMMIT TRANSACTION;
*/
/*ROLLBACK COMMAND
SYNTAX: 
  ROLLBACK;
  ROLLBACK TRANSACTION;
*/
/*SAVEPOINT COMMAND
SYNTAX: 
  SAVE TRANSACTION savepoint_name;
  ROLLBACK TRANSACTION savepoint_name;
*/
---Transaction control language---
BEGIN TRANSACTION;
UPDATE Patients SET Age = 30 WHERE PatientID = 2;
SAVE TRANSACTION sp1;
UPDATE Patients SET Age = 40 WHERE PatientID = 3;
ROLLBACK TRANSACTION sp1;
COMMIT;
-- 6. JOINS - COMBINING DATA FROM MULTIPLE TABLES
/*CREATE SECOND TABLE FOR JOINS
SYNTAX: 
  CREATE TABLE [table_name](
    column_name datatype constraints,
    FOREIGN KEY (column) REFERENCES parent_table(column)
  );
*/
--- Creating another table for joins operations ---
CREATE TABLE Appointments (
    AppointmentID INT PRIMARY KEY,
    PatientID INT,
    DoctorName VARCHAR(50),
    AppointmentDate DATE,
    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID)
);
-- Insert data into Appointments
INSERT INTO Appointments (AppointmentID, PatientID, DoctorName, AppointmentDate) 
VALUES (101, 1, 'Dr. Agarwal', '2025-02-10');
INSERT INTO Appointments (AppointmentID, PatientID, DoctorName, AppointmentDate) 
VALUES (102, 2, 'Dr. Chaubey', '2025-02-11');
INSERT INTO Appointments (AppointmentID, PatientID, DoctorName, AppointmentDate) 
VALUES (103, 3, 'Dr. Thakur', '2025-02-12');
INSERT INTO Appointments (AppointmentID, PatientID, DoctorName, AppointmentDate) 
VALUES (104, 1, 'Dr. Kumar', '2025-02-13');
SELECT * FROM Appointments;
/*INNER JOIN
SYNTAX: 
  SELECT columns FROM table1 
  INNER JOIN table2 ON table1.column = table2.column;
*/
--- Inner join ---
SELECT P.Name, A.DoctorName, A.AppointmentDate 
FROM Patients P 
INNER JOIN Appointments A ON P.PatientID = A.PatientID;
/*LEFT OUTER JOIN
SYNTAX: 
  SELECT columns FROM table1 
  LEFT JOIN table2 ON table1.column = table2.column;
*/
---Left outer join---
SELECT P.Name, A.DoctorName, A.AppointmentDate 
FROM Patients P 
LEFT JOIN Appointments A ON P.PatientID = A.PatientID;
/*RIGHT OUTER JOIN
SYNTAX: 
  SELECT columns FROM table1 
  RIGHT JOIN table2 ON table1.column = table2.column;
*/
---Right outer join---
SELECT P.Name, A.DoctorName, A.AppointmentDate 
FROM Patients P 
RIGHT JOIN Appointments A ON P.PatientID = A.PatientID;
/*FULL OUTER JOIN
SYNTAX: 
  SELECT columns FROM table1 
  FULL OUTER JOIN table2 ON table1.column = table2.column;
*/
---Full outer join---
SELECT P.Name, A.DoctorName, A.AppointmentDate 
FROM Patients P 
FULL OUTER JOIN Appointments A ON P.PatientID = A.PatientID;
/*CROSS JOIN
SYNTAX: 
  SELECT columns FROM table1 
  CROSS JOIN table2;
*/
---Cross join---
SELECT P.Name, A.DoctorName 
FROM Patients P 
CROSS JOIN Appointments A;
/*SELF JOIN
SYNTAX: 
  SELECT columns FROM table1 A 
  JOIN table1 B ON A.column = B.column;
*/
---Self Join---
SELECT A.Name AS Patient1, B.Name AS Patient2, A.Age 
FROM Patients A 
JOIN Patients B ON A.Age = B.Age AND A.PatientID <> B.PatientID;
-- ADDITIONAL USEFUL COMMANDS
/*DISTINCT - Get unique values
SYNTAX: 
  SELECT DISTINCT column FROM table;
*/
SELECT DISTINCT BloodGroup FROM Patients;
/*ORDER BY - Sort results
SYNTAX: 
  SELECT columns FROM table ORDER BY column ASC/DESC;
*/
SELECT * FROM Patients ORDER BY Age DESC;
SELECT * FROM Patients ORDER BY Name ASC;
/*TOP - Limit results
SYNTAX: 
  SELECT TOP n * FROM table;
*/
SELECT TOP 3 * FROM Patients;
SELECT TOP 2 * FROM Patients ORDER BY Age DESC;
/*AGGREGATE FUNCTIONS
SYNTAX: 
  SELECT FUNCTION(column) FROM table;
*/
-- COUNT
SELECT COUNT(*) AS TotalPatients FROM Patients;
SELECT COUNT(*) AS MalePatients FROM Patients WHERE Gender = 'male';
-- SUM
SELECT SUM(Age) AS TotalAge FROM Patients;
-- AVG
SELECT AVG(Age) AS AverageAge FROM Patients;
-- MIN and MAX
SELECT MIN(Age) AS MinAge, MAX(Age) AS MaxAge FROM Patients;
/*GROUP BY
SYNTAX: 
  SELECT column, FUNCTION(column) FROM table GROUP BY column;
*/
SELECT BloodGroup, COUNT(*) AS PatientCount 
FROM Patients 
GROUP BY BloodGroup;
SELECT Gender, AVG(Age) AS AverageAge 
FROM Patients 
GROUP BY Gender;
/*HAVING - Filter grouped results
SYNTAX: 
  SELECT column, FUNCTION(column) FROM table 
  GROUP BY column 
  HAVING condition;
*/
SELECT BloodGroup, COUNT(*) AS PatientCount 
FROM Patients 
GROUP BY BloodGroup 
HAVING COUNT(*) > 1;
/*LIKE - Pattern matching
SYNTAX: 
  SELECT columns FROM table WHERE column LIKE pattern;
*/
SELECT * FROM Patients WHERE Name LIKE 'A%';
SELECT * FROM Patients WHERE Name LIKE '%Agarwal%';
/*BETWEEN - Range
SYNTAX: 
  SELECT columns FROM table WHERE column BETWEEN value1 AND value2;
*/
SELECT * FROM Patients WHERE Age BETWEEN 25 AND 35;
/*IN - Multiple values
SYNTAX: 
  SELECT columns FROM table WHERE column IN (value1, value2, ...);
*/
SELECT * FROM Patients WHERE BloodGroup IN ('O+', 'A+', 'B+');
/*IS NULL / IS NOT NULL
SYNTAX: 
  SELECT columns FROM table WHERE column IS NULL;
  SELECT columns FROM table WHERE column IS NOT NULL;
*/
SELECT * FROM Patients WHERE Gender IS NOT NULL;
/*AND, OR, NOT - Logical operators
SYNTAX: 
  SELECT columns FROM table WHERE condition1 AND condition2;
  SELECT columns FROM table WHERE condition1 OR condition2;
  SELECT columns FROM table WHERE NOT condition;
*/
SELECT * FROM Patients WHERE Age > 30 AND Gender = 'Male';
SELECT * FROM Patients WHERE BloodGroup = 'O+' OR BloodGroup = 'A+';
SELECT * FROM Patients WHERE NOT Gender = 'Male';
-- STRING FUNCTIONS
/*LEN - String length
SYNTAX: 
  SELECT LEN(string);
*/
SELECT Name, LEN(Name) AS NameLength FROM Patients;
/*UPPER / LOWER - Case conversion
SYNTAX: 
  SELECT UPPER(string), LOWER(string);
*/
SELECT Name, UPPER(Name) AS UpperName, LOWER(Name) AS LowerName FROM Patients;
/*SUBSTRING - Extract substring
SYNTAX: 
  SELECT SUBSTRING(string, start_position, length);
*/
SELECT Name, SUBSTRING(Name, 1, 5) AS FirstFiveChars FROM Patients;
/*CONCAT - Concatenate strings
SYNTAX: 
  SELECT CONCAT(string1, string2, ...);
*/
SELECT CONCAT(Name, ' - ', BloodGroup) AS PatientInfo FROM Patients;
/*REPLACE - Replace string
SYNTAX: 
  SELECT REPLACE(string, old_value, new_value);
*/
SELECT REPLACE(Name, 'Kumar', 'Sharma') FROM Patients;
/*TRIM, LTRIM, RTRIM - Remove spaces
SYNTAX: 
  SELECT TRIM(string), LTRIM(string), RTRIM(string);
*/
SELECT TRIM('  Hello  ') AS Trimmed;
/*LEFT / RIGHT - Extract from left/right
SYNTAX: 
  SELECT LEFT(string, number_of_chars), RIGHT(string, number_of_chars);
*/
SELECT Name, LEFT(Name, 5) AS FirstFive, RIGHT(Name, 5) AS LastFive FROM Patients;
-- DATE FUNCTIONS
/*GETDATE - Current date and time
SYNTAX: 
  SELECT GETDATE();
*/
SELECT GETDATE() AS CurrentDateTime;
/*DATEADD - Add interval to date
SYNTAX: 
  SELECT DATEADD(interval, number, date);
*/
SELECT DATEADD(DAY, 7, GETDATE()) AS NextWeek;
SELECT DATEADD(MONTH, 1, GETDATE()) AS NextMonth;
SELECT DATEADD(YEAR, -1, GETDATE()) AS LastYear;
/*DATEDIFF - Difference between dates
SYNTAX: 
  SELECT DATEDIFF(interval, start_date, end_date);
*/
SELECT DATEDIFF(DAY, '2026-01-01', GETDATE()) AS DaysSinceNewYear;
SELECT Name, DATEDIFF(YEAR, '1990-01-01', GETDATE()) AS CalculatedAge FROM Patients;
/*YEAR, MONTH, DAY - Extract parts
SYNTAX: 
  SELECT YEAR(date), MONTH(date), DAY(date);
*/
SELECT YEAR(GETDATE()) AS CurrentYear;
SELECT MONTH(GETDATE()) AS CurrentMonth;
SELECT DAY(GETDATE()) AS CurrentDay;
/*FORMAT - Format date
SYNTAX: 
  SELECT FORMAT(date, format_string);
*/
SELECT FORMAT(GETDATE(), 'yyyy-MM-dd') AS FormattedDate;
SELECT FORMAT(GETDATE(), 'dd/MM/yyyy') AS IndianFormat;
-- MATHEMATICAL FUNCTIONS
/*ABS - Absolute value
SYNTAX: 
  SELECT ABS(number);
*/
SELECT ABS(-15) AS AbsoluteValue;
/*CEILING / FLOOR - Round up/down
SYNTAX: 
  SELECT CEILING(number), FLOOR(number);
*/
SELECT CEILING(4.3) AS Ceiling, FLOOR(4.7) AS Floor;
/*ROUND - Round to decimal places
SYNTAX: 
  SELECT ROUND(number, decimal_places);
*/
SELECT ROUND(123.4567, 2) AS Rounded;
/*POWER - Power function
SYNTAX: 
  SELECT POWER(base, exponent);
*/
SELECT POWER(2, 3) AS PowerResult;
/*SQRT - Square root
SYNTAX: 
  SELECT SQRT(number);
*/
SELECT SQRT(16) AS SquareRoot;
