using MemberCrud.Data;
using MemberCrud.Models;
using System.Collections.Generic;
using System.Linq;

namespace MemberCrud.Services;

/// <summary>
/// Provides database operations for church ministries.
///
/// This service uses Entity Framework Core to communicate with the
/// MemberCrud SQL Server database through <see cref="MemberCrudDbContext"/>.
///
/// The service separates the Windows Forms user interface from the
/// database logic. Forms can call these methods to add, update, delete,
/// or retrieve ministries without needing to know how the database
/// operations are performed.
/// </summary>
public class MinistryService
{
    /// <summary>
    /// Adds a new ministry to the Ministries table.
    /// </summary>
    /// <param name="ministry">
    /// The Ministry object containing the information that will be
    /// stored in the database.
    /// </param>
    /// <remarks>
    /// Entity Framework first tracks the Ministry object as a new entity.
    /// SaveChanges then sends the INSERT operation to the SQL Server
    /// database.
    /// </remarks>
    public void AddMinistry(Ministry ministry)
    {
        // Creates a temporary database context used to communicate
        // with the MemberCrud database.
        using MemberCrudDbContext db = new();

        // Adds the Ministry object to Entity Framework's change tracker.
        // At this point, the ministry has not yet been saved to SQL Server.
        db.Ministries.Add(ministry);

        // Saves all tracked changes to the SQL Server database.
        // Entity Framework generates and executes the INSERT command.
        db.SaveChanges();
    }

    /// <summary>
    /// Updates an existing ministry in the Ministries table.
    /// </summary>
    /// <param name="ministry">
    /// The Ministry object containing the updated information.
    /// The Id identifies which ministry should be updated.
    /// </param>
    /// <remarks>
    /// Entity Framework marks the Ministry object as modified.
    /// SaveChanges then generates and executes the UPDATE operation
    /// in the SQL Server database.
    /// </remarks>
    public void UpdateMinistry(Ministry ministry)
    {
        // Creates a temporary database context for this operation.
        using MemberCrudDbContext db = new();

        // Tells Entity Framework that this Ministry object already
        // exists in the database and its information has been modified.
        db.Ministries.Update(ministry);

        // Applies the updated values to the database.
        // Entity Framework generates the required UPDATE command.
        db.SaveChanges();
    }

    /// <summary>
    /// Deletes an existing ministry from the Ministries table
    /// using its unique identifier.
    /// </summary>
    /// <param name="id">
    /// The unique Id of the ministry that should be deleted.
    /// </param>
    /// <remarks>
    /// The method first searches the database for a ministry with
    /// the specified Id. If the ministry exists, Entity Framework
    /// marks it for deletion and SaveChanges removes it from the database.
    ///
    /// If no ministry with the specified Id exists, no deletion occurs.
    /// </remarks>
    public void DeleteMinistry(int id)
    {
        // Creates a temporary database context for this operation.
        using MemberCrudDbContext db = new();

        // Searches the Ministries table for a ministry whose
        // primary key matches the provided Id.
        Ministry? ministry = db.Ministries.Find(id);

        // Find() can return null if the ministry does not exist.
        // Therefore, we check the result before attempting deletion.
        if (ministry != null)
        {
            // Marks the Ministry object for deletion.
            // The record is not removed from SQL Server yet.
            db.Ministries.Remove(ministry);

            // Applies the deletion to the database.
            // Entity Framework generates and executes the DELETE command.
            db.SaveChanges();
        }
    }

    /// <summary>
    /// Retrieves all ministries stored in the Ministries table.
    /// </summary>
    /// <returns>
    /// A <see cref="List{Ministry}"/> containing all ministries
    /// currently stored in the database.
    /// </returns>
    /// <remarks>
    /// Entity Framework queries the Ministries table and automatically
    /// converts each database record into a Ministry object.
    ///
    /// ToList() executes the query and returns the results as a list
    /// that can be used by the Windows Forms user interface.
    /// </remarks>
    public List<Ministry> GetAllMinistries()
    {
        // Creates a temporary database context used to communicate
        // with the MemberCrud database.
        using MemberCrudDbContext db = new();

        // Retrieves all records from the Ministries table.
        // Entity Framework converts each database row into
        // a Ministry object and ToList() returns them as a list.
        return db.Ministries.ToList();
    }

    /// <summary>
    /// Retrieves a single ministry by id.
    /// </summary>
    public Ministry? GetMinistryById(int id)
    {
        using MemberCrudDbContext db = new();
        return db.Ministries.Find(id);
    }

    /// <summary>
    /// Returns all members assigned to a specific ministry.
    /// </summary>
    public List<Member> GetMembersForMinistry(int ministryId)
    {
        using MemberCrudDbContext db = new();

        var query = from mm in db.MemberMinistries
                    join m in db.Members on mm.MemberId equals m.Id
                    where mm.MinistryId == ministryId
                    select m;

        return query.ToList();
    }

    /// <summary>
    /// Assigns a member to the specified ministry if not already assigned.
    /// </summary>
    public void AssignMemberToMinistry(int ministryId, int memberId)
    {
        using MemberCrudDbContext db = new();

        bool exists = db.MemberMinistries.Any(x => x.MinistryId == ministryId && x.MemberId == memberId);
        if (exists) return;

        db.MemberMinistries.Add(new MemberMinistry { MinistryId = ministryId, MemberId = memberId });
        db.SaveChanges();
    }

    /// <summary>
    /// Removes the association between a member and a ministry if it exists.
    /// </summary>
    public void RemoveMemberFromMinistry(int ministryId, int memberId)
    {
        using MemberCrudDbContext db = new();

        var mapping = db.MemberMinistries.FirstOrDefault(x => x.MinistryId == ministryId && x.MemberId == memberId);
        if (mapping == null) return;

        db.MemberMinistries.Remove(mapping);
        db.SaveChanges();
    }
}