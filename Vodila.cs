namespace Ekzamen2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vodila")]
    public partial class Vodila
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Фамилия { get; set; }

        [Required]
        [StringLength(50)]
        public string Имя { get; set; }

        [Required]
        [StringLength(50)]
        public string Отчество { get; set; }

        [Required]
        [StringLength(50)]
        public string Паспорт { get; set; }

        [Column("Адрес регистрации")]
        [Required]
        [StringLength(50)]
        public string Адрес_регистрации { get; set; }

        [Column("Адрес проживания")]
        [Required]
        [StringLength(50)]
        public string Адрес_проживания { get; set; }

        [Column("Место работы")]
        [StringLength(50)]
        public string Место_работы { get; set; }

        [StringLength(50)]
        public string Должность { get; set; }

        [Column("Мобильный телефон")]
        [Required]
        [StringLength(50)]
        public string Мобильный_телефон { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "image")]
        public byte[] Фотография { get; set; }

        [StringLength(50)]
        public string Замечания { get; set; }
    }
}
