﻿using DevFlow.LayoutSupport.Controls;
using System.Windows;

namespace DevFlow.Languages.Views
{
	public class Translator : Preview
	{
		static Translator()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(Translator), new FrameworkPropertyMetadata(typeof(Translator)));
		}
	}
}