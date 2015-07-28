using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportMater
{
    class DataProcessor
    {
        private SpectrDB db;

        /**
         * constructor
         * */
        public DataProcessor() {
            db = new SpectrDB();

        }

        /// <summary>
        /// получить справочник сотамента материалов
        /// </summary>
        /// <returns></returns>
        public List<Dosp> GetSortamentList(){
            List<Dosp> res = new List<Dosp>();

            IEnumerable<Dosp> query = from dosp in db.Dosps
                                      where (dosp.Vid == 21) && (dosp.Kod != 0)
                                      select dosp;
            foreach (Dosp row in query)
            {
                res.Add(row);
            }

            return res;
        }

        /// <summary>
        /// получить справочник поставок материалов
        /// </summary>
        /// <returns></returns>
        public List<Dosp> GetPostavkaList()
        {
            List<Dosp> res = new List<Dosp>();

            IEnumerable<Dosp> query = from dosp in db.Dosps
                                      where (dosp.Vid == 22) && (dosp.Kod != 0)
                                      select dosp;
            foreach (Dosp row in query)
            {
                res.Add(row);
            }

            return res;
        }

        /// <summary>
        /// получить справочник химсостава материалов
        /// </summary>
        /// <returns></returns>
        public List<Dosp> GetHimsostavList()
        {
            List<Dosp> res = new List<Dosp>();

            IEnumerable<Dosp> query = from dosp in db.Dosps
                                      where (dosp.Vid == 23) && (dosp.Kod != 0)
                                      select dosp;
            foreach (Dosp row in query)
            {
                res.Add(row);
            }

            return res;
        }

        /// <summary>
        /// получить справочник групп материалов
        /// </summary>
        /// <returns></returns>
        public List<Dosp> GetGrupmaterList()
        {
            List<Dosp> res = new List<Dosp>();

            IEnumerable<Dosp> query = from dosp in db.Dosps
                                      where (dosp.Vid == 26) && (dosp.Kod != 0)
                                      select dosp;
            foreach (Dosp row in query)
            {
                res.Add(row);
            }

            return res;
        }

        /// <summary>
        /// получить справочник материалов
        /// </summary>
        /// <returns></returns>
        public List<Mater> GetMaterList() {
            List<Mater> res = new List<Mater>();

            IEnumerable<Mater> query = from mater in db.Maters
                                       orderby mater.Naim
                                       select mater;
            foreach (Mater row in query) {
                res.Add(row);
            }

            return res;
        }





    }
}
