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

namespace MontanoP5
{
    /// <summary>
    /// Interaction logic for SprocketOrderForm.xaml
    /// </summary>
    public partial class SprocketOrderForm : Window
    {
        SprocketOrder order = new SprocketOrder();
        public SprocketOrderForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Sprocket newSprocket = new Sprocket();
        }
    }
}
