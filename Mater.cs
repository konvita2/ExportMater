using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace ExportMater
{
    [Table(Name="mater")]
    public class Mater
    {        
        [Column(Name="nsk", IsPrimaryKey=true)]
        public decimal Nsk { get; set; }

        [Column(Name = "naim")]
        public string Naim { get; set; }
               
        [Column(Name="gr")]
        public decimal Gr { get; set; }

        [Column(Name = "sort")]
        public decimal Sort { get; set; }

        [Column(Name = "sp")]
        public decimal Sp { get; set; }

        [Column(Name = "sh")]
        public decimal Sh { get; set; }

        [Column(Name = "kod")]
        public string Kod { get; set; }

        [Column(Name = "kodm")]
        public decimal Kodm { get; set; }

        [Column(Name = "tm")]
        public decimal Tm { get; set; }

        [Column(Name = "dm")]
        public decimal Dm { get; set; }

        [Column(Name = "nsort")]
        public decimal Nsort { get; set; }

        [Column(Name = "dp")]
        public decimal Dp { get; set; }

        [Column(Name = "shp")]
        public decimal Shp { get; set; }

        [Column(Name = "ps")]
        public decimal Ps { get; set; }

        [Column(Name = "ei")]
        public string Ei { get; set; }

        [Column(Name = "cena")]
        public decimal Cena { get; set; }
        
        [Column(Name = "kol")]
        public decimal Kol { get; set; }

        [Column(Name = "oboz")]
        public string Oboz { get; set; }

        [Column(Name = "pol")]
        public decimal Pol { get; set; }

        [Column(Name = "tver")]
        public decimal Tver { get; set; }

        [Column(Name = "sklad")]
        public decimal Sklad { get; set; }
        
        [Column(Name = "rekom")]
        public bool Rekom { get; set; }

        [Column(Name = "v1000")]
        public decimal V1000 { get; set; }

        [Column(Name = "ei1")]
        public string Ei1 { get; set; }
    }
}
