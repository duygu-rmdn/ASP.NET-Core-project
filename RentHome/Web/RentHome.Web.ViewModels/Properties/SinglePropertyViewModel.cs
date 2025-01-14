﻿namespace RentHome.Web.ViewModels.Properties
{
    using System.Collections.Generic;

    using RentHome.Web.ViewModels.ContactUs;
    using RentHome.Web.ViewModels.Rental;

    public class SinglePropertyViewModel
    {
        public string Id { get; set; }

        public IEnumerable<string> ImageUrls { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string CaregoryName { get; set; }

        public string StatusName { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string OwnerFirstName { get; set; }

        public string OwnerLastName { get; set; }

        public string OwnerUsername { get; set; }

        public string OwnerEmail { get; set; }

        public string MenagerUsername { get; set; }

        public double AverageVote { get; set; }

        public bool IsPublic { get; set; }

        public ContactInputModel Contact { get; set; }

        public IEnumerable<MyPropertyRequestsViewModel> Requests { get; set; }
    }
}
