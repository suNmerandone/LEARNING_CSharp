select T1.contry as contry, SUM(T2.value) as export
from companies T1, trades T2
where T1.name = T2.seller
group by contry
order by contry
asc;

select T1.contry as contry, SUM(T2.value) as export
from companies T1, trades T2
where T1.name = T2.buyer
group by contry
order by contry
asc;
