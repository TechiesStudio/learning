CREATE PROCEDURE [dbo].[sp_validate_user]
	@userName nchar(10),
	@password nchar(10)
AS
	SELECT * from Users where userName=@userName and password=@password;