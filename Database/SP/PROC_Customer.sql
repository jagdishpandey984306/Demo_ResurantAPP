-- =============================================
-- Author:  Jagdish Pandey
-- Create date: 2020-09-27
-- Description: Customer Management (Add,Edit,Assign,List Employee )

-- Last Updated By:
--   2020-09-27 Jagdish: Initialized
-- =============================================
CREATE OR ALTER PROCEDURE PROC_Customers
(
	@Flag				VARCHAR(50)			= NULL,
	@Id					BIGINT				= NULL,
	@User				VARCHAR(150)		= NULL,
	@CustomerName		varchar(150)		= NULL,
	@PermanentAddress	varchar(150)		= NULL,
	@TemporaryAddress	varchar(150)		= NULL,
	@EmailAddress		varchar(150)		= NULL,
	@ContactNumber		varchar(150)		= NULL
)
AS 
SET NOCOUNT ON
BEGIN TRY
	/*
		EmployeeList -> Get Employee List
		AddEmployee -> Add Employee Details
		GetEmployeeDetailsById -> Get Employee details by id for update
		UpdateEmployeeDetails - update employee details
	*/
	IF @Flag = 'CustomerList'
	BEGIN
		SELECT * FROM Customer.CustomerDetails AS ed (NOLOCK)
    END

	IF @Flag = 'AddCustomer'
	BEGIN
		INSERT INTO Customer.CustomerDetails
		(
		CustomerName,
		PermanentAddress,
		TemporaryAddress,
		EmailAddress	,
		ContactNumber,
		CreatedDate,
		CreatedBy
		)
		SELECT @CustomerName,@PermanentAddress,@TemporaryAddress, @EmailAddress,@ContactNumber,SYSDATETIME(),@User

		SELECT '000' Code,'Customer Added Successfully','' Data
	END

	IF @Flag = 'GetCustomerDetailsById'
	BEGIN
		SELECT * FROM Customer.CustomerDetails AS ed WHERE ed.Id = @Id
    END

	IF @Flag = 'UpdateEmployeeDetails'
	BEGIN
		IF EXISTS(SELECT 'x' FROM Customer.CustomerDetails AS ed WHERE ed.Id = @Id)
		BEGIN
			UPDATE Customer.CustomerDetails
			SET 
				@CustomerName = @CustomerName,
				@TemporaryAddress = @TemporaryAddress,
				@PermanentAddress = @PermanentAddress,
				@EmailAddress = @EmailAddress,
				@EmailAddress = @EmailAddress,
				ModifiedBy = @User,
				ModifiedDate = SYSDATETIME()
			WHERE Id = @Id
			SELECT '000' Code,'Customer Updated Successfully','' Data
        END
		SELECT '111' Code,'No Customer Details Exists With The Id','' Data
    END

END TRY
BEGIN CATCH
IF @@TRANCOUNT>0
	ROLLBACK
	SELECT 111 Code, ERROR_MESSAGE() Message, '' Data
END CATCH
