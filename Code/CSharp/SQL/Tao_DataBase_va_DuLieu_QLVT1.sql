--baitap
--1
select MaMH,TenMH,Sotiet
from MonHoc

--2
select MaSV,HoSV,TenSV,HocBong
from SinhVien
order by MaSV

--3
select MaSV,TenSV,Phai,NgaySinh
from SinhVien
order by Phai asc

--4
select HovaTen=HoSV+' '+TenSV,NgaySinh,HocBong
from SinhVien
order by NgaySinh asc,HocBong desc

--5
select MaMH,TenMH,Sotiet
from MonHoc
where TenMH like 'T%'

--6
select HovaTen=HoSV+' '+TenSV,NgaySinh,Phai
from SinhVien
where TenSV like '%I'

--7
select MaKH,TenKH
from Khoa
where TenKH like '_N%'

--8
select MaSV,HoSV,TenSV,Phai,NgaySinh
from SinhVien
where HoSV like N'%thị%'

--9
select MaSV,HoSV,TenSV,HocBong
from SinhVien
where TenSV like '[A-M]%'

--10
select HovaTen=HoSV+' '+TenSV,NgaySinh,NoiSinh,HocBong
from SinhVien
where TenSV like '[A-M]%'
order by TenSV,HoSV