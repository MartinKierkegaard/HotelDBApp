SELECT *
from guest g
where exists(

select b.Guest_No, COUNT(b.Booking_id) as sum
from Booking b
where b.Guest_No = g.Guest_No
group by b.Guest_No
having COUNT(b.Booking_id) >= 1
--order by sum
)