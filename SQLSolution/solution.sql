SELECT
    product.name AS 'name',
    c.name AS 'category'
FROM product
LEFT JOIN category AS c
    ON product.category_id = c.id