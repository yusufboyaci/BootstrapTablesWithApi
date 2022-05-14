USE [BootstraptTablesWithApiDb]
GO

/****** Object:  View [dbo].[Insanlar]    Script Date: 14.05.2022 21:35:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[Insanlar] as
SELECT a.KisiId,k.Ad + ' ' + k.Soyad as [AdSoyad] FROM Kisiler as k join AdresDefterleri as a on k.Id=a.KisiId
GO


