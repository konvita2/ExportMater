using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using System.Configuration;



namespace ExportMater
{
    [Database(Name = "spectr")]
    public class SpectrDB : DataContext
    {    
        public SpectrDB() : base(LocalConfig.SpectrConnString)
        { 
                
        }

        public Table<Mater> Maters;
        public Table<Dosp> Dosps;


    }
}
