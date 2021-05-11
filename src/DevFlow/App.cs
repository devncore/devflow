﻿using System;
using System.Windows;
using DevFlow.Data.Theme;
using DevFlow.Main.Views;
using DevFlow.Windowbase.Flowbase;

namespace DevFlow
{
    public class App : FlowApp
    {
        protected override ThemeType OnSetDefaultTheme(ThemeType type) => ThemeType.Dark;

        protected override void OnApplyThemeManager()
        {
            AddTheme(ThemeType.Dark, "Generic.Dark.xaml");
            AddTheme(ThemeType.White, "Generic.White.xaml");
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            bool dialogResult = true;

            while (dialogResult)
            {
                ShutdownMode = ShutdownMode.OnExplicitShutdown;
                main = new MainView();
                main.ShowDialog();
                dialogResult = (bool)main.DialogResult;
            }
        }
    }
}