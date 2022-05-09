USE [db_user_new]
GO


INSERT INTO [dbo].[Role]
           ([role_name])
     VALUES
           ('User'),
		   ('Admin');
GO

INSERT INTO [dbo].[Users]
           ([user_nickname]
           ,[user_login]
           ,[user_password]
           ,[role_id])
     VALUES
           ('Shoplist', 'Lloyd_Andie','608-77-0782',1),
		   ('Prayons', 'Richards_Chester','450-03-5525',1),
		   ('Aor', 'Ellison_Roger','865-62-3703',1),
		   ('Avatar_Mobile', 'Leslie_Diane','001-72-5164',1),
		   ('Crayze', 'Drummond_Denny','841-06-7810',1),
		   ('Lopping', 'Gibson_Judith','734-33-2575',1),
		   ('Run24', 'Bryson_Ronald','183-04-7824',2),
		   ('SolSol', 'Donnelly_Anthony','078-71-4887',1),
		   ('Kulop', 'Simpson_Rose','545-27-7572',1),
		   ('MyGameNight', 'Rixon_Alexander','765-22-4262',1);
GO

INSERT INTO [dbo].[Bookmarks]
           ([bookmark_name of the compilation]]]]]]]
           ,[user_id])
     VALUES
       ('My top books', 3),
	 ('Recomendations for scientists', 2),
	 ('Books for busy people', 6),
	 ('Classic literature', 6),
	 ('My top 10 books', 10),
	 ('Modern authors', 2),
	 ('Relax', 5),
	 ('My favorites <3', 7),
	 ('Writers of century', 9),
	 ('Encyclopedias', 5);
GO

INSERT INTO [dbo].[Books_to_bookmarks]
           ([bookmark_id]
           ,[book_id]
		   ,[Id])
     VALUES
           (8,3,1),
		   (9,5,2),
		   (1,4,3),
		   (8,2,4),
		   (4,3,5),
		   (7,7,6),
		   (9,1,7),
		   (7,3,8),
		   (8,9,9),
		   (8,10,10);
GO


INSERT INTO [dbo].[Rating]
           ([rating_reaction]
           ,[user_id]
           ,[bookmark_id])
     VALUES
           ('Лайк',2,7),
		   ('Лайк',4,1),
		   ('Лайк',2,2),
		   ('Лайк',6,4),
		   ('Дизайк',2,6),
		   ('Лайк',8,7),
		   ('Дизайк',2,8),
		   ('Лайк',6,7),
		   ('Дизлайк',8,1),
		   ('Лайк',10,1);
GO

INSERT INTO [dbo].[Reviews]
           ([review_rating]
           ,[review_text]
           ,[review_media]
           ,[book_id]
           ,[user_id])
     VALUES
           (5,'TI1w5KsGE6Rqg8poLjQjR8N6YFSjNQmLqtqiOPkKMM3zmSx1LP', '', 2,5),
		   (4,'V55X01J2yUFAwRGa59GXEFXTGRbX7amMwHVnT2tSDTEfgRAkFz', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSUBVTmWmQDY05iDPuCQSTZDN7EN6Xr_P5jLg&usqp=CAU', 2,6),
		   (5,'PilQjZv5Xr3Op5dGDQxUuA1xyQ1SHgmTPjGFrlK3RYqynDVoms', '', 2,8),
		   (3,'OqybSidy1Fk8GzXZcF4CVTDKu5MqYq1NDv1Y3J2UyjzsCFOyOT', '', 4,5),
		   (5,'4norXVxZKNW5V88fSNjOweUHpqXbESMC3T6vOce8BKpfqK30Px', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQF4jN6kIAxYjwJYFdZfE3QPHnINMXm5EjExQ&usqp=CAU', 10,9),
		   (2,'This book is interesting', '', 6,8),
		   (1,'D10cGKB28JdKqHrOKToM8ekTlOXSCfK0rpXOhNjC9dmCQLFI8V', '', 3,2),
		   (5,'qtcatiZIsmzGG4fpjDW72teZsD0yC7SVQpHNi68qzeZbyl7d99', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQtXm1jUXzx59YvPGJjt9fMt-2HSp-08qbHhw&usqp=CAU', 2,3),
		   (4,'qtcatiZIsmzGG4fpjDW72teZsD0yC7SVQpHNi68qzeZbyl7d99', '', 5,3),
		   (5,'7PDsprlFvUdzaxSHnFpHYTCkGFWzDtRQGTK7eNS9OYoHVvhqr1', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS1ePwxMvkYJ0VTATDD2OjdR3vP0FOsbeyvIQ&usqp=CAU', 3,2);
GO

INSERT INTO [dbo].[Subscriptions]
           ([user_id]
           ,[creator_id]
		   ,[Id])
     VALUES
           (2,2,1),
		   (6,8,2),
		   (5,3,3),
		   (7,4,4),
		   (3,6,5),
		   (5,7,6),
		   (8,9,7),
		   (4,7,8),
		   (5,9,9),
		   (9,6,10);
GO