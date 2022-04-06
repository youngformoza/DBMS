--������� ������� ������������ �����
SELECT AVG(review_rating) FROM Reviews
WHERE book_id = 2;

--5 ����� �������� ������������� �� ������� ����
SELECT TOP 5 user_nickname, COUNT(*) FROM Reviews
JOIN Users ON Reviews.user_id = Users.user_id
GROUP BY user_nickname
ORDER BY COUNT(*) DESC;

--��� 5 ���������� �������� ���� ����� ���� ������������� �� ���������� �������
SELECT TOP 5 user_nickname, COUNT(*) FROM Rating
JOIN Users ON Rating.user_id = Users.user_id
GROUP BY user_nickname
ORDER BY COUNT(*) DESC;

--��� 5 ���������� ���������� �� ���������� �������� �� ���
SELECT TOP 5 user_nickname, COUNT(*) FROM Subscriptions
JOIN Users ON Subscriptions.creator_id = Users.user_id
GROUP BY user_nickname
ORDER BY COUNT(*) DESC;

--�������� ������ ���������� � ���������
INSERT INTO Subscriptions(user_id, creator_id)
VALUES (8,3);

--�������� ����� ������
UPDATE Reviews
SET review_text = 'This book is interesting'
WHERE review_id = 6;
