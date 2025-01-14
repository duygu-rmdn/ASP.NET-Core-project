﻿namespace RentHome.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Identity;
    using RentHome.Data.Common.Models;

    using static RentHome.Common.GlobalConstants;

    public class ApplicationUser : IdentityUser, IAuditInfo, IDeletableEntity
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid().ToString();

            this.Properties = new HashSet<Property>();
            this.Rentals = new HashSet<Rental>();
            this.ManagedProperties = new HashSet<Property>();
            this.Contracts = new HashSet<Contract>();
            this.Votes = new HashSet<Vote>();

            this.Roles = new HashSet<IdentityUserRole<string>>();
            this.Claims = new HashSet<IdentityUserClaim<string>>();
            this.Logins = new HashSet<IdentityUserLogin<string>>();
        }

        [Required]
        [MinLength(UsersNameMin)]
        [MaxLength(UsersNameMax)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(UsersNameMin)]
        [MaxLength(UsersNameMax)]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        public Image ProfilePic { get; set; }

        public DateTime RegisteredAt { get; set; } = DateTime.UtcNow;

        [MaxLength(AboutMaxLength)]
        public string About { get; set; }

        // Collections
        public virtual ICollection<Property> Properties { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }

        public virtual ICollection<Property> ManagedProperties { get; set; }

        public virtual ICollection<Contract> Contracts { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; set; }

        public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }

        public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }

        public ICollection<Vote> Votes { get; set; }

        // Audit info
        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        // Deletable entity
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
