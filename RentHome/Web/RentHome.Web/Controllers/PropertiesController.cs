﻿namespace RentHome.Web.Controllers
{
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using RentHome.Services.Data;
    using RentHome.Web.ViewModels.Properties;

    public class PropertiesController : Controller
    {
        private readonly ICityService cityService;
        private readonly ICountryService countryService;
        private readonly IPropertyService propertyService;

        public PropertiesController(
            ICityService cityService,
            ICountryService countryService,
            IPropertyService propertyService)
        {
            this.cityService = cityService;
            this.countryService = countryService;
            this.propertyService = propertyService;
        }

        public async Task<IActionResult> Create()
        {
            var cities = await this.cityService.AllCitiesAsync();
            var countries = await this.countryService.AllCountriesAsync();

            var model = new CreatePropertyInputModel
            {
                CityList = cities,
                CountryList = countries,
            };

            return this.View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreatePropertyInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.propertyService.CreateAsync(input);

            // TODO: redirect to Property info page
            return this.Redirect("/");
        }
    }
}
