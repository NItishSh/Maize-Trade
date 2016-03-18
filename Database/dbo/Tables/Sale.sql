CREATE TABLE [dbo].[Sale] (
    [SaleID]      INT             IDENTITY (1, 1) NOT NULL,
    [Date]        DATETIME        NULL,
    [PartyID]     INT             NOT NULL,
    [MaizeWeight] NUMERIC (18, 2) NULL,
    [MaizeRate]   NUMERIC (18, 2) NULL,
    [TotalAmount] NUMERIC (18, 2) NULL,
    [Note]        NVARCHAR (300)  NULL,
    PRIMARY KEY CLUSTERED ([SaleID] ASC),
    CONSTRAINT [FK_Sale_ToParty] FOREIGN KEY ([PartyID]) REFERENCES [dbo].[Party] ([PartyID])
);

