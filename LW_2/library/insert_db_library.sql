-- SCHEMA: db_library

-- DROP SCHEMA IF EXISTS db_library ;
CREATE SCHEMA IF NOT EXISTS db_library
    AUTHORIZATION postgres;
	
SET search_path TO db_library;

INSERT INTO publisher (publisher_name)
VALUES
	('Sterling Publishing'),
	('AST'),
	('Chronicle books'),
	('Alloy entertainment'),
	('Baen'),
	('Argo'),
	('Skyhorse Publishing'),
	('Free Spirit Publishing House'),
	('Five Stars'),
	('Adams Media'),
	('Kensington Publishing Corporation'),
	('Press beacon'),
	('Black Inc.'),
	('Books of Perseus'),
	('Rosman'),
	('Press of seven stories'),
	('Eksmo'),
	('ABC'),
	('Black and white publication');

INSERT INTO status (status_name) 
VALUES
	('not available'), 
	('a few'), 
	('average'), 
	('many');
	
INSERT INTO "section" (section_name) 
VALUES
	('rare and valuable editions'),
	('industrial literature'),
	('art'),
	('literature in foreign languages'),
	('external communication and project activities'),
	('local history'),
	('science and technology'),
	('religion'),
	('psychology'),
	('education'),
	('hobby'),
	('poetry');
	
INSERT INTO author (author_fullname, author_country) 
VALUES
	('Stephen King', 'USA'), 
	('Joanne Rowling', 'Great Britain'), 
	('Ray Bradbury', 'USA'), 
	('Arthur Conan Doyle', 'Great Britain'), 
	('Dan Brown', 'USA'), 
	('John Ronald Reuel Tolkien', 'Great Britain'), 
	('Agatha Christie', 'Great Britain'), 
	('Charles Dickens', 'Great Britain'), 
	('Lewis Carroll', 'Great Britain'), 
	('Mikhail Bulgakov', 'USSR');
	
INSERT INTO genre (genre_name) 
VALUES
	('fantasy'),
	('horror'),
	('novel'),
	('dystopia'),
	('documentary'),
	('comedy'),
	('thriller'),
	('drama'),
	('romance'),
	('sci-fi'),
	('action'),
	('crime');
	
INSERT INTO book (book_name, book_count, book_description, book_age_restriction, bookmark_id, rating_id, status_id, section_id)
VALUES
	('urna. Nunc quis arcu vel',603,'vel, faucibus id, libero. Donec consectetuer mauris id sapien. Cras dolor dolor, tempus non, lacinia at, iaculis quis, pede. Praesent eu dui. Cum sociis natoque penatibus et magnis',3,5,4,1,2),
 	('magnis dis parturient montes, nascetur',55,'nec luctus felis purus ac tellus. Suspendisse sed dolor. Fusce mi lorem, vehicula et, rutrum eu, ultrices sit amet, risus. Donec nibh enim, gravida sit amet, dapibus id, blandit at, nisi. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Proin vel nisl. Quisque fringilla euismod enim. Etiam gravida molestie arcu. Sed eu nibh vulputate mauris sagittis placerat. Cras dictum ultricies ligula. Nullam enim. Sed nulla ante, iaculis nec',9,10,5,2,7),
 	('Aenean',195,'in faucibus orci luctus et ultrices posuere cubilia Curae Donec tincidunt. Donec vitae erat vel pede blandit congue. In scelerisque scelerisque dui. Suspendisse ac metus vitae velit egestas lacinia. Sed congue, elit sed consequat auctor, nunc nulla vulputate dui, nec tempus mauris erat eget ipsum. Suspendisse sagittis. Nullam vitae',4,4,2,1,4),
 	('nisl. Maecenas malesuada fringilla est. Mauris eu turpis.',924,'nisi. Mauris nulla. Integer urna. Vivamus molestie dapibus ligula. Aliquam erat volutpat. Nulla dignissim. Maecenas ornare egestas ligula. Nullam feugiat placerat velit. Quisque varius. Nam porttitor scelerisque neque. Nullam nisl. Maecenas malesuada fringilla est. Mauris eu turpis. Nulla aliquet. Proin velit. Sed malesuada augue ut lacus. Nulla tincidunt, neque vitae semper egestas, urna justo faucibus',18,6,3,3,4),
 	('pharetra, felis eget varius ultrices, mauris ipsum',232,'non dui nec urna suscipit nonummy. Fusce fermentum fermentum arcu. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae Phasellus ornare. Fusce mollis. Duis sit amet diam eu dolor egestas rhoncus. Proin nisl sem, consequat nec, mollis vitae, posuere at, velit. Cras lorem lorem, luctus ut, pellentesque eget, dictum placerat, augue. Sed molestie. Sed id',12,6,2,4,6),
	('amet ante. Vivamus non lorem',942,'fringilla ornare placerat, orci lacus vestibulum lorem, sit amet ultricies sem magna nec quam. Curabitur vel lectus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec dignissim magna a tortor. Nunc commodo auctor velit. Aliquam nisl. Nulla eu neque pellentesque',16,2,1,3,7),
 	('placerat, orci lacus vestibulum lorem, sit amet ultricies sem',943,'consequat dolor vitae dolor. Donec fringilla. Donec feugiat metus sit amet ante. Vivamus non lorem vitae odio sagittis semper. Nam tempor diam dictum sapien. Aenean massa. Integer vitae nibh. Donec est mauris, rhoncus id, mollis nec, cursus a, enim. Suspendisse aliquet, sem ut cursus luctus, ipsum leo elementum sem, vitae aliquam eros turpis non enim. Mauris quis turpis',8,7,3,2,9),
 	('lobortis augue scelerisque mollis. Phasellus libero mauris, aliquam',952,'Duis dignissim tempor arcu. Vestibulum ut eros non enim commodo hendrerit. Donec porttitor tellus non magna. Nam ligula elit, pretium et, rutrum non, hendrerit id',2,2,5,3,10),
 	('natoque penatibus et magnis dis parturient montes',374,'quis, tristique ac, eleifend vitae, erat. Vivamus nisi. Mauris nulla. Integer urna. Vivamus molestie dapibus ligula. Aliquam erat volutpat. Nulla dignissim. Maecenas ornare egestas ligula. Nullam feugiat placerat velit. Quisque varius. Nam porttitor scelerisque neque. Nullam nisl. Maecenas malesuada fringilla est. Mauris eu turpis. Nulla aliquet. Proin velit. Sed malesuada',1,10,7,1,5),
 	('ante bibendum ullamcorper. Duis cursus, diam at pretium aliquet',566,'nibh dolor, nonummy ac, feugiat non, lobortis quis, pede. Suspendisse dui. Fusce diam nunc, ullamcorper eu, euismod ac, fermentum vel, mauris. Integer sem elit, pharetra ut',19,9,5,2,5);
	
INSERT INTO author_to_book (author_id, book_id)
VALUES
	(4,8),
	(2,5),
	(1,10),
	(9,2),
	(4,7),
	(3,1),
	(8,3),
	(4,9),
	(2,6),
	(1,4);

INSERT INTO genre_to_book (genre_id, book_id)
VALUES
	(7,8),
	(7,5),
	(5,10),
	(3,2),
	(5,7),
	(5,1),
	(9,3),
	(1,9),
	(1,6),
	(6,4);
	
INSERT INTO edition (edition_ISBN, edition_number, edition_publication,	edition_length, edition_type, publisher_id,	book_id)
VALUES
	('1739307169986',20,'20190203',1129,'hard',7,2),
 	('1239466457821',14,'19360220',1206,'soft',3,6),
	('1156726160500',11,'19980428',164,'hard',5,8),
	('1954476023389',4,'19850411',1223,'hard',2,6),
	('1617126298647',16,'19780814',182,'soft',1,2),
	('1666395268537',19,'20041226',524,'soft',9,5),
	('1991094619049',11,'19530715',224,'hard',8,3),
	('1369863260432',16,'19770321',1348,'soft',4,9),
	('1692701234492',30,'19921025',453,'hard',9,9),
	('1478334464312',24,'20060526',785,'soft',5,4);