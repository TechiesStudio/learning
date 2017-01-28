/*
Post-Deployment Script Template
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.
 Use SQLCMD syntax to include a file in the post-deployment script.
 Example:      :r .\myfile.sql
 Use SQLCMD syntax to reference a variable in the post-deployment script.
 Example:      :setvar TableName MyTable
               SELECT * FROM [$(TableName)]
--------------------------------------------------------------------------------------
*/

/*

Inserting Data in to Users Tables for testing purpose

*/

SET IDENTITY_INSERT [dbo].[Users] ON
INSERT INTO [dbo].[Users] ([userID], [userName], [password]) VALUES (1, N'user1     ', N'password1 ')
INSERT INTO [dbo].[Users] ([userID], [userName], [password]) VALUES (2, N'user2     ', N'password2 ')
INSERT INTO [dbo].[Users] ([userID], [userName], [password]) VALUES (3, N'user3     ', N'password3 ')
SET IDENTITY_INSERT [dbo].[Users] OFF
