﻿using System;
using System.Windows;
using DevFlow.Data;
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


            Theme.Switch(ThemeType.Dark);

            while (dialogResult)
            {
                ShutdownMode = ShutdownMode.OnExplicitShutdown;
                main = new MainView();
                main.ShowDialog();
                dialogResult = (bool)main.DialogResult;
            }
            Environment.Exit(0);
        }
    }
}
