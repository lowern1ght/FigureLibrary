CREATE TABLE category (
    id int primary key not null,
    name varchar(255) not null
);

CREATE TABLE product (
     id int primary key not null,
     category_id int foreign key REFERENCES category(id),
     name varchar(255) not null,
);

INSERT INTO category 
VALUES 
    (1, 'milk'),
    (2, 'shoes'),
    (3, 'bags'),
    (4, 'lamp');

INSERT INTO product
VALUES 
    (1, 1, 'dobrii molochnik'),
    (2, 3, 'nike bag'),
    (3, 3, 'adidas bag'),
    (4, null, 'pivo'),
    (5, null, 'yslyga');

SELECT 
    product.name AS 'name',
    c.name AS 'category'
FROM product
LEFT JOIN category AS c 
    ON product.category_id = c.id