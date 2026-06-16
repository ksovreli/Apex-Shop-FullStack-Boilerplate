# AI-Powered E-Commerce Boilerplate (.NET 8 Web API + Angular) 🚀

A production-ready, clean-architecture full-stack e-commerce foundation with built-in Identity, JWT, Cart, Wishlist, and advanced security.

## 🛠️ Tech Stack & Architecture
* **Backend:** .NET 8 Web API utilizing C# modern features.
* **Database:** SQL Server with a completely pre-made, production-ready `deploy.sql` script (including seed data).
* **Authentication:** Full ASP.NET Core Identity with Roles (Admin/User) and secure JWT Tokens.
* **Frontend:** Angular SPA with custom SCSS styling and component-driven architecture.

## ✨ Core Features Included
* 🛒 **Complete Cart & Wishlist System:** Robust backend logic tied directly to secure user JWT claims (Fully protected against IDOR vulnerabilities).
* 📦 **Order & Checkout Flow:** Order history logging, status management (Pending, etc.), and tracking capabilities.
* 🔒 **Enterprise-Grade Security:** Strict controller-level authorization (`[Authorize(Roles = "Admin")]`), robust file upload extension filtering (.jpg/.png/.webp), and global model state validation.
* 🤖 **AI-Ready Core:** Perfectly structured architecture to serve dynamically generated product assets.
* 📝 **Review & Rating System:** Complete CRUD logic for product reviews with built-in conflict prevention.

## 🚀 How to Setup
1. Clone or download this repository.
2. Open SQL Server Management Studio (SSMS) and run the `deploy.sql` script to automatically create and seed the `BackpackStoreDB` database.
3. Open `appsettings.json` in the backend project, update your connection string, and set your JWT Secret Key.
4. Run the backend (.NET 8) and frontend (Angular) projects.
