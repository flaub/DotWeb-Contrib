using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.layout {
	/// <summary>
	///     /**
	///     <p>This is a layout that contains multiple panels in an expandable accordion style such that only one
	///     panel can be open at any given time.  Each panel has built-in support for expanding and collapsing.
	///     This class is intended to be extended or created via the layout:'accordion' {@link Ext.Container#layout}
	///     config, and should generally not need to be created directly via the new keyword.</p>
	///     <p>Note that when creating a layout via config, the layout-specific config properties must be passed in via
	///     the {@link Ext.Container#layoutConfig} object which will then be applied internally to the layout.
	///     Example usage:</p>
	///     <pre><code>
	///     var accordion = new Ext.Panel({
	///     title: 'Accordion Layout',
	///     layout:'accordion',
	///     defaults: {
	///     // applied to each contained panel
	///     bodyStyle: 'padding:15px'
	///     },
	///     layoutConfig: {
	///     // layout-specific configs go here
	///     titleCollapse: false,
	///     animate: true,
	///     activeOnTop: true
	///     },
	///     items: [{
	///     title: 'Panel 1',
	///     html: '&lt;p&gt;Panel content!&lt;/p&gt;'
	///     },{
	///     title: 'Panel 2',
	///     html: '&lt;p&gt;Panel content!&lt;/p&gt;'
	///     },{
	///     title: 'Panel 3',
	///     html: '&lt;p&gt;Panel content!&lt;/p&gt;'
	///     }]
	///     });
	///     </code></pre>
	///     */
	///     Ext.layout.Accordion = Ext.extend(Ext.layout.FitLayout, {
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\layout\AccordionLayout.js</jssource>
	public class Accordion : Ext.layout.FitLayout {

		/// <summary>Auto-generated default constructor</summary>
		/// <returns></returns>
		public extern Accordion();

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static Accordion prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.layout.FitLayout superclass { get; set; }

		/// <summary>
		///     True to adjust the active item's height to fill the available space in the container, false to use the
		///     item's current height, or auto height if not explicitly set (defaults to true).
		/// </summary>
		public extern bool fill { get; set; }

		/// <summary>
		///     True to set each contained item's width to 'auto', false to use the item's current width (defaults to true).
		///     Note that some components, in particular the {@link Ext.grid.GridPanel grid}, will not function properly within
		///     layouts if they have auto width, so in such cases this config should be set to false.
		/// </summary>
		public extern bool autoWidth { get; set; }

		/// <summary>
		///     True to allow expand/collapse of each contained panel by clicking anywhere on the title bar, false to allow
		///     expand/collapse only when the toggle tool button is clicked (defaults to true).  When set to false,
		///     {@link #hideCollapseTool} should be false also.
		/// </summary>
		public extern bool titleCollapse { get; set; }

		/// <summary>
		///     True to hide the contained panels' collapse/expand toggle buttons, false to display them (defaults to false).
		///     When set to true, {@link #titleCollapse} should be true also.
		/// </summary>
		public extern bool hideCollapseTool { get; set; }

		/// <summary>
		///     True to make sure the collapse/expand toggle button always renders first (to the left of) any other tools
		///     in the contained panels' title bars, false to render it last (defaults to false).
		/// </summary>
		public extern bool collapseFirst { get; set; }

		/// <summary>
		///     True to slide the contained panels open and closed during expand/collapse using animation, false to open and
		///     close directly with no animation (defaults to false).  Note: to defer to the specific config setting of each
		///     contained panel for this property, set this to undefined at the layout level.
		/// </summary>
		public extern bool animate { get; set; }

		/// <summary><b>Experimental</b>. If animate is set to true, this will result in each animation running in sequence.</summary>
		public extern bool sequence { get; set; }

		/// <summary>
		///     True to swap the position of each panel as it is expanded so that it becomes the first item in the container,
		///     false to keep the panels in the rendered order. <b>This is NOT compatible with "animate:true"</b> (defaults to false).
		/// </summary>
		public extern bool activeOnTop { get; set; }


		/// <summary>Sets the active (expanded) item in the layout.</summary>
		/// <returns></returns>
		public extern virtual void setActiveItem();

		/// <summary>Sets the active (expanded) item in the layout.</summary>
		/// <param name="item">The string component id or numeric index of the item to activate</param>
		/// <returns></returns>
		public extern virtual void setActiveItem(string item);

		/// <summary>Sets the active (expanded) item in the layout.</summary>
		/// <param name="item">The string component id or numeric index of the item to activate</param>
		/// <returns></returns>
		public extern virtual void setActiveItem(double item);



	}

	[JsAnonymous]
	public class AccordionConfig : System.DotWeb.JsDynamic {
		/// <summary>  True to adjust the active item's height to fill the available space in the container, false to use the item's current height, or auto height if not explicitly set (defaults to true).</summary>
		public extern bool fill { get; set; }

		/// <summary>  True to set each contained item's width to 'auto', false to use the item's current width (defaults to true). Note that some components, in particular the {@link Ext.grid.GridPanel grid}, will not function properly within layouts if they have auto width, so in such cases this config should be set to false.</summary>
		public extern bool autoWidth { get; set; }

		/// <summary>  True to allow expand/collapse of each contained panel by clicking anywhere on the title bar, false to allow expand/collapse only when the toggle tool button is clicked (defaults to true).  When set to false, {@link #hideCollapseTool} should be false also.</summary>
		public extern bool titleCollapse { get; set; }

		/// <summary>  True to hide the contained panels' collapse/expand toggle buttons, false to display them (defaults to false). When set to true, {@link #titleCollapse} should be true also.</summary>
		public extern bool hideCollapseTool { get; set; }

		/// <summary>  True to make sure the collapse/expand toggle button always renders first (to the left of) any other tools in the contained panels' title bars, false to render it last (defaults to false).</summary>
		public extern bool collapseFirst { get; set; }

		/// <summary>  True to slide the contained panels open and closed during expand/collapse using animation, false to open and close directly with no animation (defaults to false).  Note: to defer to the specific config setting of each contained panel for this property, set this to undefined at the layout level.</summary>
		public extern bool animate { get; set; }

		/// <summary>  <b>Experimental</b>. If animate is set to true, this will result in each animation running in sequence.</summary>
		public extern bool sequence { get; set; }

		/// <summary>  True to swap the position of each panel as it is expanded so that it becomes the first item in the container, false to keep the panels in the rendered order. <b>This is NOT compatible with "animate:true"</b> (defaults to false).</summary>
		public extern bool activeOnTop { get; set; }

		/// <summary>  An optional extra CSS class that will be added to the container (defaults to '').  This can be useful for adding customized styles to the container or any of its children using standard CSS rules.</summary>
		public extern string extraCls { get; set; }

		/// <summary>  True to hide each contained item on render (defaults to false).</summary>
		public extern bool renderHidden { get; set; }

	}
}
