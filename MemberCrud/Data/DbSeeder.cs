using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace MemberCrud.Data
{
    public static class DbSeeder
    {
        // Connection string must match MemberCrudDbContext.OnConfiguring
        private const string ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=MemberCrud;Trusted_Connection=True;TrustServerCertificate=True;";

        public static void Seed()
        {
            try
            {
                using var conn = new SqlConnection(ConnectionString);
                conn.Open();

                using var cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                // Ministries (use IDENTITY_INSERT to allow explicit Ids)
                cmd.CommandText = @"
SET IDENTITY_INSERT Ministries ON;
IF NOT EXISTS(SELECT 1 FROM Ministries WHERE Id = 1)
    INSERT INTO Ministries (Id, Name, Description) VALUES (1, 'Worship', 'Leads worship and music for services.');
IF NOT EXISTS(SELECT 1 FROM Ministries WHERE Id = 2)
    INSERT INTO Ministries (Id, Name, Description) VALUES (2, 'Children', 'Programs and care for children during services.');
IF NOT EXISTS(SELECT 1 FROM Ministries WHERE Id = 3)
    INSERT INTO Ministries (Id, Name, Description) VALUES (3, 'Outreach', 'Community outreach and service projects.');
SET IDENTITY_INSERT Ministries OFF;
";
                cmd.ExecuteNonQuery();

                // Members (use IDENTITY_INSERT)
                cmd.CommandText = @"
SET IDENTITY_INSERT Members ON;
IF NOT EXISTS(SELECT 1 FROM Members WHERE Id = 1)
    INSERT INTO Members (Id, FirstName, LastName, Phone, Email, MembershipStatus, Street, City, PostalCode, DateOfBirth, CreatedAt)
    VALUES (1, 'Alice', 'Johnson', '555-0100', 'alice.johnson@example.com', 'Active', '123 Maple St', 'Springfield', '12345', '1988-04-12', '2023-01-10 09:00:00');
IF NOT EXISTS(SELECT 1 FROM Members WHERE Id = 2)
    INSERT INTO Members (Id, FirstName, LastName, Phone, Email, MembershipStatus, Street, City, PostalCode, DateOfBirth, CreatedAt)
    VALUES (2, 'Brian', 'Martinez', '555-0111', 'brian.martinez@example.com', 'Active', '45 Oak Ave', 'Springfield', '12345', '1995-07-03', '2023-02-05 14:30:00');
IF NOT EXISTS(SELECT 1 FROM Members WHERE Id = 3)
    INSERT INTO Members (Id, FirstName, LastName, Phone, Email, MembershipStatus, Street, City, PostalCode, DateOfBirth, CreatedAt)
    VALUES (3, 'Carla', 'Nguyen', '555-0122', 'carla.nguyen@example.com', 'Pending', '78 Pine Rd', 'Rivertown', '67890', '2000-11-20', '2024-03-01 08:15:00');
IF NOT EXISTS(SELECT 1 FROM Members WHERE Id = 4)
    INSERT INTO Members (Id, FirstName, LastName, Phone, Email, MembershipStatus, Street, City, PostalCode, DateOfBirth, CreatedAt)
    VALUES (4, 'Daniel', 'Smith', '555-0133', 'daniel.smith@example.com', 'Inactive', '9 Cedar Blvd', 'Lakeside', '24680', '1979-02-28', '2022-11-20 16:45:00');
SET IDENTITY_INSERT Members OFF;
";
                cmd.ExecuteNonQuery();

                // MemberMinistries (use IDENTITY_INSERT)
                cmd.CommandText = @"
SET IDENTITY_INSERT MemberMinistries ON;
IF NOT EXISTS(SELECT 1 FROM MemberMinistries WHERE Id = 1)
    INSERT INTO MemberMinistries (Id, MemberId, MinistryId) VALUES (1,1,1);
IF NOT EXISTS(SELECT 1 FROM MemberMinistries WHERE Id = 2)
    INSERT INTO MemberMinistries (Id, MemberId, MinistryId) VALUES (2,1,3);
IF NOT EXISTS(SELECT 1 FROM MemberMinistries WHERE Id = 3)
    INSERT INTO MemberMinistries (Id, MemberId, MinistryId) VALUES (3,2,1);
IF NOT EXISTS(SELECT 1 FROM MemberMinistries WHERE Id = 4)
    INSERT INTO MemberMinistries (Id, MemberId, MinistryId) VALUES (4,3,2);
SET IDENTITY_INSERT MemberMinistries OFF;
";
                cmd.ExecuteNonQuery();

                // VolunteerMessages (use IDENTITY_INSERT)
                cmd.CommandText = @"
SET IDENTITY_INSERT VolunteerMessages ON;
IF NOT EXISTS(SELECT 1 FROM VolunteerMessages WHERE Id = 1)
    INSERT INTO VolunteerMessages (Id, MemberId, MessageText, SentAt) VALUES (1,1,'Available to lead worship on Sundays.', '2024-06-01 10:00:00');
IF NOT EXISTS(SELECT 1 FROM VolunteerMessages WHERE Id = 2)
    INSERT INTO VolunteerMessages (Id, MemberId, MessageText, SentAt) VALUES (2,3,'Interested in volunteering with the children''s program.', '2024-06-05 12:30:00');
SET IDENTITY_INSERT VolunteerMessages OFF;
";
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"DbSeeder ADO error: {ex}");
                // Do not rethrow; we don't want to crash the UI on startup
            }
        }
    }
}
