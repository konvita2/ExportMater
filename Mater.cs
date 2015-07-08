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
        public int Nsk { get; set; }

        [Column(Name="gr")]
        public int Gr { get; set; }

        [Column(Name = "sort")]
        public int Sort { get; set; }

        [Column(Name = "sp")]
        public int Sp { get; set; }

        [Column(Name = "sh")]
        public int Sh { get; set; }

        [Column(Name = "kod")]
        public string Kod { get; set; }

        [Column(Name = "kodm")]
        public int Kodm { get; set; }

        [Column(Name = "tm")]
        public double Tm { get; set; }

        [Column(Name = "dm")]
        public double Dm { get; set; }

        [Column(Name = "nsort")]
        public double Nsort { get; set; }

        [Column(Name = "dp")]
        public double Dp { get; set; }

        [Column(Name = "shp")]
        public double Shp { get; set; }

        [Column(Name = "ps")]
        public double Ps { get; set; }

        [Column(Name = "ei")]
        public string Ei { get; set; }

        [Column(Name = "cena")]
        public double Cena { get; set; }

        [Column(Name = "kol")]
        public double Kol { get; set; }

        [Column(Name = "naim")]
        public string Naim { get; set; }

        [Column(Name = "oboz")]
        public string Oboz { get; set; }

        [Column(Name = "pol")]
        public double Pol { get; set; }

        [Column(Name = "tver")]
        public double Tver { get; set; }

        [Column(Name = "sklad")]
        public int Sklad { get; set; }

        [Column(Name = "rekom")]
        public bool Rekom { get; set; }

        [Column(Name = "v1000")]
        public double V1000 { get; set; }

        [Column(Name = "ei1")]
        public double Ei1 { get; set; }


    }
}
