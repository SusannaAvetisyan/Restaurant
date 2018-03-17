create database Restaurant

create table Boss
(
	ID int not null primary key,
	[name] varchar(10) not null,
	surname varchar(15) not null,
	[login] varchar(25) not null unique,
	[password] varchar(25) not null,
); 

create table Cook
(
	ID int not null primary key,
	[name] varchar(10) not null,
	surname varchar(15) not null,
	salary int not null,
	[login] varchar(25) not null unique,
	[password] varchar(25) not null,
	isChef bit not null, 
    isRemoved bit not null
);

create table Waiter
(
	ID int not null primary key,
	[name] varchar(10) not null,
	surname varchar(15) not null,
	salary int not null,
    isRemoved bit not null
);

create table Dish
(
    --image 
	[name] varchar(15) not null primary key,
	price int not null,
	rating smallint null check(rating between 1 and 5),
    isRemoved bit not null,
	cook_ID int not null foreign key references Cook(ID)
);

create table [Table]
(
   	number int not null primary key,
   	waiter_ID int not null foreign key references Waiter(ID),
);

create table [Order]
(
	ID int not null identity(1, 1),
    table_number int not null,
	dish_name varchar(15) not null foreign key references Dish([name]),	
    state varchar(10) not null check(state in ('finished', 'in process')),
    rating smallint null check(rating between 1 and 5)
);




