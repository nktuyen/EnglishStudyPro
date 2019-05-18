/* ---------------------------------------------------- */
/*  Generated by Enterprise Architect Version 13.5 		*/
/*  Created On : 18-May-2019 1:58:34 PM 				*/
/*  DBMS       : SQL Server 2008 						*/
/* ---------------------------------------------------- */

USE [EnglishStudyPro]
GO

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Classes]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Classes]
GO

/* Create Tables */

CREATE TABLE [Classes]
(
	[id] bigint NOT NULL IDENTITY (1, 1),
	[name] nvarchar(128) NOT NULL,
	[title] nvarchar(128) NOT NULL
)
GO

/* Create Primary Keys, Indexes, Uniques, Checks */

ALTER TABLE [Classes] 
 ADD CONSTRAINT [PK_Classes]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

ALTER TABLE [Classes] 
 ADD CONSTRAINT [UQ_Classes_id] UNIQUE NONCLUSTERED ([id] ASC)
GO

ALTER TABLE [Classes] 
 ADD CONSTRAINT [UQ_Classes_name] UNIQUE NONCLUSTERED ([name] ASC)
GO

ALTER TABLE [Classes] 
 ADD CONSTRAINT [UQ_Classes_title] UNIQUE NONCLUSTERED ([title] ASC)
GO