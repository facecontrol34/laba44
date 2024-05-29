use demoqq
Create table Requests(
requestID int,
startDate datetime,
orgTechType varchar(50),
orgTechModel varchar(50),
problemDescryption varchar(100),
requestStatus varchar(50),
completionDate datetime,
repairParts text,
masterID int,
clientID int
);

Create table Coments(
commentID int,
message varchar(100),
masterID int,
requestID int,

);

Create table Users(
userID int,
fio datetime,
phone varchar(50),
login varchar(50),
password varchar(100),
type varchar(50)
);

Insert into Requests (RequeesrequestID;startDate;orgTechType;orgTechModel;problemDescryption;requestStatus;completionDate;repairParts;masterID;clientID)
Values (1;2023-06-06;Компьютер;DEXP Aquilon O286;Перестаvarcл работать;В процессе ремонта;null;;2;7
2;2023-05-05;Компьютер;DEXP Atlas H388;Перестал работать;В процессе ремонта;null;;3;8
3;2022-07-07;Ноутбук;MSI GF76 Katana 11UC-879XRU черный;Выключается;Готова к выдаче;2023-01-01;;3;9
4;2023-08-02;Ноутбук;MSI Modern 15 B12M-211RU черный;Выключается;Новая заявка;null;;null;8
5;2023-08-02;Принтер;HP LaserJet Pro M404dn;Перестала включаться;Новая заявка;null;;null;9
);

use demoqq
Truncate Table Requests;
delete from Users;