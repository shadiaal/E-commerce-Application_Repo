# E-commerce Application with Angular and ASP.NET Core

This project is a simple e-commerce application built using Angular for the frontend and ASP.NET Core for the backend. The application allows users to view products, see details, and manage a shopping cart.

## Features

- **Product List**: View a list of products including name, description, price, and image.
- **Product Details**: Click on a product to view its details.
- **Shopping Cart**: Add products to the cart and manage the cart (remove items, view total price).
- **Backend API**: A RESTful API for handling products and cart operations.

## Prerequisites

Before you begin, ensure you have the following installed:

- [Node.js](https://nodejs.org/) (for running Angular)
- [Angular CLI](https://angular.io/cli) (for Angular app)
- [ASP.NET Core SDK](https://dotnet.microsoft.com/download) (for backend API)


## Project Structure

- **Frontend (Angular)**: Located in the `frontend` folder, handles the user interface.
- **Backend (ASP.NET Core)**: Located in the `backend` folder, provides the API for product and cart management.

## Setup Instructions

### 1. Clone the Repository

Clone this repository to your local machine:

```bash git clone <repository-url> cd <repository-name>```


### 2. Frontend Setup (Angular)
Navigate to the frontend folder and install dependencies:
```cd frontend```
```npm install```
Run the Angular development server:
```ng serve```
This will start the Angular app on http://localhost:4200/.

### 3. Backend Setup (ASP.NET Core)
Navigate to the backend folder and restore the NuGet packages:
cd backend
dotnet restore
Run the ASP.NET Core API server:
dotnet run
This will start the API on http://localhost:5129/.

### 4. Access the Application
Open http://localhost:4200/ in your browser to view the Angular frontend.
The backend API will be available at http://localhost:5129/api/products for product data and http://localhost:5129/api/cart for cart operations.
Backend API Endpoints
GET /api/products – Retrieve the list of all products.
GET /api/products/{id} – Retrieve details of a specific product by ID.
POST /api/cart – Add an item to the cart.
GET /api/cart – Retrieve all items in the cart.
DELETE /api/cart/{id} – Remove an item from the cart.
DELETE /api/cart/clear – Clear all items in the cart.


Conclusion
This project is a simple but complete e-commerce application that integrates a frontend Angular app with a backend ASP.NET Core API. It includes features such as viewing product lists, viewing product details, adding to a shopping cart, and managing the cart.


