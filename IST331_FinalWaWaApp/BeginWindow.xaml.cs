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
    /// Interaction logic for BeginWindow.xaml
    /// </summary>
    public partial class BeginWindow : Window {
        BreakfastWindow bw;
        BeveragesWindow bevW;
        LunchDinnerWindow ld;
        public BeginWindow() {
            InitializeComponent();
        }

        private void CompleteOrder_Click(object sender, RoutedEventArgs e) {
            MainWindow mainWindow = new MainWindow(bw, bevW, ld);
            this.Close();
            mainWindow.Show();
            this.Hide();
        }

        private void grid1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(bw, bevW, ld);
            this.Close();
            mainWindow.Show();
            this.Hide();
        }
    }
}
