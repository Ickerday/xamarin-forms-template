﻿using Akavache;
using AltkomSoftware.Onstage.Core.Services.Navigation;
using DryIoc;
using System.Threading.Tasks;
using XF4.Template.ViewModels.Main;
using XF4.Template.Views;
using static XF4.Template.Constants;

namespace XF4.Template
{
    public partial class App
    {
        public readonly IContainer Container;

        public App()
        {
            Container = DependencyContainer.CreateContainer();

            InitializeComponent();
        }

        protected override void OnStart()
        {
            Registrations.Start(nameof(Template));

            Container.Resolve<IPageNavigationService>()
                .InitializeAsync<MainPageViewModel, MainPage>(Navigation.RoutingTable);
        }

        // Handle when your app sleeps
        protected override async void OnSleep() =>
            await Task.CompletedTask;

        // Handle when your app resumes
        protected override async void OnResume() =>
            await Task.CompletedTask;
    }
}
