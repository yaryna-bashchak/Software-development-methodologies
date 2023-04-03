# Lab3 - part 3 - .NET
### About project
This project is created to try to use docker for .NET project.

This program generates a person with random name, gender and age using [Bogus](https://github.com/bchavez/Bogus) library,
and then serializes that object into json format using [Newtonsoft.Json](https://www.newtonsoft.com/json) and outputs the result to the console.

### How to run
- first of all, you need to install [.Net 7.0](https://dotnet.microsoft.com/en-us/download) (if you do not already have it)
- open this folder in [VS Code](https://code.visualstudio.com/download)
- install _C# extension_ (if you do not already have it)
<img src="https://user-images.githubusercontent.com/90560209/220602921-cdde3e17-3c4b-458c-bfd0-d0bf2fdd2529.png" height="80">

- write next commands in Terminal if you want to **run the program**

<code>$ dotnet run </code>

![image](https://user-images.githubusercontent.com/90560209/229602157-3ec802fe-4de7-4569-b73c-f736c4bc898f.png)

- if you have some errors, maybe you should install dependencies, so try the following command:

<code>$ dotnet restore </code>
