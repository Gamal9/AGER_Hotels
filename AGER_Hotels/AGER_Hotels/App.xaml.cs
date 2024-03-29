﻿using AGER_Hotels.Helper;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AGER_Hotels
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = (AppSettings.LastUserID == 0) ? new Helper.TransitionNavigationPage(new PresentationPage()) : new Helper.TransitionNavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
