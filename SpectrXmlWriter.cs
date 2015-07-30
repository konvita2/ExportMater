using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ExportMater
{
    class SpectrXmlWriter
    {
        private string pathXmlFile;
        private List<Dosp> listSortament;
        private List<Dosp> listHimsostav;
        private List<Dosp> listPostavka;
        private List<Dosp> listGrupmater;

        private List<Mater> listMater;

        /**
         * конструктор
         * параметр - имя файла куда будем писать
         * */
        public SpectrXmlWriter(string pathXml)
        {
            this.pathXmlFile = pathXml;
        }

        /**
         * заполнить данными списки для выгрузки
         * */
        public void PrepareData(DataProcessor dp)
        {
            
            listSortament = dp.GetSortamentList();
            listHimsostav = dp.GetHimsostavList();
            listPostavka = dp.GetPostavkaList();
            listGrupmater = dp.GetGrupmaterList();            

            listMater = dp.GetMaterList();
        }

        /**
         * пишем данные в файл xml
         * */
        public void MakeXml() 
        {
            XmlTextWriter textWriter = new XmlTextWriter(pathXmlFile, Encoding.UTF8);
            textWriter.WriteStartDocument();
            textWriter.WriteStartElement("SpectrData");
            textWriter.WriteEndElement();
            textWriter.Close();
        }

        /**
         * создать dosp раздел в файле выгрузки
         * listDosp - один из списков dosp (сортамент, поставка, химсостав, группа материала)
         * elementName - название узла в xml файле: Sortament, Postavka, Himsostav, Grupmater 
         * */
        private void UploadDosp(List<Dosp> listDosp, string elementName) 
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(pathXmlFile);
            XmlNode element = doc.CreateElement(elementName);
            doc.DocumentElement.AppendChild(element);

            foreach (Dosp dosp in listDosp) 
            {
                XmlNode subelem = doc.CreateElement("Item");
                subelem.InnerText = dosp.Im.Trim();

                // kod
                XmlAttribute attr = doc.CreateAttribute("Kod");
                attr.Value = dosp.Kod.ToString();
                subelem.Attributes.Append(attr);

                //obor
                XmlAttribute attrObor = doc.CreateAttribute("Obor");
                attrObor.Value = dosp.Obor.ToString().Trim();
                subelem.Attributes.Append(attrObor);

                //sim
                XmlAttribute attrSim = doc.CreateAttribute("Sim");
                attrSim.Value = dosp.Sim.ToString().Trim();
                subelem.Attributes.Append(attrSim);

                //us
                XmlAttribute attrUs = doc.CreateAttribute("Us");
                attrUs.Value = dosp.Us.ToString().Trim();
                subelem.Attributes.Append(attrUs);

                element.AppendChild(subelem);
            }

            doc.Save(pathXmlFile);
        }

        /*
         * 
         * */
        public void UploadSortament() {
            this.UploadDosp(listSortament, "Sortament");
        }

        /**
         * */
        public void UploadHimsostav()
        {
            this.UploadDosp(listHimsostav, "Himsostav");
        }

        /*
         * */
        public void UploadPostavka()
        {
            this.UploadDosp(listPostavka, "Postavka");
        }

        /**
         * */
        public void UploadGrupmater()
        {
            this.UploadDosp(listGrupmater, "Grupmater");
        }







    }
}
