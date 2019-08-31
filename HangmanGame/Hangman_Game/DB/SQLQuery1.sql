CREATE PROC NewUser
@Username nvarchar(50),
@Password nvarchar(50),		
@Email	nvarchar(50)
AS
	INSERT INTO TblLogin(Username,Password,Email)
	VALUES (@Username, @Password, @Email)
	
