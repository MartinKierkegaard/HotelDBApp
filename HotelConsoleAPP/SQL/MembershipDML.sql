--Gold
insert into MemberShipType
(GuestRating ,Discount ,SumBookings)
values(1,20,5);

--Silver
insert into MemberShipType
(GuestRating ,Discount ,SumBookings)
values(2,10,3);

--Bronze
insert into MemberShipType
(GuestRating ,Discount ,SumBookings)
values(1,5,1);

Update dbo.Guest
set GuestRating = 1;