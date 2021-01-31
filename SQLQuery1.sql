SELECT p.ProductName AS ÜrünAdı,
SUM(od.UnitPrice*od.Quantity) AS ToplamTutar
FROM Products AS p
JOIN [Order Details] AS od ON p.ProductID =od.ProductID 
JOIN Orders AS o ON o.OrderID=od.OrderID
GROUP BY ProductName ORDER BY ToplamTutar


