﻿using PowerQualityMonitor_NetMetering.Views;

namespace PowerQualityMonitor_NetMetering
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());

        }
    }
}
