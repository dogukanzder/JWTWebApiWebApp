namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USERS
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string ADI { get; set; }

        [StringLength(50)]
        public string SOYADI { get; set; }

        [StringLength(50)]
        public string KULLANICI_ADI { get; set; }

        [StringLength(50)]
        public string SIFRE { get; set; }
    }
}
