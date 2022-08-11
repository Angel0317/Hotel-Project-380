CREATE TABLE [dbo].[Login_Table] (
    [Username]      VARCHAR (50) NOT NULL,
    [AdminUsername] VARCHAR (50) NOT NULL,
    [UserPassword]  VARCHAR (50) NOT NULL,
    [AdminPassword] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Username] ASC)
);

