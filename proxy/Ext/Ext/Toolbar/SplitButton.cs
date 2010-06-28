using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.Toolbar {
	/// <summary>
	///     /**
	///     A split button that renders into a toolbar.
	///     <pre><code>
	///     new Ext.Panel({
	///     tbar : [
	///     {
	///     xtype: 'tbsplit',
	///     text: 'Options',
	///     handler: optionsHandler, // handle a click on the button itself
	///     menu: new Ext.menu.Menu({
	///     items: [
	///     // These items will display in a dropdown menu when the split arrow is clicked
	///     {text: 'Item 1', handler: item1Handler},
	///     {text: 'Item 2', handler: item2Handler}
	///     ]
	///     })
	///     }
	///     ]
	///     });
	///     </code></pre>
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\Toolbar.js</jssource>
	public class SplitButton : Ext.SplitButton {

		/// <summary>Creates a new SplitButton</summary>
		/// <returns></returns>
		public extern SplitButton();
		/// <summary>Creates a new SplitButton</summary>
		/// <param name="config">A standard {@link Ext.SplitButton} config object</param>
		/// <returns></returns>
		public extern SplitButton(object config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern SplitButton(Ext.Element config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern SplitButton(string config);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static SplitButton prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.SplitButton superclass { get; set; }




	}

	[JsAnonymous]
	public class SplitButtonConfig : System.DotWeb.JsDynamic {
		/// <summary> A function called when the arrow button is clicked (can be used instead of click event)</summary>
		public extern Delegate arrowHandler { get; set; }

		/// <summary> The title attribute of the arrow</summary>
		public extern string arrowTooltip { get; set; }

		/// <summary> The button text</summary>
		public extern string text { get; set; }

		/// <summary> The path to an image to display in the button (the image will be set as the background-image</summary>
		public extern string icon { get; set; }

		/// <summary> A function called when the button is clicked (can be used instead of click event).</summary>
		public extern Delegate handler { get; set; }

		/// <summary> The scope (<tt><b>this</b></tt> reference) in which the handler is executed. Defaults to this Button.</summary>
		public extern object scope { get; set; }

		/// <summary> The minimum width for this button (used to give a set of buttons a common width)</summary>
		public extern double minWidth { get; set; }

		/// <summary>{String/Object} The tooltip for the button - can be a string or QuickTips config object</summary>
		public extern object tooltip { get; set; }

		/// <summary> True to start hidden (defaults to false)</summary>
		public extern bool hidden { get; set; }

		/// <summary> True to start disabled (defaults to false)</summary>
		public extern bool disabled { get; set; }

		/// <summary> True to start pressed (only if enableToggle = true)</summary>
		public extern bool pressed { get; set; }

		/// <summary> The group this toggle button is a member of (only 1 per group can be pressed)</summary>
		public extern string toggleGroup { get; set; }

		/// <summary>{Boolean/Object} True to repeat fire the click event while the mouse is down. This can also be</summary>
		public extern object repeat { get; set; }

		/// <summary> Set a DOM tabIndex for this button (defaults to undefined)</summary>
		public extern double tabIndex { get; set; }

		/// <summary>  False to not allow a pressed Button to be depressed (defaults to undefined). Only valid when {@link #enableToggle} is true.</summary>
		public extern bool allowDepress { get; set; }

		/// <summary>  True to enable pressed/not pressed toggling (defaults to false)</summary>
		public extern bool enableToggle { get; set; }

		/// <summary>  Function called when a Button with {@link #enableToggle} set to true is clicked. Two arguments are passed:<ul class="mdetail-params"> <li><b>button</b> : Ext.Button<div class="sub-desc">this Button object</div></li> <li><b>state</b> : Boolean<div class="sub-desc">The next state if the Button, true means pressed.</div></li> </ul></summary>
		public extern Delegate toggleHandler { get; set; }

		/// <summary>  Standard menu attribute consisting of a reference to a menu object, a menu id or a menu config blob (defaults to undefined).</summary>
		public extern object menu { get; set; }

		/// <summary>  The position to align the menu to (see {@link Ext.Element#alignTo} for more details, defaults to 'tl-bl?').</summary>
		public extern string menuAlign { get; set; }

		/// <summary>  A css class which sets a background image to be used as the icon for this button</summary>
		public extern string iconCls { get; set; }

		/// <summary>  submit, reset or button - defaults to 'button'</summary>
		public extern string type { get; set; }

		/// <summary>  The type of event to map to the button's event handler (defaults to 'click')</summary>
		public extern string clickEvent { get; set; }

		/// <summary>  False to disable visual cues on mouseover, mouseout and mousedown (defaults to true)</summary>
		public extern bool handleMouseEvents { get; set; }

		/// <summary>  The type of tooltip to use. Either "qtip" (default) for QuickTips or "title" for title attribute.</summary>
		public extern string tooltipType { get; set; }

		/// <summary>  <p>(Optional) A {@link Ext.DomQuery DomQuery} selector which is used to extract the active, clickable element from the DOM structure created.</p> <p>When a custom {@link #template} is used, you  must ensure that this selector results in the selection of a focussable element.</p> <p>Defaults to <b><tt>"button:first-child"</tt></b>.</p></summary>
		public extern string buttonSelector { get; set; }

		/// <summary>  (Optional) An {@link Ext.Template} with which to create the Button's main element. This Template must contain numeric substitution parameter 0 if it is to display the text property. Changing the template could require code modifications if required elements (e.g. a button) aren't present.</summary>
		public extern Ext.Template template { get; set; }

		/// <summary>  A CSS class string to apply to the button's main element.</summary>
		public extern string cls { get; set; }

		/// <summary>  The local x (left) coordinate for this component if contained within a positioning container.</summary>
		public extern double x { get; set; }

		/// <summary>  The local y (top) coordinate for this component if contained within a positioning container.</summary>
		public extern double y { get; set; }

		/// <summary>  The page level x coordinate for this component if contained within a positioning container.</summary>
		public extern double pageX { get; set; }

		/// <summary>  The page level y coordinate for this component if contained within a positioning container.</summary>
		public extern double pageY { get; set; }

		/// <summary>  The height of this component in pixels (defaults to auto).</summary>
		public extern double height { get; set; }

		/// <summary>  The width of this component in pixels (defaults to auto).</summary>
		public extern double width { get; set; }

		/// <summary>  True to use height:'auto', false to use fixed height (defaults to false). <b>Note</b>: Although many components inherit this config option, not all will function as expected with a height of 'auto'. Setting autoHeight:true means that the browser will manage height based on the element's contents, and that Ext will not manage it at all.</summary>
		public extern bool autoHeight { get; set; }

		/// <summary>  True to use width:'auto', false to use fixed width (defaults to false). <b>Note</b>: Although many components inherit this config option, not all will function as expected with a width of 'auto'. Setting autoWidth:true means that the browser will manage width based on the element's contents, and that Ext will not manage it at all.</summary>
		public extern bool autoWidth { get; set; }

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

		/// <summary> An additional CSS class to apply to the wrapper's form item element of this field (defaults to the container's itemCls value if set, or '').  Since it is applied to the item wrapper, it allows you to write standard CSS rules that can apply to the field, the label (if specified) or any other element within the markup for the field. <p><b>This config is only used when this Component is rendered by a Container which has been configured to use the {@link Ext.form.FormLayout FormLayout} layout manager.</b></p> Example use:<pre><code> // Apply a style to the field's label: &lt;style> .required .x-form-item-label {font-weight:bold;color:red;} &lt;/style> new Ext.FormPanel({ height: 100, renderTo: Ext.getBody(), items: [{ xtype: 'textfield', fieldLabel: 'Name', itemCls: 'required' //this label will be styled },{ xtype: 'textfield', fieldLabel: 'Favorite Color' }] }); </code></pre></summary>
		public extern string itemCls { get; set; }

		/// <summary>  The unique id of this component (defaults to an auto-assigned id). You should assign an id if you need to be able to access the component later and you do not have an object reference available (e.g., using {@link Ext.ComponentMgr#getCmp}). Note that this id will also be used as the element id for the containing HTML element that is rendered to the page for this component. This allows you to write id-based CSS rules to style the specific instance of this component uniquely, and also to select sub-elements using this component's id as the parent.</summary>
		public extern string id { get; set; }

		/// <summary>  <p>A tag name or {@link Ext.DomHelper DomHelper} spec used to create the {@link #getEl Element} which will encapsulate this Component.</p> <p>You only need to specify this when creating or subclassing the base classes {@link Ext.Component}, {@link Ext.BoxComponent}, and {@link Ext.Container}. The more complex Ext classes use a more complex DOM structure created by their own onRender methods.</p> <p>This is intended to allow the developer to create application-specific utility Components encapsulated by different DOM elements. Example usage:</p><pre><code> { xtype: 'box', autoEl: { tag: 'img', src: 'http://www.example.com/example.jpg' } }, { xtype: 'box', autoEl: { tag: 'blockquote', html: 'autoEl is cool!' } }, { xtype: 'container', autoEl: 'ul', cls: 'ux-unordered-list', items: { xtype: 'box', autoEl: 'li', html: 'First list item' } } </code></pre></summary>
		public extern object autoEl { get; set; }

		/// <summary>  An optional extra CSS class that will be added to this component's Element when the mouse moves over the Element, and removed when the mouse moves out. (defaults to '').  This can be useful for adding customized "active" or "hover" styles to the component or any of its children using standard CSS rules.</summary>
		public extern string overCls { get; set; }

		/// <summary>  A custom style specification to be applied to this component's Element.  Should be a valid argument to {@link Ext.Element#applyStyles}.</summary>
		public extern string style { get; set; }

		/// <summary>  An optional extra CSS class that will be added to this component's container (defaults to '').  This can be useful for adding customized styles to the container or any of its children using standard CSS rules.</summary>
		public extern string ctCls { get; set; }

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
}
