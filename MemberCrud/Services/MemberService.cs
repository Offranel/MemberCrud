using Microsoft.Data.SqlClient;
using MemberCrud.Models;
using System;
using System.Collections.Generic;

namespace MemberCrud.Services;

public class MemberService
{
    /// <summary>
    /// Connection string used to connect to the MemberCrud SQL Server database.
    /// </summary>
    private readonly string connectionString =
        "Server=(localdb)\\MSSQLLocalDB;Database=MemberCrud;Trusted_Connection=True;";
    /// <summary>
    /// Retrieves all members from the Members table.
    /// </summary>
    /// <returns>
    /// A list of all members stored in the database.
    /// </returns>
    public List<Member> GetAllMembers()
    {
      
        List<Member> members = new();

        using SqlConnection connection = new(connectionString);

        connection.Open();

        string sql = "SELECT * FROM Members";

        using SqlCommand command = new(sql, connection);
        using SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            Member member = new Member
            {
                Id = Convert.ToInt32(reader["Id"]),
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                Phone = reader["Phone"].ToString(),
                Email = reader["Email"].ToString(),
                MembershipStatus = reader["MembershipStatus"].ToString(),
                CreateAt = Convert.ToDateTime(reader["CreateAt"])
            };

            members.Add(member);
        }

        return members;
    }
    /// <summary>
    /// Adds a new member to the Members table.
    /// </summary>
    /// <param name="member">
    /// The member to add to the database.
    /// </param>
    public void AddMember(Member member)
    {
        using SqlConnection connection = new(connectionString);

        connection.Open();

        string sql = @"INSERT INTO Members
                       (FirstName, LastName, Phone, Email, MembershipStatus, CreateAt)
                       VALUES
                       (@FirstName, @LastName, @Phone, @Email, @MembershipStatus, @CreateAt)";

        using SqlCommand command = new(sql, connection);

        command.Parameters.AddWithValue("@FirstName", member.FirstName);
        command.Parameters.AddWithValue("@LastName", member.LastName);
        command.Parameters.AddWithValue("@Phone", member.Phone);
        command.Parameters.AddWithValue("@Email", member.Email);
        command.Parameters.AddWithValue("@MembershipStatus", member.MembershipStatus);
        command.Parameters.AddWithValue("@CreateAt", member.CreateAt);

        command.ExecuteNonQuery();
    }
    /// <summary>
    /// Deletes a member from the Members table.
    /// </summary>
    /// <param name="member">
    /// The member to delete from the database.
    /// </param>
    public void DeleteMember(Member member)
    {
        using SqlConnection connection = new(connectionString);

        connection.Open();

        string sql = "DELETE FROM Members WHERE Id = @Id";

        using SqlCommand command = new(sql, connection);

        command.Parameters.AddWithValue("@Id", member.Id);

        command.ExecuteNonQuery();
    }
}