﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP_FilRouge.Entities;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour en savoir plus sur le modèle d'élément Contrôle utilisateur, consultez la page https://go.microsoft.com/fwlink/?LinkId=234236

namespace UWP_FilRouge.Views.Sellers
{
    public sealed partial class ShowSellerUC : UserControl/*Base*/
    {
        private Seller seller;

        public Seller Seller
        {
            get { return seller; }
            set { seller = value; }
        }
        public ShowSellerUC()
        {
            this.InitializeComponent();
            this.Seller = new Seller();
            this.DataContext = Seller;
        }
    }
}
