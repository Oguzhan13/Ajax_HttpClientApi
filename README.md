# Ajax_HttpClientApi

## Ajax Http Client API and MVC Project
This is a sample MVC (Model-View-Controller) project that demonstrates how to use the Ajax Http Client API to interact with a Web API. The project also utilizes the Newtonsoft.Json NuGet package for JSON serialization and deserialization.

Project Structure
lua
Copy code
- Ajax_HttpClientApi (Web API Project)
   |--- Controllers
   |--- Models
       |--- Person.cs
   |--- Services
       |--- IPersonService.cs
       |--- PersonService.cs

- Ajax_HttpClientMvc (MVC Project)
   |--- Controllers
       |--- PersonController.cs
       |--- PersonHttpController.cs
   |--- Models
       |--- Person.cs
   |--- Views
       |--- Person
           |--- Index.cshtml

- Shared
   |--- Layout.cshtml

- wwwroot
   |--- js
       |--- site.js
NuGet Packages
The project uses the following NuGet package:

Newtonsoft.Json: For JSON serialization and deserialization.
Ajax Http Client API and MVC Interaction
Ajax_HttpClientApi (Web API Project)

This project contains the Web API endpoints that the MVC project will interact with.
It includes a PersonController that handles CRUD (Create, Read, Update, Delete) operations for the Person entity.
Ajax_HttpClientMvc (MVC Project)

This project serves as the frontend and communicates with the Web API using the Ajax Http Client API.
It includes a PersonController and a PersonHttpController.
PersonController handles the user interface and contains actions to display and manage Person data.
PersonHttpController uses the HttpClientFactory to send HTTP requests to the Web API's PersonController endpoints.
Accessing the Web API from MVC
To access the Web API from the MVC project, follow these steps:

Add the Web API project reference to the MVC project.

In Program.cs of the Web API project, configure CORS using builderServices.AddCors() and app.UseCors() to allow access from the MVC project.

In the MVC project's Program.cs, add the AddHttpClient() method in builder.Services to register the HttpClientFactory.

Modify View/Shared/Layout.cshtml to change the home page codes in the Navbar section for accessing the Person Controller in the MVC project.

AJAX Interaction in MVC
In site.js located in the wwwroot/js/ folder, create a function that uses AJAX to interact with the Web API.

This function will call the API endpoints for getting a list of persons, getting a single person, and creating a new person.
Create PersonController.cs in the MVC project's Controllers folder, and implement actions for displaying and managing persons.

Use the methods defined in site.js to interact with the Web API endpoints.
Create the Index.cshtml view in the MVC project's Views/Person folder to display the list of persons.

Create PersonHttpController.cs in the MVC project's Controllers folder, and implement actions using the HttpClientFactory to send HTTP requests to the Web API's PersonController endpoints.

Person Model
In both the Web API and MVC projects, the Person model should have the same properties to ensure proper serialization and deserialization. Make sure to keep the Person.cs in the Models folder of both projects consistent.

Enjoy your AJAX Http Client API and MVC project!
