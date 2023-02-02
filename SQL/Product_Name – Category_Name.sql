SELECT
	p.Name AS product,
	c.Name AS category
FROM Products p
LEFT JOIN ProductsCategories AS pc
	ON p.Id = pc.ProductId
LEFT JOIN Categories c
	ON pc.CategoryId = c.Id;
ORDER BY product;