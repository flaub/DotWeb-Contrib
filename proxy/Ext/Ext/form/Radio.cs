using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.form {
	/// <summary>
	///     /**
	///     Single radio field.  Same as Checkbox, but provided as a convenience for automatically setting the input type.
	///     Radio grouping is handled automatically by the browser if you give each radio in a group the same name.
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\form\Radio.js</jssource>
	public class Radio : Ext.form.Checkbox {

		/// <summary>Creates a new Radio</summary>
		/// <returns></returns>
		public extern Radio();
		/// <summary>Creates a new Radio</summary>
		/// <param name="config">Configuration options</param>
		/// <returns></returns>
		public extern Radio(object config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern Radio(Ext.Element config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern Radio(string config);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static Radio prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.form.Checkbox superclass { get; set; }


		/// <summary>If this radio is part of a group, it will return the selected value</summary>
		/// <returns>String</returns>
		public extern virtual void getGroupValue();

		/// <summary>
		///     Sets either the checked/unchecked status of this Radio, or, if a string value
		///     is passed, checks a sibling Radio of the same name whose value is the value specified.
		/// </summary>
		/// <returns></returns>
		public extern virtual void setValue();

		/// <summary>
		///     Sets either the checked/unchecked status of this Radio, or, if a string value
		///     is passed, checks a sibling Radio of the same name whose value is the value specified.
		/// </summary>
		/// <param name="value">{String/Boolean} Checked value, or the value of the sibling radio button to check.</param>
		/// <returns></returns>
		public extern virtual void setValue(object value);

		/// <summary>Overridden and disabled. The editor element does not support standard valid/invalid marking. @hide</summary>
		/// <returns></returns>
		public extern virtual void markInvalid();

		/// <summary>Overridden and disabled. The editor element does not support standard valid/invalid marking. @hide</summary>
		/// <returns></returns>
		public extern virtual void clearInvalid();



	}

	[JsAnonymous]
	public class RadioConfig : System.DotWeb.JsDynamic {
		/// <summary> The CSS class to use when the control is checked (defaults to 'x-form-check-checked'). Note that this class applies to both checkboxes and radio buttons and is added to the control's wrapper element.</summary>
		public extern string checkedCls { get; set; }

		/// <summary> The CSS class to use when the control receives input focus (defaults to 'x-form-check-focus'). Note that this class applies to both checkboxes and radio buttons and is added to the control's wrapper element.</summary>
		public extern string focusCls { get; set; }

		/// <summary> The CSS class to use when the control is hovered over (defaults to 'x-form-check-over'). Note that this class applies to both checkboxes and radio buttons and is added to the control's wrapper element.</summary>
		public extern string overCls { get; set; }

		/// <summary> The CSS class to use when the control is being actively clicked (defaults to 'x-form-check-down'). Note that this class applies to both checkboxes and radio buttons and is added to the control's wrapper element.</summary>
		public extern string mouseDownCls { get; set; }

		/// <summary> The tabIndex for this field. Note this only applies to fields that are rendered, not those which are built via applyTo (defaults to 0, which allows the browser to manage the tab index).</summary>
		public extern double tabIndex { get; set; }

		/// <summary> True if the checkbox should render already checked (defaults to false)</summary>
		public extern bool checked_ { get; set; }

		/// <summary>{String/Object} A DomHelper element spec, or true for a default element spec (defaults to {tag: "input", type: "checkbox", autocomplete: "off"}).</summary>
		public extern object autoCreate { get; set; }

		/// <summary> The text that appears beside the checkbox (defaults to '')</summary>
		public extern string boxLabel { get; set; }

		/// <summary> The value that should go into the generated input element's value attribute (defaults to undefined, with no value attribute)</summary>
		public extern string inputValue { get; set; }

		/// <summary> A function called when the {@link #checked} value changes (can be used instead of handling the check event). The handler is passed the following parameters: <div class="mdetail-params"><ul> <li><b>checkbox</b> : Ext.form.Checkbox<div class="sub-desc">The Checkbox being toggled.</div></li> <li><b>checked</b> : Boolean<div class="sub-desc">The new checked state of the checkbox.</div></li> </ul></div></summary>
		public extern Delegate handler { get; set; }

		/// <summary> An object to use as the scope ("this" reference) of the {@link #handler} function (defaults to this Checkbox).</summary>
		public extern object scope { get; set; }

		/// <summary> The label text to display next to this field (defaults to '') <p><b>A Field's label is not by default rendered as part of the Field's structure. The label is rendered by the {@link Ext.layout.FormLayout form layout} layout manager of the {@link Ext.form.Container Container} to which the Field is added.</b></p></summary>
		public extern string fieldLabel { get; set; }

		/// <summary> A CSS style specification to apply directly to this field's label (defaults to the container's labelStyle value if set, or ''). For example, <code>labelStyle: 'font-weight:bold;'</code>.</summary>
		public extern string labelStyle { get; set; }

		/// <summary> The standard separator to display after the text of each form label (defaults to the value of {@link Ext.layout.FormLayout#labelSeparator}, which is a colon ':' by default).  To display no separator for this field's label specify empty string ''.</summary>
		public extern string labelSeparator { get; set; }

		/// <summary> True to completely hide the label element (defaults to false)</summary>
		public extern bool hideLabel { get; set; }

		/// <summary> The CSS class used to provide field clearing (defaults to 'x-form-clear-left')</summary>
		public extern string clearCls { get; set; }

		/// <summary> An additional CSS class to apply to the wrapper's form item element of this field (defaults to the container's itemCls value if set, or '').  Since it is applied to the item wrapper, it allows you to write standard CSS rules that can apply to the field, the label (if specified) or any other element within the markup for the field. NOTE: this will not have any effect on fields that are not part of a form. Example use: <pre><code> // Apply a style to the field's label: &lt;style> .required .x-form-item-label {font-weight:bold;color:red;} &lt;/style> new Ext.FormPanel({ height: 100, renderTo: document.body, items: [{ xtype: 'textfield', fieldLabel: 'Name', itemCls: 'required' //this label will be styled },{ xtype: 'textfield', fieldLabel: 'Favorite Color' }] }); </code></pre></summary>
		public extern string itemCls { get; set; }

		/// <summary> The type attribute for input fields -- e.g. radio, text, password, file (defaults to "text"). The types "file" and "password" must be used to render those field types currently -- there are no separate Ext components for those. Note that if you use <tt>inputType:'file'</tt>, {@link #emptyText} is not supported and should be avoided.</summary>
		public extern string inputType { get; set; }

		/// <summary> A value to initialize this field with (defaults to undefined).</summary>
		public extern object value { get; set; }

		/// <summary> The field's HTML name attribute (defaults to "").</summary>
		public extern string name { get; set; }

		/// <summary> A custom CSS class to apply to the field's underlying element (defaults to "").</summary>
		public extern string cls { get; set; }

		/// <summary> The CSS class to use when marking a field invalid (defaults to "x-form-invalid")</summary>
		public extern string invalidClass { get; set; }

		/// <summary> The error text to use when marking a field invalid and no message is provided (defaults to "The value in this field is invalid")</summary>
		public extern string invalidText { get; set; }

		/// <summary> The CSS class to use when the field receives focus (defaults to "x-form-focus")</summary>
		public extern string focusClass { get; set; }

		/// <summary>{String/Boolean} The event that should initiate field validation. Set to false to disable automatic validation (defaults to "keyup").</summary>
		public extern object validationEvent { get; set; }

		/// <summary> Whether the field should validate when it loses focus (defaults to true).</summary>
		public extern bool validateOnBlur { get; set; }

		/// <summary> The length of time in milliseconds after user input begins until validation is initiated (defaults to 250)</summary>
		public extern double validationDelay { get; set; }

		/// <summary> The default CSS class for the field (defaults to "x-form-field")</summary>
		public extern string fieldClass { get; set; }

		/// <summary> The location where error text should display.  Should be one of the following values (defaults to 'qtip'): <pre> Value         Description -----------   ---------------------------------------------------------------------- qtip          Display a quick tip when the user hovers over the field title         Display a default browser title attribute popup under         Add a block div beneath the field containing the error text side          Add an error icon to the right of the field with a popup on hover [element id]  Add the error text directly to the innerHTML of the specified element </pre></summary>
		public extern string msgTarget { get; set; }

		/// <summary> <b>Experimental</b> The effect used when displaying a validation message under the field (defaults to 'normal').</summary>
		public extern string msgFx { get; set; }

		/// <summary> True to mark the field as readOnly in HTML (defaults to false) -- Note: this only sets the element's readOnly DOM attribute.</summary>
		public extern bool readOnly { get; set; }

		/// <summary> True to disable the field (defaults to false). <p>Be aware that conformant with the <a href="http://www.w3.org/TR/html401/interact/forms.html#h-17.12.1">HTML specification</a>, disabled Fields will not be {@link Ext.form.BasicForm#submit submitted}.</p></summary>
		public extern bool disabled { get; set; }

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

		/// <summary>  The unique id of this component (defaults to an auto-assigned id). You should assign an id if you need to be able to access the component later and you do not have an object reference available (e.g., using {@link Ext.ComponentMgr#getCmp}). Note that this id will also be used as the element id for the containing HTML element that is rendered to the page for this component. This allows you to write id-based CSS rules to style the specific instance of this component uniquely, and also to select sub-elements using this component's id as the parent.</summary>
		public extern string id { get; set; }

		/// <summary>  <p>A tag name or {@link Ext.DomHelper DomHelper} spec used to create the {@link #getEl Element} which will encapsulate this Component.</p> <p>You only need to specify this when creating or subclassing the base classes {@link Ext.Component}, {@link Ext.BoxComponent}, and {@link Ext.Container}. The more complex Ext classes use a more complex DOM structure created by their own onRender methods.</p> <p>This is intended to allow the developer to create application-specific utility Components encapsulated by different DOM elements. Example usage:</p><pre><code> { xtype: 'box', autoEl: { tag: 'img', src: 'http://www.example.com/example.jpg' } }, { xtype: 'box', autoEl: { tag: 'blockquote', html: 'autoEl is cool!' } }, { xtype: 'container', autoEl: 'ul', cls: 'ux-unordered-list', items: { xtype: 'box', autoEl: 'li', html: 'First list item' } } </code></pre></summary>
		public extern object autoEl { get; set; }

		/// <summary>  A custom style specification to be applied to this component's Element.  Should be a valid argument to {@link Ext.Element#applyStyles}.</summary>
		public extern string style { get; set; }

		/// <summary>  An optional extra CSS class that will be added to this component's container (defaults to '').  This can be useful for adding customized styles to the container or any of its children using standard CSS rules.</summary>
		public extern string ctCls { get; set; }

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
}
