/*

create table category (
    id int identity primary key,
    name varchar(100)
);

create table product (
    id int identity primary key,
    name varchar(100),
    category_id int references category
);

*/

select product.[name] as 'Продукт', c.[name] as 'Категория'
from product
left join category c on c.id = product.category_id