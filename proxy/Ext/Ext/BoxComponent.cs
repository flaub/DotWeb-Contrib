using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext {
	/// <summary>
	///     /**
	///     <p>Base class for any visual {@link Ext.Component} that uses a box container.  BoxComponent provides automatic box
	///     model adjustments for sizing and positioning and will work correctly withnin the Component rendering model.  All
	///     container classes should subclass BoxComponent so that they will work consistently when nested within other Ext
	///     layout containers.</p>
	///     <p>A BoxComponent may be created as a custom Component which encapsulates any HTML element, either a pre-existing
	///     element, or one that is created to your specifications at render time. Usually, to participate in layouts,
	///     a Component will need to be a <b>Box</b>Component in order to have its width and height managed.</p>
	///     <p>To use a pre-existing element as a BoxComponent, configure it so that you preset the <b>el</b> property to the
	///     element to reference:<pre><code>
	///     var pageHeader = new Ext.BoxComponent({
	///     el: 'my-header-div'
	///     });</code></pre>
	///     This may then be {@link Ext.Container#add added} to a {@link Ext.Container Container} as a child item.</p>
	///     <p>To create a BoxComponent based around a HTML element to be created at render time, use the
	///     {@link Ext.Component#autoEl autoEl} config option which takes the form of a
	///     {@link Ext.DomHelper DomHelper} specification:<pre><code>
	///     var myImage = new Ext.BoxComponent({
	///     autoEl: {
	///     tag: 'img',
	///     src: '/images/my-image.jpg'
	///     }
	///     });</code></pre></p>
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\BoxComponent.js</jssource>
	public class BoxComponent : Ext.Component {

		/// <summary></summary>
		/// <returns></returns>
		public extern BoxComponent();
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern BoxComponent(Ext.Element config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern BoxComponent(string config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern BoxComponent(object config);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static BoxComponent prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.Component superclass { get; set; }

		/// <summary>The local x (left) coordinate for this component if contained within a positioning container.</summary>
		public extern double x { get; set; }

		/// <summary>The local y (top) coordinate for this component if contained within a positioning container.</summary>
		public extern double y { get; set; }

		/// <summary>The page level x coordinate for this component if contained within a positioning container.</summary>
		public extern double pageX { get; set; }

		/// <summary>The page level y coordinate for this component if contained within a positioning container.</summary>
		public extern double pageY { get; set; }

		/// <summary>The height of this component in pixels (defaults to auto).</summary>
		public extern double height { get; set; }

		/// <summary>The width of this component in pixels (defaults to auto).</summary>
		public extern double width { get; set; }

		/// <summary>
		///     True to use height:'auto', false to use fixed height (defaults to false). <b>Note</b>: Although many components
		///     inherit this config option, not all will function as expected with a height of 'auto'. Setting autoHeight:true
		///     means that the browser will manage height based on the element's contents, and that Ext will not manage it at all.
		/// </summary>
		public extern bool autoHeight { get; set; }

		/// <summary>
		///     True to use width:'auto', false to use fixed width (defaults to false). <b>Note</b>: Although many components
		///     inherit this config option, not all will function as expected with a width of 'auto'. Setting autoWidth:true
		///     means that the browser will manage width based on the element's contents, and that Ext will not manage it at all.
		/// </summary>
		public extern bool autoWidth { get; set; }


		/// <summary>
		///     Sets the width and height of this BoxComponent. This method fires the {@link #resize} event. This method can accept
		///     either width and height as separate arguments, or you can pass a size object like <code>{width:10, height:20}</code>.
		///     <li>A Number specifying the new width in the {@link #getEl Element}'s {@link Ext.Element#defaultUnit}s (by default, pixels).</li>
		///     <li>A String used to set the CSS width style.</li>
		///     <li>A size object in the format <code>{width: widthValue, height: heightValue}</code>.</li>
		///     <li><code>undefined</code> to leave the width unchanged.</li>
		///     </ul></div>
		///     This may be one of:<div class="mdetail-params"><ul>
		///     <li>A Number specifying the new height in the {@link #getEl Element}'s {@link Ext.Element#defaultUnit}s (by default, pixels).</li>
		///     <li>A String used to set the CSS height style. Animation may <b>not</b> be used.</li>
		///     <li><code>undefined</code> to leave the height unchanged.</li>
		///     </ul></div>
		/// </summary>
		/// <returns>Ext.BoxComponent</returns>
		public extern virtual void setSize();

		/// <summary>
		///     Sets the width and height of this BoxComponent. This method fires the {@link #resize} event. This method can accept
		///     either width and height as separate arguments, or you can pass a size object like <code>{width:10, height:20}</code>.
		///     <li>A Number specifying the new width in the {@link #getEl Element}'s {@link Ext.Element#defaultUnit}s (by default, pixels).</li>
		///     <li>A String used to set the CSS width style.</li>
		///     <li>A size object in the format <code>{width: widthValue, height: heightValue}</code>.</li>
		///     <li><code>undefined</code> to leave the width unchanged.</li>
		///     </ul></div>
		///     This may be one of:<div class="mdetail-params"><ul>
		///     <li>A Number specifying the new height in the {@link #getEl Element}'s {@link Ext.Element#defaultUnit}s (by default, pixels).</li>
		///     <li>A String used to set the CSS height style. Animation may <b>not</b> be used.</li>
		///     <li><code>undefined</code> to leave the height unchanged.</li>
		///     </ul></div>
		/// </summary>
		/// <param name="width">The new width to set. This may be one of:<div class="mdetail-params"><ul></param>
		/// <returns>Ext.BoxComponent</returns>
		public extern virtual void setSize(object width);

		/// <summary>
		///     Sets the width and height of this BoxComponent. This method fires the {@link #resize} event. This method can accept
		///     either width and height as separate arguments, or you can pass a size object like <code>{width:10, height:20}</code>.
		///     <li>A Number specifying the new width in the {@link #getEl Element}'s {@link Ext.Element#defaultUnit}s (by default, pixels).</li>
		///     <li>A String used to set the CSS width style.</li>
		///     <li>A size object in the format <code>{width: widthValue, height: heightValue}</code>.</li>
		///     <li><code>undefined</code> to leave the width unchanged.</li>
		///     </ul></div>
		///     This may be one of:<div class="mdetail-params"><ul>
		///     <li>A Number specifying the new height in the {@link #getEl Element}'s {@link Ext.Element#defaultUnit}s (by default, pixels).</li>
		///     <li>A String used to set the CSS height style. Animation may <b>not</b> be used.</li>
		///     <li><code>undefined</code> to leave the height unchanged.</li>
		///     </ul></div>
		/// </summary>
		/// <param name="width">The new width to set. This may be one of:<div class="mdetail-params"><ul></param>
		/// <param name="height">The new height to set (not required if a size object is passed as the first arg).</param>
		/// <returns>Ext.BoxComponent</returns>
		public extern virtual void setSize(object width, object height);

		/// <summary>
		///     Sets the width of the component.  This method fires the {@link #resize} event.
		///     <li>A Number specifying the new width in the {@link #getEl Element}'s {@link Ext.Element#defaultUnit}s (by default, pixels).</li>
		///     <li>A String used to set the CSS width style.</li>
		///     </ul></div>
		/// </summary>
		/// <returns>Ext.BoxComponent</returns>
		public extern virtual void setWidth();

		/// <summary>
		///     Sets the width of the component.  This method fires the {@link #resize} event.
		///     <li>A Number specifying the new width in the {@link #getEl Element}'s {@link Ext.Element#defaultUnit}s (by default, pixels).</li>
		///     <li>A String used to set the CSS width style.</li>
		///     </ul></div>
		/// </summary>
		/// <param name="width">The new width to setThis may be one of:<div class="mdetail-params"><ul></param>
		/// <returns>Ext.BoxComponent</returns>
		public extern virtual void setWidth(double width);

		/// <summary>
		///     Sets the height of the component.  This method fires the {@link #resize} event.
		///     <li>A Number specifying the new height in the {@link #getEl Element}'s {@link Ext.Element#defaultUnit}s (by default, pixels).</li>
		///     <li>A String used to set the CSS height style.</li>
		///     <li><i>undefined</i> to leave the height unchanged.</li>
		///     </ul></div>
		/// </summary>
		/// <returns>Ext.BoxComponent</returns>
		public extern virtual void setHeight();

		/// <summary>
		///     Sets the height of the component.  This method fires the {@link #resize} event.
		///     <li>A Number specifying the new height in the {@link #getEl Element}'s {@link Ext.Element#defaultUnit}s (by default, pixels).</li>
		///     <li>A String used to set the CSS height style.</li>
		///     <li><i>undefined</i> to leave the height unchanged.</li>
		///     </ul></div>
		/// </summary>
		/// <param name="height">The new height to set. This may be one of:<div class="mdetail-params"><ul></param>
		/// <returns>Ext.BoxComponent</returns>
		public extern virtual void setHeight(double height);

		/// <summary>Gets the current size of the component's underlying element.</summary>
		/// <returns>Object</returns>
		public extern virtual void getSize();

		/// <summary>Gets the current XY position of the component's underlying element.</summary>
		/// <returns>Array</returns>
		public extern virtual void getPosition();

		/// <summary>Gets the current XY position of the component's underlying element.</summary>
		/// <param name="local">(optional) If true the element's left and top are returned instead of page XY (defaults to false)</param>
		/// <returns>Array</returns>
		public extern virtual void getPosition(bool local);

		/// <summary>Gets the current box measurements of the component's underlying element.</summary>
		/// <returns>Object</returns>
		public extern virtual void getBox();

		/// <summary>Gets the current box measurements of the component's underlying element.</summary>
		/// <param name="local">(optional) If true the element's left and top are returned instead of page XY (defaults to false)</param>
		/// <returns>Object</returns>
		public extern virtual void getBox(bool local);

		/// <summary>Sets the current box measurements of the component's underlying element.</summary>
		/// <returns>Ext.BoxComponent</returns>
		public extern virtual void updateBox();

		/// <summary>Sets the current box measurements of the component's underlying element.</summary>
		/// <param name="box">An object in the format {x, y, width, height}</param>
		/// <returns>Ext.BoxComponent</returns>
		public extern virtual void updateBox(object box);

		/// <summary>
		///     Sets the left and top of the component.  To set the page XY position instead, use {@link #setPagePosition}.
		///     This method fires the {@link #move} event.
		/// </summary>
		/// <returns>Ext.BoxComponent</returns>
		public extern virtual void setPosition();

		/// <summary>
		///     Sets the left and top of the component.  To set the page XY position instead, use {@link #setPagePosition}.
		///     This method fires the {@link #move} event.
		/// </summary>
		/// <param name="left">The new left</param>
		/// <returns>Ext.BoxComponent</returns>
		public extern virtual void setPosition(double left);

		/// <summary>
		///     Sets the left and top of the component.  To set the page XY position instead, use {@link #setPagePosition}.
		///     This method fires the {@link #move} event.
		/// </summary>
		/// <param name="left">The new left</param>
		/// <param name="top">The new top</param>
		/// <returns>Ext.BoxComponent</returns>
		public extern virtual void setPosition(double left, double top);

		/// <summary>
		///     Sets the page XY position of the component.  To set the left and top instead, use {@link #setPosition}.
		///     This method fires the {@link #move} event.
		/// </summary>
		/// <returns>Ext.BoxComponent</returns>
		public extern virtual void setPagePosition();

		/// <summary>
		///     Sets the page XY position of the component.  To set the left and top instead, use {@link #setPosition}.
		///     This method fires the {@link #move} event.
		/// </summary>
		/// <param name="x">The new x position</param>
		/// <returns>Ext.BoxComponent</returns>
		public extern virtual void setPagePosition(double x);

		/// <summary>
		///     Sets the page XY position of the component.  To set the left and top instead, use {@link #setPosition}.
		///     This method fires the {@link #move} event.
		/// </summary>
		/// <param name="x">The new x position</param>
		/// <param name="y">The new y position</param>
		/// <returns>Ext.BoxComponent</returns>
		public extern virtual void setPagePosition(double x, double y);

		/// <summary>Force the component's size to recalculate based on the underlying element's current height and width.</summary>
		/// <returns>Ext.BoxComponent</returns>
		public extern virtual void syncSize();



	}

	[JsAnonymous]
	public class BoxComponentConfig : System.DotWeb.JsDynamic {
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

    public class BoxComponentEvents {
        /// <summary>Fires after the component is resized.
        /// <pre><code>
        /// USAGE: ({Ext.Component} objthis, {Number} adjWidth, {Number} adjHeight, {Number} rawWidth, {Number} rawHeight)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>adjWidth</b></term><description>The box-adjusted width that was set</description></item>
        /// <item><term><b>adjHeight</b></term><description>The box-adjusted height that was set</description></item>
        /// <item><term><b>rawWidth</b></term><description>The width that was originally specified</description></item>
        /// <item><term><b>rawHeight</b></term><description>The height that was originally specified</description></item>
        /// </list>
        /// </summary>
        public static string resize { get { return "resize"; } }
        /// <summary>Fires after the component is moved.
        /// <pre><code>
        /// USAGE: ({Ext.Component} objthis, {Number} x, {Number} y)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>x</b></term><description>The new x position</description></item>
        /// <item><term><b>y</b></term><description>The new y position</description></item>
        /// </list>
        /// </summary>
        public static string move { get { return "move"; } }
    }

    public delegate void BoxComponentResizeDelegate(Ext.Component objthis, double adjWidth, double adjHeight, double rawWidth, double rawHeight);
    public delegate void BoxComponentMoveDelegate(Ext.Component objthis, double x, double y);
}
