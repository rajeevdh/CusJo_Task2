Project 1 ->  CusJoTaskEmailNotifications
API to record the response of the users via email sent.
ORM - Entity Framework, Code First approach. Migrations can be found in 'Migrations' folder. Table that contain 'pending emails' are seeded using migrations. To and from address may have to changed as smtp.Credentials requires personal email credentials.

Project 2 -> EmailNotification
Console App to send email based on the conditions defined.
This can be either Schedule via Task Scheduler or can be converted to a Azure WebJob.

NOTE - TO and From addrees in the database contain my personal email id, this may have to be chagned if required. smtp.Credentials should also be changed accordingly.