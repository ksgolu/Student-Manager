CREATE TABLE [dbo].[gstudent] (
    [RollNo]     VARCHAR (50)   NOT NULL,
    [Name]       NVARCHAR (50)  NOT NULL,
    [FatherName] NVARCHAR (50)  NOT NULL,
    [MotherName] NVARCHAR (50)  NOT NULL,
    [course]     VARCHAR (10)   NULL,
    [DOB]        DATE           NOT NULL,
    [Email]      VARCHAR (50)   NOT NULL,
    [Address]    NVARCHAR (250) NOT NULL,
    [StudentPhoto] IMAGE NOT NULL, 
    CONSTRAINT [PK_gstudent] PRIMARY KEY CLUSTERED ([RollNo] ASC)
);

