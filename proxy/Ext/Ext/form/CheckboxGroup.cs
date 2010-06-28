using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.form {
	/// <summary>
	///     /**
	///     A grouping container for {@link Ext.form.Checkbox} controls.
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\form\CheckboxGroup.js</jssource>
	public class CheckboxGroup : Ext.form.Field {

		/// <summary>Creates a new CheckboxGroup</summary>
		/// <returns></returns>
		public extern CheckboxGroup();
		/// <summary>Creates a new CheckboxGroup</summary>
		/// <param name="config">Configuration options</param>
		/// <returns></returns>
		public extern CheckboxGroup(object config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern CheckboxGroup(Ext.Element config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern CheckboxGroup(string config);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static CheckboxGroup prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.form.Field superclass { get; set; }

		/// <summary>An Array of {@link Ext.form.Checkbox Checkbox}es or Checkbox config objectsto arrange in the group.</summary>
		public extern System.Array items { get; set; }

		/// <summary>
		///     Specifies the number of columns to use when displaying groupedcheckbox/radio controls using automatic layout.  This config can take several types of values:
		///     <ul><li><b>'auto'</b> : <p class="sub-desc">The controls will be rendered one per column on one row and the width
		///     of each column will be evenly distributed based on the width of the overall field container. This is the default.</p></li>
		///     <li><b>Number</b> : <p class="sub-desc">If you specific a number (e.g., 3) that number of columns will be
		///     created and the contained controls will be automatically distributed based on the value of {@link #vertical}.</p></li>
		///     <li><b>Array</b> : Object<p class="sub-desc">You can also specify an array of column widths, mixing integer
		///     (fixed width) and float (percentage width) values as needed (e.g., [100, .25, .75]). Any integer values will
		///     be rendered first, then any float values will be calculated as a percentage of the remaining space. Float
		///     values do not have to add up to 1 (100%) although if you want the controls to take up the entire field
		///     container you should do so.</p></li></ul>
		/// </summary>
		public extern object columns { get; set; }

		/// <summary>
		///     True to distribute contained controls across columns, completely filling each columntop to bottom before starting on the next column.  The number of controls in each column will be automatically
		///     calculated to keep columns as even as possible.  The default value is false, so that controls will be added
		///     to columns one at a time, completely filling each row left to right before starting on the next row.
		/// </summary>
		public extern bool vertical { get; set; }

		/// <summary>False to validate that at least one item in the group is checked (defaults to true).If no items are selected at validation time, {@link @blankText} will be used as the error text.</summary>
		public extern bool allowBlank { get; set; }

		/// <summary>Error text to display if the {@link #allowBlank} validation fails (defaults to "You mustselect at least one item in this group")</summary>
		public extern string blankText { get; set; }


		/// <summary>@hide</summary>
		/// <returns></returns>
		public extern virtual void initValue();

		/// <summary>@hide</summary>
		/// <returns></returns>
		public extern virtual void getValue();

		/// <summary>@hide</summary>
		/// <returns></returns>
		public extern virtual void getRawValue();

		/// <summary>@hide</summary>
		/// <returns></returns>
		public extern virtual void setValue();

		/// <summary>@hide</summary>
		/// <returns></returns>
		public extern virtual void setRawValue();



	}

	[JsAnonymous]
	public class CheckboxGroupConfig : System.DotWeb.JsDynamic {
		/// <summary> An Array of {@link Ext.form.Checkbox Checkbox}es or Checkbox config objects to arrange in the group.</summary>
		public extern System.Array items { get; set; }

		/// <summary>{String/Number/Array} Specifies the number of columns to use when displaying grouped checkbox/radio controls using automatic layout.  This config can take several types of values: <ul><li><b>'auto'</b> : <p class="sub-desc">The controls will be rendered one per column on one row and the width of each column will be evenly distributed based on the width of the overall field container. This is the default.</p></li> <li><b>Number</b> : <p class="sub-desc">If you specific a number (e.g., 3) that number of columns will be created and the contained controls will be automatically distributed based on the value of {@link #vertical}.</p></li> <li><b>Array</b> : Object<p class="sub-desc">You can also specify an array of column widths, mixing integer (fixed width) and float (percentage width) values as needed (e.g., [100, .25, .75]). Any integer values will be rendered first, then any float values will be calculated as a percentage of the remaining space. Float values do not have to add up to 1 (100%) although if you want the controls to take up the entire field container you should do so.</p></li></ul></summary>
		public extern object columns { get; set; }

		/// <summary> True to distribute contained controls across columns, completely filling each column top to bottom before starting on the next column.  The number of controls in each column will be automatically calculated to keep columns as even as possible.  The default value is false, so that controls will be added to columns one at a time, completely filling each row left to right before starting on the next row.</summary>
		public extern bool vertical { get; set; }

		/// <summary> False to validate that at least one item in the group is checked (defaults to true). If no items are selected at validation time, {@link @blankText} will be used as the error text.</summary>
		public extern bool allowBlank { get; set; }

		/// <summary> Error text to display if the {@link #allowBlank} validation fails (defaults to "You must select at least one item in this group")</summary>
		public extern string blankText { get; set; }

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

		/// <summary> The tabIndex for this field. Note this only applies to fields that are rendered, not those which are built via applyTo (defaults to undefined).</summary>
		public extern double tabIndex { get; set; }

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

		/// <summary>{String/Object} A DomHelper element spec, or true for a default element spec (defaults to {tag: "input", type: "text", size: "20", autocomplete: "off"})</summary>
		public extern object autoCreate { get; set; }

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

		/// <summary>  An optional extra CSS class that will be added to this component's Element when the mouse moves over the Element, and removed when the mouse moves out. (defaults to '').  This can be useful for adding customized "active" or "hover" styles to the component or any of its children using standard CSS rules.</summary>
		public extern string overCls { get; set; }

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

    public class CheckboxGroupEvents {
        /// <summary>Fires when the state of a child checkbox changes.
        /// <pre><code>
        /// USAGE: ({Ext.form.CheckboxGroup} objthis, {Array} chckd)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>chckd</b></term><description>An array containing the checked boxes.</description></item>
        /// </list>
        /// </summary>
        public static string change { get { return "change"; } }
    }

    public delegate void CheckboxGroupChangeDelegate(Ext.form.CheckboxGroup objthis, System.Array chckd);
}
