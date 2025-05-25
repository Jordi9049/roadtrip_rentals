CREATE DATABASE RoadTripRentals
GO


use RoadTripRentals
GO


--Supplier (David) table drops
IF OBJECT_ID ('SupplierStockOrder') IS NOT NULL
	DROP table SupplierStockOrder
GO

IF OBJECT_ID ('SupplierStock') IS NOT NULL
	DROP table SupplierStock
GO
 
IF OBJECT_ID ('StockOrder') IS NOT NULL
	DROP table StockOrder
GO

IF OBJECT_ID ('Supplier') IS NOT NULL
	DROP table Supplier
GO

IF OBJECT_ID ('Staff') IS NOT NULL
	DROP table Staff
GO

--Customer (Jordan) drop tables
IF OBJECT_ID ('RentalCost') IS NOT NULL
	DROP table RentalCost

IF OBJECT_ID ('RentalCar') IS NOT NULL
	DROP table RentalCar
GO

IF OBJECT_ID ('CarDetails') IS NOT NULL
	DROP table CarDetails
GO
 
IF OBJECT_ID ('Rental') IS NOT NULL
	DROP table Rental
GO

IF OBJECT_ID ('Model') IS NOT NULL
	DROP table Model
GO

IF OBJECT_ID ('Customer') IS NOT NULL
	DROP table Customer
GO

IF OBJECT_ID ('PaymentType') IS NOT NULL
	DROP table PaymentType
GO

--CUSTOMER
CREATE TABLE [dbo].[Customer](
CustomerID	int	NOT NULL,
[Title] [varchar](10) NOT NULL,
[Forename] [varchar](30) NOT NULL,
[Surname] [varchar](30) NOT NULL,
[Street] [varchar](50) NOT NULL,
[County] [varchar](30) NOT NULL,
[City] [varchar](50) NOT NULL,
[Postcode] [varchar](9) NOT NULL,
[EmailAddress] [varchar](50) NOT NULL,
[TelephoneNo] [varchar](15) NOT NULL,

CONSTRAINT pkCustNo PRIMARY KEY (CustomerID),

	CONSTRAINT chkTitle CHECK (Title IN ('Mr','Mrs','Miss','Ms')),
	CONSTRAINT chkPostcode CHECK 
    (
    Postcode LIKE '[A-Z][A-Z][0-9][0-9][ ][0-9][A-Z][A-Z]' OR 
    Postcode LIKE '[A-Z][A-Z][0-9][0-9][0-9][A-Z][A-Z]'
    ),

	CONSTRAINT chkTelNo CHECK (TelephoneNo LIKE REPLICATE('[0-9]', 11)),
	CONSTRAINT chkEmail check (EmailAddress like '%_@__%.__%')
)

--MODEL
CREATE TABLE Model
(
	ModelID			varchar(10)			NOT NULL,
	ModelDesc		varchar(20)			NOT NULL,
	Make			varchar(20)			NOT NULL,
	
	CONSTRAINT pkModelID PRIMARY KEY (ModelID),
	CONSTRAINT unqModelDesc UNIQUE (ModelDesc)
)

--RENTALCost 
CREATE TABLE [dbo].[RentalCost]
(
[RentalCostID] [int] NOT NULL,
[RentalCost] [decimal](6, 2) NOT NULL,

CONSTRAINT pkRentalCostID PRIMARY KEY (RentalCostID),
CONSTRAINT chkRentalCost CHECK (RentalCost > 0),
)

--CAR DETAILS (Jordan (joining supplier and customer)
CREATE TABLE [dbo].[CarDetails](
	[CarReg] [varchar](8) NOT NULL,
	[ModelID][varchar](10) NOT NULL,
	[Colour] [varchar](20) NOT NULL,
	[Mileage] [int] NOT NULL,
	[FuelType] [varchar](20) NOT NULL,
	[NoSeats] [int] NOT NULL,
	[Year] [int] NOT NULL,
	[RentalCostID] [int] NOT NULL,

	CONSTRAINT pkCarReg PRIMARY KEY (CarReg),

	CONSTRAINT fkModelID FOREIGN KEY (ModelID) REFERENCES Model (ModelID),
	CONSTRAINT fkRentalCostID FOREIGN KEY (RentalCostID) REFERENCES RentalCost (RentalCostID),
	CONSTRAINT chkFuelType CHECK (FuelType IN ('Petrol','Diesel','Hybrid','Electric')),
	CONSTRAINT chkNoSeats CHECK (NoSeats >= 2)

)

---PaymentType
CREATE TABLE [dbo].[PaymentType](
	[PaymentID] [int] NOT NULL,
	[PaymentType] [varchar](12) NOT NULL,


	CONSTRAINT pkPaymentID PRIMARY KEY (PaymentID),
	CONSTRAINT chkPaymentType CHECK (PaymentType IN ('Cash','Card', 'Cheque', 'Paypal'))
	)

--RENTAL
CREATE TABLE [dbo].[Rental]
(
[RentalID] [int] NOT NULL,
[CustomerID] [int] NULL,
[StartDatetime] [datetime] NOT NULL,
[NoDays] [int] NOT NULL,
[PaymentID] [int] NOT NULL,
[PaymentDate] [datetime] NOT NULL,


CONSTRAINT pkRentalID PRIMARY KEY (RentalID),

	CONSTRAINT fkCustomerID FOREIGN KEY (CustomerID) REFERENCES Customer (CustomerID),
	CONSTRAINT fkPaymentID FOREIGN KEY (PaymentID) REFERENCES PaymentType (PaymentID),
	CONSTRAINT chkNoDays CHECK (NoDays > 0)
)


--RENTAL CAR (MULTIPLE)
CREATE TABLE RentalCar
(
    RentalID int NOT NULL,
    CarReg varchar(8) NOT NULL,
    TotalCost decimal(10,2) NOT NULL DEFAULT 0.00,

    CONSTRAINT pkRentalCar PRIMARY KEY (RentalID, CarReg),
    CONSTRAINT fkRentalID FOREIGN KEY (RentalID) REFERENCES Rental (RentalID),
    CONSTRAINT fkCarReg1 FOREIGN KEY (CarReg) REFERENCES CarDetails (CarReg),
)



CREATE TABLE Staff 
(
	StaffID			int			NOT NULL,
	StaffForename		varchar(20)		NOT NULL,
	StaffSurname		varchar(20)		NOT NULL,
	StaffEmail		varchar(50)		NOT NULL,

	CONSTRAINT pkStaffID PRIMARY KEY (StaffID),

	CONSTRAINT chkStaffEmail check (StaffEmail like '%_@__%.__%')
)

CREATE TABLE Supplier
(
	SupplierNo			int					NOT NULL,
	SupplierName			varchar(50)			NOT NULL,
	SupplierStreet			varchar(30)			NOT NULL,
	SupplierTown			varchar(30)			NOT NULL,
	SupplierCounty			varchar(30)			NOT NULL,
	SupplierPostCode		varchar(8)			NOT NULL,
	SupplierTelNo			varchar(11)			NOT NULL,
	SupplierEmail			varchar(50)			NOT NULL,
	
	CONSTRAINT pkSupplierNo PRIMARY KEY (SupplierNo),

	CONSTRAINT chkPostcode2 CHECK (SupplierPostcode LIKE '[A-Z][A-Z][0-9][0-9] [0-9][A-Z][A-Z]'),
	CONSTRAINT chkSupplierTelNo CHECK (SupplierTelNo LIKE REPLICATE('[0-9]', 11)),
	CONSTRAINT chkSupplierEmail check (SupplierEmail like '%_@__%.__%')
)


CREATE TABLE StockOrder 
(
	OrderNo			int			NOT NULL,
	OrderDate		datetime		NOT NULL,
	OrderDeliveryDate	datetime		NOT NULL,
	OrderDelivered		bit			NOT NULL,
	StaffID			int			NOT NULL,
	SupplierNo		int			NOT NULL,
	
	CONSTRAINT pkOrderNo PRIMARY KEY (OrderNo),
	CONSTRAINT fkStaffID FOREIGN KEY (StaffID) REFERENCES Staff (StaffID),
	CONSTRAINT fkSupplierNo FOREIGN KEY (SupplierNo) REFERENCES Supplier (SupplierNo),	
)


CREATE TABLE SupplierStock
(
	SupplierCarReg		varchar(8)		NOT NULL,
	Colour			varchar(15)		NOT NULL,
	Mileage			int			NOT NULL,
	FuelType		varchar(15)		NOT NULL,
	NoOfSeats		int			NOT NULL,
	CarYear			int			NOT NULL,
	Price			money			NOT NULL,
	SupplierNo		int			NOT NULL,
	ModelID			varchar(2)		NOT NULL,

	CONSTRAINT pkSupplierCarReg PRIMARY KEY (SupplierCarReg),
	CONSTRAINT fkSupplierNo2 FOREIGN KEY (SupplierNo) REFERENCES Supplier (SupplierNo),
	CONSTRAINT fkModelID2 FOREIGN KEY (ModelID) REFERENCES Model (ModelID),

	CONSTRAINT chkPrice CHECK (Price > 0)
)


CREATE TABLE SupplierStockOrder
(
	OrderNo			int		NOT NULL,
	SupplierCarReg		varchar(8)	NOT NULL,

	CONSTRAINT pkSupplierStockOrder PRIMARY KEY (OrderNo, SupplierCarReg),
	CONSTRAINT fkOrderNo FOREIGN KEY (OrderNo) REFERENCES StockOrder (OrderNo),
	CONSTRAINT fkSupplierCarReg FOREIGN KEY (SupplierCarReg) REFERENCES SupplierStock (SupplierCarReg),
)


	 --populating customer table
INSERT INTO Customer (CustomerID, Title, Forename, Surname, Street, County, City, Postcode, EmailAddress, TelephoneNo)
VALUES
(1,'Mr', 'John', 'Doe', '10 Main St', 'London', 'London', 'WL15 4HS', 'john.doe@example.com', '07123456789'),
(2,'Mrs', 'Sarah', 'Smith', '15,High St', 'Bristol', 'South West', 'BS11 6EE', 'sarah.smith@example.com', '07876543210'),
(3,'Miss', 'Emma', 'Taylor', '22 Park Rd', 'Manchester', 'Greater Manchester', 'MP14 5TB', 'emma.taylor@example.com', '07987654321'),
(4,'Ms', 'Sophie', 'Jones', '4 Church Ln', 'Birmingham', 'West Midlands', 'Bt22 5TG', 'sophie.jones@example.com', '07321098765');

SELECT * FROM customer

 --populating model table
 INSERT INTO Model (ModelID, ModelDesc, Make) VALUES 
 ('A4', 'A4', 'Audi'),
 ('A5', 'A5', 'Audi'),
 ('A6', 'A6', 'Audi'),
 ('Q5', 'Q5', 'Audi'),
 ('Q7', 'Q7', 'Audi'),
 ('1S', '1 Series', 'BMW'),
 ('3S', '3 Series', 'BMW'),
 ('X5', 'X5', 'BMW'),
 ('X7', 'X7', 'BMW'),
 ('FO', 'Focus', 'Ford'),
 ('FI', 'Fiesta', 'Ford'),
 ('MN', 'Mondeo', 'Ford'),
 ('MU', 'Mustang', 'Ford'),
 ('PT', 'Passat', 'Volkswagen'),
 ('AR', 'Arteon', 'Volkswagen'),
 ('GF', 'Golf', 'Volkswagen'),
 ('JT', 'Jetta', 'Volkswagen'),
 ('CC', 'Civic', 'Honda'),
 ('AD', 'Accord', 'Honda'),
 ('AS', 'A-Class', 'Mercedes'),
 ('BS', 'B-Class', 'Mercedes'),
 ('CS', 'C-Class', 'Mercedes')

SELECT * FROM Model ORDER BY Make

--Populating Rental Cost
INSERT INTO RentalCost (RentalCostID, RentalCost)
VALUES
(1, 30.00),
(3, 45.00)

SELECT * FROM RentalCost

--Populating Car Details
INSERT INTO CarDetails (CarReg, ModelID, Colour, Mileage, FuelType, NoSeats, Year, RentalCostID)
VALUES 
('AB12CDE', 'X5', 'Black', 15000, 'Petrol', 4, 2019, 1),
('FG34HIJ', 'A4', 'White', 20000, 'Diesel', 5, 2018, 3)

SELECT * FROM CarDetails

--Populating PaymentType
INSERT INTO [dbo].[PaymentType] ([PaymentID], [PaymentType], [PaymentDate])
VALUES
	(1, 'Card', GETDATE()),
	(2, 'Cash', GETDATE()),
	(3, 'Card', GETDATE()),
	(4, 'Cash', GETDATE()),
	(6, 'Card', GETDATE());

SELECT * FROM PaymentType

--Populating Rental Table
INSERT INTO [dbo].[Rental] ([RentalID], [CustomerID], [StartDatetime], [NoDays], [PaymentID])
VALUES
(1, 1, '2023-05-01 09:00:00', 3, 1),
(2, 2, '2023-05-10 10:00:00', 5, 2),
(3, 3, '2023-05-15 12:00:00', 2, 3);
SELECT * FROM Rental

--Populating Rental Car
INSERT INTO RentalCar (RentalID, CarReg) VALUES
(1,'AB12CDE'),
(2,'FG34HIJ');
SELECT * FROM RentalCar

 --populating staff table
INSERT INTO Staff (StaffID,  StaffForename, StaffSurname, StaffEmail) VALUES 
(101, 'Simon', 'Morrison', 'simon.morrison@roadtriprentals.com'),   
(102, 'Brendan', 'Mulligan', 'brendan.mulligan@roadtriprentals.com' ),  
(103, 'Ryan', 'Pulson', 'ryan.pulson@roadtriprentals.com' ), 
(104, 'William', 'Tucker', 'william.tucker@roadtriprentals.com' ), 
(105, 'David', 'Lynch', 'david.lynch@roadtriprentals.com' ), 
(106, 'Lily', 'Collins', 'lily.collins@roadtriprentals.com' ),
(107, 'Jordan', 'Belfort', 'jordan.belfort@roadtriprentals.com'),
(108, 'Frank', 'Reynolds', 'frank.reynolds@roadtriprentals.com'), 
(109, 'Charlie', 'Kelly', 'charlie.kelly@roadtriprentals.com'),
(110, 'Peter', 'Harris', 'peter.harris@roadtriprentals.com')

SELECT * FROM Staff 

 --populating supplier table
INSERT INTO Supplier (SupplierNo, SupplierName, SupplierStreet, SupplierTown, SupplierCounty, SupplierPostCode, SupplierTelNo, SupplierEmail) VALUES 	
(1001, 'Bob Mullan Motors', '14 Clooney Rd', 'Eglinton', 'Derry', 'BT47 3DN', '02812345679', 'sales@bmmmotors.com'),  				  	
(1002, 'Ed O Neils Cars', '2 Lacey Industrial Est', 'Coleraine', 'Derry', 'BT49 5GH', '02873546874', 'ed@eoncars.com'), 						  	
(1003, 'Curley Cars', '43 Victoria Rd', 'Campsie', 'Derry', 'BT47 2PU', '02871821456', 'conor@curleycars.co.uk'), 			 
(1004, 'Mediocre Motors', '8 Cherry Rd', 'Salford', 'Manchester', 'MA14 1BL', '02045133784', 'enquiries@mediocremotors.com'), 
(1005, 'Car Haven', '16 Car Park', 'Lisburn', 'Down', 'BT12 3HP', '02174856475', 'sales@carhaven.com'),
(1006, 'Cars Cars Cars', '7 Castledawson est', 'Magherafelt', 'Derry', 'BT46 5SW', '01465231785', 'info@carsx3.com'),
(1007, 'Audi Corporation', '5 Titanic Park', 'Belfast', 'Down', 'BT11 6RE', '08006998888', 'enquiries@audi.com'),
(1008, 'VW Group', '16 Riverside Road', 'Newry', 'Armagh', 'BT23 5LK', '09054136541', 'enquiries@vwgroup.com')

SELECT * FROM Supplier

 

 --populating supplier stock table
 INSERT INTO SupplierStock (SupplierCarReg,	Colour, Mileage, FuelType, NoOfSeats, CarYear, Price, SupplierNo, ModelID) VALUES 
 ('WER3405', 'Red', 27623, 'Diesel', 5, 2017, 18650, 1003, 'FO'),
 ('PLK340F', 'Black', 17364, 'Diesel', 7, 2018, 34500, 1007, 'Q7'),
 ('TLP0992', 'White', 22336, 'Petrol', 5, 2017, 21350, 1007, 'A6'),
 ('BSD1931', 'Blue', 16886, 'Electric', 5, 2019, 25950, 1008, 'AR'),
 ('WTG5547', 'Orange', 13224, 'Petrol', 2, 2020, 29995, 1001, 'MU'),
 ('KHD1256', 'Red', 50000, 'Petrol', 5, 2018, 15000, 1007, 'A4'),
 ('WXC8762', 'Blue', 75000, 'Diesel', 5, 2015, 8500, 1002, '1S'),
 ('QPO9834', 'Black', 40000, 'Petrol', 5, 2019, 18000, 1003, 'CS'),
 ('BGT7145', 'White', 100000, 'Diesel', 5, 2013, 8000, 1008, 'AR'),
 ('LNJ3901', 'Silver', 60000, 'Electric', 5, 2017, 13000, 1008, 'GF'),
 ('RFD5928', 'Red', 80000, 'Diesel', 5, 2016, 11000, 1006, 'FI'),
 ('VTY6390', 'Blue', 90000, 'Petrol', 5, 2014, 9000, 1007, 'CC'),
 ('XZM2745', 'Black', 5000, 'Diesel', 5, 2022, 25000, 1008, 'BS'),
 ('EKH8361', 'White', 30000, 'Petrol', 5, 2020, 20000, 1007, 'A5'),
 ('JLP4019', 'Silver', 20000, 'Electric', 2, 2021, 22000, 1002, 'MU'),
 ('HGE9012', 'Blue', 40000, 'Petrol', 5, 2020, 15000, 1001, 'X5'),
 ('MLV2235', 'Silver', 10000, 'Petrol', 5, 2021, 20000, 1001, '3S'),
 ('TRF3467', 'Black', 8000, 'Diesel', 5, 2020, 16000, 1002, 'AD'),
 ('AWV7722', 'Red', 60000, 'Diesel', 5, 2016, 15000, 1005, 'PT'),
 ('LLI9345', 'Grey', 5000, 'Petrol', 5, 2022, 28000, 1005, 'AR'),
 ('CMJ2033', 'White', 2000, 'Diesel', 5, 2023, 40000, 1005, 'BS'),
 ('UIO3365', 'Silver', 18000, 'Petrol', 5, 2019, 14500, 1006, 'GF'),
 ('QAZ7444', 'White', 20000, 'Diesel', 5, 2019, 15500, 1006, 'AD'),
 ('DSA3235', 'Black', 15000, 'Petrol', 5, 2021, 25000, 1007, 'A5'),
 ('PVB7814', 'Silver', 44000, 'Electric', 5, 2020, 21000, 1004, 'AS'),
 ('NZL3728', 'Red', 66000, 'Diesel', 5, 2017, 14500, 1004, 'MN'),
 ('GKT9285', 'Grey', 99000, 'Petrol', 5, 2015, 8900, 1004, 'FO'),
 ('KUI9842', 'White', 15000, 'Petrol', 5, 2021, 25000, 1008, 'GF'),
 ('JKP4258', 'Red', 30000, 'Petrol', 5, 2020, 21000, 1008, 'PT'),
 ('PLP6927', 'Blue', 35000, 'Electric', 5, 2019, 19000, 1008, 'AR'),
 ('KPM2387', 'Silver', 18000, 'Diesel', 5, 2020, 27000, 1007, 'A4'),
 ('QUI6905', 'Black', 12000, 'Diesel', 5, 2019, 22000, 1007, 'Q5'),
 ('LKA6697', 'Grey', 60000, 'Diesel', 5, 2016, 7000, 1001, 'FI'),
 ('STU8671', 'Black', 5000, 'Petrol', 5, 2022, 25000, 1001, 'PT'),
 ('BDR3958', 'White', 42000, 'Petrol', 5, 2021, 23500, 1004, 'CC'),
 ('NKH6790', 'Blue', 88000, 'Diesel', 5, 2016, 12800, 1004, 'MN'),
 ('JRD1354', 'Silver', 56000, 'Petrol', 5, 2020, 20500, 1004, 'GF'),
 ('HJK6784', 'Grey', 13000, 'Diesel', 5, 2019, 17000, 1002, 'AS'),
 ('POK5123', 'White', 10000, 'Petrol', 7, 2021, 19000, 1002, 'X7'),
 ('TES0233', 'Silver', 20000, 'Diesel', 5, 2019, 13500, 1006, 'MU'),
 ('QWE1100', 'Red', 25000, 'Petrol', 5, 2017, 8000, 1006, 'PT'),
 ('POI7865', 'Grey', 30000, 'Electric', 5, 2016, 7500, 1006, 'AR'),
 ('LKJ5478', 'Blue', 20000, 'Petrol', 5, 2019, 10500, 1006, 'PT'),
 ('RVP9532', 'White', 22000, 'Diesel', 5, 2020, 22500, 1004, '3S'),
 ('LHN2367', 'Blue', 33000, 'Petrol', 5, 2018, 18000, 1004, 'PT'),
 ('JXC4806', 'Black', 9000, 'Electric', 5, 2019, 14000, 1003, 'FO'),
 ('DFR5056', 'Silver', 14000, 'Electric', 7, 2022, 35000, 1007, 'Q7'),
 ('TGR7204', 'White', 25000, 'Electric', 5, 2020, 23000, 1008, 'CC'),
 ('HGH1865', 'Silver', 45000, 'Diesel', 5, 2018, 16000, 1008, 'JT'),
 ('FVG9930', 'Black', 15000, 'Petrol', 5, 2021, 27000, 1005, 'CS'),
 ('DCX7422', 'Blue', 1000, 'Diesel', 5, 2023, 35000, 1005, 'CC'),
 ('UXO2089', 'Blue', 20000, 'Petrol', 5, 2019, 9500, 1006, 'FO'),
 ('PLT8621', 'Black', 56000, 'Petrol', 2, 2019, 19500, 1004, '1S'),
 ('JHT4567', 'Red', 5000, 'Petrol', 2, 2020, 30000, 1003, '1S'),
 ('KTR3087', 'Blue', 15000, 'Electric', 5, 2019, 25000, 1003, 'MN'),
 ('NCP1456', 'Black', 10000, 'Petrol', 5, 2021, 35000, 1003, 'CS'),
 ('ETR1885', 'White', 25000, 'Diesel', 5, 2023, 30000, 1001, 'JT'),
 ('GVA3829', 'Silver', 12000, 'Electric', 5, 2020, 15000, 1002, 'AS'),
 ('SGL8766', 'Black', 50000, 'Petrol', 5, 2018, 10000, 1001, '1S'),
 ('DFR7245', 'Red', 30000, 'Diesel', 5, 2019, 12000, 1001, '3S'),
 ('NMB7996', 'Black', 15000, 'Diesel', 5, 2018, 12250, 1006, 'JT'),
 ('RTY9750', 'Red', 10000, 'Petrol', 7, 2022, 38000, 1007, 'Q7'),
 ('GJW3681', 'White', 11000, 'Diesel', 5, 2021, 29000, 1007, 'Q5'),
 ('XXR3851', 'Black', 40000, 'Diesel', 5, 2018, 18000, 1008, 'GF'),
 ('DTH0883', 'White', 28000, 'Petrol', 7, 2020, 32000, 1005, 'X7'),
 ('VCF3695', 'Blue', 40000, 'Diesel', 5, 2017, 18000, 1005, 'FO'),
 ('YUI2232', 'Silver', 45000, 'Petrol', 5, 2015, 12000, 1005, 'MN'),
 ('XPM5503', 'White', 15000, 'Diesel', 5, 2018, 11250, 1006, 'FI'),
 ('HAT6811', 'Black', 18000, 'Petrol', 5, 2019, 12500, 1006, 'MN'),
 ('QBS6249', 'Black', 75000, 'Petrol', 5, 2014, 9700, 1004, 'FI'),
 ('GNH7785', 'Red', 50000, 'Petrol', 2, 2018, 20000, 1005, '1S'),
 ('PDK2468', 'Grey', 12000, 'Petrol', 5, 2018, 22000, 1003, 'AD'),
 ('KNB3094', 'Red', 5000, 'Diesel', 5, 2021, 16000, 1003, 'FI'),
 ('LKC4967', 'Red', 15000, 'Diesel', 5, 2018, 13000, 1002, 'Q7'),
 ('KJG2189', 'Blue', 11000, 'Petrol', 5, 2020, 22000, 1002, 'A4'),
 ('JLM5841', 'White', 20000, 'Diesel', 5, 2017, 8000, 1001, 'MN'),
 ('HMG7890', 'White', 8000, 'Hybrid', 5, 2020, 28000, 1003, 'BS'),
 ('BPL9703', 'Blue', 15000, 'Petrol', 7, 2021, 30000, 1007, 'Q7'),
 ('HTT6481', 'Black', 20000, 'Petrol', 5, 2021, 28000, 1008, 'AR'),
 ('JDL5678', 'Silver', 2000, 'Electric', 5, 2022, 45000, 1003, 'AS'),
 ('YHN9658', 'Red', 12000, 'Petrol', 2, 2018, 14000, 1002, '1S'),
 ('TYU3695', 'Blue', 14000, 'Diesel', 5, 2019, 9000, 1002, 'FI'),
 ('VFF6730', 'Black', 35000, 'Electric', 5, 2019, 24000, 1005, 'BS'),
 ('TYH7418', 'White', 10000, 'Petrol', 5, 2021, 31000, 1007, 'A6'),
 ('GTS6691', 'Blue', 9000, 'Petrol', 5, 2021, 29000, 1007, 'A4'),
 ('JVP5412', 'Black', 50000, 'Petrol', 5, 2017, 14000, 1008, 'GF'),
 ('YZA6321', 'Blue', 45000, 'Petrol', 5, 2014, 6000, 1001, 'FO'),
 ('KSA8576', 'White', 8000, 'Petrol', 5, 2021, 18000, 1002, 'FI'),
 ('HMF1298', 'Black', 9000, 'Petrol', 5, 2019, 19000, 1002, 'CS'),
 ('VBT4411', 'Red', 35000, 'Electric', 2, 2015, 9000, 1001, 'CC'),
 ('GJU8952', 'Red', 12000, 'Petrol', 5, 2020, 28000, 1007, 'A6');
 
 SELECT * FROM SupplierStock
 
  INSERT INTO StockOrder(OrderNo,  OrderDate, OrderDeliveryDate, OrderDelivered, StaffID, SupplierNo) VALUES 
 (10000, '20220311', '20220318', 1, 104, 1003),
 (10001, '20220604', '20220611', 1, 107, 1002),
 (10002, '20221023', '20221030', 1, 102, 1006),
 (10003, '20230215', '20230222', 1, 101, 1005)
 
 SELECT * FROM StockOrder


 INSERT INTO SupplierStockOrder(OrderNo, SupplierCarReg) VALUES 
 (10000, 'KTR3087'),
 (10000, 'JDL5678'),
 (10001, 'HMF1298'),
 (10001, 'KSA8576'),
 (10001, 'TYU3695'),
 (10002, 'HAT6811'),
 (10003, 'VFF6730'),
 (10003, 'GNH7785')

  SELECT * FROM SupplierStockOrder

 

