CREATE TABLE [dbo].[Guest_Table] (
    [firstName]   VARCHAR (50) NOT NULL,
    [lastName]    VARCHAR (50) NOT NULL,
    [phoneNumber] FLOAT (53)   NOT NULL,
    [Address]     VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Guest_Table] PRIMARY KEY CLUSTERED ([firstName] ASC)
);

