-- CREATE TABLE [dbo].[Menu]
-- (
-- 	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
-- 	[MenuName] VARCHAR(255) NOT NULL,
-- 	[MenuLevel] INT NOT NULL DEFAULT 0,
-- 	[MenuOrder] INT NOT NULL DEFAULT 0,
-- 	[MenuParentId] INT FOREIGN KEY REFERENCES Menu(Id),
-- 	[MenuLink] VARCHAR(1024) NULL,
-- 	[MenuActive] BIT DEFAULT 0
-- );
-- SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES
-- WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_CATALOG = 'sakila'
/*
INSERT INTO [sakila].[dbo].[Menu]
(MenuName,MenuLevel,MenuOrder,MenuParentId,MenuLink,MenuActive)
VALUES('Parent 1',0,1,NULL,NULL,1),
('Parent 2',0,2,NULL,NULL,1),
('Parent 3',0,3,NULL,NULL,1),
('Parent 4',0,4,NULL,NULL,1),
('P1Child 1',1,1,1,NULL,1),
('P1Child 2',1,2,1,NULL,1),
('P1Child 3',1,3,1,NULL,1),
('P1Child 4',1,4,1,NULL,1),
('P2Child 1',1,1,2,NULL,1),
('P2Child 2',1,2,2,NULL,1),
('P4Child 1',1,1,4,NULL,1),
('P2Child 2',1,2,4,NULL,1),
('C4Child 1',2,1,11,NULL,1),
('C4Child 2',2,2,11,NULL,1),
('C4Child2 1', 2,1,12,NULL,1);
*/
SELECT * FROM [Menu];
