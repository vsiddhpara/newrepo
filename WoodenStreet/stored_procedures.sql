-- =============================================
-- Author:		<Anisha Bhatia>
-- Create date: <22/03/2023>
-- Description:	<Created stored procedure for getting all the Products for /products page>
-- =============================================

IF OBJECT_ID ( 'uspGetProducts') IS NOT NULL   
    DROP PROCEDURE uspGetProducts;  
GO

CREATE PROCEDURE uspGetProducts
AS
	SELECT p.ProductId,p.ProductName,p.CompanyName,p.IsRated,p.Ratings,p.DiscountedPrice,p.OriginalPrice,i.ProductImageUrl
	FROM Products p
	INNER JOIN Images i ON i.ProductId = p.ProductId
GO

EXEC uspGetProducts
GO