using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportMater
{
    /**
     * класс для рабочего окружения
     * тут
     * - строка подключения
     * - файл сохранения
     * */
    class WorkingEnv
    {
        private string connString = "";
        private string outputFile = "";

        public string ConnString {
            get { return connString; }
            set { connString = value; }
        }

        public string OutputFile {
            get { return outputFile; }
            set { outputFile = value; }        
        }

        public WorkingEnv() {
            connString = LocalConfig.SpectrConnString;
            outputFile = LocalConfig.OutputFile;
        }
    }
}
