create database PM
use PM

create table Products (
	proID varchar(30) primary key,
	proName varchar(30),
	amount int,
	unitPrice int,
	updated date default null
)

create table Customers(
	cusID varchar(30) primary key,
	cusName varchar(30),
	cusNumber varChar(30),
	cusAdd varchar(30)
)

create table Users (
	username varchar(30),
	password varchar(30),
	cusID varchar(30) foreign key references Customers(cusID),
)

create table Orders (
	orderID varchar(30) primary key,
	cusID varchar(30) foreign key references Customers(cusID),
	orderStatus varchar(30),
	totalPrice int,
	created varchar(30),
	updated varchar(30)
)

create table OrderDetails (
	orderDetailID varchar(30) primary key,
	orderID varchar(30) foreign key references Orders(orderID),
	proID varchar(30),
	proName varchar(30),
	amount int,
	unitPrice int
)

create table Exports (
	exportID varchar(30) primary key,
	cusName varchar(30),
	cusNumber varchar(10),
	exportStatus varchar(30),
	paymentStatus varchar(30),
	paymentMethod varchar(30),
	totalPrice int,
	created varchar(30),
	updated varchar(30)
)

create table ExportDetails (
	exportDetailID int identity(1,1) primary key,
	exportID varchar(30) foreign key references Exports(exportID),
	proID varchar(30),
	proName varchar(30),
	amount int,
	unitPrice int
)

create table Receipts(
	receiptID varchar(30) primary key,
	created varchar(30),
	updated varchar(30)
)

create table ReceiptDetails(
	receiptDetailID int identity(1,1) primary key,
	receiptID varchar(30) foreign key references Receipts(receiptID),
	proID varchar(30),
	proName varchar(30),
	amount int,
	unitPrice int
)



insert into Users (username, password) values ('admin', '123')

insert into Products (proID, proName, amount, unitPrice) values ('SP', 'Deodorant Spray', 150, 450000)
insert into Products (proID, proName, amount, unitPrice) values ('SO', 'Deodorant Soap', 120, 380000)
insert into Products (proID, proName, amount, unitPrice) values ('SM', 'Deodorant Set mini', 40, 290000)
insert into Products (proID, proName, amount, unitPrice) values ('SL', 'Deodorant Set large', 50, 800000)

