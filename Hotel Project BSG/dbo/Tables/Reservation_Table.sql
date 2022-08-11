CREATE TABLE [dbo].[Reservation_Table] (
    [ReservationId] INT          NOT NULL,
    [Room]          INT          NOT NULL,
    [Checkin]       DATETIME     NOT NULL,
    [Checkout]      DATETIME     NOT NULL,
    [firstName]     VARCHAR (50) NOT NULL,
    [lastName]      VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([ReservationId] ASC)
);

