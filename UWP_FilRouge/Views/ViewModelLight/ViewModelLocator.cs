﻿using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWP_FilRouge.Views.ViewModelLight.Views;

namespace UWP_FilRouge.Views.ViewModelLight
{
    public class ViewModelLocator
    {   /// <summary>        
        /// Initializes a new instance of the ViewModelLocator class.        
        /// /// </summary>
        /// 
        public enum Pages
        {
            LoginPage,
            RegisterPage,
            
            MainPage
        }

        public ViewModelLocator()        
        {            
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);            //Register your services used here            
            var navigationService = new NavigationService();
            navigationService.Configure("Login Page", typeof(LoginPage));
            navigationService.Configure("Register Page", typeof(RegisterPage));
            navigationService.Configure("Seller Main Page", typeof(SellerMainPage));
            navigationService.Configure("Customer Main Page", typeof(CustomerMainPage));
            navigationService.Configure("Order Main Page", typeof(OrderMainPage));
            navigationService.Configure("Main Page", typeof(MainPage));
            navigationService.Configure("Home Page", typeof(HomePage));
            navigationService.Configure("Contact Page", typeof(ContactPage));
            navigationService.Configure("About Page", typeof(AboutPage));
            if (ViewModelBase.IsInDesignModeStatic)
            {
                // Create design time view services and models
            }
            else
            {
                // Create run time view services and models
            }

            SimpleIoc.Default.Register<INavigationService>(() => navigationService);

            SimpleIoc.Default.Register<LoginPageViewModel>();

            SimpleIoc.Default.Register<RegisterPageViewModel>();

            SimpleIoc.Default.Register<SellerMainPageViewModel>();

            SimpleIoc.Default.Register<CustomerMainPageViewModel>();

            SimpleIoc.Default.Register<OrderMainPageViewModel>();

            SimpleIoc.Default.Register<HomePageViewModel>();

            SimpleIoc.Default.Register<ContactPageViewModel>();

            SimpleIoc.Default.Register<AboutPageViewModel>();

        }


        public HomePageViewModel HomePageInstance
        {
            get { return ServiceLocator.Current.GetInstance<HomePageViewModel>(); }
        }

        public ContactPageViewModel ContactPageInstance
        {
            get { return ServiceLocator.Current.GetInstance<ContactPageViewModel>(); }
        }

        public AboutPageViewModel AboutPageInstance
        {
            get { return ServiceLocator.Current.GetInstance<AboutPageViewModel>(); }
        }

        public LoginPageViewModel LoginPageInstance        
        {            
            get { return ServiceLocator.Current.GetInstance<LoginPageViewModel>(); }        
        }

        public RegisterPageViewModel RegisterPageInstance
        {
            get { return ServiceLocator.Current.GetInstance<RegisterPageViewModel>(); }
        }

        public SellerMainPageViewModel SellerMainPageInstance
        {
            get { return ServiceLocator.Current.GetInstance<SellerMainPageViewModel>(); }
        }

        public CustomerMainPageViewModel CustomerMainPageInstance
        {
            get { return ServiceLocator.Current.GetInstance<CustomerMainPageViewModel>(); }
        }

        public OrderMainPageViewModel OrderMainPageInstance
        {
            get { return ServiceLocator.Current.GetInstance<OrderMainPageViewModel>(); }
        }


    }

}
