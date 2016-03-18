CREATE TABLE [dbo].[Party] (
    [PartyID]       INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (50)  NOT NULL,
    [Address]       NVARCHAR (300) NULL,
    [City]          NVARCHAR (50)  NOT NULL,
    [TIN]           NVARCHAR (20)  NOT NULL,
    [ContactNumber] NVARCHAR (10)  NULL,
    [Note]          NVARCHAR (300) NULL,
    PRIMARY KEY CLUSTERED ([PartyID] ASC)
);

