using DotWeb.Client;
using DotWeb.Client.Dom.Html;
using DotWeb.Client.Dom.Events;

namespace DotWeb.Sample.Script
{
	public class Hello : JsScript
	{
		private HtmlElement box;
		private bool toggle = false;

		public Hello() {
			Window.alert("Hello DotWeb!");

			this.box = (HtmlElement)Document.getElementById("box");
			this.box.onclick = this.OnClick;
		}

		public void OnClick(MouseEvent evt) {
			if (!this.toggle) {
				this.toggle = true;
				this.box.style.backgroundColor = "red";
			}
			else {
				this.toggle = false;
				this.box.style.backgroundColor = "black";
			}
		}
	}
}
