﻿namespace RentHome.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using RentHome.Data.Common.Repositories;
    using RentHome.Data.Models;
    using RentHome.Services.Mapping;

    public class SettingsService : ISettingsService
    {
        private readonly IDeletableEntityRepository<Setting> settingsRepository;

        public SettingsService(IDeletableEntityRepository<Setting> settingsRepository)
        {
            this.settingsRepository = settingsRepository;
        }

        public int GetCount()
            => this.settingsRepository.AllAsNoTracking().Count();

        public IEnumerable<T> GetAll<T>()
            => this.settingsRepository.All().To<T>().ToList();
    }
}
