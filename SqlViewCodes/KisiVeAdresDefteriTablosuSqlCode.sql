USE [BootstraptTablesWithApiDb]
GO

/****** Object:  View [dbo].[KisiVeAdresDefteriTablosu]    Script Date: 14.05.2022 21:34:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create view [dbo].[KisiVeAdresDefteriTablosu] 
as
select a.Id,a.Adres,a.Mail,a.Konum,a.KisiId,a.IsActive, 
k.Ad + ' ' + k.Soyad as [AdSoyad] from AdresDefterleri as a join Kisiler as k on k.Id=a.KisiId
GO


