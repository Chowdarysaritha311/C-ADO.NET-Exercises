using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static string connectionString = @"Server=localhost;Database=TestDB;Trusted_Connection=True;";

    static void Main()
    {
        InsertEmployee(1, "Alice", 50000);
        ReadEmployees();
        UpdateEmployee(1, 55000);
        DeleteEmployee(1);
    }

    static void InsertEmployee(int id, string name, decimal salary)
    {
        using SqlConnection con = new SqlConnection(connectionString);
        string query = "INSERT INTO Employees (Id, Name, Salary) VALUES (@Id, @Name, @Salary)";
        using SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@Id", id);
        cmd.Parameters.AddWithValue("@Name", name);
        cmd.Parameters.AddWithValue("@Salary", salary);
        con.Open();
        cmd.ExecuteNonQuery();
        Console.WriteLine("Inserted employee");
    }

    static void ReadEmployees()
    {
        using SqlConnection con = new SqlConnection(connectionString);
        string query = "SELECT * FROM Employees";
        using SqlCommand cmd = new SqlCommand(query, con);
        con.Open();
        using SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Console.WriteLine($"Id: {reader["Id"]}, Name: {reader["Name"]}, Salary: {reader["Salary"]}");
        }
    }

    static void UpdateEmployee(int id, decimal newSalary)
    {
        using SqlConnection con = new SqlConnection(connectionString);
        string query = "UPDATE Employees SET Salary = @Salary WHERE Id = @Id";
        using SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@Salary", newSalary);
        cmd.Parameters.AddWithValue("@Id", id);
        con.Open();
        cmd.ExecuteNonQuery();
        Console.WriteLine("Updated employee salary");
    }

    static void DeleteEmployee(int id)
    {
        using SqlConnection con = new SqlConnection(connectionString);
        string query = "DELETE FROM Employees WHERE Id = @Id";
        using SqlCommand cmd = new SqlCommand(query, con);
        cmd.Parameters.AddWithValue("@Id", id);
        con.Open();
        cmd.ExecuteNonQuery();
        Console
