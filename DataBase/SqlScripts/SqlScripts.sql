-- Create the Navbar table
CREATE TABLE Navbar (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(255) NOT NULL,
    Access NVARCHAR(255) NOT NULL,
    Active BIT NOT NULL,
    RoutLink NVARCHAR(255) NOT NULL
);
-- Create the Contents table
CREATE TABLE Contents (
    Id INT PRIMARY KEY IDENTITY,
    Link NVARCHAR(255) NOT NULL,
    Discription NVARCHAR(255) NOT NULL,
    Active BIT NOT NULL,
    Title NVARCHAR(255) NOT NULL
);
-- Create the Event table
CREATE TABLE Event (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(255) NOT NULL,
    Discription NVARCHAR(255) NOT NULL,
    Date DATETIME NOT NULL,
    Active BIT NOT NULL
);
--Create the Prayer Request table
CREATE TABLE Prayer_Request (
    Id INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(255) NOT NULL,
    Request NVARCHAR(255) NOT NULL,
    PhoneNo INT NOT NULL,
    Email NVARCHAR(255) NOT NULL
);


-- Insert a row into the Navbar table
INSERT INTO Navbar (Name, Access, Active, RoutLink)
VALUES ('Home', '1', 1, '/home'),
 ('Donation', '1', 1, '/donet'),
 ('Song', '1', 1, '/song'),
 ('Prayer', '1', 1, '/prayer'),
 ('About', '1', 1, '/about');

 -- Insert a row into the Contents table
INSERT INTO Contents
VALUES ('https://www.youtube.com/embed/-fkVRjnva2s?si=RIFJ79QvTKrwwwRK', 'Adject you life accourding to the God will', 1, 'Adjustment is perilous | From Pastors Desk | Wilson Mathew | IFC'),
 ('https://www.youtube.com/embed/b4dBWGoZ9-A?si=TYfXYVGv4k9dghoi', 'Some time God answer to our prayers according to his will', 1, 'Sometimes God answers out prayer according to his will | From Pastors Desk | Wilson Mathew'),
 ('https://www.youtube.com/embed/kuKhmQmRDNQ?si=v8dWD5s685_-E5h6', 'Life of Jesus make us overcomers', 1, 'Life of Jesus Christ makes us overcomers | From Pastors Desk | Wilson Mathew | IFC Nashik')
 --SP
 --SP to insert into Prayer table
CREATE or alter PROCEDURE SP_insert_prayer_request
    @Name NVARCHAR(255),
    @Request NVARCHAR(255),
    @PhoneNo float,
    @Email NVARCHAR(255),
	@CreatedOn DateTime
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Prayer_Request (Name, Request, PhoneNo, Email,CreatedOn)
    VALUES (@Name, @Request, @PhoneNo, @Email,@CreatedOn);
END;