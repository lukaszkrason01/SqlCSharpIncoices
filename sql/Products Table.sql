alter table Products alter column PRICE money 
Create table Products(
	ID int identity(1,1) primary key,
	Name varchar(20),
	JM int foreign key references jm(ID),
	VAT int foreign key references vatrate(ID),
	PRICE money
)

insert into Products
values ('Product name' ,1,1,100)
insert into Products
values ('Product nam' ,2,1,200)


select * from jm
select * from vatrate
select * from Products

create procedure Products_getByIDInner
	@id int
	as
begin
	if @id = 0
	begin
		select Products.ID, Products.Name,vatrate.Rate as 'Vat',jm.Name as 'JM' , Products.PRICE 
		from Products
		inner join vatrate
		on VAT = vatrate.ID
		inner join jm
		on JM = jm.ID
	end
	else
	begin
		select Products.ID, Products.Name,vatrate.Rate as 'Vat',jm.Name as 'JM' , Products.PRICE 
		from Products
		inner join vatrate
		on VAT = vatrate.ID
		inner join jm
		on JM = jm.ID
		where Products.ID = @id
	end
end

create procedure Products_getAll
as
begin
select * from Products
end

create procedure Products_getByID
	@id int
as
begin
select * from Products
where ID = @id
end

create procedure Products_getByName
	@condition as varchar(50)
as
begin
select * from Products
where name Like CONCAT('%',@condition,'%')
end

create procedure Products_getByPrice
	@condition as int
as
begin
select * from Products
where PRICE > 1000
end

create procedure Products_updateByID
	@id int,
	@name varchar(50),
	@jm int,
	@vat int,
	@price int
as
begin
update Products
set Name = @name , JM = @jm , VAT = @vat , PRICE = @price
where ID = @id
end 

create procedure Products_insert
	@name varchar(50),
	@jm int,
	@vat int,
	@price int
as
begin
insert into Products
values (@name,@jm,@vat,@price)
end