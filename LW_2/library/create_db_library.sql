-- SCHEMA: db_library

-- DROP SCHEMA IF EXISTS db_library ;

CREATE SCHEMA IF NOT EXISTS db_library
    AUTHORIZATION postgres;

SET search_path TO db_library;

CREATE TABLE publisher (
	publisher_id serial PRIMARY KEY,
	publisher_name VARCHAR(100) NOT NULL
);

CREATE TABLE status (
	status_id serial PRIMARY KEY,
	status_name VARCHAR(50) NOT NULL
);
	
CREATE TABLE "section" (
	section_id serial PRIMARY KEY,
	section_name VARCHAR(50) NOT NULL
);

CREATE TABLE author (
	author_id serial PRIMARY KEY,
	author_fullname VARCHAR(100) NOT NULL,
	author_country VARCHAR(100) NOT NULL
);

/* */

CREATE TABLE genre (
	genre_id serial PRIMARY KEY,
	genre_name VARCHAR(20) NOT NULL
);

CREATE TABLE book (
	book_id serial PRIMARY KEY,
	book_name VARCHAR(1000) NOT NULL,
	book_count INT,
	book_description VARCHAR(1000),
	book_age_restriction INT,
	bookmark_id INT,
	rating_id INT,
	status_id INT NOT NULL,
	FOREIGN KEY (status_id)
		REFERENCES status (status_id),
	section_id INT NOT NULL,
	FOREIGN KEY (section_id)
		REFERENCES "section" (section_id)
);

CREATE TABLE author_to_book (
	author_id INT NOT NULL,
	FOREIGN KEY (author_id)
		REFERENCES author (author_id),
	book_id INT NOT NULL,
	FOREIGN KEY (book_id)
		REFERENCES book (book_id),
	PRIMARY KEY (author_id, book_id)
);

CREATE TABLE genre_to_book (
	genre_id INT NOT NULL,
	FOREIGN KEY (genre_id)
		REFERENCES genre (genre_id),
	book_id INT NOT NULL,
	FOREIGN KEY (book_id)
		REFERENCES book (book_id),
	PRIMARY KEY (genre_id, book_id)
);

CREATE TABLE edition (
	edition_id serial PRIMARY KEY,
	edition_ISBN VARCHAR(13) NOT NULL,
	edition_number INT NOT NULL, 
	edition_publication DATE,
	edition_length INT,
	edition_type VARCHAR(4),
	publisher_id INT NOT NULL,
	FOREIGN KEY (publisher_id)
		REFERENCES publisher (publisher_id),
	book_id INT NOT NULL,
	FOREIGN KEY (book_id)
		REFERENCES book (book_id)
);