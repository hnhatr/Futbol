﻿using System;

using Xamarin.Forms;
using ACE;

namespace Futbol
{
	public class RootPage : TabbedPage
	{
		public RootPage ()
		{

			Title = "asjdhasjkd";

			var FirstPage = new HomePage ();
//			FirstPage.Icon = "icon.png";
			FirstPage.Title = ResourceLoader.LocalizeString ("string_tab_video", "");
			FirstPage.Title = "aaaaaa";

			var SecondPage = new GeneralPage ();
//			SecondPage.Icon = "icon.png";
			SecondPage.Title = ResourceLoader.LocalizeString ("string_tab_livescore", "");
//
			SecondPage.Title = "bbb";

			Children.Add (FirstPage);
			Children.Add (SecondPage);
		}
	}
}

