/* ---------------------------------------------------- */
/*  Generated by Enterprise Architect Version 13.5 		*/
/*  Created On : 18-May-2019 10:40:22 AM 				*/
/*  DBMS       : SQL Server 2008 						*/
/* ---------------------------------------------------- */

USE [EnglishStudyPro]
GO

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Media]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Media]
GO

/* Create Tables */

CREATE TABLE [Media]
(
	[id] smallint NOT NULL IDENTITY (1, 1),
	[name] nvarchar(128) NOT NULL,
	[title] nvarchar(128) NOT NULL
)
GO

/* Create Primary Keys, Indexes, Uniques, Checks */

ALTER TABLE [Media] 
 ADD CONSTRAINT [PK_Media]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

ALTER TABLE [Media] 
 ADD CONSTRAINT [UQ_Media_id] UNIQUE NONCLUSTERED ([id] ASC)
GO

ALTER TABLE [Media] 
 ADD CONSTRAINT [UQ_Media_name] UNIQUE NONCLUSTERED ([name] ASC)
GO

ALTER TABLE [Media] 
 ADD CONSTRAINT [UQ_Media_title] UNIQUE NONCLUSTERED ([title] ASC)
GO