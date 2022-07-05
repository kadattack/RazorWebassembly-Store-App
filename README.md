# RazorWebassembly-Store-App
.NET 6 Bazor Webassembly with Asp.Net Core hosting implementation of a web store.


This is the tutorial implementation of the Blazor store from the Udemy course 
https://www.udemy.com/course/blazor-ecommerce/


The app uses .NET 6 Blazor WebAssembly for the client and the server uses .NET Core Web API.
The template used was created with `dotnet new blazorwasm -o <AppName> -ho`. This setup allows better management of which code is executed on server side and which on client side.
As this is a simple tutorial intended for learning it uses a simple Sqlite file to store data.
