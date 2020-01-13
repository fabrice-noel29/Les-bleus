﻿using CommonServiceLocator;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP_FilRouge.Views.ViewModels;

namespace UWP_FilRouge.Views.MvvmLight
{
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            //Register your services used here
            SimpleIoc.Default.Register<INavigationService, NavigationService>();
            SimpleIoc.Default.Register<OrderCheckPage>();
            SimpleIoc.Default.Register<MainPageViewModel>();
        }

        public OrderCheckPage ShopPageInstance
        {
            get { return ServiceLocator.Current.GetInstance<OrderCheckPage>(); }
        }

        //public MainPageViewModel MyProperty
        //{
        //    get { return ServiceLocator.Current.GetInstance<MainPageViewModel>(); }
        //}

    }
}
