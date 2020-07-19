Contains all the schema, code, and data for your SQL Server database.
Once this project is compiled, you use the output to deploy the database to your preferred target.
This works whether you want to create a new database or upgrade an existing one.


The scripts in the project will run every time they are applied to a target database.
In other words, you need to be very aware of existing data—and avoid INSERT statements that will cause primary key violations.

For this reason, anytime you add or update lookup data, the SQL statements need to first check that the data doesn’t exist already, as in this snippet:

if not exists(select 1 from dbo.Priority where Name = 'Low')
    insert into dbo.Priority(Name, Ordinal) values('Low', 0);