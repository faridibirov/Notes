# Notes Management API

This repository contains a Web API for managing notes, developed using a range of modern technologies and tools. The API is built following Clean Architecture principles and is designed to be scalable, maintainable, and secure.

## Technologies and Tools Used

- **Backend**:
  - **ASP.NET Core**: For building the Web API.
  - **Entity Framework Core**: For database interactions.
  - **IdentityServer**: For authentication and authorization.
  - **CQRS**: For separating read and write operations.
  - **MediatR**: For implementing the CQRS pattern.
  - **Automapper**: For object-object mapping.
  - **Fluent Validation**: For validating models.
  - **Serilog**: For logging.
  - **Swagger / NSwag Studio**: For API documentation.
  - **XUnit**: For unit testing.
  - **MS SQL**: As the database.

- **Frontend**:
  - **React**: For building the client-side application.
  - **TypeScript**: For adding static types to JavaScript.

## Project Structure

The project follows the Clean Architecture pattern, which helps in maintaining a separation of concerns, making the solution more maintainable and testable.

- **Core**: Contains the domain entities and interfaces.
- **Application**: Contains the application logic, such as CQRS handlers, validation, and mapping.
- **Infrastructure**: Contains the implementation of the interfaces defined in the Core, such as data access (EF Core) and logging (Serilog).
- **API**: The presentation layer that exposes the endpoints via controllers.
- **ClientApp**: The frontend application built with React and TypeScript.

## Features

- **Authentication and Authorization**: Secure the API using IdentityServer.
- **Notes Management**: Create, read, update, and delete notes.
- **CQRS Pattern**: Separates the command and query responsibilities for better scalability.
- **Validation**: Models are validated using Fluent Validation.
- **Logging**: All actions are logged using Serilog.
- **Unit Testing**: The project includes unit tests written with XUnit.

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Node.js](https://nodejs.org/) (for running the frontend)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or any compatible database)

### Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/faridibirov/Notes.git
   cd Notes

2. **Set up the database**:

Update the connection string in appsettings.json to point to your SQL Server instance.
Apply migrations to create the database schema:
```
Update-Database
```

### Code Source
This code was developed following a course on YouTube. You can find the course here: [Platinum DEV - YouTube Course](https://www.youtube.com/watch?v=Q4LB-Ju2Mz8&list=PLEtg-LdqEKXbpq4RtUp1hxZ6ByGjnvQs4&ab_channel=PlatinumDEV).

### Contributing
Contributions are welcome! Please submit a pull request or open an issue for any changes or suggestions.


