using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Z12_resconov
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Model = new Model();

            this.DataContext = Model;
        }

        public Model Model;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["Brush"] = new SolidColorBrush(Colors.Aqua);
        }

        private void LoadStyles()
        {
            string filename = Environment.CurrentDirectory + @"\Dictionary3.xaml";

            if (File.Exists(filename))
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    ResourceDictionary dic = (ResourceDictionary)XamlReader.Load(fs);

                    Resources.MergedDictionaries.Add(dic);
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LoadStyles();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Model.Zoom += 10;
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {

        }
    }
}
