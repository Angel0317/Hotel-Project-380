CREATE TABLE [dbo].[GuestInfo_Table] (
    [ReservationId] INT          NOT NULL,
    [RoomNumber]          INT          NOT NULL,
    [DateOut]       CHAR(10)     NOT NULL,
    [DateIn]      CHAR(10)     NOT NULL,
    [firstName]     VARCHAR (50) NOT NULL,
    [lastName]      VARCHAR (50) NOT NULL,
    [EmailAddress] VARCHAR(50) NOT NULL, 
    [Address] VARCHAR(50) NOT NULL, 
    [Zip] VARCHAR(5) NOT NULL, 
    [State] VARCHAR(2) NOT NULL, 
    [Days] VARCHAR(4) NOT NULL, 
    [GuestNumber] VARCHAR(1) NOT NULL, 
    [CardNumber] VARCHAR(4) NOT NULL, 
    PRIMARY KEY CLUSTERED ([ReservationId] ASC)
);

