USE [TWO]
GO
/****** Object:  StoredProcedure [dbo].[TMR_VIEW_UNSENTDATA]    Script Date: 11/04/2019 9:52:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Waleed Rehman
-- Create date: 31 Dec 2018
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TMR_VIEW_UNSENTDATA]
	
AS
BEGIN
	SELECT VENDORID, CUSTNMBR, DOCNUMBR, DOCTYPE, DOCDATE, VCHRNMBR, DOCAMNT, DUEDATE, SERIES,  Status, ErrorMsg, 
	PhoneNo1,PhoneNo2,PhoneNo3, AttemptDate, id
    FROM     TMRMESSAGETABLE where Status = 3
END

GO
/****** Object:  StoredProcedure [dbo].[TMRUPDATEMESSAGETABLE]    Script Date: 11/04/2019 9:52:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Waleed Rehman
-- Create date: 31 Dec 2018
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TMRUPDATEMESSAGETABLE] @status int,@errormsg varchar(1000),@phoneno varchar(50),@attemptdate date,@id int

	
AS
BEGIN
	update TMRMESSAGETABLE set Status = @status, ErrorMsg = @errormsg, PhoneNo1 = @phoneno, AttemptDate = @attemptdate
    where id= @id
END

GO
/****** Object:  StoredProcedure [dbo].[ViewFilteredMessages]    Script Date: 11/04/2019 9:52:02 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Waleed Rehman>
-- Create date: <10/1/2019>
-- Description:	<Procedure>
-- =============================================
CREATE PROCEDURE [dbo].[ViewFilteredMessages] @Status int, @series varchar(5), @StartDate datetime, @EndDate datetime
	
AS
BEGIN
SELECT VENDORID, CUSTNMBR, DOCNUMBR, DOCTYPE, DOCDATE, VCHRNMBR, DOCAMNT, DUEDATE, SERIES,  Status, 
ErrorMsg, PhoneNo1,PhoneNo2,PhoneNo3, AttemptDate, id
FROM     TMRMESSAGETABLE 
where status= case when @status = 0 then status else @status end
  and series = case when @series = 'All' then series else @series end
  and docdate between @StartDate and @EndDate
END

GO
