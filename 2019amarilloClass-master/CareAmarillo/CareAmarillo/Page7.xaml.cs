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

namespace CareAmarillo
{
    /// <summary>
    /// Interaction logic for Page7.xaml
    /// </summary>
    public partial class Page7 : Window
    {
        private Search policeSearch;
        public Page7()
        {
            InitializeComponent();
            policeSearch = new Search();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lblShelters.Content = policeSearch.FindAShelter(txtSearch.Text);
        }

        private void Change_Password_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Change(object sender, TextCompositionEventArgs e)
        {

        }
    }
}