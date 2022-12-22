# HartApplication
This is a very simple application. There are two solutions, a database solution and a WebAPI solution. The database will need to be published before the WebAPI can work.

Visual Studio should launch htmlpage.html when the project is run. This page uses very simple HTML and Angular to display inventory, and also to run a countdown timer which then displays a message retrieved from an API endpoint.

## Database Project
The database project is very simple. It has pre- and post-scripts to set up the sample data.

## Web Project
This is a simple WebAPI project, which has controllers for getting the inventory, and retrieving settings (the only settings are the timer's starting value, and the message to display after the countdown). There is also a simple HTML file with HTML, Angular, and JavaScript for demonstrating these - it will display the inventory, start a timer with the starting value it's retrieved from the API, then after the countdown is complete retrieve the message to display and show it.
