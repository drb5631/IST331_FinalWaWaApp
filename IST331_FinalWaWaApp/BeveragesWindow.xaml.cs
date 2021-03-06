﻿using System;
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
    /// Interaction logic for Beverages.xaml
    /// </summary>
    public partial class BeveragesWindow : Window {
        MainWindow mainParent;
        BreakfastWindow bwParent;
        LunchDinnerWindow ldParent;

        public BeveragesWindow(MainWindow mainWindow, BreakfastWindow breakfastWindow, LunchDinnerWindow lunchDinnerWindow) {
            mainParent = mainWindow;
            bwParent = mainParent.GetBreakfastWindow();
            ldParent = mainParent.GetLunchDinnerWindow();
            InitializeComponent();
        }
        private void BackButton_Click(object sender, RoutedEventArgs e) {
            mainParent.Show();
            this.Hide();
        }
        private void ClearOrderBtn_Click(object sender, RoutedEventArgs e) {
            orderBox.Items.Clear();
            mainParent.orderBox.Items.Clear();
            mainParent.GetLunchDinnerWindow().orderBox.Items.Clear();
            mainParent.GetBreakfastWindow().orderBox.Items.Clear();
        }

        private void ColdbrewButton(object sender, RoutedEventArgs e) {

            orderBox.Items.Add("Cold Brew/Iced Coffee - $2.26");
            mainParent.orderBox.Items.Add("Cold Brew/Iced Coffee - $2.26");
            mainParent.GetBreakfastWindow().orderBox.Items.Add("Cold Brew/Iced Coffee - $2.26");
            mainParent.GetLunchDinnerWindow().orderBox.Items.Add("Cold Brew/Iced Coffee - $2.26");
        }

        private void Fruitsmoothie_Click(object sender, RoutedEventArgs e) {

            orderBox.Items.Add("Fruit Smoothies - $2.53");
            mainParent.orderBox.Items.Add("Fruit Smoothies - $2.53");
            mainParent.GetBreakfastWindow().orderBox.Items.Add("Fruit Smoothies - $2.53");
            mainParent.GetLunchDinnerWindow().orderBox.Items.Add("Fruit Smoothies - $2.53");
        }
        private void Chaitea_Click(object sender, RoutedEventArgs e) {

            orderBox.Items.Add("Chai Tea - $2.79");
            mainParent.orderBox.Items.Add("Chai Tea - $2.79");
            mainParent.GetBreakfastWindow().orderBox.Items.Add("Chai Tea - $2.79");
            mainParent.GetLunchDinnerWindow().orderBox.Items.Add("Chai Tea - $2.79");
        }

        private void Lattes_Click(object sender, RoutedEventArgs e) {
            orderBox.Items.Add("Lattes - $2.69");
            mainParent.orderBox.Items.Add("Lattes - $2.69");
            mainParent.GetBreakfastWindow().orderBox.Items.Add("Lattes - $2.69");
            mainParent.GetLunchDinnerWindow().orderBox.Items.Add("Lattes - $2.69");
        }
    }
}
