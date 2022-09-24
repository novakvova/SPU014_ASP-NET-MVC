using Microsoft.AspNetCore.Identity;
using System.Collections;
using System.Collections.Generic;

namespace WebShop.Data.Entities
{
    public class RoleEntity : IdentityRole<int>
    {
        public virtual ICollection<UserRoleEntity> UserRoles { get; set; }
    }
}
