﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Entity.Entities.Tariffs;
using Entity.Entities.Contacts;
using System.ComponentModel.DataAnnotations;

namespace Entity.Entities.Countries
{
    public class Country : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Image { get; set; }
        public bool HasLiquid { get; set; }
        public bool IsDeleted { get; set; }
        //public IFormFile Photo { get; set; }
        public virtual ICollection<Tariff> Tariffs { get; set; }
        public virtual ICollection<CountryContact> CountryContacts { get; set; }
    }
}
