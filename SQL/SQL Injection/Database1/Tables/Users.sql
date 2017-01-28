
CREATE TABLE [dbo].[Users] (
    [userID]   INT        IDENTITY (1, 1) NOT NULL,
    [userName] NCHAR (10) NOT NULL,
    [password] NCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([userID] ASC)
);
