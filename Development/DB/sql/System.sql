/* ---------------------------------------------------- */
/*  Generated by Enterprise Architect Version 13.5 		*/
/*  Created On : 18-May-2019 1:58:34 PM 				*/
/*  DBMS       : SQL Server 2008 						*/
/* ---------------------------------------------------- */

USE [EnglishStudyPro]
GO

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[System]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [System]
GO

/* Create Tables */

CREATE TABLE [System]
(
	[name] nvarchar(128) NOT NULL,
	[version] bigint NOT NULL,
	[desc] nvarchar(128) NULL,
	[pin] varchar(128) NOT NULL,    -- Pass-code
	[date] int NOT NULL
)
GO

/* Create Primary Keys, Indexes, Uniques, Checks */

ALTER TABLE [System] 
 ADD CONSTRAINT [UQ_System_name] UNIQUE NONCLUSTERED ([name] ASC)
GO

ALTER TABLE [System] 
 ADD CONSTRAINT [UQ_System_version] UNIQUE NONCLUSTERED ([version] ASC)
GO

/* Create Table Comments */

EXEC sp_addextendedproperty 'MS_Description', 'System information','Schema', [dbo], 'table', [System]
GO

EXEC sp_addextendedproperty 'MS_Description', 'Pass-code', 'Schema', [dbo], 'table', [System], 'column', [pin]
GO