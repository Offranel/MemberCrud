using System;
using System.Collections.Generic;
using System.Text;

namespace MemberCrud.Models 
{
    // The ministry 


    /// <summary>
    /// Gets or sets the unique identifier for the Ministry entity.
    /// </summary>
    public class Ministry
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Description { get; set; }
    }
}
