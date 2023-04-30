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
	IsHandled BIT
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


CREATE TABLE [Category](
	CategoryId int identity(1,1) NOT NULL primary key,
	VAT float,
	MenuCard varchar(25)
);

CREATE TABLE [MenuItem](
	MenuItemId int identity(1,1) NOT NULL primary key,
	Name varchar(25),
	Stock int,
	Price float,
	CategoryId int foreign key references Category(CategoryId)
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