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

namespace IST331_FinalWaWaApp {
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class BeveragesWindow : Window {
        MainWindow parent;

        public BeveragesWindow(MainWindow mainWindow) {
            parent = mainWindow;
            InitializeComponent();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e) {
            parent.Show();
            this.Hide();
        }
        private void ClearOrderBtn_Click(object sender, RoutedEventArgs e) {
            orderBox.Items.Clear();
        }

        private void ColdbrewButton(object sender, RoutedEventArgs e) {

            orderBox.Items.Add("Cold Brew/Iced Coffee - $2.26");
            parent.orderBox.Items.Add("Cold Brew/Iced Coffee - $2.26");
        }

        private void Fruitsmoothie_Click(object sender, RoutedEventArgs e) {

            orderBox.Items.Add("Fruit Smoothies - $2.53");
            parent.orderBox.Items.Add("Fruit Smoothies - $2.53");

        }
        private void Chaitea_Click(object sender, RoutedEventArgs e) {

            orderBox.Items.Add("Chai Tea - $2.79");
            parent.orderBox.Items.Add("Chai Tea - $2.79");
        }

        private void Lattes_Click(object sender, RoutedEventArgs e) {
            orderBox.Items.Add("Lattes - $2.69");
            parent.orderBox.Items.Add("Lattes - $2.69");
        }
    }
}
