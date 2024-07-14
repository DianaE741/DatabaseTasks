

select  Products.ProductID,
        Products.ProductDesc, 		
		CASE WHEN  SUM([Order Details].Quantity) IS NULL THEN 0
		ELSE SUM([Order Details].Quantity) END AS QTY

from Products left join [Order Details] ON 
     [Order Details].ProductID = Products.ProductID
	 GROUP BY Products.ProductID, Products.ProductDesc