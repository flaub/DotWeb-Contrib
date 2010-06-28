using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.tree {
	/// <summary>
	///     /**
	///     Provides editor functionality for inline tree node editing.  Any valid {@link Ext.form.Field} subclass can be used
	///     as the editor field.
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\tree\TreeEditor.js</jssource>
	public class TreeEditor : Ext.Editor {

		/// <summary>that will be applied to the default field instance (defaults to a {@link Ext.form.TextField}).</summary>
		/// <returns></returns>
		public extern TreeEditor();
		/// <summary>that will be applied to the default field instance (defaults to a {@link Ext.form.TextField}).</summary>
		/// <param name="tree"></param>
		/// <returns></returns>
		public extern TreeEditor(TreePanel tree);
		/// <summary>that will be applied to the default field instance (defaults to a {@link Ext.form.TextField}).</summary>
		/// <param name="tree"></param>
		/// <param name="fieldConfig">(optional) Either a prebuilt {@link Ext.form.Field} instance or a Field config object</param>
		/// <returns></returns>
		public extern TreeEditor(TreePanel tree, object fieldConfig);
		/// <summary>that will be applied to the default field instance (defaults to a {@link Ext.form.TextField}).</summary>
		/// <param name="tree"></param>
		/// <param name="fieldConfig">(optional) Either a prebuilt {@link Ext.form.Field} instance or a Field config object</param>
		/// <param name="config">(optional) A TreeEditor config object</param>
		/// <returns></returns>
		public extern TreeEditor(TreePanel tree, object fieldConfig, object config);
		/// <summary>Create a new Editor</summary>
		/// <param name="field">The Field object (or descendant)</param>
		/// <returns></returns>
		public extern TreeEditor(Ext.form.Field field);
		/// <summary>Create a new Editor</summary>
		/// <param name="field">The Field object (or descendant)</param>
		/// <param name="config">The config object</param>
		/// <returns></returns>
		public extern TreeEditor(Ext.form.Field field, object config);
		/// <summary>
		///     element and its id used as the component id.  If a string is passed, it is assumed to be the id of an existing element
		///     and is used as the component id.  Otherwise, it is assumed to be a standard config object and is applied to the component.
		/// </summary>
		/// <param name="config">The configuration options.  If an element is passed, it is set as the internal</param>
		/// <returns></returns>
		public extern TreeEditor(Ext.Element config);
		/// <summary>
		///     element and its id used as the component id.  If a string is passed, it is assumed to be the id of an existing element
		///     and is used as the component id.  Otherwise, it is assumed to be a standard config object and is applied to the component.
		/// </summary>
		/// <param name="config">The configuration options.  If an element is passed, it is set as the internal</param>
		/// <returns></returns>
		public extern TreeEditor(string config);
		/// <summary>
		///     element and its id used as the component id.  If a string is passed, it is assumed to be the id of an existing element
		///     and is used as the component id.  Otherwise, it is assumed to be a standard config object and is applied to the component.
		/// </summary>
		/// <param name="config">The configuration options.  If an element is passed, it is set as the internal</param>
		/// <returns></returns>
		public extern TreeEditor(object config);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static TreeEditor prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.Editor superclass { get; set; }

		/// <summary>The position to align to (see {@link Ext.Element#alignTo} for more details, defaults to "l-l").</summary>
		public extern string alignment { get; set; }

		/// <summary>True to hide the bound element while the editor is displayed (defaults to false)</summary>
		public extern bool hideEl { get; set; }

		/// <summary>CSS class to apply to the editor (defaults to "x-small-editor x-tree-editor")</summary>
		public extern string cls { get; set; }

		/// <summary>True to shim the editor if selects/iframes could be displayed beneath it (defaults to false)</summary>
		public extern bool shim { get; set; }

		/// <summary>
		///     The maximum width in pixels of the editor field (defaults to 250).  Note that if the maxWidth would exceed
		///     the containing tree element's size, it will be automatically limited for you to the container width, taking
		///     scroll and client offsets into account prior to each edit.
		/// </summary>
		public extern double maxWidth { get; set; }

		/// <summary>
		///     The number of milliseconds between clicks to register a double-click that will triggerediting on the current node (defaults to 350).  If two clicks occur on the same node within this time span,
		///     the editor for the node will display, otherwise it will be processed as a regular click.
		/// </summary>
		public extern double editDelay { get; set; }

		/// <summary>The {@link Ext.tree.TreeNode TreeNode} this editor is bound to. Read-only.</summary>
		public extern Ext.tree.TreeNode editNode { get; set; }


		/// <summary>Edit the text of the passed {@link Ext.tree.TreeNode TreeNode}.</summary>
		/// <returns></returns>
		public extern virtual void triggerEdit();

		/// <summary>Edit the text of the passed {@link Ext.tree.TreeNode TreeNode}.</summary>
		/// <param name="node">{Ext.tree.TreeNode} The TreeNode to edit. The TreeNode must be {@link Ext.tree.TreeNode#editable editable}.</param>
		/// <returns></returns>
		public extern virtual void triggerEdit(object node);



	}

	[JsAnonymous]
	public class TreeEditorConfig : System.DotWeb.JsDynamic {
		/// <summary>  The position to align to (see {@link Ext.Element#alignTo} for more details, defaults to "l-l").</summary>
		public extern string alignment { get; set; }

		/// <summary>  True to hide the bound element while the editor is displayed (defaults to false)</summary>
		public extern bool hideEl { get; set; }

		/// <summary>  CSS class to apply to the editor (defaults to "x-small-editor x-tree-editor")</summary>
		public extern string cls { get; set; }

		/// <summary>  True to shim the editor if selects/iframes could be displayed beneath it (defaults to false)</summary>
		public extern bool shim { get; set; }

		/// <summary>  The maximum width in pixels of the editor field (defaults to 250).  Note that if the maxWidth would exceed the containing tree element's size, it will be automatically limited for you to the container width, taking scroll and client offsets into account prior to each edit.</summary>
		public extern double maxWidth { get; set; }

		/// <summary> The number of milliseconds between clicks to register a double-click that will trigger editing on the current node (defaults to 350).  If two clicks occur on the same node within this time span, the editor for the node will display, otherwise it will be processed as a regular click.</summary>
		public extern double editDelay { get; set; }

		/// <summary>{Boolean/String}  True for the editor to automatically adopt the size of the underlying field, "width" to adopt the width only, or "height" to adopt the height only (defaults to false)</summary>
		public extern object autoSize { get; set; }

		/// <summary>  True to automatically revert the field value and cancel the edit when the user completes an edit and the field validation fails (defaults to true)</summary>
		public extern bool revertInvalid { get; set; }

		/// <summary>  True to skip the edit completion process (no save, no events fired) if the user completes an edit and the value has not changed (defaults to false).  Applies only to string values - edits for other data types will never be ignored.</summary>
		public extern bool ignoreNoChange { get; set; }

		/// <summary>  The data value of the underlying field (defaults to "")</summary>
		public extern object value { get; set; }

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
}
