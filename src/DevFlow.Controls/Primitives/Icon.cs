﻿using DevFlow.Controls.Extends;
using DevFlow.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DevFlow.Controls.Primitives
{
	internal static class IconData
	{
		internal static readonly string CLOSE = "M19,6.41L17.59,5L12,10.59L6.41,5L5,6.41L10.59,12L5,17.59L6.41,19L12,13.41L17.59,19L19,17.59L13.41,12L19,6.41Z";
		internal static readonly string CHECK_CIRCLE = "M12 2C6.5 2 2 6.5 2 12S6.5 22 12 22 22 17.5 22 12 17.5 2 12 2M10 17L5 12L6.41 10.59L10 14.17L17.59 6.58L19 8L10 17Z";
		internal static readonly string CROP = "M7,17V1H5V5H1V7H5V17A2,2 0 0,0 7,19H17V23H19V19H23V17M17,15H19V7C19,5.89 18.1,5 17,5H9V7H17V15Z";
		internal static readonly string MICROSOFT_VISUAL_STUDIO = "M17,8.5L12.25,12.32L17,16V8.5M4.7,18.4L2,16.7V7.7L5,6.7L9.3,10.03L18,2L22,4.5V20L17,22L9.34,14.66L4.7,18.4M5,14L6.86,12.28L5,10.5V14Z";
		internal static readonly string MOVIE_OPEN_PLAY = "M14.75 7.46L12 3.93L13.97 3.54L16.71 7.07L14.75 7.46M21.62 6.1L20.84 2.18L16.91 2.96L19.65 6.5L21.62 6.1M4.16 5.5L3.18 5.69C2.1 5.91 1.4 6.96 1.61 8.04L2 10L6.9 9.03L4.16 5.5M11.81 8.05L9.07 4.5L7.1 4.91L9.85 8.44L11.81 8.05M2 10V20C2 21.11 2.9 22 4 22H13.81C13.3 21.12 13 20.1 13 19C13 15.69 15.69 13 19 13C20.1 13 21.12 13.3 22 13.81V10H2M17 22L22 19L17 16V22Z";
		internal static readonly string MENU = "M3,6H21V8H3V6M3,11H21V13H3V11M3,16H21V18H3V16Z";
		internal static readonly string GOOLE_TRANSLATE = "M20,5H10.88L10,2H4A2,2 0 0,0 2,4V17A2,2 0 0,0 4,19H11L12,22H20A2,2 0 0,0 22,20V7A2,2 0 0,0 20,5M7.17,14.59A4.09,4.09 0 0,1 3.08,10.5A4.09,4.09 0 0,1 7.17,6.41C8.21,6.41 9.16,6.78 9.91,7.5L10,7.54L8.75,8.72L8.69,8.67C8.4,8.4 7.91,8.08 7.17,8.08C5.86,8.08 4.79,9.17 4.79,10.5C4.79,11.83 5.86,12.92 7.17,12.92C8.54,12.92 9.13,12.05 9.29,11.46H7.08V9.91H11.03L11.04,10C11.08,10.19 11.09,10.38 11.09,10.59C11.09,12.94 9.5,14.59 7.17,14.59M13.2,12.88C13.53,13.5 13.94,14.06 14.39,14.58L13.85,15.11L13.2,12.88M13.97,12.12H13L12.67,11.08H16.66C16.66,11.08 16.32,12.39 15.1,13.82C14.58,13.2 14.21,12.59 13.97,12.12M21,20A1,1 0 0,1 20,21H13L15,19L14.19,16.23L15.11,15.31L17.79,18L18.5,17.27L15.81,14.59C16.71,13.56 17.41,12.34 17.73,11.08H19V10.04H15.36V9H14.32V10.04H12.36L11.18,6H20A1,1 0 0,1 21,7V20Z";
		internal static readonly string EYEDROPPER_VARIANT = "M6.92,19L5,17.08L13.06,9L15,10.94M20.71,5.63L18.37,3.29C18,2.9 17.35,2.9 16.96,3.29L13.84,6.41L11.91,4.5L10.5,5.91L11.92,7.33L3,16.25V21H7.75L16.67,12.08L18.09,13.5L19.5,12.09L17.58,10.17L20.7,7.05C21.1,6.65 21.1,6 20.71,5.63Z";
		internal static readonly string COG_REFRESH_OUTLINE = "M18 14.5C19.1 14.5 20.1 14.9 20.8 15.7L22 14.5V18.5H18L19.8 16.7C19.3 16.3 18.7 16 18 16C16.6 16 15.5 17.1 15.5 18.5S16.6 21 18 21C18.8 21 19.5 20.6 20 20H21.7C21.1 21.5 19.7 22.5 18 22.5C15.8 22.5 14 20.7 14 18.5S15.8 14.5 18 14.5M11.7 20H11.3L10.9 17.4C9.7 17.2 8.7 16.5 7.9 15.6L5.5 16.6L4.7 15.3L6.8 13.7C6.4 12.5 6.4 11.3 6.8 10.1L4.7 8.7L5.5 7.4L7.9 8.4C8.7 7.5 9.7 6.9 10.9 6.6L11.2 4H12.7L13.1 6.6C14.3 6.8 15.4 7.5 16.1 8.4L18.5 7.4L19.3 8.7L17.2 10.2C17.4 10.8 17.5 11.4 17.5 12H18C18.5 12 19 12.1 19.5 12.2V12L19.4 11L21.5 9.4C21.7 9.2 21.7 9 21.6 8.8L19.6 5.3C19.5 5 19.3 5 19 5L16.5 6C16 5.6 15.4 5.3 14.8 5L14.4 2.3C14.5 2.2 14.2 2 14 2H10C9.8 2 9.5 2.2 9.5 2.4L9.1 5.1C8.5 5.3 8 5.7 7.4 6L5 5C4.7 5 4.5 5 4.3 5.3L2.3 8.8C2.2 9 2.3 9.2 2.5 9.4L4.6 11L4.5 12L4.6 13L2.5 14.7C2.3 14.9 2.3 15.1 2.4 15.3L4.4 18.8C4.5 19 4.7 19 5 19L7.5 18C8 18.4 8.6 18.7 9.2 19L9.6 21.7C9.6 21.9 9.8 22.1 10.1 22.1H12.6C12.1 21.4 11.9 20.7 11.7 20M16 12.3V12C16 9.8 14.2 8 12 8S8 9.8 8 12C8 14.2 9.8 16 12 16C12.7 14.3 14.2 12.9 16 12.3M10 12C10 10.9 10.9 10 12 10S14 10.9 14 12 13.1 14 12 14 10 13.1 10 12Z";
		internal static readonly string MONITOR_SHIMMER = "M21 16H3V4H21M21 2H3C1.89 2 1 2.89 1 4V16C1 17.11 1.9 18 3 18H10V20H8V22H16V20H14V18H21C22.11 18 23 17.11 23 16V4C23 2.89 22.1 2 21 2M15 5.5L14.38 6.87L13 7.5L14.38 8.13L15 9.5L15.63 8.13L17 7.5L15.63 6.87L15 5.5M10.5 7.5L9.41 9.91L7 11L9.41 12.09L10.5 14.5L11.6 12.09L14 11L11.6 9.91L10.5 7.5";
		internal static readonly string CHEVRON_RIGHT = "M8.59,16.58L13.17,12L8.59,7.41L10,6L16,12L10,18L8.59,16.58Z";
		internal static readonly string CHEVRON_DOWN = "M7.41,8.58L12,13.17L16.59,8.58L18,10L12,16L6,10L7.41,8.58Z";
		internal static readonly string CURSOR_POINTER = "M13.75,10.19L14.38,10.32L18.55,12.4C19.25,12.63 19.71,13.32 19.65,14.06V14.19L19.65,14.32L18.75,20.44C18.69,20.87 18.5,21.27 18.15,21.55C17.84,21.85 17.43,22 17,22H10.12C9.63,22 9.18,21.82 8.85,21.47L2.86,15.5L3.76,14.5C4,14.25 4.38,14.11 4.74,14.13H5.03L9,15V4.5A2,2 0 0,1 11,2.5A2,2 0 0,1 13,4.5V10.19H13.75Z";
		internal static readonly string IMAGE = "M8.5,13.5L11,16.5L14.5,12L19,18H5M21,19V5C21,3.89 20.1,3 19,3H5A2,2 0 0,0 3,5V19A2,2 0 0,0 5,21H19A2,2 0 0,0 21,19Z";
		internal static readonly string CALENDAR_MONTH = "M9,10V12H7V10H9M13,10V12H11V10H13M17,10V12H15V10H17M19,3A2,2 0 0,1 21,5V19A2,2 0 0,1 19,21H5C3.89,21 3,20.1 3,19V5A2,2 0 0,1 5,3H6V1H8V3H16V1H18V3H19M19,19V8H5V19H19M9,14V16H7V14H9M13,14V16H11V14H13M17,14V16H15V14H17Z";
		internal static readonly string WINDOW_MINIMIZE = "M20,12H4V14H20";
		internal static readonly string WEB = "M16.36,14C16.44,13.34 16.5,12.68 16.5,12C16.5,11.32 16.44,10.66 16.36,10H19.74C19.9,10.64 20,11.31 20,12C20,12.69 19.9,13.36 19.74,14M14.59,19.56C15.19,18.45 15.65,17.25 15.97,16H18.92C17.96,17.65 16.43,18.93 14.59,19.56M14.34,14H9.66C9.56,13.34 9.5,12.68 9.5,12C9.5,11.32 9.56,10.65 9.66,10H14.34C14.43,10.65 14.5,11.32 14.5,12C14.5,12.68 14.43,13.34 14.34,14M12,19.96C11.17,18.76 10.5,17.43 10.09,16H13.91C13.5,17.43 12.83,18.76 12,19.96M8,8H5.08C6.03,6.34 7.57,5.06 9.4,4.44C8.8,5.55 8.35,6.75 8,8M5.08,16H8C8.35,17.25 8.8,18.45 9.4,19.56C7.57,18.93 6.03,17.65 5.08,16M4.26,14C4.1,13.36 4,12.69 4,12C4,11.31 4.1,10.64 4.26,10H7.64C7.56,10.66 7.5,11.32 7.5,12C7.5,12.68 7.56,13.34 7.64,14M12,4.03C12.83,5.23 13.5,6.57 13.91,8H10.09C10.5,6.57 11.17,5.23 12,4.03M18.92,8H15.97C15.65,6.75 15.19,5.55 14.59,4.44C16.43,5.07 17.96,6.34 18.92,8M12,2C6.47,2 2,6.5 2,12A10,10 0 0,0 12,22A10,10 0 0,0 22,12A10,10 0 0,0 12,2Z";
		internal static readonly string PALETTE = "M17.5,12A1.5,1.5 0 0,1 16,10.5A1.5,1.5 0 0,1 17.5,9A1.5,1.5 0 0,1 19,10.5A1.5,1.5 0 0,1 17.5,12M14.5,8A1.5,1.5 0 0,1 13,6.5A1.5,1.5 0 0,1 14.5,5A1.5,1.5 0 0,1 16,6.5A1.5,1.5 0 0,1 14.5,8M9.5,8A1.5,1.5 0 0,1 8,6.5A1.5,1.5 0 0,1 9.5,5A1.5,1.5 0 0,1 11,6.5A1.5,1.5 0 0,1 9.5,8M6.5,12A1.5,1.5 0 0,1 5,10.5A1.5,1.5 0 0,1 6.5,9A1.5,1.5 0 0,1 8,10.5A1.5,1.5 0 0,1 6.5,12M12,3A9,9 0 0,0 3,12A9,9 0 0,0 12,21A1.5,1.5 0 0,0 13.5,19.5C13.5,19.11 13.35,18.76 13.11,18.5C12.88,18.23 12.73,17.88 12.73,17.5A1.5,1.5 0 0,1 14.23,16H16A5,5 0 0,0 21,11C21,6.58 16.97,3 12,3Z";
		internal static readonly string CONTENTPASTE = "M19,20H5V4H7V7H17V4H19M12,2A1,1 0 0,1 13,3A1,1 0 0,1 12,4A1,1 0 0,1 11,3A1,1 0 0,1 12,2M19,2H14.82C14.4,0.84 13.3,0 12,0C10.7,0 9.6,0.84 9.18,2H5A2,2 0 0,0 3,4V20A2,2 0 0,0 5,22H19A2,2 0 0,0 21,20V4A2,2 0 0,0 19,2Z";
		internal static readonly string CHECKBOLD = "M9,20.42L2.79,14.21L5.62,11.38L9,14.77L18.88,4.88L21.71,7.71L9,20.42Z";
		internal static readonly string FOLDER_OPEN_OUTLINE = "M6.1,10L4,18V8H21A2,2 0 0,0 19,6H12L10,4H4A2,2 0 0,0 2,6V18A2,2 0 0,0 4,20H19C19.9,20 20.7,19.4 20.9,18.5L23.2,10H6.1M19,18H6L7.6,12H20.6L19,18Z";

		internal static readonly string FOLDER_TABLE = "M4 4C2.89 4 2 4.89 2 6V18A2 2 0 0 0 4 20H20A2 2 0 0 0 22 18V8C22 6.89 21.1 6 20 6H12L10 4H4M12 9H15V11H12V9M16 9H19V11H16V9M12 12H15V14H12V12M16 12H19V14H16V12M12 15H15V17H12V15M16 15H19V17H16V15Z";
		internal static readonly string MAXIMIZE = "M4,4H20V20H4V4M6,8V18H18V8H6Z";
		internal static readonly string RESIZE = "M22,22H20V20H22V22M22,18H20V16H22V18M18,22H16V20H18V22M18,18H16V16H18V18M14,22H12V20H14V22M22,14H20V12H22V14Z";

		internal static readonly string SELECT_ALL = "M9,9H15V15H9M7,17H17V7H7M15,5H17V3H15M15,21H17V19H15M19,17H21V15H19M19,9H21V7H19M19,21A2,2 0 0,0 21,19H19M19,13H21V11H19M11,21H13V19H11M9,3H7V5H9M3,17H5V15H3M5,21V19H3A2,2 0 0,0 5,21M19,3V5H21A2,2 0 0,0 19,3M13,3H11V5H13M3,9H5V7H3M7,21H9V19H7M3,13H5V11H3M3,5H5V3A2,2 0 0,0 3,5Z";

		internal static readonly string ARROW_LEFT_BOLD = "M20,11V13H8L13.5,18.5L12.08,19.92L4.16,12L12.08,4.08L13.5,5.5L8,11H20Z";
		internal static readonly string ARROW_RIGHT_BOLD = "M4,11V13H16L10.5,18.5L11.92,19.92L19.84,12L11.92,4.08L10.5,5.5L16,11H4Z";
		internal static readonly string ARROW_UP_BOLD = "M13,20H11V8L5.5,13.5L4.08,12.08L12,4.16L19.92,12.08L18.5,13.5L13,8V20Z";
		internal static readonly string CONSOLE_LINE = "M13,19V16H21V19H13M8.5,13L2.47,7H6.71L11.67,11.95C12.25,12.54 12.25,13.5 11.67,14.07L6.74,19H2.5L8.5,13Z";
		internal static readonly string PLUS = "M19,13H13V19H11V13H5V11H11V5H13V11H19V13Z";
		internal static readonly string ARROW_ALL = "M13,11H18L16.5,9.5L17.92,8.08L21.84,12L17.92,15.92L16.5,14.5L18,13H13V18L14.5,16.5L15.92,17.92L12,21.84L8.08,17.92L9.5,16.5L11,18V13H6L7.5,14.5L6.08,15.92L2.16,12L6.08,8.08L7.5,9.5L6,11H11V6L9.5,7.5L8.08,6.08L12,2.16L15.92,6.08L14.5,7.5L13,6V11Z";

		internal static readonly string MICROSOFT_WINDOWS = "M3,12V6.75L9,5.43V11.91L3,12M20,3V11.75L10,11.9V5.21L20,3M3,13L9,13.09V19.9L3,18.75V13M20,13.25V22L10,20.09V13.1L20,13.25Z";
		internal static readonly string ARROW_DOWN_BOX = "M3,5A2,2 0 0,1 5,3H19A2,2 0 0,1 21,5V19A2,2 0 0,1 19,21H5C3.89,21 3,20.1 3,19V5M11,6V14.5L7.5,11L6.08,12.42L12,18.34L17.92,12.42L16.5,11L13,14.5V6H11Z";
		internal static readonly string TEXT_BOX = "M14,17H7V15H14M17,13H7V11H17M17,9H7V7H17M19,3H5C3.89,3 3,3.89 3,5V19A2,2 0 0,0 5,21H19A2,2 0 0,0 21,19V5C21,3.89 20.1,3 19,3Z";
		internal static readonly string FOLDER = "M10,4H4C2.89,4 2,4.89 2,6V18A2,2 0 0,0 4,20H20A2,2 0 0,0 22,18V8C22,6.89 21.1,6 20,6H12L10,4Z";
		internal static readonly string DESKTOP_CLASSIC = "M6,2C4.89,2 4,2.89 4,4V12C4,13.11 4.89,14 6,14H18C19.11,14 20,13.11 20,12V4C20,2.89 19.11,2 18,2H6M6,4H18V12H6V4M4,15C2.89,15 2,15.89 2,17V20C2,21.11 2.89,22 4,22H20C21.11,22 22,21.11 22,20V17C22,15.89 21.11,15 20,15H4M8,17H20V20H8V17M9,17.75V19.25H13V17.75H9M15,17.75V19.25H19V17.75H15Z";
		internal static readonly string HARDDISK = "M6,2H18A2,2 0 0,1 20,4V20A2,2 0 0,1 18,22H6A2,2 0 0,1 4,20V4A2,2 0 0,1 6,2M12,4A6,6 0 0,0 6,10C6,13.31 8.69,16 12.1,16L11.22,13.77C10.95,13.29 11.11,12.68 11.59,12.4L12.45,11.9C12.93,11.63 13.54,11.79 13.82,12.27L15.74,14.69C17.12,13.59 18,11.9 18,10A6,6 0 0,0 12,4M12,9A1,1 0 0,1 13,10A1,1 0 0,1 12,11A1,1 0 0,1 11,10A1,1 0 0,1 12,9M7,18A1,1 0 0,0 6,19A1,1 0 0,0 7,20A1,1 0 0,0 8,19A1,1 0 0,0 7,18M12.09,13.27L14.58,19.58L17.17,18.08L12.95,12.77L12.09,13.27Z";
	}

	public class Icon : ContentControl
	{
		#region DependencyProperties

		public static readonly DependencyProperty FillProperty = DependencyProperty.Register("Fill", typeof(Brush), typeof(Icon), new PropertyMetadata(Brushes.White));
		public static readonly DependencyProperty IconTypeProperty = DependencyProperty.Register("IconType", typeof(GeometryIconStyle), typeof(Icon), new PropertyMetadata(GeometryIconStyle.None, IconTypePropertyChanged));
		public static readonly DependencyProperty DataProperty = DependencyProperty.Register("Data", typeof(Geometry), typeof(Icon), new PropertyMetadata(null));
		#endregion

		#region Fill

		public Brush Fill
		{
			get => (Brush)GetValue(FillProperty);
			set => SetValue(FillProperty, value);
		}
		#endregion

		#region IconType

		public GeometryIconStyle IconType
		{
			get => (GeometryIconStyle)GetValue(IconTypeProperty);
			set => SetValue(IconTypeProperty, value);
		}
		#endregion

		#region Data

		public Geometry Data
		{
			get => (Geometry)GetValue(DataProperty);
			set => SetValue(DataProperty, value);
		}
		#endregion

		#region IconTypePropertyChanged

		private static void IconTypePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
		{
			Icon icon = (Icon)d;

			switch ((GeometryIconStyle)e.NewValue)
			{
				case GeometryIconStyle.Close: icon.Data = IconData.CLOSE.ToGeometry(); break;
				case GeometryIconStyle.CheckCircle: icon.Data = IconData.CHECK_CIRCLE.ToGeometry(); break;
				case GeometryIconStyle.Crop: icon.Data = IconData.CROP.ToGeometry(); break;
				case GeometryIconStyle.MicrosoftVisualStudio: icon.Data = IconData.MICROSOFT_VISUAL_STUDIO.ToGeometry(); break;
				case GeometryIconStyle.MonitorShimmer: icon.Data = IconData.MONITOR_SHIMMER.ToGeometry(); break;
				case GeometryIconStyle.MovieOpenPlay: icon.Data = IconData.MOVIE_OPEN_PLAY.ToGeometry(); break;
				case GeometryIconStyle.GoogleTranslate: icon.Data = IconData.MOVIE_OPEN_PLAY.ToGeometry(); break;
				case GeometryIconStyle.EyedropperVariant: icon.Data = IconData.EYEDROPPER_VARIANT.ToGeometry(); break;
				case GeometryIconStyle.OcgRefreshOutline: icon.Data = IconData.COG_REFRESH_OUTLINE.ToGeometry(); break;
				case GeometryIconStyle.Image: icon.Data = IconData.IMAGE.ToGeometry(); break;
				case GeometryIconStyle.CalendarMonth: icon.Data = IconData.CALENDAR_MONTH.ToGeometry(); break;
				case GeometryIconStyle.Minimize: icon.Data = IconData.WINDOW_MINIMIZE.ToGeometry(); break;
				case GeometryIconStyle.Menu: icon.Data = IconData.MENU.ToGeometry(); break;
				case GeometryIconStyle.Palette: icon.Data = IconData.PALETTE.ToGeometry(); break;
				case GeometryIconStyle.Web: icon.Data = IconData.WEB.ToGeometry(); break;
				case GeometryIconStyle.ContentPaste: icon.Data = IconData.CONTENTPASTE.ToGeometry(); break;
				case GeometryIconStyle.CheckBold: icon.Data = IconData.CHECKBOLD.ToGeometry(); break;
				case GeometryIconStyle.FolderOpenOutline: icon.Data = IconData.FOLDER_OPEN_OUTLINE.ToGeometry(); break;
				case GeometryIconStyle.FolderTable: icon.Data = IconData.FOLDER_TABLE.ToGeometry(); break;
				case GeometryIconStyle.Maximize: icon.Data = IconData.MAXIMIZE.ToGeometry(); break;
				case GeometryIconStyle.Resize: icon.Data = IconData.RESIZE.ToGeometry(); break;
				case GeometryIconStyle.SelectAll: icon.Data = IconData.SELECT_ALL.ToGeometry(); break;
				case GeometryIconStyle.ArrowLeftBold: icon.Data = IconData.ARROW_LEFT_BOLD.ToGeometry(); break;
				case GeometryIconStyle.ArrowRightBold: icon.Data = IconData.ARROW_RIGHT_BOLD.ToGeometry(); break;
				case GeometryIconStyle.ArrowUpBold: icon.Data = IconData.ARROW_UP_BOLD.ToGeometry(); break;
				case GeometryIconStyle.Plus: icon.Data = IconData.PLUS.ToGeometry(); break;
				case GeometryIconStyle.Folder: icon.Data = IconData.FOLDER.ToGeometry(); break;
				case GeometryIconStyle.ConsoleLine: icon.Data = IconData.CONSOLE_LINE.ToGeometry(); break;
				case GeometryIconStyle.ArrowAll: icon.Data = IconData.ARROW_ALL.ToGeometry(); break;
				case GeometryIconStyle.MicrosoftWindows: icon.Data = IconData.MICROSOFT_WINDOWS.ToGeometry(); break;
				case GeometryIconStyle.ArrowDownBox: icon.Data = IconData.ARROW_DOWN_BOX.ToGeometry(); break;
				case GeometryIconStyle.TextBox: icon.Data = IconData.TEXT_BOX.ToGeometry(); break;
				case GeometryIconStyle.Harddisk: icon.Data = IconData.HARDDISK.ToGeometry(); break;
				case GeometryIconStyle.DesktopClassic: icon.Data = IconData.DESKTOP_CLASSIC.ToGeometry(); break;
				case GeometryIconStyle.ChevronRight: icon.Data = IconData.CHEVRON_RIGHT.ToGeometry(); break;
				case GeometryIconStyle.ChevronDown: icon.Data = IconData.CHEVRON_DOWN.ToGeometry(); break;
				case GeometryIconStyle.None:
					break;
				default:
					break;
			}
		}
		#endregion
	}
}




