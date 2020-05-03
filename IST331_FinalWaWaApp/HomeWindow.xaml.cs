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
        public BreakfastWindow GetBreakfastWindow() {
            return bw;
        }
        public BeveragesWindow GetBeveragesWindow() {
            return bevW;
        }
        public LunchDinnerWindow GetLunchDinnerWindow() {
            return ld;
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

                int orderNumber = random.Next(100, 1001);
                MessageBox.Show("YOUR ORDER IS BEING MADE! PLEASE PAY BEFORE PICKING UP!\n\nTHANK YOU FOR CHOOSING WAWA!\n\nORDER NUMBER: " + orderNumber + "\nORDER TOTAL: $" + total);
                BeginWindow beginWindow = new BeginWindow();
                this.Close();
                beginWindow.Show();
            }
            else {
                MessageBox.Show("YOU HAVE NOT SELECTED ANY ITEMS.\n\nPLEASE CHOOSE YOUR DESIRED ITEMS AND THEN COMPLETE YOUR ORDER\n\n" +
                    "IF YOU YOU HAVE DECIDED TO CANCEL YOUR ORDER, SELECT 'Cancel Order'\n\nTHANK YOU!");
            }
        }

        private void CancelOrder_Click(object sender, RoutedEventArgs e) {
            BeginWindow beginWindow = new BeginWindow();
            this.Close();
            beginWindow.Show();

        }

        private void OrderBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }

        private void ClearOrder_Click(object sender, RoutedEventArgs e) {
            orderBox.Items.Clear();
            ld.orderBox.Items.Clear();
            bevW.orderBox.Items.Clear();
            bw.orderBox.Items.Clear();
        }

        private void DeleteItem_Click(object sender, RoutedEventArgs e) {
            ld.orderBox.Items.Remove(orderBox.SelectedItem);
            bevW.orderBox.Items.Remove(orderBox.SelectedItem);
            bw.orderBox.Items.Remove(orderBox.SelectedItem);
            orderBox.Items.Remove(orderBox.SelectedItem);
        }
    }
}
