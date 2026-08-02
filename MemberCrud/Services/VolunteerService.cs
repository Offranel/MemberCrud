using Microsoft.Data.SqlClient;
using MemberCrud.Models;
using System;
using System.Collections.Generic;

namespace MemberCrud.Services;

public class VolunteerService
{
    private readonly string connectionString =
        "Server=(localdb)\\MSSQLLocalDB;Database=MemberCrud;Trusted_Connection=True;";

    public void SendVolunteerMessage(VolunteerMessage message)
    {
        using SqlConnection connection = new(connectionString);

        connection.Open();

        string sql = @"INSERT INTO VolunteerMessages
                      (MemberId, MessageText, SentAt)
                      VALUES
                      (@MemberId, @MessageText, @SentAt)";

        using SqlCommand command = new(sql, connection);

        command.Parameters.AddWithValue("@MemberId", message.MemberId);
        command.Parameters.AddWithValue("@MessageText", message.MessageText);
        command.Parameters.AddWithValue("@SentAt", message.SentAt);

        command.ExecuteNonQuery();
    }

    public List<VolunteerMessage> GetMessageHistory()
    {
        List<VolunteerMessage> messages = new();

        using SqlConnection connection = new(connectionString);

        connection.Open();

        string sql = "SELECT * FROM VolunteerMessages";

        using SqlCommand command = new(sql, connection);
        using SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            VolunteerMessage message = new VolunteerMessage
            {
                Id = Convert.ToInt32(reader["Id"]),
                MemberId = Convert.ToInt32(reader["MemberId"]),
                MessageText = reader["MessageText"].ToString(),
                SentAt = Convert.ToDateTime(reader["SentAt"])
            };

            messages.Add(message);
        }

        return messages;
    }
}
