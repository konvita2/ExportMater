using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace ExportMater
{
    [Table(Name="dosp")]
    public class Dosp
    {
        [Column(IsPrimaryKey=true, IsDbGenerated=true, Name="nozap")]
        public int Nozap { get; set; }

        [Column(Name = "kod")]
        public int Kod { get; set;}

        [Column(Name="vid")]
        public int Vid { get; set; }

        [Column(Name = "im")]
        public string Im { get; set; }

        
        [Column(Name = "sim")]
        public string Sim { get; set; }

        
        [Column(Name = "us")]
        public decimal Us { get; set; }

        
        [Column(Name = "obor")]
        public string Obor { get; set; }
        
        
    }
}
