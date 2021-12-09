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
        }

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
    }
}
