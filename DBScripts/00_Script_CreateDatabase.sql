Create database RRScheduleManagement

Use RRScheduleManagement

ATEEQUE\SQLEXPRESS

Error	12	Metadata file 'C:\Users\Shaikh\documents\visual studio 2012\Projects\RSSDAL\bin\Debug\RSSDAL.dll' could not be found	C:\Users\Shaikh\documents\visual studio 2012\Projects\RRSBLL\CSC	RRSBLL


create procedure spUserLogin
@email nvarchar(100),
@password nvarchar(100)
As
Begin
Select * from tblUsers where Email=@email and Password=@password
end