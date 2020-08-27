create database BUYListDB;

use BUYListDB;

SELECT 
    Users.Name AS User_Name,
    Users.Email AS User_Email,
    Items.Name AS Item_Name,
    Items.Description AS Item_Description,
    Items.CreateDate AS Item_Create_Date
FROM
    Users
        INNER JOIN
    Items ON Items.UserId = Users.Id
ORDER BY Users.Name;