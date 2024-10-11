# BootcampFinalProject

## **Backend Project Installation**

To run Backend, follow these steps:

1. Clone the repository: **`git clone https://github.com/hrnoguz27/BootcampFinalProject.git`**
2. Navigate to the project directory: **`cd BootcampFinalProject`**
4. Open solution with VS or VS Code
5. Open terminal and update migrations: **`dotnet ef database update -c AppDbContext -p .\BootcampFinalProject`**
6. Start the project: **`dotnet run -p .\BootcampFinalProject`**
7. Save the listening on port for frontend. **`Now listening on: http://localhost:{your_port}`**

## **Frontend Project Installation**

To run Frontend, follow these steps:

1. Clone the repository: **`git clone https://github.com/hrnoguz27/BootcampFinalProject.git`**
2. Navigate to the project directory: **`cd BootcampFinalProject`**
3. Navigate to the frontend project: **`cd BootcampFinalProject.Client`**
4. Run given command to open project with VS Code: **`code .`**
5. Open terminal and Install dependencies: **`npm install`**
6. Change the apiUrl with your URL : **`Open src/environments/environment.ts file and change "apiURL" and "resourceUrl" with your saved backend port`**
7. Start the project: **`ng serve --open`**
