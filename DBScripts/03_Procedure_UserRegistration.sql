Create procedure spUserRegistration
@Email  as varchar(50),
@Password as varchar(50),
@Firstname as varchar(50),
@Lastname as varchar(50),
@Gender as varchar(50),
@UserImage as varchar(50),
@ActivationCode as varchar(50)
as
Begin
Insert into tblUsers values 
(@Email,@Password,@Firstname,@Firstname,@Gender,1,@UserImage,1,@ActivationCode)
end