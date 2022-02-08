USE mooc;
IF (NOT EXISTS(SELECT *
               FROM INFORMATION_SCHEMA.TABLES
               WHERE TABLE_SCHEMA = 'dbo'
                 AND TABLE_NAME = 'courses'))
    BEGIN
        CREATE TABLE courses
        (
            [id]       CHAR(36)     NOT NULL,
            [name]     VARCHAR(255) NOT NULL,
            [duration] VARCHAR(255) NOT NULL,
            PRIMARY KEY ([id])
        );
    END

IF (NOT EXISTS(SELECT *
               FROM INFORMATION_SCHEMA.TABLES
               WHERE TABLE_SCHEMA = 'dbo'
                 AND TABLE_NAME = 'courses_counter'))
    BEGIN
        CREATE TABLE courses_counter
        (
            [id]               CHAR(36)      NOT NULL,
            [total]            INT           NOT NULL,
            [existing_courses] nvarchar(max) NOT NULL,
            PRIMARY KEY ([id])
        );
    END

IF (NOT EXISTS(SELECT *
               FROM INFORMATION_SCHEMA.TABLES
               WHERE TABLE_SCHEMA = 'dbo'
                 AND TABLE_NAME = 'domain_events'))
    BEGIN
        CREATE TABLE domain_events
        (
            [id]           CHAR(36)      NOT NULL,
            [aggregate_id] CHAR(36)      NOT NULL,
            [name]         VARCHAR(255)  NOT NULL,
            [body]         nvarchar(max) NOT NULL,
            [occurred_on]  datetime2(0)  NOT NULL,
            PRIMARY KEY ([id])
        );
    END

IF (NOT EXISTS(SELECT *
            FROM INFORMATION_SCHEMA.TABLES
            WHERE TABLE_SCHEMA = 'dbo'
                AND TABLE_NAME = 'videos'))
BEGIN
    CREATE TABLE [dbo].[videos]
    (
        [id] CHAR(36) NOT NULL PRIMARY KEY, 
        [type_id] INT NOT NULL, 
        [title] VARCHAR(255) NOT NULL, 
        [url] VARCHAR(255) NOT NULL, 
        [course_id] CHAR(36) NOT NULL, 
        [type] VARCHAR(255) NOT NULL
    );
END