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
                return ConfigurationManager.ConnectionStrings["KtsCleaning.Properties.Settings.spectrConnectionString"].ToString();
            }
        }
    }
}
