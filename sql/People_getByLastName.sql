USE [Sample]

Go 

Set ansi_nulls on
go
set quoted_identifier on 
go

alter procedure [dbo].[People_getByLastName]
	@LastName nvarchar(50)
as
begin
	set nocount on;

	select * from dbo.People
	where LastName = @LastName;

end