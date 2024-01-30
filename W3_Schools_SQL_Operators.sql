--W3School Education

--SQL Home
Select * from Customers

--Sql INTRO
--SQL is an ANSI/ISO standard, there are different versions of the SQL language.
--However, to be compliant with the ANSI standard, they all support at least the major commands (such as SELECT, 
--UPDATE, DELETE, INSERT, WHERE) in a similar manner.

--SQL SYNTAX
--SQL keywords are NOT case sensitive: select is the same as SELECT
	sElEct * FRom Customers --this will run without any error

--SQL SELECT
Select ContactName, City, c.Address from Customers c

--SQL Select Distinct
Select distinct City from Customers --Distinct gives us only the differences
Select City from Customers

--SQL Where
SelEct * from Customers where City = 'Berlin'

--SQL Order By
--The ORDER BY keyword is used to sort the result-set in ascending or descending order.
Select * from Customers c order by c.City ,c.ContactName 
--If there are more than one same city, order them with contact name

--SQL AND ___  SQL OR
SELECT * FROM Customers
WHERE Country = 'Germany'
AND City = 'Berlin'
AND PostalCode > 1200

Select * from Customers c 
where c.Country = 'Spain' And (c.ContactName like 'M%' or c.ContactName like 'J%') 

--SQL Not
Select * from Customers
where not City = 'Lyon' 

SELECT * FROM Customers
WHERE Customers.ContactName NOT LIKE 'A%'

--SQL Insert Into 
Insert Into Customers (CustomerID, CompanyName ,Address, City, PostalCode, Country)
Values ('AAAAA', 'Tom B. Erichsen', 'Skagen 21', 'Stavanger', '4006', 'Norway')

--SQL Null Values
SELECT c.ContactName
FROM Customers c
WHERE c.ContactName IS NULL

SELECT c.ContactName
FROM Customers c
WHERE c.ContactName IS Not NULL

--SQL Update Statements
Update Customers
Set ContactName = 'Zagara Mugara'
where CustomerID = 'AAAAA'

--SQL Delete 
Delete from Customers
where Customers.PostalCode = '12209'

--SQL Select Top 
SELECT TOP 3 * FROM Customers
WHERE Country='Germany'

--SQL Min and Max
Select Min(p.UnitPrice) from Products p
Select Max(p.UnitPrice) from Products p

--SQL Count
Select count(*) from Products
Select count(*) from Products p where p.UnitPrice < 10

Select count(Distinct p.SupplierID) from Products p
Select * from Products

--SQL Sum         Just summation
SELECT SUM([Order Details].Quantity)
FROM [Order Details]

Select * from [Order Details]
Select * from Products

Select sum([Order Details].UnitPrice * [Order Details].Quantity)
from [Order Details] Left Join
Products on [Order Details].ProductID = Products.ProductID

--SQL Avg
SELECT AVG(Products.UnitPrice) as UnitPrice_Average
FROM Products

--SQL Like
--Select all customers that starts with the letter "a"
Select * from Customers where Customers.ContactName like 'a%'

Select * from Customers where Customers.ContactName like 'A__ T_u_____'

--Return all customers from a city that contains the letter 'L'
Select * from Customers where City like '%l%'

--SQL Wildcard
--Return all customers starting with either "b", "s", or "p":
SELECT * FROM Customers
WHERE ContactName LIKE '[bsp]%'

--SQL In
--The IN operator is a shorthand for multiple OR conditions.
Select * from Customers where City In ('Cork', 'Paris', 'Lyon')

--SQL Between 
Select * from Products where Products.UnitPrice between 20 and 80

SELECT * FROM Products
WHERE ProductName BETWEEN 'Carnarvon Tigers' AND 'Mozzarella di Giovanni'
ORDER BY ProductName

--SQL Aliases
SELECT c.City as 'Living Place' FROM Customers c

--SQL Join
SELECT Orders.OrderID, Customers.ContactName, Orders.OrderDate
FROM Orders
INNER JOIN Customers ON Orders.CustomerID=Customers.CustomerID;

--SQL Inner Join
--SQL Left Join
--SQL Right Join
--SQL Full Join
--SQL Self Join

--SQL Union
SELECT City FROM Customers
UNION
SELECT City FROM Suppliers
ORDER BY City

--Goup By
Select Count(c.CustomerID) as 'Number of CustomerID', c.CustomerID from Customers c group by c.CustomerID
--List the number of customers in each country.
SELECT Count(CustomerID), Country
FROM Customers Group by Country

SELECT count (CustomerID), Country
FROM Customers
group by Country ORDER BY  count(CustomerID) Desc

--SQL Having
--so similar to where keyword
Select count(CustomerID), Country from Customers
group by Country
having count(CustomerID) < 10
order by count(CustomerID) desc

 





