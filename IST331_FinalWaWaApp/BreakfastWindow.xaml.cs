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
using System.Windows.Shapes;

namespace IST331_FinalWaWaApp {
    /// <summary>
    /// Interaction logic for BreafastWindow.xaml
    /// </summary>
    public partial class BreakfastWindow : Window {
        MainWindow mainParent;
        BeveragesWindow bevParent;
        LunchDinnerWindow ldParent;

        public BreakfastWindow(MainWindow mainWindow, BeveragesWindow bevW, LunchDinnerWindow ld) {
            mainParent = mainWindow;
            bevParent = bevW;
            ldParent = ld;
            InitializeComponent();
        }

        private void SecondBreakfastBackBtn_Click(object sender, RoutedEventArgs e) {
            mainParent.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

        }

        private void ListBox_SelectionChanged(object sender, RoutedEventArgs e) {

        }

        private void EggSandwich_Click(object sender, RoutedEventArgs e) {
            orderBox.Items.Add("Egg Sandwich - $3.26");
            mainParent.orderBox.Items.Add("Egg Sandwich - $3.26");
            bevParent.orderBox.Items.Add("Egg Sandwich - $3.26");
            ldParent.orderBox.Items.Add("Egg Sandwich - $3.26");
        }

        private void Bagel_Click(object sender, RoutedEventArgs e) {
            orderBox.Items.Add("Bagel - $2.26");
            mainParent.orderBox.Items.Add("Bagel - $2.26");
            bevParent.orderBox.Items.Add("Bagel - $2.26");
            ldParent.orderBox.Items.Add("Bagel - $2.26");
        }

        private void Burrito2_Click(object sender, RoutedEventArgs e) {
            orderBox.Items.Add("Breakfast Buritto - $4.26");
            mainParent.orderBox.Items.Add("Breakfast Buritto - $4.26");
            bevParent.orderBox.Items.Add("Breakfast Buritto - $4.26");
            ldParent.orderBox.Items.Add("Breakfast Buritto - $4.26");
        }

        private void ClearOrder_Click(object sender, RoutedEventArgs e) {
            orderBox.Items.Clear();
            mainParent.orderBox.Items.Clear();
            bevParent.orderBox.Items.Clear();
            ldParent.orderBox.Items.Clear();
        }
    }
}
