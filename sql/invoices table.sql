create table Invoices(
	ID int identity(1,1) primary key,
	Name varchar(50),
	CompanyID int foreign key references Companies(ID),	
	Date date,
	Term date,
	PaymentMethodID int foreign key references paymentmethod(ID),
	TotalNetAmount money,
	TotalTaxAmount money,
	TotalBrtAmount money,
	State int foreign key references States(ID)
)

insert into Invoices
values('FV/1/2020',1,'2020-01-01','2020-01-01',1,1000,230,1230)
SELECT CAST(SCOPE_IDENTITY() as int)

delete from  Companies
where ComID = 1

drop table InvoiceItems
create table InvoiceItems(
	InvoiceID int foreign key references Invoices(ID),
	ProductID int Foreign key references Products(ID),
	Quantity decimal,
	NetPrice money,
	NetAmount money,
	VatRate int,
	VatAmount money,
	BrtAmount money
)

create procedure Invoices_insert
	@name varchar(50),
	@companyID int,
	@date date,
	@term date,
	@paymentMethodID int,
	@totalNetAmount money,
	@totalTaxAmount money,
	@totalBrtAmount money,
	@state int
as
begin
insert into Invoices
Values(@name , @companyID,@date,@term,@paymentMethodID
	,@totalNetAmount,@totalTaxAmount,@totalBrtAmount,  @state)
SELECT CAST(SCOPE_IDENTITY() as int)
end

create procedure Invoices_update
	@id  int,
	@name varchar(50),
	@companyID int,
	@date date,
	@term date,
	@paymentMethodID int,
	@totalNetAmount money,
	@totalTaxAmount money,
	@totalBrtAmount money,
	@state int
as
begin
Update Invoices 
set name = @name , CompanyID = @companyID , Date = @date, Term = @term 
, PaymentMethodID = @paymentMethodID , TotalNetAmount = @totalNetAmount 
, TotalTaxAmount = @totalTaxAmount , TotalBrtAmount = @totalBrtAmount , State = @state 
where id = @id;
end


create procedure InvoiceItems_Insert
	@invoiceID int ,
	@productID int,
	@quantity decimal,
	@netPrice money,
	@netAmount money,
	@vatRate int,
	@vatAmount money,
	@brtAmount money
as
begin
	insert into InvoiceItems
	values(@invoiceID,@productID,@quantity,@netPrice,@netAmount,@vatRate,@vatAmount,@brtAmount)
end

create procedure InvoiceItems_GetByCompanyID
@id int
AS
BEGIN
	SELECT * FROM InvoiceItems
	WHERE InvoiceID = @ID
END

create procedure InvoiceItems_deleteByInvoiceID
@id int
as
begin
delete from InvoiceItems 
where InvoiceID = @id
end

drop table InvoiceItems
drop table Invoices


select * from InvoiceItems
select * from Invoices


drop procedure Invoices_insert
drop procedure Invoices_update