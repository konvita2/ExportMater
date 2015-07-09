using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ExportMater
{
    class LocalConfig
    {
        public static string SpectrConnString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ExportMater.Properties.Settings.spectrConnectionString"].ToString();
            }
        }

        public static string OutputFile
        {
            get
            {
                return Properties.Settings.Default.spectrOutputFile;                
            }
        }
    }
}
