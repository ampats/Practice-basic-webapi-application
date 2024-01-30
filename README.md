# Practice-basic-webapi-application

### _This file includes instructions on how to run and test the application locally on Windows. Also it includes instructions on how to use an artifact of the application to run it locally on Windows_
---

### How to run and test the app with repository cloning

- Clone repository using [repo ssh link](git@github.com:ampats/Practice-basic-webapi-application.git) by running the following git command in the terminal, inside the destination folder you want to clone it:
```git
git clone git@github.com:ampats/Practice-basic-webapi-application.git
```
#### 1. To run the application

- Run the following commands inside src\Practice-basic-webapi-application
```dotnet
    dotnet build
    dotnet run
```
- While running, output displays 2 links for the local machine currently making the request (format: *http://localhost:xxxx*): click one of them

- "Hello World" is then displayed in the localhost window
- Press ```Ctrl + C``` to shut down

#### 2. To run the test for the application

- Run the following command (inside Practice-basic-webapi-application)
```dotnet
    dotnet test
```
- A "Passed" message should be displayed at the end along with other details regarding the test


### How to use an artifact of the application to run it locally on Windows
---

#### 1. Instructions to download the artifact and extract the files in your local machine

- A zip file will be downloaded in your PC once you click on the artifact (named **"artifact"**). When download is ready click on **Save as** and save it in your preferred destination folder

- Open the destination folder and right click on the zip file and then click on **Extract All**

- Leave the default destination folder to extract and click on **Extract**

#### 2. Instructions to run the application locally after extracting the files

- Click on the extracted folder and then on **release>win-x64** folder, which includes the files of the binary

- Double click on **WebApi.exe**. The application is now running on your local machine. 

- A Command Line window will pop up, displaying 2 links for the local machine currently making the request (format: <http://localhost:xxxx>): navigate to one of them by copy-pasting it in your browser

- ``Hello World`` is then displayed in the localhost window

- Press ```Ctrl + C``` to shut down (make sure to click inside the command line window before pressing)