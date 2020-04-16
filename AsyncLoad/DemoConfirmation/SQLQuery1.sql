CREATE TABLE [dbo].[EmployeeInfo] (
    [EmpNo]       INT          IDENTITY (1, 1) NOT NULL,
    [EmpName]     VARCHAR (50) NOT NULL,
    [DeptName]    VARCHAR (50) NOT NULL,
    [Designation] VARCHAR (50) NOT NULL,
    [Salary]      DECIMAL (18) NOT NULL,
    PRIMARY KEY CLUSTERED ([EmpNo] ASC)
);

INSERT INTO [dbo].[EmployeeInfo] ([EmpName], [DeptName], [Designation], [Salary]) VALUES ('Harry', 'ITServices','Director', CAST(780000 AS Decimal(18, 0)))
INSERT INTO [dbo].[EmployeeInfo] ([EmpName], [DeptName], [Designation], [Salary]) VALUES ('Larry', 'Administration','Manager', CAST(1556000 AS Decimal(18, 0)))
INSERT INTO [dbo].[EmployeeInfo] ([EmpName], [DeptName], [Designation], [Salary]) VALUES ('Maggy', 'Administration','Dy. Manager', CAST(45000 AS Decimal(18, 0)))

select * from [dbo].[EmployeeInfo]