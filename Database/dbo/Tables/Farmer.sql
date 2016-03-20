CREATE TABLE [dbo].[Farmer] (
    [FarmerID]      INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (100) NULL,
    [Village]       NVARCHAR (50)  NULL,
    [ContactNumber] NVARCHAR (13)  NULL,
    PRIMARY KEY CLUSTERED ([FarmerID] ASC)
);

