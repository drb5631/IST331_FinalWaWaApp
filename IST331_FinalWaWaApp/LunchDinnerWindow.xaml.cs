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
    /// Interaction logic for LunchDinnerWindow.xaml
    /// </summary>
    public partial class LunchDinnerWindow : Window {
        MainWindow mainParent;
        BeveragesWindow bevParent;
        BreakfastWindow bParent;

        public LunchDinnerWindow(MainWindow mainWindow, BeveragesWindow beveragesWindow, BreakfastWindow breakfastWindow) {
            mainParent = mainWindow;
            bevParent = mainParent.GetBeveragesWindow();
            bParent = mainParent.GetBreakfastWindow();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

        }

        private void hotSandwichesBackBtn_Click(object sender, RoutedEventArgs e) {
            this.Hide();
            mainParent.Show();
        }

        private void Chickensandwiches_Click(object sender, RoutedEventArgs e) {
            orderBox.Items.Add("Chicken Sandwich - $4.26");
            mainParent.orderBox.Items.Add("Chicken Sandwich - $4.26");
            bevParent.orderBox.Items.Add("Chicken Sandwich - $4.26");
            bParent.orderBox.Items.Add("Chicken Sandwich - $4.26");
        }

        private void Meatballsub_Click(object sender, RoutedEventArgs e) {
            orderBox.Items.Add("Meatball Sandwich - $4.26");
            mainParent.orderBox.Items.Add("Meatball Sandwich - $4.26");
            bevParent.orderBox.Items.Add("Meatball Sandwich - $4.26");
            bParent.orderBox.Items.Add("Meatball Sandwich - $4.26");
        }

        private void Flatbreads_Click(object sender, RoutedEventArgs e) {
            orderBox.Items.Add("Flatbread - $3.26");
            mainParent.orderBox.Items.Add("Flatbread - $3.26");
            bevParent.orderBox.Items.Add("Flatbread - $3.26");
            bParent.orderBox.Items.Add("Flatbread - $3.26");
        }

        private void ClearOrderButton_Click(object sender, RoutedEventArgs e) {
            orderBox.Items.Clear();
            mainParent.orderBox.Items.Clear();
            bevParent.orderBox.Items.Clear();
            bParent.orderBox.Items.Clear();
        }
    }
}
