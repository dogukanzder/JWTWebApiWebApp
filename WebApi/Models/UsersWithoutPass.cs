using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class UsersWithoutPass
    {
        public int ID { get; set; }

        public string ADI { get; set; }

        public string SOYADI { get; set; }

        public string KULLANICI_ADI { get; set; }
    }
}