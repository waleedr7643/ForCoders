use [WST]
GO
/****** Object:  Trigger [dbo].[InsertTMRMessage1]    Script Date: 11/04/2019 9:59:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[InsertTMRMessage1] ON [dbo].[PM20000]
AFTER INSERT
AS
BEGIN
 declare @vid char(15);
 declare @custnumber char(15);
 declare @docnumber char(21);
 declare @doctype smallint;
 declare @duedate datetime;
 declare @docdate datetime;
 declare @docamnt numeric(19, 5);
 declare @vnumber char(21);
 declare @countype int;
 declare @series char(21);
 declare @phone1 varchar(50);
 declare @phone2 varchar(50);
 declare @phone3 varchar(50);
 --declare @countnum int;
 --declare @coountsnum int;
 
 
 --select @id = customerlist.id from inserted customerlist;
 select @vid = VENDORID from inserted ;
 select @custnumber = '' ;
 select @docnumber = DOCNUMBR from inserted ;
 select @doctype = DOCTYPE from inserted ;
 select @duedate = DUEDATE from inserted ;
 select @docdate = DOCDATE from inserted ;
 select @vnumber = VCHRNMBR from inserted ;
 select @docamnt = DOCAMNT from inserted ;
 select @series = 'pm'
 set @phone1 = (select Left(PHNUMBR1,11) from pm00200 where VENDORID = @vid)
 set @phone2 = (select Left(PHNUMBR2,11) from pm00200 where VENDORID = @vid)
 set @phone3 = (select Left(PHONE3,11) from pm00200 where VENDORID = @vid)

set @countype = (select  count(DOCNUMBR) from TMRMESSAGETABLE where DOCNUMBR = @docnumber and DOCTYPE = @doctype and vendorid  = @vid)

IF (@countype =  0)
	INSERT INTO TMRMESSAGETABLE(VENDORID,CUSTNMBR,DOCNUMBR,DOCTYPE,DUEDATE,DOCDATE,DOCAMNT,VCHRNMBR,SERIES,PhoneNo1,PhoneNo2,PhoneNo3)
    VALUES(@vid,@custnumber,@docnumber,@doctype,@duedate,@docdate,@docamnt,@vnumber,@series,@phone1,@phone2,@phone3)

  END
