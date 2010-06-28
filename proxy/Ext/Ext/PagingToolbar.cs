using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext {
	/// <summary>
	///     /**
	///     <p>A specialized toolbar that is bound to a {@link Ext.data.Store} and provides automatic paging control. This
	///     Component {@link Ext.data.Store#load load}s blocks of data into the Store passing parameters who's names are
	///     specified by the store's {@link Ext.data.Store#paramNames paramNames} property.</p>
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\PagingToolbar.js</jssource>
	public class PagingToolbar : Ext.ToolbarClass {

		/// <summary>Create a new PagingToolbar</summary>
		/// <returns></returns>
		public extern PagingToolbar();
		/// <summary>Create a new PagingToolbar</summary>
		/// <param name="config">The config object</param>
		/// <returns></returns>
		public extern PagingToolbar(object config);
		/// <summary>Creates a new Toolbar</summary>
		/// <param name="config">A config object or an array of buttons to <tt>{@link #add}</tt></param>
		/// <returns></returns>
		public extern PagingToolbar(System.Array config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern PagingToolbar(Ext.Element config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern PagingToolbar(string config);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static PagingToolbar prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.ToolbarClass superclass { get; set; }

		/// <summary>The {@link Ext.data.Store} the paging toolbar should use as its data source (required).</summary>
		public extern Ext.data.Store store { get; set; }

		/// <summary>True to display the displayMsg (defaults to false)</summary>
		public extern bool displayInfo { get; set; }

		/// <summary>The number of records to display per page (defaults to 20)</summary>
		public extern double pageSize { get; set; }

		/// <summary>
		///     The paging status message to display (defaults to "Displaying {0} - {1} of {2}").  Note that this string is
		///     formatted using the braced numbers 0-2 as tokens that are replaced by the values for start, end and total
		///     respectively. These tokens should be preserved when overriding this string if showing those values is desired.
		/// </summary>
		public extern string displayMsg { get; set; }

		/// <summary>The message to display when no records are found (defaults to "No data to display")</summary>
		public extern string emptyMsg { get; set; }

		/// <summary>Customizable piece of the default paging text (defaults to "Page")</summary>
		public extern string beforePageText { get; set; }

		/// <summary>
		///     Customizable piece of the default paging text (defaults to "of {0}"). Note that this string is
		///     formatted using {0} as a token that is replaced by the number of total pages. This token should be
		///     preserved when overriding this string if showing the total page count is desired.
		/// </summary>
		public extern string afterPageText { get; set; }

		/// <summary>Customizable piece of the default paging text (defaults to "First Page")</summary>
		public extern string firstText { get; set; }

		/// <summary>Customizable piece of the default paging text (defaults to "Previous Page")</summary>
		public extern string prevText { get; set; }

		/// <summary>Customizable piece of the default paging text (defaults to "Next Page")</summary>
		public extern string nextText { get; set; }

		/// <summary>Customizable piece of the default paging text (defaults to "Last Page")</summary>
		public extern string lastText { get; set; }

		/// <summary>Customizable piece of the default paging text (defaults to "Refresh")</summary>
		public extern string refreshText { get; set; }

		/// <summary>Object mapping of parameter names for load calls (defaults to {start: 'start', limit: 'limit'})</summary>
		public extern object paramNames { get; set; }


		/// <summary>Change the active page</summary>
		/// <returns></returns>
		public extern virtual void changePage();

		/// <summary>Change the active page</summary>
		/// <param name="page">The page to display</param>
		/// <returns></returns>
		public extern virtual void changePage(System.Number page);

		/// <summary>Unbinds the paging toolbar from the specified {@link Ext.data.Store}</summary>
		/// <returns></returns>
		public extern virtual void unbind();

		/// <summary>Unbinds the paging toolbar from the specified {@link Ext.data.Store}</summary>
		/// <param name="store">The data store to unbind</param>
		/// <returns></returns>
		public extern virtual void unbind(Ext.data.Store store);

		/// <summary>Binds the paging toolbar to the specified {@link Ext.data.Store}</summary>
		/// <returns></returns>
		public extern virtual void bind();

		/// <summary>Binds the paging toolbar to the specified {@link Ext.data.Store}</summary>
		/// <param name="store">The data store to bind</param>
		/// <returns></returns>
		public extern virtual void bind(Ext.data.Store store);



	}

	[JsAnonymous]
	public class PagingToolbarConfig : System.DotWeb.JsDynamic {
		/// <summary> The {@link Ext.data.Store} the paging toolbar should use as its data source (required).</summary>
		public extern Ext.data.Store store { get; set; }

		/// <summary>  True to display the displayMsg (defaults to false)</summary>
		public extern bool displayInfo { get; set; }

		/// <summary>  The number of records to display per page (defaults to 20)</summary>
		public extern double pageSize { get; set; }

		/// <summary>  The paging status message to display (defaults to "Displaying {0} - {1} of {2}").  Note that this string is formatted using the braced numbers 0-2 as tokens that are replaced by the values for start, end and total respectively. These tokens should be preserved when overriding this string if showing those values is desired.</summary>
		public extern string displayMsg { get; set; }

		/// <summary>  The message to display when no records are found (defaults to "No data to display")</summary>
		public extern string emptyMsg { get; set; }

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

    public class PagingToolbarEvents {
        /// <summary>
        ///     Fires after the active page has been changed.
        ///     <li><code>total</code> : Number <div class="sub-desc">The total number of records in the dataset as
        ///     returned by the server</div></li>
        ///     <li><code>activePage</code> : Number <div class="sub-desc">The current page number</div></li>
        ///     <li><code>pages</code> : Number <div class="sub-desc">The total number of pages (calculated from
        ///     the total number of records in the dataset as returned by the server and the current {@link #pageSize})</div></li>
        ///     </ul>
        /// 
        /// <pre><code>
        /// USAGE: ({Ext.PagingToolbar} objthis, {Object} changeEvent)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>changeEvent</b></term><description>An object that has these properties:<ul></description></item>
        /// </list>
        /// </summary>
        public static string change { get { return "change"; } }
        /// <summary>
        ///     Fires just before the active page is changed.
        ///     Return false to prevent the active page from being changed.
        ///     <li><code>start</code> : Number <div class="sub-desc">The starting row number for the next page of records to
        ///     be retrieved from the server</div></li>
        ///     <li><code>limit</code> : Number <div class="sub-desc">The number of records to be retrieved from the server</div></li>
        ///     </ul>
        ///     (note: the names of the <b>start</b> and <b>limit</b> properties are determined
        ///     by the store's {@link Ext.data.Store#paramNames paramNames} property.)
        /// 
        /// <pre><code>
        /// USAGE: ({Ext.PagingToolbar} objthis, {Object} beforeChangeEvent)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>beforeChangeEvent</b></term><description>An object that has these properties:<ul></description></item>
        /// </list>
        /// </summary>
        public static string beforechange { get { return "beforechange"; } }
    }

    public delegate void PagingToolbarChangeDelegate(Ext.PagingToolbar objthis, object changeEvent);
    public delegate void PagingToolbarBeforechangeDelegate(Ext.PagingToolbar objthis, object beforeChangeEvent);
}
