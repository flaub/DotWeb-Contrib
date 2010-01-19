using System;
using DotWeb.Client;
using DotWeb.Client.Dom;
using System.DotWeb;
using DotWeb.Client.Ui;

namespace DotWeb.Sample.Client.Sticky
{
	public class Main
	{
		extern Window Window {
			[JsMacro("$wnd")]
			get;
		}

		public Main() {
			Window.alert("Hi");

			var panel = new SimplePanel();
			panel.Click += new DotWeb.Client.Dom.Events.MouseEventHandler(panel_Click);
		}

		void panel_Click(DotWeb.Client.Dom.Events.MouseEvent evt) {
		}
	}
}
