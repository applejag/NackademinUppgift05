
USE [ModelFirst.Zoophobia];
GO

IF OBJECT_ID(N'[dbo].[AnimalParentingTrigger]', 'TR') IS NOT NULL
    DROP TRIGGER [dbo].[AnimalParentingTrigger];
GO

CREATE TRIGGER AnimalParentingTrigger ON [dbo].[Animals]
FOR DELETE AS
	

	DELETE FROM [dbo].[AnimalParents]
		WHERE ChildId = ANY(SELECT Id FROM deleted)
		OR ParentId = ANY(SELECT Id FROM deleted);

GO
