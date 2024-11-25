# Write your MySQL query statement below
SELECT A.book_id, A.title, A.author, A.published_year
FROM books AS A
WHERE A.rating IS NULL
ORDER BY A.book_id ASC