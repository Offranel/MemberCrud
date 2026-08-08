# Church Member Manager

## About

Church Member Manager is a Windows Forms application built with C# and .NET.

This program helps a church manage members, ministries, and volunteer information.

## Features

- Add, edit, and delete members
- View member information
- Add, edit, and delete ministries
- Assign members to ministries
- Find members who are not serving
- Save volunteer messages
- View church statistics

## Technologies

- C#
- .NET
- Windows Forms
- Entity Framework Core
- SQL Server
- GitHub

## Database

The application uses SQL Server to store its data.

Entity Framework Core is used to communicate between the C# application and the SQL Server database.

### Tables

- Members
- Ministries
- MemberMinistries
- VolunteerMessages

## Project Structure

- **Models** - Represents the application's data objects.
- **Services** - Contains the logic for accessing and managing data.
- **Data** - Contains the Entity Framework database context.
- **Forms** - Contains the Windows Forms user interface.
- **Database** - Contains the initial SQL database script.

## Team Members

Francis Sengele and Ivanna Otero

## Course

This project was created for learning in CPW 211 at Clover Park Technical College.
