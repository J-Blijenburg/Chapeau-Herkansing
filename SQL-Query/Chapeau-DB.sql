/*The Following sql query's are for creating the tables*/

/*This is the ENUM for the status of a table*/
CREATE TABLE [TableStatus](
	TableStatusId int identity(1,1) NOT NULL primary key,
	Status varchar(20)
);

CREATE TABLE [Table](
	TableId int identity(1,1) NOT NULL primary key,
	Number int,
	Status int foreign key references TableStatus(TableStatusId)
);

/*This is the ENUM for which payment is selected*/
CREATE TABLE [PaymentMethod](
	PaymentMethodId int identity(1,1) NOT NULL primary key,
	Method varchar(15)
);

CREATE TABLE [Payment](
	PaymentId int identity(1,1) NOT NULL primary key,
	IsPaid BIT
);

/*This is the ENUM to selected the employee role*/
CREATE TABLE [EmployeeRole](
	EmployeeRoleId int identity(1,1) NOT NULL primary key,
	Role VarChar(25)
);

CREATE TABLE [Employee](
	EmployeeId int identity(1,1) NOT NULL primary key,
	FirstName varchar(50),
	LastName varchar(50),
	EmployeeNumber int,
	Password varchar(50),
	IsActive BIT,
	RegistrationDate Date,
	Role int foreign key references EmployeeRole(EmployeeRoleId)
);

CREATE TABLE [Receipt](
	ReceiptId int identity(1,1) NOT NULL primary key,
	ReceiptDateTime Date,
	Feedback varchar(1000),
	EmployeeId int foreign key references Employee(EmployeeId),
	TableId int foreign key references [Table](TableId),
	LowVatPrice float,
	HighVatPrice float,
	TotalPrice float,
	Tip float,
	IsHandled BIT,
	PaymentId int foreign key references Payment(PaymentId)
);

/*This Table is a enum for the status of the order*/
CREATE TABLE [OrderStatus](
	OrderStatusId int identity(1,1) NOT NULL primary key,
	Status varchar(25)
);

CREATE TABLE [Order](
	OrderId int identity(1,1) NOT NULL primary key,
	EmployeeId int,
	ReceiptId int foreign key references Receipt(ReceiptId),
	OrderDateTime DateTime,
	Status int foreign key references OrderStatus(OrderStatusId)
);

CREATE TABLE [Menu](
	MenuId int identity(1,1) NOT NULL primary key,
	Name varchar(25),
	StartTime time,
	EndTime time
);

CREATE TABLE [MenuCategory](
	MenuCategoryId int identity(1,1) NOT NULL primary key,
	VAT float,
	Name varchar(25),
	MenuId int foreign key references Menu(MenuId)
);

CREATE TABLE [MenuItem](
	MenuItemId int identity(1,1) NOT NULL primary key,
	Name varchar(355),
	Stock int,
	Price float,
	MenuCategoryId int foreign key references MenuCategory(MenuCategoryId)
)

CREATE TABLE [OrderItem](
	OrderItemId int identity(1,1) NOT NULL primary key,
	OrderId int foreign key references [Order](OrderId),
	Comment varchar(1000),
	MenuItemId int foreign key references MenuItem(MenuItemId),
	Quantity int
)

/*First the tables has to be created before they can be filled with information*/

GO

INSERT INTO [TableStatus]
VALUES 
('Open'),
('Reserved'),
('Occupied');

INSERT INTO [PaymentMethod]
VALUES
('CreditCard'),
('Cash'),
('Pin');

INSERT INTO [EmployeeRole]
VALUES
('Chefkok'),
('Bartender'),
('Waiter'),
('Manager');

INSERT INTO [OrderStatus]
VALUES
('Ordered'),
('Preparing'),
('Deliverd'),
('ReadyToBeServed');

GO

INSERT INTO [Menu]
VALUES
('Lunch', CONVERT(TIME, '12:00:00'), CONVERT(TIME,'18:00:00')),
('Dinner', CONVERT(TIME, '18:00:00'), CONVERT(TIME, '23:59:59')),
('Drinks', CONVERT(TIME, '07:00:00'), CONVERT(TIME, '23:59:59'));

GO

/*The category's for the lunch Card*/
INSERT INTO [MenuCategory]
VALUES
(6, 'Starters', 1),
(6, 'Mains', 1),
(6, 'Desserts', 1)
;

/*The category's for the Diner Card*/
INSERT INTO [MenuCategory]
VALUES
(6, 'Starters', 2),
(6, 'Entres', 2),
(6, 'Mains', 2),
(6, 'Desserts', 2)
;

/*The category's for the Drinks Card*/
INSERT INTO [MenuCategory]
VALUES
(6, 'SoftDrinks', 3),
(21, 'Beers', 3),
(21, 'Wines', 3),
(21, 'Spirits', 3),
(6, 'HotDrinks', 3)
;

/*Menu items for the lunch Starter*/
INSERT INTO [MenuItem]
VALUES
('Steak tartaar met truffelmayonaisse', 25, 7.50, 1),
('Paté van fazant met monegaskische uitjes', 25, 8.50, 1),
('Provençaalse vissoep met rouille, oude kaas en croutons', 25, 6.50, 1)
;

/*Menu items for the lunch Maincourse*/
INSERT INTO [MenuItem]
VALUES
('Hertenstoofpotje met rode kool', 25, 12.50, 2),
('Gebakken kabeljauw met curry-sabayon', 25, 14.50, 2),
('Linguini met paddenstoelensaus', 25, 13.50, 2)
;

/*Menu items for the lunch Desserts*/
INSERT INTO [MenuItem]
VALUES
('Taart van witte chocolade en speculaas met mandarijn', 25, 5.50, 3),
('Verse Madeleine met vijgen compote en crème patissier met Grand Marnier', 25, 6.50, 3),
('3 soorten boerenkazen met rogge rozijnenbrood', 25, 5, 3)
;

/*Menu items for the Diner Starters*/
INSERT INTO [MenuItem]
VALUES
('Kalfstartaar met tonijnmayonaise en gefrituurde mosselen', 25, 8.50, 4),
('Paté van fazant met Monegaskische uitjes', 25, 8.50, 4),
('Krab-zalm koekjes met zoetzure-chilisaus', 25, 9, 4)
;

/*Menu items for the Diner Entres*/
INSERT INTO [MenuItem]
VALUES
('Provençaalse vissoep met rouille en croutons', 25, 6.50, 5),
('Consommé van fazant met bosui en groene kruiden', 25, 7.50, 5)
;

/*Menu items for the Diner Mains*/
INSERT INTO [MenuItem]
VALUES
('Op de huid gebakken kabeljauw rug filet met curry-sabayon', 25, 17.50, 6),
('Gebakken ossenhaas met kalf-jus met roze pepers', 25, 22.50, 6),
('Hertenbiefstuk met eigen stoof en rode kool', 25, 25, 6)
;

/*Menu items for the Diner Desserts*/
INSERT INTO [MenuItem]
VALUES
('Café surprise (Koffie met huisgemaakte bonbons)', 25, 5.50, 7),
('Cherry Baby ( Slagroomijs met warme kersen)', 25, 6.50, 7),
('Port e Fromage (verschillende kazen met glaasje port)', 25, 7.50, 7)
;

/*Menu items for all the soft drinks*/
INSERT INTO [MenuItem]
VALUES
('Spa rood', 25, 2.50, 8),
('Spa groen', 25, 2.50, 8),
('Coca Cola Light', 25, 2.50, 8),
('Coca Cola', 25, 2.50, 8),
('Sisi', 25, 2.50, 8),
('Tonic', 25, 2.50, 8),
('Bitter Lemon', 25, 2.50, 8)
;

/*Menu Items for all the beers*/
INSERT INTO [MenuItem]
VALUES
('Hertog Jan', 25, 3, 9),
('Duvel', 25, 4.50, 9),
('Kriek', 25, 4, 9),
('Leffe Triple', 25, 4.50, 9)
;

/*Menu Items for all the wines*/
INSERT INTO [MenuItem]
VALUES
('Witte huiswijn fles', 25, 28.50, 10),
('Witte huiswijn glas', 25, 6.50, 10),
('Rode huiswijn fles', 25, 32, 10),
('Rode huiswijn glas', 25, 7.50, 10),
('Champagne fles', 25, 50, 10)
;

/*Menu Items for all the Spirits(gedistileerde dranken)*/
INSERT INTO [MenuItem]
VALUES
('Jonge Jenever', 25, 3.50, 11),
('Whiskey', 25, 5, 11),
('Rum', 25, 4.50, 11),
('Vieux', 25, 4.50, 11),
('Berenburg', 25, 3.50, 11)
;

INSERT INTO [MenuItem]
VALUES
('Koffie', 25, 2.50, 12),
('Cappuchino', 25, 3.50, 12),
('Espresso', 25, 3, 12),
('Thee', 25, 2.50, 12)