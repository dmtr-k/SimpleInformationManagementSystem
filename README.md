# Book Application

This application allows users to manage books including inserting, updating, and deleting book records. Additionally, users can search for books based on various criteria such as genre, publisher, price range, title, and author.

## Table of Contents

- [Introduction](#introduction)
- [Technologies Used](#technologies-used)
- [Installation](#installation)
- [Usage](#usage)
- [Code Structure](#code-structure)
- [Contributing](#contributing)
- [License](#license)

## Introduction

The Book Application provides a user-friendly interface for managing book records in a database. It offers functionalities like inserting new books, updating existing ones, deleting records, and searching for specific books based on different criteria.

## Technologies Used

The application is built using the following technologies:

- C# programming language
- .NET Framework
- Windows Forms for GUI
- SQL Server for database management

## Installation

1. Clone the repository to your local machine.
2. Open the project in Visual Studio.
3. Ensure that .NET Framework and SQL Server are installed on your machine.
4. Restore NuGet packages if necessary.
5. Build the solution.

## Usage

- **Inserting a Book**: Click on the "Insert" button to add a new book record. Fill in the required details such as title, author, publisher, etc., and click "Insert".
- **Updating a Book**: Click on the "Update" button to modify an existing book record. Enter the book ID, make the necessary changes, and click "Update".
- **Deleting a Book**: Click on the "Delete" button to remove a book record from the database. Enter the book ID and click "Delete".
- **Searching for Books**: Use the search functionality to find books based on genre, publisher, price range, title, or author.

## Code Structure

The codebase consists of several classes organized as follows:

- `Form1`: Handles the main user interface for managing book records and searching for books.
- `Form2`: Provides functionality for inserting, updating, and deleting book records.
- `authenticate`: Contains classes for user authentication and database management.
- `Database`: Manages the database-related operations and interfaces with the user interface.

## Contributing

Contributions to the Book Application are welcome! If you find any bugs or have suggestions for improvements, please open an issue or submit a pull request on GitHub.

## License

This project is licensed under the [MIT License](LICENSE).
