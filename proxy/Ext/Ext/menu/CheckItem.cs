using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.menu {
	/// <summary>
	///     /**
	///     Adds a menu item that contains a checkbox by default, but can also be part of a radio group.
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\menu\CheckItem.js</jssource>
	public class CheckItem : Ext.menu.Item {

		/// <summary>Creates a new CheckItem</summary>
		/// <returns></returns>
		public extern CheckItem();
		/// <summary>Creates a new CheckItem</summary>
		/// <param name="config">Configuration options</param>
		/// <returns></returns>
		public extern CheckItem(object config);
		/// <summary>
		///     element and its id used as the component id.  If a string is passed, it is assumed to be the id of an existing element
		///     and is used as the component id.  Otherwise, it is assumed to be a standard config object and is applied to the component.
		/// </summary>
		/// <param name="config">The configuration options.  If an element is passed, it is set as the internal</param>
		/// <returns></returns>
		public extern CheckItem(Ext.Element config);
		/// <summary>
		///     element and its id used as the component id.  If a string is passed, it is assumed to be the id of an existing element
		///     and is used as the component id.  Otherwise, it is assumed to be a standard config object and is applied to the component.
		/// </summary>
		/// <param name="config">The configuration options.  If an element is passed, it is set as the internal</param>
		/// <returns></returns>
		public extern CheckItem(string config);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static CheckItem prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.menu.Item superclass { get; set; }

		/// <summary>
		///     All check items with the same group name will automatically be grouped into a single-select
		///     radio button group (defaults to '')
		/// </summary>
		public extern string group { get; set; }

		/// <summary>The default CSS class to use for check items (defaults to "x-menu-item x-menu-check-item")</summary>
		public extern string itemCls { get; set; }

		/// <summary>The default CSS class to use for radio group check items (defaults to "x-menu-group-item")</summary>
		public extern string groupClass { get; set; }

		/// <summary>
		///     True to initialize this checkbox as checked (defaults to false).  Note thatif this checkbox is part of a radio group (group = true) only the last item in the group that is
		///     initialized with checked = true will be rendered as checked.
		/// </summary>
		public extern bool checked_ { get; set; }


		/// <summary>
		///     A function that handles the checkchange event.  The function is undefined by default, but if an implementation
		///     is provided, it will be called automatically when the checkchange event fires.
		/// </summary>
		/// <returns></returns>
		public extern virtual void checkHandler();

		/// <summary>
		///     A function that handles the checkchange event.  The function is undefined by default, but if an implementation
		///     is provided, it will be called automatically when the checkchange event fires.
		/// </summary>
		/// <param name="objthis"></param>
		/// <returns></returns>
		public extern virtual void checkHandler(Ext.menu.CheckItem objthis);

		/// <summary>
		///     A function that handles the checkchange event.  The function is undefined by default, but if an implementation
		///     is provided, it will be called automatically when the checkchange event fires.
		/// </summary>
		/// <param name="objthis"></param>
		/// <param name="chckd">The checked value that was set</param>
		/// <returns></returns>
		public extern virtual void checkHandler(Ext.menu.CheckItem objthis, bool chckd);

		/// <summary>Set the checked state of this item</summary>
		/// <returns></returns>
		public extern virtual void setChecked();

		/// <summary>Set the checked state of this item</summary>
		/// <param name="chckd">The new checked value</param>
		/// <returns></returns>
		public extern virtual void setChecked(bool chckd);

		/// <summary>Set the checked state of this item</summary>
		/// <param name="chckd">The new checked value</param>
		/// <param name="suppressEvent">(optional) True to prevent the checkchange event from firing (defaults to false)</param>
		/// <returns></returns>
		public extern virtual void setChecked(bool chckd, bool suppressEvent);



	}

	[JsAnonymous]
	public class CheckItemConfig : System.DotWeb.JsDynamic {
		/// <summary>  All check items with the same group name will automatically be grouped into a single-select radio button group (defaults to '')</summary>
		public extern string group { get; set; }

		/// <summary> The default CSS class to use for check items (defaults to "x-menu-item x-menu-check-item")</summary>
		public extern string itemCls { get; set; }

		/// <summary> The default CSS class to use for radio group check items (defaults to "x-menu-group-item")</summary>
		public extern string groupClass { get; set; }

		/// <summary> True to initialize this checkbox as checked (defaults to false).  Note that if this checkbox is part of a radio group (group = true) only the last item in the group that is initialized with checked = true will be rendered as checked.</summary>
		public extern bool checked_ { get; set; }

		/// <summary> Either an instance of {@link Ext.menu.Menu} or the config object for an {@link Ext.menu.Menu} which acts as the submenu when this item is activated.</summary>
		public extern object menu { get; set; }

		/// <summary> The path to an icon to display in this item (defaults to Ext.BLANK_IMAGE_URL).  If icon is specified {@link #iconCls} should not be.</summary>
		public extern string icon { get; set; }

		/// <summary> A CSS class that specifies a background image that will be used as the icon for this item (defaults to '').  If iconCls is specified {@link #icon} should not be.</summary>
		public extern string iconCls { get; set; }

		/// <summary> The text to display in this item (defaults to '').</summary>
		public extern string text { get; set; }

		/// <summary> The href attribute to use for the underlying anchor link (defaults to '#').</summary>
		public extern string href { get; set; }

		/// <summary> The target attribute to use for the underlying anchor link (defaults to '').</summary>
		public extern string hrefTarget { get; set; }

		/// <summary> True if this item can be visually activated (defaults to true)</summary>
		public extern bool canActivate { get; set; }

		/// <summary> Length of time in milliseconds to wait before showing this item (defaults to 200)</summary>
		public extern double showDelay { get; set; }

		/// <summary>  A function that will handle the click event of this menu item (optional). The handler is passed the following parameters:<div class="mdetail-params"><ul> <li><code>b</code> : Item<div class="sub-desc">This menu Item.</div></li> <li><code>e</code> : EventObject<div class="sub-desc">The click event.</div></li> </ul></div></summary>
		public extern Delegate handler { get; set; }

		/// <summary>  The scope (<tt><b>this</b></tt> reference) in which the handler function will be called.</summary>
		public extern object scope { get; set; }

		/// <summary> The CSS class to use when the item becomes activated (defaults to "x-menu-item-active")</summary>
		public extern string activeClass { get; set; }

		/// <summary> True to hide the containing menu after this item is clicked (defaults to true)</summary>
		public extern bool hideOnClick { get; set; }

		/// <summary> Length of time in milliseconds to wait before hiding after a click (defaults to 100)</summary>
		public extern double hideDelay { get; set; }

		/// <summary> 
		///     The registered xtype to create. This config option is not used when passing a config object into a constructor. This config option is used only when lazy instantiation is being used, and a child item of a Container is being specified not as a fully instantiated Component, but as a Component config object. The xtype will be looked up at render time up to determine what type of child Component to create.
		///     The predefined xtypes are listed at the top of this document.
		///     If you subclass Components to create your own Components, you may register them using Ext.ComponentMgr.registerType in order to be able to take advantage of lazy instantiation and rendering.
		/// </summary>
		public extern string xtype { get; set; }

		/// <summary> The label text to display next to this Component (defaults to '') <p><b>This config is only used when this Component is rendered by a Container which has been configured to use the {@link Ext.form.FormLayout FormLayout} layout manager.</b></p> Example use:<pre><code> new Ext.FormPanel({ height: 100, renderTo: Ext.getBody(), items: [{ xtype: 'textfield', fieldLabel: 'Name' }] }); </code></pre></summary>
		public extern string fieldLabel { get; set; }

		/// <summary> A CSS style specification to apply directly to this field's label (defaults to the container's labelStyle value if set, or '').<code></code>. <p><b>This config is only used when this Component is rendered by a Container which has been configured to use the {@link Ext.form.FormLayout FormLayout} layout manager.</b></p> Example use:<pre><code> new Ext.FormPanel({ height: 100, renderTo: Ext.getBody(), items: [{ xtype: 'textfield', fieldLabel: 'Name', labelStyle: 'font-weight:bold;' }] }); </code></pre></summary>
		public extern string labelStyle { get; set; }

		/// <summary> The standard separator to display after the text of each form label (defaults to the value of {@link Ext.layout.FormLayout#labelSeparator}, which is a colon ':' by default).  To display no separator for this field's label specify empty string ''. <p><b>This config is only used when this Component is rendered by a Container which has been configured to use the {@link Ext.form.FormLayout FormLayout} layout manager.</b></p> Example use:<pre><code> new Ext.FormPanel({ height: 100, renderTo: Ext.getBody(), items: [{ xtype: 'textfield', fieldLabel: 'Name', labelSeparator: '...' }] }); </code></pre></summary>
		public extern string labelSeparator { get; set; }

		/// <summary> True to completely hide the label element (defaults to false).  By default, even if you do not specify a {@link fieldLabel} the space will still be reserved so that the field will line up with other fields that do have labels. Setting this to true will cause the field to not reserve that space. <p><b>This config is only used when this Component is rendered by a Container which has been configured to use the {@link Ext.form.FormLayout FormLayout} layout manager.</b></p> Example use:<pre><code> new Ext.FormPanel({ height: 100, renderTo: Ext.getBody(), items: [{ xtype: 'textfield' hideLabel: true }] }); </code></pre></summary>
		public extern bool hideLabel { get; set; }

		/// <summary> The CSS class used to provide field clearing (defaults to 'x-form-clear-left'). <p><b>This config is only used when this Component is rendered by a Container which has been configured to use the {@link Ext.form.FormLayout FormLayout} layout manager.</b></p></summary>
		public extern string clearCls { get; set; }

		/// <summary>  The unique id of this component (defaults to an auto-assigned id). You should assign an id if you need to be able to access the component later and you do not have an object reference available (e.g., using {@link Ext.ComponentMgr#getCmp}). Note that this id will also be used as the element id for the containing HTML element that is rendered to the page for this component. This allows you to write id-based CSS rules to style the specific instance of this component uniquely, and also to select sub-elements using this component's id as the parent.</summary>
		public extern string id { get; set; }

		/// <summary>  <p>A tag name or {@link Ext.DomHelper DomHelper} spec used to create the {@link #getEl Element} which will encapsulate this Component.</p> <p>You only need to specify this when creating or subclassing the base classes {@link Ext.Component}, {@link Ext.BoxComponent}, and {@link Ext.Container}. The more complex Ext classes use a more complex DOM structure created by their own onRender methods.</p> <p>This is intended to allow the developer to create application-specific utility Components encapsulated by different DOM elements. Example usage:</p><pre><code> { xtype: 'box', autoEl: { tag: 'img', src: 'http://www.example.com/example.jpg' } }, { xtype: 'box', autoEl: { tag: 'blockquote', html: 'autoEl is cool!' } }, { xtype: 'container', autoEl: 'ul', cls: 'ux-unordered-list', items: { xtype: 'box', autoEl: 'li', html: 'First list item' } } </code></pre></summary>
		public extern object autoEl { get; set; }

		/// <summary>  An optional extra CSS class that will be added to this component's Element (defaults to '').  This can be useful for adding customized styles to the component or any of its children using standard CSS rules.</summary>
		public extern string cls { get; set; }

		/// <summary>  An optional extra CSS class that will be added to this component's Element when the mouse moves over the Element, and removed when the mouse moves out. (defaults to '').  This can be useful for adding customized "active" or "hover" styles to the component or any of its children using standard CSS rules.</summary>
		public extern string overCls { get; set; }

		/// <summary>  A custom style specification to be applied to this component's Element.  Should be a valid argument to {@link Ext.Element#applyStyles}.</summary>
		public extern string style { get; set; }

		/// <summary>  An optional extra CSS class that will be added to this component's container (defaults to '').  This can be useful for adding customized styles to the container or any of its children using standard CSS rules.</summary>
		public extern string ctCls { get; set; }

		/// <summary>  Render this component disabled (default is false).</summary>
		public extern bool disabled { get; set; }

		/// <summary>  Render this component hidden (default is false).</summary>
		public extern bool hidden { get; set; }

		/// <summary>{Object/Array}  An object or array of objects that will provide custom functionality for this component.  The only requirement for a valid plugin is that it contain an init method that accepts a reference of type Ext.Component. When a component is created, if any plugins are available, the component will call the init method on each plugin, passing a reference to itself.  Each plugin can then call methods or respond to events on the component as needed to provide its functionality.</summary>
		public extern object plugins { get; set; }

		/// <summary>  The id of the element, a DOM element or an existing Element corresponding to a DIV that is already present in the document that specifies some structural markup for this component.  When applyTo is used, constituent parts of the component can also be specified by id or CSS class name within the main element, and the component being created may attempt to create its subcomponents from that markup if applicable. Using this config, a call to render() is not required.  If applyTo is specified, any value passed for {@link #renderTo} will be ignored and the target element's parent node will automatically be used as the component's container.</summary>
		public extern object applyTo { get; set; }

		/// <summary>  <p>The id of the element, a DOM element or an existing Element that this component will be rendered into. When using this config, a call to render() is not required.<p> <p>If this Component needs to be managed by a {@link Ext.Container Container}'s {@link Ext.Component#layout layout manager}, do not use this option. It is the responsiblity of the Container's layout manager to perform rendering. See {@link #render}.</p></summary>
		public extern object renderTo { get; set; }

		/// <summary>  <p>A flag which causes the Component to attempt to restore the state of internal properties from a saved state on startup. The component must have either a {@link #stateId} or {@link #id} assigned for state to be managed.  Auto-generated ids are not guaranteed to be stable across page loads and cannot be relied upon to save and restore the same state for a component.<p> For state saving to work, the state manager's provider must have been set to an implementation of {@link Ext.state.Provider} which overrides the {@link Ext.state.Provider#set set} and {@link Ext.state.Provider#get get} methods to save and recall name/value pairs. A built-in implementation, {@link Ext.state.CookieProvider} is available.</p> <p>To set the state provider for the current page:</p> <pre><code> Ext.state.Manager.setProvider(new Ext.state.CookieProvider()); </code></pre> <p>Components attempt to save state when one of the events listed in the {@link #stateEvents} configuration fires.</p> <p>You can perform extra processing on state save and restore by attaching handlers to the {@link #beforestaterestore}, {@link #staterestore}, {@link #beforestatesave} and {@link #statesave} events</p></summary>
		public extern bool stateful { get; set; }

		/// <summary>  The unique id for this component to use for state management purposes (defaults to the component id if one was set, otherwise null if the component is using a generated id). <p>See {@link #stateful} for an explanation of saving and restoring Component state.</p></summary>
		public extern string stateId { get; set; }

		/// <summary>  CSS class added to the component when it is disabled (defaults to "x-item-disabled").</summary>
		public extern string disabledClass { get; set; }

		/// <summary>  Whether the component can move the Dom node when rendering (defaults to true).</summary>
		public extern bool allowDomMove { get; set; }

		/// <summary>  True if the component should check for hidden classes (e.g. 'x-hidden' or 'x-hide-display') and remove them on render (defaults to false).</summary>
		public extern bool autoShow { get; set; }

		/// <summary>  <p>How this component should be hidden. Supported values are "visibility" (css visibility), "offsets" (negative offset position) and "display" (css display) - defaults to "display".</p> <p>For Containers which may be hidden and shown as part of a {@link Ext.layout.CardLayout card layout} Container such as a {@link Ext.TabPanel TabPanel}, it is recommended that hideMode is configured as "offsets". This ensures that hidden Components still have height and width so that layout managers can perform measurements when calculating layouts.</p></summary>
		public extern string hideMode { get; set; }

		/// <summary>  True to hide and show the component's container when hide/show is called on the component, false to hide and show the component itself (defaults to false).  For example, this can be used as a shortcut for a hide button on a window by setting hide:true on the button when adding it to its parent container.</summary>
		public extern bool hideParent { get; set; }

		/// <summary> (optional) A config object containing one or more event handlers to be added to this object during initialization.  This should be a valid listeners config object as specified in the {@link #addListener} example for attaching multiple handlers at once.</summary>
		public extern object listeners { get; set; }

	}

    public class CheckItemEvents {
        /// <summary>Fires before the checked value is set, providing an opportunity to cancel if needed
        /// <pre><code>
        /// USAGE: ({Ext.menu.CheckItem} objthis, {Boolean} chckd)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>chckd</b></term><description>The new checked value that will be set</description></item>
        /// </list>
        /// </summary>
        public static string beforecheckchange { get { return "beforecheckchange"; } }
        /// <summary>Fires after the checked value has been set
        /// <pre><code>
        /// USAGE: ({Ext.menu.CheckItem} objthis, {Boolean} chckd)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>chckd</b></term><description>The checked value that was set</description></item>
        /// </list>
        /// </summary>
        public static string checkchange { get { return "checkchange"; } }
    }

    public delegate void CheckItemBeforecheckchangeDelegate(Ext.menu.CheckItem objthis, bool chckd);
    public delegate void CheckItemCheckchangeDelegate(Ext.menu.CheckItem objthis, bool chckd);
}
