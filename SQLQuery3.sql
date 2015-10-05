
SELECT SUM(Price)*31 AS 'Lost income', Hotel_No

FROM Room

WHERE NOT EXISTS

                      (SELECT Room_No FROM Booking

                      WHERE Date_From >= '2013-03-01' AND Date_From <= '2013-03-31')

                      GROUP BY Hotel_No

                      ORDER BY Hotel_No;

