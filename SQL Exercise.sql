create table Customers (
  Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  Name varchar(100)
);

insert into Customers (Name) 
values ('Max'), ('Pavel'), ('Ivan'), ('Leonid');

create table Orders (
  Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
  CustomerId int NOT NULL,
  CONSTRAINT FK_Customer FOREIGN KEY (CustomerId)
  REFERENCES Customers(Id)
);
insert into Orders (CustomerId)
values (2), (4);

select Name as 'Customers' from Customers
where Name NOT IN (
	select Customers.Name from Customers
	INNER JOIN Orders on Orders.CustomerId = Customers.Id
);