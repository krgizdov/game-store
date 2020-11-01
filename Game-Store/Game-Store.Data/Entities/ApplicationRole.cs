using Microsoft.AspNetCore.Identity;
using System;

namespace Game_Store.Data.Entities
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public ApplicationRole()
            : this(null)
        {
        }

        public ApplicationRole(string name)
            : base(name)
        {
            Id = Guid.NewGuid();
            IsDeleted = false;
        }

        public bool IsDeleted { get; set; }
    }
}
