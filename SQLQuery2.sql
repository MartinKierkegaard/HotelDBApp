
Select AVG(Price)
From Room
Where Room.Hotel_No IN
(Select Hotel.Hotel_No
From Hotel
Where Hotel.Name Like '%Scandic%');

Select AVG(r.Price)
From Room r, Hotel h
Where r.Hotel_No = h.Hotel_No
AND h.name LIKE  '%Scandic%'

-- Today is 2011-02-26

select Count(*)
From Booking
Where Date_From <= '2011-02-26' AND Date_TO >= '2011-02-26'
AND Booking.Hotel_No IN
(Select Hotel.Hotel_No
From Hotel
Where Hotel.Name Like '%Scandic%');
	

select count(*)
from Booking
where Date_From <= convert(date, getdate()) AND Date_To >= convert(date, getdate())
AND Booking.Hotel_No IN
(Select Hotel.Hotel_No
From Hotel
Where Hotel.Name Like '%Scandic%');


