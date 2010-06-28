using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext {
	/// <summary>
	///     /**
	///     A base editor field that handles displaying/hiding on demand and has some built-in sizing and event handling logic.
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\Editor.js</jssource>
	public class Editor : Ext.Component {

		/// <summary>Create a new Editor</summary>
		/// <returns></returns>
		public extern Editor();
		/// <summary>Create a new Editor</summary>
		/// <param name="field">The Field object (or descendant)</param>
		/// <returns></returns>
		public extern Editor(Ext.form.Field field);
		/// <summary>Create a new Editor</summary>
		/// <param name="field">The Field object (or descendant)</param>
		/// <param name="config">The config object</param>
		/// <returns></returns>
		public extern Editor(Ext.form.Field field, object config);
		/// <summary>
		///     element and its id used as the component id.  If a string is passed, it is assumed to be the id of an existing element
		///     and is used as the component id.  Otherwise, it is assumed to be a standard config object and is applied to the component.
		/// </summary>
		/// <param name="config">The configuration options.  If an element is passed, it is set as the internal</param>
		/// <returns></returns>
		public extern Editor(Ext.Element config);
		/// <summary>
		///     element and its id used as the component id.  If a string is passed, it is assumed to be the id of an existing element
		///     and is used as the component id.  Otherwise, it is assumed to be a standard config object and is applied to the component.
		/// </summary>
		/// <param name="config">The configuration options.  If an element is passed, it is set as the internal</param>
		/// <returns></returns>
		public extern Editor(string config);
		/// <summary>
		///     element and its id used as the component id.  If a string is passed, it is assumed to be the id of an existing element
		///     and is used as the component id.  Otherwise, it is assumed to be a standard config object and is applied to the component.
		/// </summary>
		/// <param name="config">The configuration options.  If an element is passed, it is set as the internal</param>
		/// <returns></returns>
		public extern Editor(object config);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static Editor prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.Component superclass { get; set; }

		/// <summary>
		///     True for the editor to automatically adopt the size of the underlying field, "width" to adopt the width only,
		///     or "height" to adopt the height only (defaults to false)
		/// </summary>
		public extern object autoSize { get; set; }

		/// <summary>
		///     True to automatically revert the field value and cancel the edit when the user completes an edit and the field
		///     validation fails (defaults to true)
		/// </summary>
		public extern bool revertInvalid { get; set; }

		/// <summary>
		///     True to skip the edit completion process (no save, no events fired) if the user completes an edit and
		///     the value has not changed (defaults to false).  Applies only to string values - edits for other data types
		///     will never be ignored.
		/// </summary>
		public extern bool ignoreNoChange { get; set; }

		/// <summary>False to keep the bound element visible while the editor is displayed (defaults to true)</summary>
		public extern bool hideEl { get; set; }

		/// <summary>The data value of the underlying field (defaults to "")</summary>
		public extern object value { get; set; }

		/// <summary>The position to align to (see {@link Ext.Element#alignTo} for more details, defaults to "c-c?").</summary>
		public extern string alignment { get; set; }

		/// <summary>"sides" for sides/bottom only, "frame" for 4-way shadow, and "drop"for bottom-right shadow (defaults to "frame")</summary>
		public extern object shadow { get; set; }

		/// <summary>True to constrain the editor to the viewport</summary>
		public extern bool constrain { get; set; }

		/// <summary>Handle the keydown/keypress events so they don't propagate (defaults to true)</summary>
		public extern bool swallowKeys { get; set; }

		/// <summary>True to complete the edit when the enter key is pressed (defaults to false)</summary>
		public extern bool completeOnEnter { get; set; }

		/// <summary>True to cancel the edit when the escape key is pressed (defaults to false)</summary>
		public extern bool cancelOnEsc { get; set; }

		/// <summary>True to update the innerHTML of the bound element when the update completes (defaults to false)</summary>
		public extern bool updateEl { get; set; }


		/// <summary>
		///     Starts the editing process and shows the editor.
		///     to the innerHTML of el.
		/// </summary>
		/// <returns></returns>
		public extern virtual void startEdit();

		/// <summary>
		///     Starts the editing process and shows the editor.
		///     to the innerHTML of el.
		/// </summary>
		/// <param name="el">The element to edit</param>
		/// <returns></returns>
		public extern virtual void startEdit(object el);

		/// <summary>
		///     Starts the editing process and shows the editor.
		///     to the innerHTML of el.
		/// </summary>
		/// <param name="el">The element to edit</param>
		/// <param name="value">(optional) A value to initialize the editor with. If a value is not provided, it defaults</param>
		/// <returns></returns>
		public extern virtual void startEdit(object el, string value);

		/// <summary>Sets the height and width of this editor.</summary>
		/// <returns></returns>
		public extern virtual void setSize();

		/// <summary>Sets the height and width of this editor.</summary>
		/// <param name="width">The new width</param>
		/// <returns></returns>
		public extern virtual void setSize(double width);

		/// <summary>Sets the height and width of this editor.</summary>
		/// <param name="width">The new width</param>
		/// <param name="height">The new height</param>
		/// <returns></returns>
		public extern virtual void setSize(double width, double height);

		/// <summary>Realigns the editor to the bound field based on the current alignment config value.</summary>
		/// <returns></returns>
		public extern virtual void realign();

		/// <summary>Ends the editing process, persists the changed value to the underlying field, and hides the editor.</summary>
		/// <returns></returns>
		public extern virtual void completeEdit();

		/// <summary>Ends the editing process, persists the changed value to the underlying field, and hides the editor.</summary>
		/// <param name="remainVisible">Override the default behavior and keep the editor visible after edit (defaults to false)</param>
		/// <returns></returns>
		public extern virtual void completeEdit(bool remainVisible);

		/// <summary>
		///     Cancels the editing process and hides the editor without persisting any changes.  The field value will be
		///     reverted to the original starting value.
		///     cancel (defaults to false)
		/// </summary>
		/// <returns></returns>
		public extern virtual void cancelEdit();

		/// <summary>
		///     Cancels the editing process and hides the editor without persisting any changes.  The field value will be
		///     reverted to the original starting value.
		///     cancel (defaults to false)
		/// </summary>
		/// <param name="remainVisible">Override the default behavior and keep the editor visible after</param>
		/// <returns></returns>
		public extern virtual void cancelEdit(bool remainVisible);

		/// <summary>Sets the data value of the editor</summary>
		/// <returns></returns>
		public extern virtual void setValue();

		/// <summary>Sets the data value of the editor</summary>
		/// <param name="value">Any valid value supported by the underlying field</param>
		/// <returns></returns>
		public extern virtual void setValue(object value);

		/// <summary>Gets the data value of the editor</summary>
		/// <returns>Mixed</returns>
		public extern virtual void getValue();



	}

	[JsAnonymous]
	public class EditorConfig : System.DotWeb.JsDynamic {
		/// <summary>{Boolean/String}  True for the editor to automatically adopt the size of the underlying field, "width" to adopt the width only, or "height" to adopt the height only (defaults to false)</summary>
		public extern object autoSize { get; set; }

		/// <summary>  True to automatically revert the field value and cancel the edit when the user completes an edit and the field validation fails (defaults to true)</summary>
		public extern bool revertInvalid { get; set; }

		/// <summary>  True to skip the edit completion process (no save, no events fired) if the user completes an edit and the value has not changed (defaults to false).  Applies only to string values - edits for other data types will never be ignored.</summary>
		public extern bool ignoreNoChange { get; set; }

		/// <summary>  False to keep the bound element visible while the editor is displayed (defaults to true)</summary>
		public extern bool hideEl { get; set; }

		/// <summary>  The data value of the underlying field (defaults to "")</summary>
		public extern object value { get; set; }

		/// <summary>  The position to align to (see {@link Ext.Element#alignTo} for more details, defaults to "c-c?").</summary>
		public extern string alignment { get; set; }

		/// <summary>{Boolean/String} "sides" for sides/bottom only, "frame" for 4-way shadow, and "drop" for bottom-right shadow (defaults to "frame")</summary>
		public extern object shadow { get; set; }

		/// <summary> True to constrain the editor to the viewport</summary>
		public extern bool constrain { get; set; }

		/// <summary> Handle the keydown/keypress events so they don't propagate (defaults to true)</summary>
		public extern bool swallowKeys { get; set; }

		/// <summary> True to complete the edit when the enter key is pressed (defaults to false)</summary>
		public extern bool completeOnEnter { get; set; }

		/// <summary> True to cancel the edit when the escape key is pressed (defaults to false)</summary>
		public extern bool cancelOnEsc { get; set; }

		/// <summary> True to update the innerHTML of the bound element when the update completes (defaults to false)</summary>
		public extern bool updateEl { get; set; }

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

    public class EditorEvents {
        /// <summary>
        ///     Fires when editing is initiated, but before the value changes.  Editing can be canceled by returning
        ///     false from the handler of this event.
        /// 
        /// <pre><code>
        /// USAGE: ({Editor} objthis, {Ext.Element} boundEl, {Mixed} value)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>boundEl</b></term><description>The underlying element bound to this editor</description></item>
        /// <item><term><b>value</b></term><description>The field value being set</description></item>
        /// </list>
        /// </summary>
        public static string beforestartedit { get { return "beforestartedit"; } }
        /// <summary>Fires when this editor is displayed
        /// <pre><code>
        /// USAGE: ({Ext.Element} boundEl, {Mixed} value)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>boundEl</b></term><description>The underlying element bound to this editor</description></item>
        /// <item><term><b>value</b></term><description>The starting field value</description></item>
        /// </list>
        /// </summary>
        public static string startedit { get { return "startedit"; } }
        /// <summary>
        ///     Fires after a change has been made to the field, but before the change is reflected in the underlying
        ///     field.  Saving the change to the field can be canceled by returning false from the handler of this event.
        ///     Note that if the value has not changed and ignoreNoChange = true, the editing will still end but this
        ///     event will not fire since no edit actually occurred.
        /// 
        /// <pre><code>
        /// USAGE: ({Editor} objthis, {Mixed} value, {Mixed} startValue)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>value</b></term><description>The current field value</description></item>
        /// <item><term><b>startValue</b></term><description>The original field value</description></item>
        /// </list>
        /// </summary>
        public static string beforecomplete { get { return "beforecomplete"; } }
        /// <summary>Fires after editing is complete and any changed value has been written to the underlying field.
        /// <pre><code>
        /// USAGE: ({Editor} objthis, {Mixed} value, {Mixed} startValue)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>value</b></term><description>The current field value</description></item>
        /// <item><term><b>startValue</b></term><description>The original field value</description></item>
        /// </list>
        /// </summary>
        public static string complete { get { return "complete"; } }
        /// <summary>Fires after editing has been canceled and the editor's value has been reset.
        /// <pre><code>
        /// USAGE: ({Editor} objthis, {Mixed} value, {Mixed} startValue)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>value</b></term><description>The user-entered field value that was discarded</description></item>
        /// <item><term><b>startValue</b></term><description>The original field value that was set back into the editor after cancel</description></item>
        /// </list>
        /// </summary>
        public static string canceledit { get { return "canceledit"; } }
        /// <summary>
        ///     Fires when any key related to navigation (arrows, tab, enter, esc, etc.) is pressed.  You can check
        ///     {@link Ext.EventObject#getKey} to determine which key was pressed.
        /// 
        /// <pre><code>
        /// USAGE: ({Ext.form.Field} objthis, {Ext.EventObject} e)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>e</b></term><description>The event object</description></item>
        /// </list>
        /// </summary>
        public static string specialkey { get { return "specialkey"; } }
    }

    public delegate void EditorBeforestarteditDelegate(Editor objthis, Ext.Element boundEl, object value);
    public delegate void EditorStarteditDelegate(Ext.Element boundEl, object value);
    public delegate void EditorBeforecompleteDelegate(Editor objthis, object value, object startValue);
    public delegate void EditorCompleteDelegate(Editor objthis, object value, object startValue);
    public delegate void EditorCanceleditDelegate(Editor objthis, object value, object startValue);
    public delegate void EditorSpecialkeyDelegate(Ext.form.Field objthis, Ext.EventObject e);
}
