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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public MainWindow() {
            InitializeComponent();
        }

        BeveragesWindow bevW;
        BreakfastWindow bw;
        LunchDinnerWindow ld;

        private void Button_Click(object sender, RoutedEventArgs e) {

        }

        private void BtnBreakfast_Click(object sender, RoutedEventArgs e) {
            bw = new BreakfastWindow(this);
            bw.Show();
            this.Hide();
        }

        private void BeverageButton(object sender, RoutedEventArgs e) {
            bevW = new BeveragesWindow(this);
            bevW.Show();
            this.Hide();
        }

        private void LunchDinerButton_Click(object sender, RoutedEventArgs e) {
            ld = new LunchDinnerWindow(this);
            ld.Show();
            this.Hide();
        }

        private void CompleteOrder_Click(object sender, RoutedEventArgs e) {
            Random random = new Random();
            double total = 0.0;
            string[] orderItems = orderBox.Items.OfType<string>().ToArray();
            List<double> itemPrices = new List<double>();
            foreach (string item in orderItems) {
                double itemPrice = Double.Parse(item.Substring(item.IndexOf("$") + 1));
                //double itemPrice = Double.Parse(item.Substring(start, end));
               itemPrices.Add(itemPrice);
               total = total + itemPrice;
            }

            int orderNumber = random.Next(1, 101);
            MessageBox.Show("Your order is being made. Please pay at the register before picking up. \nThank you for choosing Wawa!\nOrder Number: " + orderNumber + "\nOrder Total: $" + total);
            BeginWindow beginWindow = new BeginWindow();
            this.Hide();
            beginWindow.Show();
        }

        private void CancelOrder_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        }

        private void OrderBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }
    }
}
