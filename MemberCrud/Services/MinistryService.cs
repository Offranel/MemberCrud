using Microsoft.Data.SqlClient;
using MemberCrud.Models;
using System;
using System.Collections.Generic;

namespace MemberCrud.Services;

public class MinistryService
{
    private readonly string connectionString =
        "Server=(localdb)\\MSSQLLocalDB;Database=MemberCrud;Trusted_Connection=True;";

    public void AddMinistry(Ministry ministry)
    {
        using SqlConnection connection = new(connectionString);

        connection.Open();

        string sql = @"INSERT INTO Ministries
                      (Name, Description)
                      VALUES
                      (@Name, @Description)";

        using SqlCommand command = new(sql, connection);

        command.Parameters.AddWithValue("@Name", ministry.Name);
        command.Parameters.AddWithValue("@Description", ministry.Description);

        command.ExecuteNonQuery();
    }

    public void UpdateMinistry(Ministry ministry)
    {
        using SqlConnection connection = new(connectionString);

        connection.Open();

        string sql = @"UPDATE Ministries
                      SET Name = @Name,
                          Description = @Description
                      WHERE Id = @Id";

        using SqlCommand command = new(sql, connection);

        command.Parameters.AddWithValue("@Id", ministry.Id);
        command.Parameters.AddWithValue("@Name", ministry.Name);
        command.Parameters.AddWithValue("@Description", ministry.Description);

        command.ExecuteNonQuery();
    }

    public void DeleteMinistry(int id)
    {
        using SqlConnection connection = new(connectionString);

        connection.Open();

        string sql = "DELETE FROM Ministries WHERE Id = @Id";

        using SqlCommand command = new(sql, connection);

        command.Parameters.AddWithValue("@Id", id);

        command.ExecuteNonQuery();
    }

    public List<Ministry> GetAllMinistries()
    {
        List<Ministry> ministries = new();

        using SqlConnection connection = new(connectionString);

        connection.Open();

        string sql = "SELECT * FROM Ministries";

        using SqlCommand command = new(sql, connection);
        using SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            Ministry ministry = new Ministry
            {
                Id = Convert.ToInt32(reader["Id"]),
                Name = reader["Name"].ToString(),
                Description = reader["Description"].ToString()
            };

            ministries.Add(ministry);
        }

        return ministries;
    }
}