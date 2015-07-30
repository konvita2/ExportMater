using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExportMater
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WorkingEnv env;

        public MainWindow()
        {
            InitializeComponent();

            env = new WorkingEnv();
            this.DataContext = env;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            DataProcessor dp = new DataProcessor();
            SpectrXmlWriter sxw = new SpectrXmlWriter(env.OutputFile);
            sxw.PrepareData(dp);
            sxw.MakeXml();
            sxw.UploadSortament();
            sxw.UploadGrupmater();
            sxw.UploadHimsostav();
            sxw.UploadPostavka();

            MessageBox.Show("Выгружено!");
        }
    }
}
