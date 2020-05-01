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
using System.Windows.Shapes;

namespace IST331_FinalWaWaApp {
    /// <summary>
    /// Interaction logic for SecondBreafastWindow.xaml
    /// </summary>
    public partial class BreakfastWindow : Window {
        MainWindow parent;

        public BreakfastWindow(MainWindow mainWindow) {
            parent = mainWindow;
            InitializeComponent();
        }

        private void SecondBreakfastBackBtn_Click(object sender, RoutedEventArgs e) {
            parent.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {

        }

        private void ListBox_SelectionChanged(object sender, RoutedEventArgs e) {

        }

        private void EggSandwich_Click(object sender, RoutedEventArgs e) {
            orderBox.Items.Add("Egg Sandwich            $2.26");
            parent.orderBox.Items.Add("Egg Sandwich            $2.26");
        }

        private void Bagel_Click(object sender, RoutedEventArgs e) {
            orderBox.Items.Add("Bagel                    $2.26");
            parent.orderBox.Items.Add("Bagel                    $2.26");
        }

        private void Burrito2_Click(object sender, RoutedEventArgs e) {
            orderBox.Items.Add("Breakfast Buritto        $2.26");
            parent.orderBox.Items.Add("Breakfast Buritto        $2.26");
        }
    }
}