﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using UWP_FilRouge.Entities;


// Pour en savoir plus sur le modèle d'élément Contrôle utilisateur, consultez la page https://go.microsoft.com/fwlink/?LinkId=234236

namespace UWP_FilRouge.Views.Sellers
{
    public sealed partial class ListSellerUC : UserControl/*Base*/
    {

        public ObservableCollection<Seller> SellerList { get; set; }


        public ListSellerUC()
        {
            this.InitializeComponent();
            this.SellerList = new ObservableCollection<Seller>(); //To show the seller list
            this.DataContext = SellerList;
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            UpdateGrid.Visibility=Visibility.Visible;

        }

        
    }
}

