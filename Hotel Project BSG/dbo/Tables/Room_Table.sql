CREATE TABLE [dbo].[Room_Table] (
    [RoomType]      VARCHAR (50) NOT NULL,
    [RoomNumber]    INT          NOT NULL,
    [RoomAvailable] VARCHAR(50)         NOT NULL,
    [RoomReserved]  VARCHAR(50)         NOT NULL,
    [GuestMax] VARCHAR(5) NOT NULL, 
    PRIMARY KEY CLUSTERED ([RoomType] ASC)
);

