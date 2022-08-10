CREATE TABLE [dbo].[Reservation_Table] (
    [ReservationId] INT          NOT NULL,
    [Room]          INT          NOT NULL,
    [Checkin]       DATETIME     NOT NULL,
    [Checkout]      DATETIME     NOT NULL,
	[FirstName]		VARCHAR (50) NOT NULL,
	[LastName]		VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([ReservationId] ASC)
);

