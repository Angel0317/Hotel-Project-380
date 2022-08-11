CREATE TABLE [dbo].[Room_Table] (
    [RoomType]      VARCHAR (50) NOT NULL,
    [RoomNumber]    INT          NOT NULL,
    [RoomAvailable] DATE         NOT NULL,
    [RoomReserved]  DATE         NOT NULL,
    PRIMARY KEY CLUSTERED ([RoomType] ASC)
);

