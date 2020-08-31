use Sample

create table States(
ID int identity(1,1) primary key,
Name varchar(20)
)

exec sp_rename  'States.Polname', 'Name','column'
alter table States add PolName varchar(20)
alter table States Drop column Name
alter table States rename	 column  
update States
set name = 'Active', PolName='Aktywne' where id =1

insert into States
values ('Aktywne')

insert into States
values ('Usuniête')

delete States
where id =3

Create table jm(
	ID int identity(1,1) primary key,
	Name varchar(10)
)

alter table jm add Precision int

update jm 
set name = 'szt' ,precision = 0
where id = 1

insert into jm
values ('szt')

insert into jm
values ('kg')

Create table vatrate(
	ID int identity (1,1) primary key,
	Rate int
	)

insert into vatrate
values(23)
insert into vatrate
values(8)
insert into vatrate
values(5)


create procedure vatrate_Execute
@id int,
@rate int
as
begin
	if @id = 0
	begin
		insert into vatrate
		values (@rate)
	end
	else
	begin
		update vatrate
		set Rate = @rate
		where ID = @id
	end
end

create procedure vatrate_Delete
@id int
as
begin
delete vatrate
where ID = @id
end

create table paymentmethod(
	ID int identity(1,1) primary key,
	Name varchar(50)
)
insert into paymentmethod
values ('Gotówka')
insert into paymentmethod
values ('Przelew')
insert into paymentmethod
values ('Karta')
insert into paymentmethod
values ('BLIK')


CREATE PROCEDURE vatrate_getByID
@id int
as
BEGIN
	SET NOCOUNT ON;
	SELECT * from vatrate
	where id = @id
END

CREATE PROCEDURE jm_getByID
@id int
as
BEGIN
	SET NOCOUNT ON;
	SELECT * from jm
	where id = @id
END

create procedure jm_getAll
as
begin
select * from jm
end

create procedure jm_getByID
@id int
as
begin
select * from jm
where ID = @id
end

create procedure vatrate_getAll
as
begin
select * from vatrate
end

create procedure PaymentMethod_getAll
as
begin
select * from PaymentMethod
end

create procedure State_getAll
as
begin
select * from States
end

