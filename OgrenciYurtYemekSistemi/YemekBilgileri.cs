using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OgrenciYurtYemekSistemi
{
    [Table("YemekBilgileri", Schema = "dbo")]
    internal class YemekBilgileri
    {
        [Key]
        [Column("GecisID")]
        public int GecisID { get; set; }

        [Required]
        [ForeignKey("OgrenciBilgileri")]
        [Column("OgrenciID")]
        public int OgrenciID { get; set; }

        [Required]
        [Column("Tarih")]
        public DateTime Tarih { get; set; }

        [Required]
        [Column("Saat")]
        public TimeSpan Saat { get; set; }

        [Required]
        [MaxLength(10)]
        [Column("Ögün")]
        public string Ögün { get; set; }

        [Required]
        [Column("YemekDurumu")]
        public byte YemekDurumu { get; set; }

        // Foreign key relationship
        public virtual OgrenciBilgileri OgrenciBilgileri { get; set; }
    }
}