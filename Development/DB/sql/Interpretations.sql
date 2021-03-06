/* ---------------------------------------------------- */
/*  Generated by Enterprise Architect Version 13.5 		*/
/*  Created On : 18-May-2019 1:58:34 PM 				*/
/*  DBMS       : SQL Server 2008 						*/
/* ---------------------------------------------------- */

USE [EnglishStudyPro]
GO

/* Drop Tables */

IF EXISTS (SELECT 1 FROM dbo.sysobjects WHERE id = object_id(N'[Interpretations]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1) 
DROP TABLE [Interpretations]
GO

/* Create Tables */

CREATE TABLE [Interpretations]
(
	[id] bigint NOT NULL IDENTITY (1, 1),
	[class] bigint NOT NULL,
	[vocabulary] nvarchar(128) NOT NULL,
	[interpretation] nvarchar(128) NOT NULL
)
GO

/* Create Primary Keys, Indexes, Uniques, Checks */

ALTER TABLE [Interpretations] 
 ADD CONSTRAINT [PK_Interpretations]
	PRIMARY KEY CLUSTERED ([id] ASC)
GO

ALTER TABLE [Interpretations] 
 ADD CONSTRAINT [UQ_Interpretations_id] UNIQUE NONCLUSTERED ([id] ASC)
GO