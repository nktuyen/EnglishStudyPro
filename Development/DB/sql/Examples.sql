/* ---------------------------------------------------- */
/*  Generated by Enterprise Architect Version 13.5 		*/
/*  Created On : 18-May-2019 1:58:34 PM 				*/
/*  DBMS       : SQL Server 2008 						*/
/* ---------------------------------------------------- */

USE [EnglishStudyPro]
GO

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Examples]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Examples]
GO

/* Create Tables */

CREATE TABLE [Examples]
(
	[id] bigint NOT NULL IDENTITY (1, 1),
	[interpretation_id] bigint NOT NULL,
	[example] nvarchar(512) NOT NULL,
	[translation] nvarchar(512) NOT NULL
)
GO

/* Create Primary Keys, Indexes, Uniques, Checks */

ALTER TABLE [Examples] 
 ADD CONSTRAINT [PK_Examples]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

ALTER TABLE [Examples] 
 ADD CONSTRAINT [UQ_Examples_id] UNIQUE NONCLUSTERED ([id] ASC)
GO