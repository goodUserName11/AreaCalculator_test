--Products - таблица продуктов
--ProdName - имя продукта
--Categories - таблица категорий
--CatName - имя категории
--Products_Categories - связующая таблица Products m-m Categories
--ProdId - id продукта
--CatId - id категории

SELECT ProdName, CatName
FROM Products
LEFT JOIN Products_Categories
ON Products.Id = Products_Categories.ProdId
LEFT JOIN Categories
ON Categories.Id = Products_Categories.CatId