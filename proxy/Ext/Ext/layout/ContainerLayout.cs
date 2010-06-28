using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.layout {
	/// <summary>
	///     /**
	///     <p>Every {@link Ext.Container Container} delegates the rendering of its child {@link Ext.Component Component}s
	///     to a layout manager class which must be {@link Ext.Container#layout configured} into the Container.</p>
	///     <p>Some layouts also provide sizing and positioning of child Components.</p>
	///     <p>The ContainerLayout class is the default layout manager used when no layout is configured into a Container.
	///     It provides the basic foundation for all other layout classes in Ext. It simply renders all child Components
	///     into the Container, performing no sizing or positioning services.</p>
	///     <p>This class is intended to be extended and should generally not need to be created directly via the new keyword.</p>
	///     */
	///     Ext.layout.ContainerLayout = function(config){
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\layout\ContainerLayout.js</jssource>
	[JsObject]
	public class ContainerLayout  {

		/// <summary>Auto-generated default constructor</summary>
		/// <returns></returns>
		public extern ContainerLayout();

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static Ext.layout.ContainerLayout prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>
		///     An optional extra CSS class that will be added to the container (defaults to '').  This can be useful for
		///     adding customized styles to the container or any of its children using standard CSS rules.
		/// </summary>
		public extern string extraCls { get; set; }

		/// <summary>True to hide each contained item on render (defaults to false).</summary>
		public extern bool renderHidden { get; set; }

		/// <summary>
		///     A reference to the {@link Ext.Component} that is active.  For example,
		///     if(myPanel.layout.activeItem.id == 'item-1') { ... }.  activeItem only applies to layout styles that can
		///     display items one at a time (like {@link Ext.layout.Accordion}, {@link Ext.layout.CardLayout}
		///     and {@link Ext.layout.FitLayout}).  Read-only.  Related to {@link Ext.Container#activeItem}.
		/// </summary>
		public extern Ext.Component activeItem { get; set; }




	}

	[JsAnonymous]
	public class ContainerLayoutConfig : System.DotWeb.JsDynamic {
		/// <summary>  An optional extra CSS class that will be added to the container (defaults to '').  This can be useful for adding customized styles to the container or any of its children using standard CSS rules.</summary>
		public extern string extraCls { get; set; }

		/// <summary>  True to hide each contained item on render (defaults to false).</summary>
		public extern bool renderHidden { get; set; }

	}
}
