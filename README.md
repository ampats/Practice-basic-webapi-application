# Practice-basic-webapi-application

### _This file includes instructions on how to run and test the application locally on Windows_
---

- Clone repository using [repo ssh link](git@github.com:ampats/Practice-basic-webapi-application.git) by running the following git command in the terminal, inside the destination folder you want to clone it:
```git
git clone git@github.com:ampats/Practice-basic-webapi-application.git
```
### 1. To run the application

- Run the following commands inside src\Practice-basic-webapi-application
```dotnet
    dotnet build
    dotnet run
```
- While running, output displays 2 links for the local machine currently making the request (format: *http://localhost:xxxx*): click one of them

- "Hello World" is then displayed in the localhost window
- Press ```Ctrl + C``` to shut down

### 2. To run the test for the application

- Run the following command inside test\PracticeWebApi.Test
```dotnet
    dotnet test
```
- A "Passed" message should be displayed at the end along with other details regarding the test