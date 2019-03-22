# Let’s talk to the database.

Use your OrdersMVC app and edit your controller to grab data. Using SqlConnection and SqlCommand, connect to the dev database using this connection string:

Data Source=VXCDEV-DE-01;Initial Catalog=Sales;User ID=VxUser;PWD=L0ngP@s$W0r|>$@r3|3es7!

Query the Orders table and display the top 10 orders’ info on the page (SELECT TOP 10 * FROM Orders). You can use a DataTable or SqlDataReader, whichever you feel more comfortable with.

Pro move: try to put the connection string in the web.config’s “connectionStrings” section. Looking at the web.config for applications already developed is a great way to learn.
