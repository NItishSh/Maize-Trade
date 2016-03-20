CREATE TABLE [dbo].[Purchase] (
    [PurchaseID]        INT             IDENTITY (1, 1) NOT NULL,
    [Date]              DATETIME        NULL,
    [FarmerID]          INT             NOT NULL,
    [MaizeWeight]       NUMERIC (18, 2) NULL,
    [MaizeRate]         NUMERIC (18, 2) NULL,
    [DeductionInWeight] NUMERIC (18, 2) NULL,
    [TotalAmount]       NUMERIC (18, 2) NULL,
    [Note]              VARCHAR(300) NULL,
    PRIMARY KEY CLUSTERED ([PurchaseID] ASC),
    CONSTRAINT [FK_Purchase_ToFarmer] FOREIGN KEY ([FarmerID]) REFERENCES [dbo].[Farmer] ([FarmerID])
);

