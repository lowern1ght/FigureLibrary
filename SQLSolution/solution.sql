/* many-to-many

create table product_o (
    id int identity primary key not null,
    name varchar(100) not null
);

create table category_o (
    id int identity primary key not null,
    title varchar(100)
);

create table product_category (
    product_id int references product_o,
    category_id int references category_o
);

insert into category_o values ('sport'), ('food')

insert into product_o values ('ball'), ('cheese'), ('tomato'), ('shirt'), ('smoking')

insert into product_category values (1, 1), (2, 2), (3, 2) */

select pr.name, c.title
from product_o as pr
    left join product_category pc on pr.id = pc.product_id
    left join category_o c on pc.category_id = c.id