﻿using Audiotica.Core.Windows.Services;
using Audiotica.Database.Services.Interfaces;
using Audiotica.Factory;
using Audiotica.Web.MatchEngine.Interfaces.Providers;
using Audiotica.Web.MatchEngine.Services;
using Audiotica.Windows.Services;
using Audiotica.Windows.Services.NavigationService;
using Autofac;

namespace Audiotica.Windows.AppEngine.Modules
{
    internal class ServiceModule : AppModule
    {
        public override void LoadDesignTime(ContainerBuilder builder)
        {
            builder.RegisterType<DesignBackgroundAudioService>().As<IBackgroundAudioService>();
            builder.RegisterType<DesignNavigationService>().As<INavigationService>();
            builder.RegisterType<DesignLibraryService>().As<ILibraryService>();
            builder.RegisterType<DesignMatchEngineService>().As<IMatchEngineService>();
            builder.RegisterType<WindowsPlayerService>().As<IWindowsPlayerService>();
        }

        public override void LoadRunTime(ContainerBuilder builder)
        {
            builder.RegisterType<BackgroundAudioService>().As<IBackgroundAudioService>().SingleInstance();
            builder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();
            builder.RegisterType<DesignLibraryService>().As<ILibraryService>();
            builder.RegisterType<MatchEngineService>().As<IMatchEngineService>();
            builder.RegisterType<WindowsPlayerService>().As<IWindowsPlayerService>();
        }
    }
}