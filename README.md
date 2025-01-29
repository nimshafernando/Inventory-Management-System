
# Inventory Management System 📦

**A Robust Solution for Inventory and Transaction Tracking**  

This Inventory Management System is a desktop application built using **C#** and **Object-Oriented Programming (OOP)** principles, ensuring modularity, maintainability, and scalability. The system is managed through **PHPMyAdmin**, to track and log all transactions comprehensively.

---

## 🌟 Features

### **Inventory Management**
- **Add, Update, Delete Products**: Manage product catalog dynamically with options to modify existing entries or remove obsolete products.
- **Stock Levels**: Real-time monitoring of stock levels, with low-stock alerts to prevent inventory shortages.
- **Product Categorization**: Organize inventory using categories for better navigation and reporting.

### **Transaction Logs**
- **Detailed Logging**: Tracks all inventory movements, including additions, sales, and returns.
- **User Actions**: Records user-specific actions for better traceability and accountability.
- **Timestamps**: Includes timestamps for all transactions to ensure precise records.

### **Reporting**
- **Sales Reports**: Generate reports based on transaction logs to analyze trends and performance.
- **Inventory Reports**: View detailed inventory statuses, including current stock levels and turnover rates.
- **User Activity Reports**: Monitor and evaluate user actions within the system.

### **User Management**
- **Access Control**: Differentiate between admin and regular users for role-specific functionalities.
- **Authentication**: Secure login system to protect sensitive data.

---

## 🛠️ Technologies Used
- **Frontend**: Built with **C#** Windows Forms for an intuitive and user-friendly interface.
- **Backend**: Implemented with OOP concepts for modularity and efficiency.
- **Database**: **PHPMyAdmin** for reliability and ease of use.

---

## 📌 Getting Started  

### **Prerequisites**  
- Windows OS  
- Visual Studio (or any compatible C# IDE)  
- MySQL Server  
- PHPMyAdmin  

### **Installation**
1. **Clone the repository**:  
   ```bash
   git clone https://github.com/your-username/stock-management-system.git  
   cd stock-management-system  
   ```  

2. **Set up the database**:  
   - Open PHPMyAdmin and create a database (e.g., `stock_management`).  
   - Import the provided SQL file (`stock_management.sql`) to set up the tables and default data.  

3. **Configure the connection string**:  
   - In the project, locate the database connection file (e.g., `DatabaseConnection.cs`).  
   - Update the connection string with your MySQL credentials:  
     ```csharp
     string connectionString = "server=localhost;user=root;password=your_password;database=stock_management;";
     ```

4. **Build and Run the Application**:  
   - Open the solution in Visual Studio.  
   - Restore NuGet packages if required.  
   - Build the solution and run the application.  

---

## 📖 Usage
1. **Login**:  
   - Use admin credentials for access to all functionalities.  
   - Regular users have limited permissions.  

2. **Manage Inventory**:  
   - Navigate to the inventory section to add, update, or delete products.  
   - Use filters to sort and find specific items quickly.  

3. **Track Transactions**:  
   - View transaction logs in the reports section.  
   - Export logs for external use, if required.  

4. **Generate Reports**:  
   - Use the reporting tool to gain insights into sales trends, inventory turnover, and user activities.

---

## 🤝 Contribution
Contributions are welcome! Fork the repository, create a branch, and submit a pull request with your improvements.

---

## 📜 License
This project is licensed under the MIT License.
