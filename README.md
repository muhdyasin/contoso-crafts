# 🛍️ Contoso Crafts

**Contoso Crafts** is a sample **e-commerce web application** built using **ASP.NET Core** and **Blazor**.  
It’s inspired by platforms like Etsy, showcasing handcrafted products with details, images, and user ratings.  
The project was developed as part of learning **C#**, **ASP.NET Core**, **Blazor Server**, and **JSON-based data handling**.

---

## 🚀 Features

- 🧾 **Product Catalog** – Displays a list of handcrafted items with titles, descriptions, and images.  
- 🔍 **Dynamic Data Fetching** – Product data is served from a JSON file using a dedicated service (`JsonFileProductService`).  
- ⭐ **Rating System** – Users can rate products using an interactive star-based UI.  
- 🪄 **Modal Product Details** – Clicking “More Info” opens a Bootstrap modal showing product info and ratings.  
- 🧩 **Component-Based Architecture** – Built using Blazor components for reusable and clean design.  
- 🌐 **Controller Support** – Added API endpoints to fetch product data as JSON.  

---

## 🧠 Learning Objectives

- Understand the **Model–View–Controller (MVC)** and **Razor Pages** architecture in ASP.NET Core.  
- Learn how to use **dependency injection** and **services** in ASP.NET Core.  
- Implement **interactive Blazor components** and event binding.  
- Manage static files and assets in an ASP.NET Core project.  

---

## 🛠️ Tech Stack

| Category | Technology |
|-----------|-------------|
| **Frontend** | Blazor Server, Razor Pages, Bootstrap 5 |
| **Backend** | ASP.NET Core 9.0, C# |
| **Data** | JSON file (Product Data Source) |
| **Version Control** | Git & GitHub |



``` ## 📁 Project Structure
Contoso Crafts/
│
├── Contoso_Crafts.csproj
├── Program.cs
├── Controllers/
├── Components/
├── Models/
├── Pages/
├── Services/
├── wwwroot/
│   ├── css/
│   ├── js/
│   ├── lib/
│   └── data/
│       └── Products.json
```

---

## ▶️ How to Run

1. **Clone the repository**
   ```bash
   git clone https://github.com/<your-username>/ContosoCrafts.git

2. **Open the project** in Visual Studio or VS Code.

3. **Build and run** the application (F5 or dotnet run).

4. Navigate to: https://localhost:5001

 

## 🧩 Future Improvements

- Add product filtering or search functionality.

- Implement user authentication and cart management.

- Store data in a real database (e.g., SQL Server or Azure).

- Deploy using Render, Azure, or another cloud provider.


## 📜 License

This project is licensed under the MIT License — see the LICENSE
 file for details.

## 💡 Acknowledgments

This project is based on the Microsoft Learn Blazor + ASP.NET Core tutorials, extended with additional features like modals and rating logic.
