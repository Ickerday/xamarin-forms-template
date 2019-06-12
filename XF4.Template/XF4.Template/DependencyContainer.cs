﻿using DryIoc;
using XF4.Template.Services.Dialog;
using XF4.Template.ViewModels.Main;

namespace XF4.Template
{
    public static class DependencyContainer
    {
        public static IContainer CreateContainer()
        {
            var container = new Container();

            #region SERVICES
            container.Register<IDialogService, DialogService>();
            #endregion

            #region VIEWMODELS
            container.Register<MainPageViewModel>();
            #endregion

            return container;
        }
    }
}