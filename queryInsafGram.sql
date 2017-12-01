create database InsafGram

create table account(
	email CHAR(50) primary key not null check(email like '%@%'),
	pass CHAR(50)not null,
	gender CHAR(50) check(gender IN ('Female','Male')),
	birthdate Date
)
select * from account
drop table account
insert into account values('muharramsyah19@gmail.com','muharram19','Male','05-19-1996')