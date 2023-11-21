--select	dbo.func('0779923449')
--select Substring('+994779923445',5,3)
Alter  FUNCTION fuuncc (@input varchar(13))
RETURNS varchar(20)
as
    BEGIN
		Declare @output varchar(20)
		if Substring(@input,1,4) = '+994' and len(@input)=13
			Set @output= '+994'+' ('+Substring(@input,5,2)+') '+Substring(@input,7,3)+'-'+Substring(@input,10,2)+'-'+Substring(@input,12,2)
		Else if Substring(@input,1,1) = '0' and len(@input)=10
			Set @output= '+994 ('+Substring(@input,2,2)+')'+Substring(@input,4,3)+'-'+Substring(@input,7,2)+'-'+Substring(@input,9,2)
		Else Return null
		RETURN @output
		END	
