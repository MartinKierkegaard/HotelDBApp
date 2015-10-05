--Add the HotelUrl to the database
Alter table Hotel
ADD HotelUrl VARCHAR(50);

UPDATE HOTEL
SET HotelUrl = 'http://www.hotellegoland.dk/'
Where Name Like '%LegoLand%';