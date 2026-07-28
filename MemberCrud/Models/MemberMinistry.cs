using System;

namespace MemberCrud.Models
{
    /// <summary>
    /// Gets or sets the unique identifier for the MemberMinistry entity.
    /// </summary>
    public class MemberMinistry
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        public int MinistryId { get; set; }
    }
}
