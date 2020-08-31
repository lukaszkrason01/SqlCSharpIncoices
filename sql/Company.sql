use Sample

create table Companies(
	ID int identity(1,1) Primary key,
	Name varchar(50),
	Street varchar(50),
	ZipCode varchar(10),
	City varchar(50),
	NIP varchar (12)
	)


SELECT ORDINAL_POSITION 
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'Companies'
ORDER BY ORDINAL_POSITION


CREATE PROCEDURE Companies_getAll
as
BEGIN
	SET NOCOUNT ON;
	SELECT * from Companies
	order by name
END

CREATE PROCEDURE Companies_getByID
@id int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * from Companies
	where ID= @id
END

CREATE PROCEDURE Companies_getByName
@cond varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * from Companies
	where Name like  CONCAT('%', @cond ,'%')
END

CREATE PROCEDURE Companies_getByStreet
@cond varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * from Companies
	where Street  like  CONCAT(@cond ,'%')
END

CREATE PROCEDURE Companies_getByZipCode
@cond varchar(10)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * from Companies
	where ZipCode like  CONCAT(@cond ,'%')
END

CREATE PROCEDURE Companies_getByCity
@cond varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * from Companies
	where City like  CONCAT(@cond ,'%')
END

CREATE PROCEDURE Companies_getByNip
@cond varchar(12)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * from Companies
	where NIP like  CONCAT(@cond ,'%')
END

CREATE PROCEDURE Companies_insert
	@ComName varchar(50),
	@ComStreet varchar(50),
	@ComZipCode varchar(10),
	@ComCity varchar(50),
	@ComNIP varchar (12)
AS
BEGIN
	SET NOCOUNT ON;
	insert into Companies
	values (@ComName, @ComStreet, @ComZipCode, @ComCity, @ComNIP)
END

Create procedure Companies_updateByID
	@id int,
	@ComName varchar(50),
	@ComStreet varchar(50),
	@ComZipCode varchar(10),
	@ComCity varchar(50),
	@ComNIP varchar (12)
as
begin
update Companies
set Name = @ComName, Street = @ComStreet, ZipCode= @ComZipcode ,City = @ComCity,NIP = @ComNIP
where ID = @id
end

















create procedure Invoices_getAll
as
begin
select * from Invoices
end















select * from Invoices









create table ProductsInInvoice




exec [dbo].[vatrate_getAll]
create procedure Invoices_getInvoiceNumber
as
begin
select COUNT(ID) from Invoices;
end

drop procedure Invoices_update
drop procedure Companies_getAll
drop procedure Companies_getByID
drop procedure Companies_getByName
drop procedure Companies_getByStreet
drop procedure Companies_getByCity
drop procedure Companies_getByZipCode
drop procedure Companies_getByNip
drop procedure Companies_updateByID
drop procedure Companies_insert

drop table invoiceItems
drop table Invoices
drop table paymentmethod
drop table Products
drop table Companies
drop table jm
drop table vatrate
drop table State