﻿using DevFlow.LayoutSupport.Controls;
using System.Windows;
using System.Windows.Media;

namespace DevFlow.Skins.Views
{
	public class SwitchSkin : Preview
	{
		static SwitchSkin()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(SwitchSkin), new FrameworkPropertyMetadata(typeof(SwitchSkin)));
		}

		public SwitchSkin()
		{
		}

	}
}
