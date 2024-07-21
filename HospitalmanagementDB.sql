create database HospitalMgnt;
USE HospitalMgnt;
CREATE TABLE Patients (
    PatientID INT PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    DateOfBirth DATE,
    Gender NVARCHAR(10),
    PhoneNumber NVARCHAR(20),
    Email NVARCHAR(100),
    Address NVARCHAR(255)
);
CREATE TABLE Doctors (
    DoctorID INT PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    DateOfBirth DATE,
    Gender NVARCHAR(10),
    PhoneNumber NVARCHAR(20),
    Email NVARCHAR(100),
    Specialty NVARCHAR(50),
    LicenseNumber NVARCHAR(20)
);
CREATE TABLE Appointments (
    AppointmentID INT PRIMARY KEY,
    PatientID INT,
    DoctorID INT,
    AppointmentDate DATETIME,
    Notes NVARCHAR(1000),
    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID),
    FOREIGN KEY (DoctorID) REFERENCES Doctors(DoctorID)
);
CREATE TABLE Wards (
    WardID INT PRIMARY KEY,
    WardName NVARCHAR(50),
    Capacity INT
	);
CREATE TABLE Pharmacy (
    MedicineID INT PRIMARY KEY,
    MedicineName NVARCHAR(100),
    Manufacturer NVARCHAR(100),
    ExpiryDate DATE,
    Price DECIMAL(10, 2)
);
CREATE TABLE Payments (
    PaymentID INT PRIMARY KEY,
    PatientID INT,
    Amount DECIMAL(10, 2),
    PaymentDate DATETIME,
    FOREIGN KEY (PatientID) REFERENCES Patients(PatientID)
);

CREATE TABLE Login (
    LoginID INT PRIMARY KEY,
    UserName NVARCHAR(50) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    CreatedAt DATETIME DEFAULT GETDATE(),
    LastLoginAt DATETIME,
    IsActive BIT DEFAULT 1
);
-- Example INSERT statement
INSERT INTO Login (UserName, PasswordHash, Email) VALUES ('FaithW.', 'fay', 'faithw@example.com');
INSERT INTO Login (UserName, PasswordHash, Email) VALUES ('PeaceW.', 'peace', 'peacew@example.com');
INSERT INTO Login (UserName, PasswordHash, Email) VALUES ('Amanda.', 'aaa', 'amanda@example.com');
INSERT INTO Login (UserName, PasswordHash, Email) VALUES ('LaureenW.', 'lauu', 'lauw@example.com');

-- Example SELECT statement
SELECT * FROM Login;
USE HospitalMgnt; 
SELECT * FROM Appointments;








 


