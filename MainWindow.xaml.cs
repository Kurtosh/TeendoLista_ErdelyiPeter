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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TeendoLista_ErdelyiPeter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //listaElemekBetoltese();
            //toroltElemekBetoltese();
        }

       /* private void toroltElemekBetoltese()
        {
            string eleresiUt2 = @"D:\GitHubP1\TeendoLista_ErdelyiPeter\bin\Debug\torolt.txt";
            if (File.Exists(eleresiUt2))
            {
                var be = File.ReadAllLines("torolt.txt");
                elemekListaja.ItemsSource = be;
            }
            
        }

        private void listaElemekBetoltese()
        {
            string eleresiUt = @"D:\GitHubP1\TeendoLista_ErdelyiPeter\bin\Debug\meglevo.txt";
            if (File.Exists(eleresiUt))
            {
                var be = File.ReadAllLines("meglevo.txt");
                elemekListaja.ItemsSource = be;
            }
            
        }*/

        private void feladatHozzaadas_Click(object sender, RoutedEventArgs e)
        {
            elemekListaja.Items.Add(new CheckBox() {Content = feladatNeve.Text });

            
        }

        private void feladatModositas_Click(object sender, RoutedEventArgs e)
        {
            int index = elemekListaja.SelectedIndex;
            elemekListaja.Items.RemoveAt(index);
            elemekListaja.Items.Insert(index, new CheckBox() { Content = feladatNeve.Text });

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void feladatTorles_Click(object sender, RoutedEventArgs e)
        {
            int index = elemekListaja.SelectedIndex;
            string szoveg = ((CheckBox)elemekListaja.SelectedItem).Content.ToString();
            elemekListaja.Items.RemoveAt(index);
            toroltElemLista.Items.Add(new CheckBox() { Content = szoveg });
        }

        private void feladatVisszaalitas_Click(object sender, RoutedEventArgs e)
        {
            int index = toroltElemLista.SelectedIndex;
            string szoveg = ((CheckBox)toroltElemLista.SelectedItem).Content.ToString();
            toroltElemLista.Items.RemoveAt(index);
            elemekListaja.Items.Add(new CheckBox() { Content = szoveg });
        }

        private void feladatVeglegTorlese_Click(object sender, RoutedEventArgs e)
        {
            int index = toroltElemLista.SelectedIndex;
            toroltElemLista.Items.RemoveAt(index);
        }

       /* private void Window_Closed(object sender, EventArgs e)
        {
            string eleresiUt = @"D:\GitHubP1\TeendoLista_ErdelyiPeter\bin\Debug\meglevo.txt";
                List<string> listaElemek = new List<string>();
                string[] elemLista = elemekListaja.Items.OfType<string>().ToArray();
                for (int i = 0; i < elemLista.Length; i++)
                {
                listaElemek[i] = elemLista[i];
                }
                File.WriteAllLines(eleresiUt, listaElemek);
            string eleresiUt2 = @"D:\GitHubP1\TeendoLista_ErdelyiPeter\bin\Debug\torolt.txt";
                List<string> toroltElemek = new List<string>();
            string[] toroltLista = toroltElemLista.Items.OfType<string>().ToArray();
            for (int i = 0; i < toroltLista.Length; i++)
                {
                    toroltElemek[i] = toroltLista[i];
                }
                File.WriteAllLines(eleresiUt2, toroltElemek);
        }*/
    }
}
