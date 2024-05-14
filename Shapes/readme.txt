

select Category.Name,Product.Name from Category cross join Product inner join CategoryProduct on Category.id=CategoryID and Product.id=ProductID