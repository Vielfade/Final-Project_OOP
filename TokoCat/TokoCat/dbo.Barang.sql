USE [DBPenjualanCAT]
GO

/****** Object: Table [dbo].[Barang] Script Date: 24/07/2018 17:08:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Barang] (
    [Kode]   VARCHAR (6)  NOT NULL,
    [Nama]   VARCHAR (50) NOT NULL,
    [Warna]  VARCHAR (50) NOT NULL,
    [Satuan] VARCHAR (50) NOT NULL
);


