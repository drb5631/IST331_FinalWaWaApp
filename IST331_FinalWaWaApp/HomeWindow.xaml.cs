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

        BreakfastWindow bw;
        BeveragesWindow bevW;
        LunchDinnerWindow ld;

        public MainWindow(BreakfastWindow breakfastWindow, BeveragesWindow beveragesWindow, LunchDinnerWindow lunchDinnerWindow) {
            InitializeComponent();
            this.bw = breakfastWindow;
            bw = new BreakfastWindow(this, bevW, ld);
            this.bevW = beveragesWindow;
            bevW = new BeveragesWindow(this, bw, ld);
            this.ld = lunchDinnerWindow;
            ld = new LunchDinnerWindow(this, bevW, bw);
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

        }

        private void BtnBreakfast_Click(object sender, RoutedEventArgs e) {
            bw.Show();
            this.Hide();
        }

        private void BeverageButton(object sender, RoutedEventArgs e) {
            bevW.Show();
            this.Hide();
        }

        private void LunchDinerButton_Click(object sender, RoutedEventArgs e) {
            ld.Show();
            this.Hide();
        }

        private void CompleteOrder_Click(object sender, RoutedEventArgs e) {
            string[] orderItems = orderBox.Items.OfType<string>().ToArray();
            if (orderItems.Length != 0) {
                Random random = new Random();
                double total = 0.0;
                List<double> itemPrices = new List<double>();
                foreach (string item in orderItems) {
                    double itemPrice = Double.Parse(item.Substring(item.IndexOf("$") + 1));
                    total = total + itemPrice;
                }

                int orderNumber = random.Next(1, 101);
                MessageBox.Show("Your order is being made. Please pay at the register before picking up. \nThank you for choosing Wawa!\nOrder Number: " + orderNumber + "\nOrder Total: $" + total);
                BeginWindow beginWindow = new BeginWindow();
                this.Close();
                beginWindow.Show();
            }
            else {
                MessageBox.Show("You have not selected andy items. Please choose your desired items and then complete your order\n" +
                    "If you have decided to cancel your, please select 'Cancel Order'\nThank you!");
            }
        }

        private void CancelOrder_Click(object sender, RoutedEventArgs e) {
            Application.Current.Shutdown();
        }

        private void OrderBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }

        private void ClearOrder_Click(object sender, RoutedEventArgs e) {
            orderBox.Items.Clear();
            ld.orderBox.Items.Clear();
            bevW.orderBox.Items.Clear();
            bw.orderBox.Items.Clear();
        }
    }
}
