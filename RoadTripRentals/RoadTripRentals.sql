--CREATE DATABASE RoadTripRentals
GO


use RoadTripRentals
GO




IF OBJECT_ID ('SupplierStockOrder') IS NOT NULL
	DROP table SupplierStockOrder
GO

IF OBJECT_ID ('SupplierStock') IS NOT NULL
	DROP table SupplierStock
GO
 
IF OBJECT_ID ('StockOrder') IS NOT NULL
	DROP table StockOrder
GO

IF OBJECT_ID ('SupplierModel') IS NOT NULL
	DROP table SupplierModel
GO

IF OBJECT_ID ('Supplier') IS NOT NULL
	DROP table Supplier
GO

IF OBJECT_ID ('Staff') IS NOT NULL
	DROP table Staff
GO

CREATE TABLE Staff 
(
	StaffID			int				NOT NULL,
	StaffForename	varchar(20)		NOT NULL,
	StaffSurname	varchar(20)		NOT NULL,
	StaffEmail		varchar(50)		NOT NULL,

	CONSTRAINT pkStaffID PRIMARY KEY (StaffID),

	CONSTRAINT chkStaffEmail check (StaffEmail like '%_@__%.__%')
)

CREATE TABLE Supplier
(
	SupplierNo				int					NOT NULL,
	SupplierName			varchar(50)			NOT NULL,
	SupplierStreet			varchar(30)			NOT NULL,
	SupplierTown			varchar(30)			NOT NULL,
	SupplierCounty			varchar(30)			NOT NULL,
	SupplierPostCode		varchar(8)			NOT NULL,
	SupplierTelNo			varchar(11)			NOT NULL,
	SupplierEmail			varchar(50)			NOT NULL,
	
	CONSTRAINT pkSupplierNo PRIMARY KEY (SupplierNo),

	CONSTRAINT chkPostcode CHECK (SupplierPostcode LIKE '[A-Z][A-Z][0-9][0-9] [0-9][A-Z][A-Z]'),
	CONSTRAINT chkSupplierTelNo CHECK (SupplierTelNo LIKE REPLICATE('[0-9]', 11)),
	CONSTRAINT chkSupplierEmail check (SupplierEmail like '%_@__%.__%')
)

CREATE TABLE SupplierModel
(
	SupplierModelID	varchar(2)			NOT NULL,
	ModelDesc		varchar(20)			NOT NULL,
	Make			varchar(20)			NOT NULL,
	
	CONSTRAINT pkSupplierModelID PRIMARY KEY (SupplierModelID),

	CONSTRAINT unqModelDesc UNIQUE (ModelDesc)
)



CREATE TABLE StockOrder 
(
	OrderNo				int					NOT NULL,
	OrderDate			datetime			NOT NULL,
	OrderDeliveryDate	datetime			NOT NULL,
	OrderTotal			money				NOT NULL,
	OrderDelivered		bit					NOT NULL,
	StaffID				int					NOT NULL,
	SupplierNo			int					NOT NULL,
	
	CONSTRAINT pkOrderNo PRIMARY KEY (OrderNo),
	CONSTRAINT fkStaffID FOREIGN KEY (StaffID) REFERENCES Staff (StaffID),
	CONSTRAINT fkSupplierNo FOREIGN KEY (SupplierNo) REFERENCES Supplier (SupplierNo),

	CONSTRAINT chkOrderTotal CHECK (OrderTotal > 0)
)


CREATE TABLE SupplierStock
(
	SupplierCarReg		varchar(8)			NOT NULL,
	Colour				varchar(15)			NOT NULL,
	Mileage				int					NOT NULL,
	FuelType			varchar(15)			NOT NULL,
	NoOfSeats			int					NOT NULL,
	CarYear				datetime			NOT NULL,
	Price				money				NOT NULL,
	SupplierNo			int					NOT NULL,
	SupplierModelID		varchar(2)			NOT NULL,

	CONSTRAINT pkSupplierCarReg PRIMARY KEY (SupplierCarReg),
	CONSTRAINT fkSupplierNo2 FOREIGN KEY (SupplierNo) REFERENCES Supplier (SupplierNo),
	CONSTRAINT fkSupplierModelID FOREIGN KEY (SupplierModelID) REFERENCES SupplierModel (SupplierModelID),

	CONSTRAINT chkPrice CHECK (Price > 0)
)


CREATE TABLE SupplierStockOrder
(
	OrderNo				int					NOT NULL,
	SupplierCarReg		varchar(8)			NOT NULL,

	CONSTRAINT pkSupplierStockOrder PRIMARY KEY (OrderNo, SupplierCarReg),
	CONSTRAINT fkOrderNo FOREIGN KEY (OrderNo) REFERENCES StockOrder (OrderNo),
	CONSTRAINT fkSupplierCarReg FOREIGN KEY (SupplierCarReg) REFERENCES SupplierStock (SupplierCarReg),
)

 --populating staff table
INSERT INTO Staff (StaffID,  StaffForename, StaffSurname, StaffEmail) VALUES 
(101, 'Simon', 'Morrison', 'simon.morrison@roadtriprentals.com'),   
(102, 'Brendan', 'Mulligan', 'brendan.mulligan@roadtriprentals.com'),  
(103, 'Ryan', 'Pulson', 'ryan.pulson@roadtriprentals.com'), 
(104, 'William', 'Tucker', 'william.tucker@roadtriprentals.com'), 
(105, 'David', 'Lynch', 'david.lynch@roadtriprentals.com'), 
(106, 'Lily', 'Collins', 'lily.collins@roadtriprentals.com'),
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

 --populating supplier model table
 INSERT INTO SupplierModel (SupplierModelID, ModelDesc, Make) VALUES 
 ('A6', 'A6', 'Audi'),
 ('A5', 'A5', 'Audi'),
 ('A4', 'A4', 'Audi'),
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
 ('PU', 'Puma', 'Ford'),
 ('PT', 'Passat', 'Volkswagen'),
 ('AR', 'Arteon', 'Volkswagen'),
 ('GF', 'Golf', 'Volkswagen'),
 ('JT', 'Jetta', 'Volkswagen')
 
 SELECT * FROM SupplierModel
 

 --populating supplier stock table
 INSERT INTO SupplierStock (SupplierCarReg,	Colour, Mileage, FuelType, NoOfSeats, CarYear, Price, SupplierNo, SupplierModelID) VALUES 
 ('WER 3405', 'Red', 27623, 'Diesel', 5, 2017, 18650.00, 1003, 'FO'),
 ('PLK340F', 'Black', 17364, 'Diesel', 7, 2018, 34500.00, 1007, 'Q7'),
 ('TLP 0992', 'White', 22336, 'Petrol', 5, 2017, 21350, 1007, 'A6'),
 ('BSD 1931', 'Blue', 16886, 'Electric', 5, 2019, 25950, 1008, 'AR'),
 ('WTG5547', 'Orange', 13224, 'Petrol', 2, 2020, 29995, 1001, 'MU')

 SELECT * FROM SupplierStock