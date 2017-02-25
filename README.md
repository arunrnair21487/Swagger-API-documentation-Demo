# Swagger-API-documentation-Demo
The Swagger specification is a powerful definition format to describe RESTful APIs. The Swagger specification creates a RESTful interface for easily developing and consuming an API by effectively mapping all the resources and operations associated with it.
If you want to know more about Swagger, go to http://swagger.io/getting-started/

Here I am trying to create the swagger specifications of a simple Calculator API using a Asp.Net Web Application Project.

The steps followed to develop the project are following:
--------------------------------------------------------
1. Create a Asp.Net Web Application Project
2. Select Web API template
3. Add a Web API Controller named CalculatorController and add methods to the controller like GetSum, GetDiff, GetProduct, GetDiv etc.
4. Add Swashbuckle library to the project(Go to Tools -> NuGet Package Manager -> Package Manager Console, type install-package Swashbuckle)
5. Go to App_Start -> RouteConfig.cs, change default Controller and Action to Calculator and GetSum respectively. So while running the solution, this Controller and Action will be executed by default.
6. Build the solution and run it.
7. The browser will be navigated to http://localhost:port number/. 
8. Navigate to http://localhost:port number/swagger. You can now view a Swagger UI where you can see a decent documentation about your Calculator API and methods/functions inside the Calculator API. Moreover, using this UI, you can do a lot of ad-hoc testing of your Calculator API by passing the necessary parameters.

echo "# Swagger-API-documentation-Demo" >> README.md
