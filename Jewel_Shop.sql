create database Shop
use Shop
		--User data Table
create table Login(
username varchar(50) primary key, 
password varchar(50),

);
insert into Login values ('Admin', 'Admin')

select * from Login

create table lul(
price int,
quantity int,
)

alter table lul add total as (price * quantity) 
select * from lul
insert into lul values (30,20)

			--Employee Table
create table Employee(
emp_id int primary key,		--id is PK
emp_name varchar(30) not null,		--name of employee
emp_cnic int unique,				--cnic of employee
emp_gen varchar(15) not null,		--gender
emp_no int not null,					--contact number
emp_exp int not null,				--employee experience
emp_post varchar(20) not null,		--employee post in store

);

			--Customer Table
create table Customer(
c_id int primary key,		--customer id 
c_name varchar(30) not null,			--customer name
c_no int not null,					--customer number
c_adress varchar(50) not null,		--customer address
c_cnic int unique,					--customer cnic

);


		--Product Table
create table Product(
p_id varchar(30) primary key,			--product id
p_company varchar(30) not null,			--company of the product
p_catagory varchar(30) not null,			--product catagory
p_type varchar(30) not null,				--product type
p_price float not null,					--product price

);


		--Bill Table
create table Bill(
rec_no int unique,		--reciept number
c_id int foreign key references Customer(c_id) not null,			--customer name
p_id varchar(30) foreign key references Product(p_id),		--p_id as FK
u_price float not null,					--unit price of product
quantity int not null,				--quantity of product

);

alter table Bill add T_Price as (u_price * quantity)	--derived column

alter table Bill add datee varchar(30)

select * from Employee

select * from Customer

select * from Product

select * from Bill	


insert into Employee(emp_id,emp_name,emp_cnic) values(10, 'Ahmad',5656)




