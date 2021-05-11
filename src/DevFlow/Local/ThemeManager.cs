﻿using DevFlow.Data.Theme;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DevFlow.Local
{
    internal class ThemeManager
    {
        private DevFlowApp App;
        private Collection<ResourceDictionary> Themes;
        private ResourceDictionary DarkThemeResource;
        private ResourceDictionary WhiteThemeResource;

        private ResourceDictionary CurrentTheme;

        internal ThemeManager(DevFlowApp app)
        {
            App = app;
            Themes = App.Resources.MergedDictionaries;

            DarkThemeResource = new ResourceDictionary { Source = new Uri("/DevFlow.Resources;component/Themes/Generic.Dark.xaml", UriKind.RelativeOrAbsolute) };
            WhiteThemeResource = new ResourceDictionary { Source = new Uri("/DevFlow.Resources;component/Themes/Generic.White.xaml", UriKind.RelativeOrAbsolute) };
        }

        internal void Switch(ThemeType theme)
        {
            if (Themes.Contains(CurrentTheme))
            {
                Themes.Remove(CurrentTheme);
            }

            switch (theme)
            {
                case ThemeType.Dark: CurrentTheme = DarkThemeResource; break;
                case ThemeType.White: CurrentTheme = WhiteThemeResource; break;
            }

            Themes.Add(CurrentTheme);
        }
    }
}