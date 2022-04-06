--Средний рейтинг определенной книги
SELECT AVG(review_rating) FROM Reviews
WHERE book_id = 2;

--5 самых активных пользователей по отзывам книг
SELECT TOP 5 user_nickname, COUNT(*) FROM Reviews
JOIN Users ON Reviews.user_id = Users.user_id
GROUP BY user_nickname
ORDER BY COUNT(*) DESC;

--Топ 5 популярных подборок книг среди всех пользователей по количеству реакций
SELECT TOP 5 user_nickname, COUNT(*) FROM Rating
JOIN Users ON Rating.user_id = Users.user_id
GROUP BY user_nickname
ORDER BY COUNT(*) DESC;

--Топ 5 популярных криэйторов по количеству подписок на них
SELECT TOP 5 user_nickname, COUNT(*) FROM Subscriptions
JOIN Users ON Subscriptions.creator_id = Users.user_id
GROUP BY user_nickname
ORDER BY COUNT(*) DESC;

--Добавить нового подписчика к криэйтору
INSERT INTO Subscriptions(user_id, creator_id)
VALUES (8,3);

--Обновить текст отзыва
UPDATE Reviews
SET review_text = 'This book is interesting'
WHERE review_id = 6;
