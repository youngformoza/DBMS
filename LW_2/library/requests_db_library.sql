SET search_path TO db_library;

-- определить количество книг по жанрам, отсортировать по убыванию
SELECT COUNT(*), genre.genre_name FROM genre_to_book
JOIN genre ON genre_to_book.genre_id = genre.genre_id
GROUP BY genre.genre_name 
ORDER BY COUNT(*) DESC;

-- топ 3 встречаемых издательства
SELECT publisher_name, COUNT(*) FROM edition
JOIN publisher ON edition.publisher_id = publisher.publisher_id
GROUP BY publisher.publisher_name
ORDER BY COUNT(*) DESC
LIMIT 3;

-- 5 авторов, чьи книги преобладают в библиотеке
SELECT author_fullname, COUNT(*) FROM author_to_book
JOIN author ON author_to_book.author_id = author.author_id
GROUP BY author.author_fullname
ORDER BY COUNT(*) DESC
LIMIT 5;

-- вывод всех книг упорядоченных по названию с количеством страниц (вспомогательный запрос)
SELECT book_name, edition.edition_length FROM book
JOIN edition ON book.book_id = edition.book_id
ORDER BY book.book_name ASC;
-- среднее количество страниц в книге по изданиям
SELECT book_name, AVG(edition.edition_length) FROM book
JOIN edition ON book.book_id = edition.book_id
GROUP BY book.book_name;