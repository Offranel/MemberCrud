using MemberCrud.Data;
using MemberCrud.Models;
using System.Collections.Generic;
using System.Linq;

namespace MemberCrud.Services;

/// <summary>
/// Provides database operations for volunteer messages.
///
/// This service uses Entity Framework Core to communicate with the
/// MemberCrud SQL Server database through <see cref="MemberCrudDbContext"/>.
///
/// The service is responsible for saving volunteer messages and
/// retrieving the history of messages stored in the database.
///
/// Windows Forms can call these methods without needing to know
/// how the database connection or SQL operations are implemented.
/// </summary>
public class VolunteerService
{
    /// <summary>
    /// Saves a new volunteer message in the VolunteerMessages table.
    /// </summary>
    /// <param name="message">
    /// The VolunteerMessage object containing the message information
    /// that will be stored in the database.
    ///
    /// The object contains information such as the MemberId,
    /// the message text, and the date and time the message was sent.
    /// </param>
    /// <remarks>
    /// Entity Framework first adds the VolunteerMessage object to
    /// its change tracker as a new entity.
    ///
    /// SaveChanges then generates and executes the required INSERT
    /// operation against the SQL Server database.
    /// </remarks>
    public void SendVolunteerMessage(VolunteerMessage message)
    {
        // Creates a temporary database context used to communicate
        // with the MemberCrud SQL Server database.
        using MemberCrudDbContext db = new();

        // Adds the VolunteerMessage object to Entity Framework's
        // change tracker.
        //
        // At this point, the message is marked as a new entity,
        // but it has not yet been saved to the SQL Server database.
        db.VolunteerMessages.Add(message);

        // Saves all tracked changes to the database.
        //
        // Entity Framework automatically generates an INSERT command
        // using the properties of the VolunteerMessage object.
        db.SaveChanges();
    }

    /// <summary>
    /// Retrieves the complete volunteer message history from
    /// the VolunteerMessages table.
    /// </summary>
    /// <returns>
    /// A <see cref="List{VolunteerMessage}"/> containing all volunteer
    /// messages currently stored in the database.
    /// </returns>
    /// <remarks>
    /// Entity Framework queries the VolunteerMessages table and
    /// automatically converts each database record into a
    /// VolunteerMessage object.
    ///
    /// ToList() executes the query and returns the results as a list
    /// that can be displayed or used by the Windows Forms interface.
    /// </remarks>
    public List<VolunteerMessage> GetMessageHistory()
    {
        // Creates a temporary database context used to communicate
        // with the MemberCrud SQL Server database.
        using MemberCrudDbContext db = new();

        // Retrieves all records from the VolunteerMessages table.
        //
        // Entity Framework automatically maps database columns such as
        // Id, MemberId, MessageText, and SentAt to the corresponding
        // properties in the VolunteerMessage model.
        //
        // ToList() executes the database query and returns the results
        // as a List of VolunteerMessage objects.
        return db.VolunteerMessages.ToList();
    }
}
 