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

namespace ButtonExample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            textbox.AppendText("Should I do it..?");
        }

        void DevilClick(object sender, RoutedEventArgs e) {
            textbox.Clear();
            textbox.AppendText("Come on, do it!");
        }
        
        void AngelClick(object sender, RoutedEventArgs e) {
            textbox.Clear();
            textbox.AppendText("Don't do it! You might regret it!");
        }
    }
}
