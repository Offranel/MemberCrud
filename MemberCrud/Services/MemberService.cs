using MemberCrud.Data;
using MemberCrud.Models;
using System.Collections.Generic;
using System.Linq;

namespace MemberCrud.Services;

/// <summary>
/// Provides database operations for church members.
/// 
/// This service uses Entity Framework Core to communicate with the
/// MemberCrud SQL Server database through <see cref="MemberCrudDbContext"/>.
/// 
/// The service separates the Windows Forms user interface from the
/// database logic. Forms can call these methods without needing to know
/// how the data is stored or retrieved.
/// </summary>
public class MemberService
{
    /// <summary>
    /// Retrieves all members stored in the Members table.
    /// </summary>
    /// <returns>
    /// A <see cref="List{Member}"/> containing all members currently
    /// stored in the database.
    /// </returns>
    /// <remarks>
    /// Entity Framework Core reads the Members table and converts
    /// each database record into a Member object.
    /// </remarks>
    public List<Member> GetAllMembers()
    {
        // Creates a temporary database context used to communicate
        // with the MemberCrud database.
        using MemberCrudDbContext db = new();

        // Retrieves all records from the Members table and converts
        // the results into a List of Member objects.
        return db.Members.ToList();
    }

    /// <summary>
    /// Adds a new member to the Members table.
    /// </summary>
    /// <param name="member">
    /// The Member object containing the information that will be
    /// stored in the database.
    /// </param>
    /// <remarks>
    /// The member is first added to Entity Framework's change tracker.
    /// SaveChanges then sends the INSERT operation to the SQL Server
    /// database.
    /// </remarks>
    public void AddMember(Member member)
    {
        // Creates a database context for this operation.
        using MemberCrudDbContext db = new();

        // Marks the Member object as a new record that should
        // be inserted into the Members table.
        db.Members.Add(member);

        // Saves the new member to the SQL Server database.
        db.SaveChanges();
    }

    /// <summary>
    /// Deletes an existing member from the Members table.
    /// </summary>
    /// <param name="member">
    /// The Member object representing the database record that
    /// should be deleted.
    /// </param>
    /// <remarks>
    /// Entity Framework marks the member for deletion.
    /// SaveChanges then sends the DELETE operation to the database.
    /// </remarks>
    public void DeleteMember(Member member)
    {
        // Creates a database context for this operation.
        using MemberCrudDbContext db = new();

        // Marks the selected member as a record that should
        // be removed from the Members table.
        db.Members.Remove(member);

        // Applies the deletion to the SQL Server database.
        db.SaveChanges();
    }
}