# WebAppLiftItt
This application is a work in progress.
This application will allow the user to keep track of their Weight Lifting workouts by allowing the user to save workouts that will include many exercises and many sets per exercise.
This app is being built using Asp.Net MVC, Entity Framework and Jquery. The data is saved in a SQL Relational Database.

# Technologies
## ASP.NET MVC (Model-View-Controller) 
A web application framework developed by Microsoft that provides a pattern-based way to build dynamic websites and web applications. It's designed to separate an application into three interconnected components: Model, View, and Controller, each with distinct responsibilities.

### Model
The Model represents the application's data and business logic. It encapsulates the data, database interactions, and business rules. Models can include classes that define the structure of the data, handle database operations (using Entity Framework, for example), and contain methods to manipulate that data.

In ASP.NET MVC, Models are typically represented as classes in C# (or other .NET languages) and often correspond to database tables/entities. They don't usually contain any direct logic related to the user interface.

### View
The View represents the user interface (UI) of the application. It's responsible for rendering the data obtained from the Model in a format that's suitable for presentation to the user. Views are often written using HTML, CSS, and a templating engine (like Razor syntax in ASP.NET).

In ASP.NET MVC, Views are separate files that contain HTML markup along with placeholders or code snippets that get replaced with data from the Model. They are responsible for displaying data to the user and handling user interactions through forms, buttons, links, etc.

### Controller
The Controller acts as an intermediary between the Model and the View. It processes incoming requests from the user, interacts with the Model to retrieve data, and passes that data to the appropriate View for presentation.

In ASP.NET MVC, Controllers are C# classes that handle HTTP requests, perform business logic operations, retrieve data from the Model, and determine which View to render based on the request. They contain action methods that respond to specific URLs and user actions, manipulating the Model and selecting the appropriate View to display.

## Entity Framework
Entity Framework (EF) is an Object-Relational Mapping (ORM) framework developed by Microsoft. It allows developers to work with relational databases using .NET objects, eliminating the need for most of the database-related code that developers typically write.

### Entity Framework Core Components:
### DbContext: 
DbContext is the heart of Entity Framework. It represents a session with the database and acts as a bridge between your domain classes (entities) and the database. It includes configurations for entity sets, database connections, and manages changes in the database.

### Entity: 
An entity is a class that represents a table or document in the database. Each instance of an entity corresponds to a row in the table or a document in a NoSQL database. These classes contain properties that map to columns in the table/document.

### DbSet<T>: 
DbSet is a collection of entities of a specific type. It's used within the DbContext to query and manipulate entities of that type. For example, DbSet<User> represents a collection of User entities.

### LINQ to Entities: 
Entity Framework uses LINQ (Language Integrated Query) to query data from the database using familiar C# syntax. LINQ queries are translated into SQL queries by EF, allowing developers to interact with the database using code that feels like C#.

### Code-First or Database-First Approach: 
Entity Framework supports both code-first and database-first approaches. With code-first, developers define the entity classes and relationships in code, and EF generates the database schema based on those classes. In database-first, EF generates entity classes based on an existing database schema.

### Migrations: 
EF Core supports migrations, which enable developers to make changes to the database schema and update the database without losing data. Migrations are code-based representations of database changes.

## jQuery 
Jquery is a JavaScript library that simplifies HTML document traversal, event handling, and Ajax interactions for rapid web development. It simplifies tasks like DOM manipulation, event handling, and asynchronous HTTP requests.
## Key Components of jQuery:
### DOM Manipulation: 
jQuery allows easy selection and manipulation of DOM elements using selectors ($() function) and methods to modify HTML content, CSS properties, or manipulate the DOM structure.

### Event Handling: 
jQuery provides methods to attach event handlers to DOM elements. For instance, click(), on(), hover(), etc., allow you to respond to user interactions like clicks, mouse movements, keyboard input, etc.

### Ajax: 
jQuery simplifies Ajax requests with functions like $.ajax(), $.get(), $.post(), etc., allowing you to send and receive data from a server asynchronously without reloading the entire page.

### Effects and Animations: 
jQuery includes built-in effects and animations, making it easy to add visual transitions or animations to elements on a web page.

### Utilities: 
jQuery provides various utility functions for tasks such as iterating through arrays or objects, manipulating strings, handling asynchronous operations, etc.

## Typical Usage of jQuery in Web Development:
### Selecting Elements: 
Use selectors like IDs, classes, elements, attributes, etc., to select one or more elements and perform actions on them.

### Manipulating Elements: 
Modify attributes, content, styles, or positions of selected elements using jQuery methods.

### Event Handling: 
Attach event listeners to elements to perform actions in response to user interactions or other events.

### Ajax Requests: 
Send HTTP requests to a server using jQuery's Ajax functions ($.ajax(), $.get(), $.post(), etc.) to fetch or send data without page reloads.

### Animation and Effects: 
Apply animations or visual effects to elements on the page using jQuery's built-in functions.

### Plugins: 
Utilize jQuery plugins, which are additional libraries built on top of jQuery, to extend its functionality for specific tasks or UI components.
