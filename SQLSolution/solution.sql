SELECT
    product.name AS 'name',
    c.name AS 'category'
FROM product
LEFT JOIN category AS c
    ON product.category_id = c.id

/* На текущий момент нет доступа к ТЗ, поэтому я добавлю ветку к запросу для вывода пустых категорий*/

SELECT
    product.name AS 'name',
    c.name AS 'category'
FROM product
FULL JOIN category AS c
    ON product.category_id = c.id