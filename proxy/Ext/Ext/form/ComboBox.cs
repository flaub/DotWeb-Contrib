using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.form {
	/// <summary>
	///     /**
	///     <p>A combobox control with support for autocomplete, remote-loading, paging and many other features.</p>
	///     A ComboBox works in a similar manner to a traditional HTML &lt;select> field. The difference is that to submit the
	///     {@link #valueField}, you must specify a {@link #hiddenName} to create a hidden input field to hold the
	///     value of the valueField. The <i>{@link #displayField}</i> is shown in the text field which is named
	///     according to the {@link #name}.
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\form\Combo.js</jssource>
	public class ComboBox : Ext.form.TriggerField {

		/// <summary>Create a new ComboBox.</summary>
		/// <returns></returns>
		public extern ComboBox();
		/// <summary>Create a new ComboBox.</summary>
		/// <param name="config">Configuration options</param>
		/// <returns></returns>
		public extern ComboBox(object config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern ComboBox(Ext.Element config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern ComboBox(string config);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static ComboBox prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.form.TriggerField superclass { get; set; }

		/// <summary>
		///     The id, DOM node or element of an existing HTML SELECT to convert to a ComboBox.Note that if you specify this and the combo is going to be in a {@link Ext.form.BasicForm} or
		///     {@link Ext.form.FormPanel}, you must also set {@link #lazyRender} = true.
		/// </summary>
		public extern object transform { get; set; }

		/// <summary>True to prevent the ComboBox from rendering until requested (should always be used whenrendering into an Ext.Editor, defaults to false).</summary>
		public extern bool lazyRender { get; set; }

		/// <summary>A DomHelper element spec, or true for a default element spec (defaults to:{tag: "input", type: "text", size: "24", autocomplete: "off"})</summary>
		public extern object autoCreate { get; set; }

		/// <summary>
		///     The data source to which this combo is bound (defaults to undefined).  This can beany {@link Ext.data.Store} subclass, a 1-dimensional array (e.g., ['Foo','Bar']) or a 2-dimensional array (e.g.,
		///     [['f','Foo'],['b','Bar']]).  Arrays will be converted to a {@link Ext.data.SimpleStore} internally.
		///     1-dimensional arrays will automatically be expanded (each array item will be the combo value and text) and
		///     for multi-dimensional arrays, the value in index 0 of each item will be assumed to be the combo value, while
		///     the value at index 1 is assumed to be the combo text.
		/// </summary>
		public extern object store { get; set; }

		/// <summary>If supplied, a header element is created containing this text and added into the top ofthe dropdown list (defaults to undefined, with no header element)</summary>
		public extern string title { get; set; }

		/// <summary>The width (used as a parameter to {@link Ext.Element#setWidth}) of the dropdown list (defaults to the width of the ComboBox field)</summary>
		public extern double listWidth { get; set; }

		/// <summary>The underlying data field name to bind to this ComboBox (defaults to undefined ifmode = 'remote' or 'text' if transforming a select)</summary>
		public extern string displayField { get; set; }

		/// <summary>
		///     The underlying data value name to bind to this ComboBox (defaults to undefined ifmode = 'remote' or 'value' if transforming a select) Note: use of a valueField requires the user to make a selection
		///     in order for a value to be mapped.
		/// </summary>
		public extern string valueField { get; set; }

		/// <summary>
		///     If specified, a hidden form field with this name is dynamically generated to store thefield's data value (defaults to the underlying DOM element's name). Required for the combo's value to automatically
		///     post during a form submission.  Note that the hidden field's id will also default to this name if {@link #hiddenId}
		///     is not specified.  The combo's id and the hidden field's ids should be different, since no two DOM nodes should
		///     share the same id, so if the combo and hidden names are the same, you should specify a unique hiddenId.
		/// </summary>
		public extern string hiddenName { get; set; }

		/// <summary>
		///     If {@link #hiddenName} is specified, hiddenId can also be provided to give the hidden fielda unique id (defaults to the hiddenName).  The hiddenId and combo {@link #id} should be different, since no two DOM
		///     nodes should share the same id.
		/// </summary>
		public extern string hiddenId { get; set; }

		/// <summary>CSS class to apply to the dropdown list element (defaults to '')</summary>
		public extern string listClass { get; set; }

		/// <summary>CSS class to apply to the selected item in the dropdown list (defaults to 'x-combo-selected')</summary>
		public extern string selectedClass { get; set; }

		/// <summary>
		///     An additional CSS class used to style the trigger button.  The trigger will always get theclass 'x-form-trigger' and triggerClass will be <b>appended</b> if specified (defaults to 'x-form-arrow-trigger'
		///     which displays a downward arrow icon).
		/// </summary>
		public extern string triggerClass { get; set; }

		/// <summary>True or "sides" for the default effect, "frame" for 4-way shadow, and "drop" for bottom-right</summary>
		public extern object shadow { get; set; }

		/// <summary>A valid anchor position value. See {@link Ext.Element#alignTo} for details on supportedanchor positions (defaults to 'tl-bl')</summary>
		public extern string listAlign { get; set; }

		/// <summary>The maximum height in pixels of the dropdown list before scrollbars are shown (defaults to 300)</summary>
		public extern double maxHeight { get; set; }

		/// <summary>The minimum height in pixels of the dropdown list when the list is constrained by itsdistance to the viewport edges (defaults to 90)</summary>
		public extern double minHeight { get; set; }

		/// <summary>The action to execute when the trigger is clicked.  Use 'all' to run thequery specified by the allQuery config option (defaults to 'query')</summary>
		public extern string triggerAction { get; set; }

		/// <summary>The minimum number of characters the user must type before autocomplete and typeahead activate(defaults to 4 if remote or 0 if local, does not apply if editable = false)</summary>
		public extern double minChars { get; set; }

		/// <summary>True to populate and autoselect the remainder of the text being typed after a configurabledelay ({@link #typeAheadDelay}) if it matches a known value (defaults to false)</summary>
		public extern bool typeAhead { get; set; }

		/// <summary>The length of time in milliseconds to delay between the start of typing and sending thequery to filter the dropdown list (defaults to 500 if mode = 'remote' or 10 if mode = 'local')</summary>
		public extern double queryDelay { get; set; }

		/// <summary>If greater than 0, a paging toolbar is displayed in the footer of the dropdown list and thefilter queries will execute with page start and limit parameters.  Only applies when mode = 'remote' (defaults to 0)</summary>
		public extern double pageSize { get; set; }

		/// <summary>True to select any existing text in the field immediately on focus.  Only applieswhen editable = true (defaults to false)</summary>
		public extern bool selectOnFocus { get; set; }

		/// <summary>Name of the query as it will be passed on the querystring (defaults to 'query')</summary>
		public extern string queryParam { get; set; }

		/// <summary>The text to display in the dropdown list while data is loading.  Only applieswhen mode = 'remote' (defaults to 'Loading...')</summary>
		public extern string loadingText { get; set; }

		/// <summary>True to add a resize handle to the bottom of the dropdown list (defaults to false)</summary>
		public extern bool resizable { get; set; }

		/// <summary>The height in pixels of the dropdown list resize handle if resizable = true (defaults to 8)</summary>
		public extern double handleHeight { get; set; }

		/// <summary>False to prevent the user from typing text directly into the field, just like atraditional select (defaults to true)</summary>
		public extern bool editable { get; set; }

		/// <summary>The text query to send to the server to return all records for the list with no filtering (defaults to '')</summary>
		public extern string allQuery { get; set; }

		/// <summary>Set to 'local' if the ComboBox loads local data (defaults to 'remote' which loads from the server)</summary>
		public extern string mode { get; set; }

		/// <summary>The minimum width of the dropdown list in pixels (defaults to 70, will be ignored iflistWidth has a higher value)</summary>
		public extern double minListWidth { get; set; }

		/// <summary>True to restrict the selected value to one of the values in the list, false toallow the user to set arbitrary text into the field (defaults to false)</summary>
		public extern bool forceSelection { get; set; }

		/// <summary>The length of time in milliseconds to wait until the typeahead text is displayedif typeAhead = true (defaults to 250)</summary>
		public extern double typeAheadDelay { get; set; }

		/// <summary>
		///     When using a name/value combo, if the value passed to setValue is not found inthe store, valueNotFoundText will be displayed as the field text if defined (defaults to undefined). If this
		///     defaut text is used, it means there is no value set and no validation will occur on this field.
		/// </summary>
		public extern string valueNotFoundText { get; set; }

		/// <summary>True to not initialize the list for this combo until the field is focused (defaults to true)</summary>
		public extern bool lazyInit { get; set; }

		/// <summary>
		///     The value of the match string used to filter the store. Delete this property to force a requery.
		///     Example use:<pre><code>
		///     var combo = new Ext.form.ComboBox({
		///     ...
		///     mode: 'remote',
		///     ...
		///     listeners: {
		///     // delete the previous query in the beforequery event or set
		///     // combo.lastQuery = null (this will reload the store the next time it expands)
		///     beforequery: function(qe){
		///     delete qe.combo.lastQuery;
		///     }
		///     }
		///     });
		///     </code></pre>
		/// </summary>
		public extern string lastQuery { get; set; }

		/// <summary>
		///     The template string, or {@link Ext.XTemplate}instance to use to display each item in the dropdown list. Use
		///     this to create custom UI layouts for items in the list.
		///     <p>
		///     If you wish to preserve the default visual look of list items, add the CSS
		///     class name <pre>x-combo-list-item</pre> to the template's container element.
		///     <p>
		///     <b>The template must contain one or more substitution parameters using field
		///     names from the Combo's</b> {@link #store Store}. An example of a custom template
		///     would be adding an <pre>ext:qtip</pre> attribute which might display other fields
		///     from the Store.
		///     <p>
		///     The dropdown list is displayed in a DataView. See {@link Ext.DataView} for details.
		/// </summary>
		public extern object tpl { get; set; }

		/// <summary>
		///     <b>This setting is required if a custom XTemplate has been specified in {@link #tpl}
		///     which assigns a class other than <pre>'x-combo-list-item'</pre> to dropdown list items</b>.
		///     A simple CSS selector (e.g. div.some-class or span:first-child) that will be
		///     used to determine what nodes the DataView which handles the dropdown display will
		///     be working with.
		/// </summary>
		public extern string itemSelector { get; set; }

		/// <summary>The {@link Ext.DataView DataView} used to display the ComboBox's options.</summary>
		public extern Ext.DataView view { get; set; }


		/// <summary>Returns the store associated with this combo.</summary>
		/// <returns>Ext.data.Store</returns>
		public extern virtual void getStore();

		/// <summary>
		///     Allow or prevent the user from directly editing the field text.  If false is passed,
		///     the user will only be able to select from the items defined in the dropdown list.  This method
		///     is the runtime equivalent of setting the 'editable' config option at config time.
		/// </summary>
		/// <returns></returns>
		public extern virtual void setEditable();

		/// <summary>
		///     Allow or prevent the user from directly editing the field text.  If false is passed,
		///     the user will only be able to select from the items defined in the dropdown list.  This method
		///     is the runtime equivalent of setting the 'editable' config option at config time.
		/// </summary>
		/// <param name="value">True to allow the user to directly edit the field text</param>
		/// <returns></returns>
		public extern virtual void setEditable(bool value);

		/// <summary>Returns the currently selected field value or empty string if no value is set.</summary>
		/// <returns>String</returns>
		public extern virtual void getValue();

		/// <summary>Clears any text/value currently set in the field</summary>
		/// <returns></returns>
		public extern virtual void clearValue();

		/// <summary>
		///     Sets the specified value into the field.  If the value finds a match, the corresponding record text
		///     will be displayed in the field.  If the value does not match the data value of an existing item,
		///     and the valueNotFoundText config option is defined, it will be displayed as the default field text.
		///     Otherwise the field will be blank (although the value will still be set).
		/// </summary>
		/// <returns></returns>
		public extern virtual void setValue();

		/// <summary>
		///     Sets the specified value into the field.  If the value finds a match, the corresponding record text
		///     will be displayed in the field.  If the value does not match the data value of an existing item,
		///     and the valueNotFoundText config option is defined, it will be displayed as the default field text.
		///     Otherwise the field will be blank (although the value will still be set).
		/// </summary>
		/// <param name="value">The value to match</param>
		/// <returns></returns>
		public extern virtual void setValue(string value);

		/// <summary>Returns true if the dropdown list is expanded, else false.</summary>
		/// <returns></returns>
		public extern virtual void isExpanded();

		/// <summary>
		///     Select an item in the dropdown list by its data value. This function does NOT cause the select event to fire.
		///     The store must be loaded and the list expanded for this function to work, otherwise use setValue.
		///     selected item if it is not currently in view (defaults to true)
		/// </summary>
		/// <returns>Boolean</returns>
		public extern virtual void selectByValue();

		/// <summary>
		///     Select an item in the dropdown list by its data value. This function does NOT cause the select event to fire.
		///     The store must be loaded and the list expanded for this function to work, otherwise use setValue.
		///     selected item if it is not currently in view (defaults to true)
		/// </summary>
		/// <param name="value">The data value of the item to select</param>
		/// <returns>Boolean</returns>
		public extern virtual void selectByValue(string value);

		/// <summary>
		///     Select an item in the dropdown list by its data value. This function does NOT cause the select event to fire.
		///     The store must be loaded and the list expanded for this function to work, otherwise use setValue.
		///     selected item if it is not currently in view (defaults to true)
		/// </summary>
		/// <param name="value">The data value of the item to select</param>
		/// <param name="scrollIntoView">False to prevent the dropdown list from autoscrolling to display the</param>
		/// <returns>Boolean</returns>
		public extern virtual void selectByValue(string value, bool scrollIntoView);

		/// <summary>
		///     Select an item in the dropdown list by its numeric index in the list. This function does NOT cause the select event to fire.
		///     The store must be loaded and the list expanded for this function to work, otherwise use setValue.
		///     selected item if it is not currently in view (defaults to true)
		/// </summary>
		/// <returns></returns>
		public extern virtual void select();

		/// <summary>
		///     Select an item in the dropdown list by its numeric index in the list. This function does NOT cause the select event to fire.
		///     The store must be loaded and the list expanded for this function to work, otherwise use setValue.
		///     selected item if it is not currently in view (defaults to true)
		/// </summary>
		/// <param name="index">The zero-based index of the list item to select</param>
		/// <returns></returns>
		public extern virtual void select(double index);

		/// <summary>
		///     Select an item in the dropdown list by its numeric index in the list. This function does NOT cause the select event to fire.
		///     The store must be loaded and the list expanded for this function to work, otherwise use setValue.
		///     selected item if it is not currently in view (defaults to true)
		/// </summary>
		/// <param name="index">The zero-based index of the list item to select</param>
		/// <param name="scrollIntoView">False to prevent the dropdown list from autoscrolling to display the</param>
		/// <returns></returns>
		public extern virtual void select(double index, bool scrollIntoView);

		/// <summary>
		///     Execute a query to filter the dropdown list.  Fires the {@link #beforequery} event prior to performing the
		///     query allowing the query action to be canceled if needed.
		///     in the field than the minimum specified by the minChars config option.  It also clears any filter previously
		///     saved in the current store (defaults to false)
		/// </summary>
		/// <returns></returns>
		public extern virtual void doQuery();

		/// <summary>
		///     Execute a query to filter the dropdown list.  Fires the {@link #beforequery} event prior to performing the
		///     query allowing the query action to be canceled if needed.
		///     in the field than the minimum specified by the minChars config option.  It also clears any filter previously
		///     saved in the current store (defaults to false)
		/// </summary>
		/// <param name="query">The SQL query to execute</param>
		/// <returns></returns>
		public extern virtual void doQuery(string query);

		/// <summary>
		///     Execute a query to filter the dropdown list.  Fires the {@link #beforequery} event prior to performing the
		///     query allowing the query action to be canceled if needed.
		///     in the field than the minimum specified by the minChars config option.  It also clears any filter previously
		///     saved in the current store (defaults to false)
		/// </summary>
		/// <param name="query">The SQL query to execute</param>
		/// <param name="forceAll">True to force the query to execute even if there are currently fewer characters</param>
		/// <returns></returns>
		public extern virtual void doQuery(string query, bool forceAll);

		/// <summary>Hides the dropdown list if it is currently expanded. Fires the {@link #collapse} event on completion.</summary>
		/// <returns></returns>
		public extern virtual void collapse();

		/// <summary>Expands the dropdown list if it is currently hidden. Fires the {@link #expand} event on completion.</summary>
		/// <returns></returns>
		public extern virtual void expand();

		/// <summary>@hide</summary>
		/// <returns></returns>
		public extern virtual void onTriggerClick();

		/// <summary>@hide</summary>
		/// <returns></returns>
		public extern virtual void autoSize();



	}

	[JsAnonymous]
	public class ComboBoxConfig : System.DotWeb.JsDynamic {
		/// <summary> The id, DOM node or element of an existing HTML SELECT to convert to a ComboBox. Note that if you specify this and the combo is going to be in a {@link Ext.form.BasicForm} or {@link Ext.form.FormPanel}, you must also set {@link #lazyRender} = true.</summary>
		public extern object transform { get; set; }

		/// <summary> True to prevent the ComboBox from rendering until requested (should always be used when rendering into an Ext.Editor, defaults to false).</summary>
		public extern bool lazyRender { get; set; }

		/// <summary>{Boolean/Object} A DomHelper element spec, or true for a default element spec (defaults to: {tag: "input", type: "text", size: "24", autocomplete: "off"})</summary>
		public extern object autoCreate { get; set; }

		/// <summary>{Ext.data.Store/Array} The data source to which this combo is bound (defaults to undefined).  This can be any {@link Ext.data.Store} subclass, a 1-dimensional array (e.g., ['Foo','Bar']) or a 2-dimensional array (e.g., [['f','Foo'],['b','Bar']]).  Arrays will be converted to a {@link Ext.data.SimpleStore} internally. 1-dimensional arrays will automatically be expanded (each array item will be the combo value and text) and for multi-dimensional arrays, the value in index 0 of each item will be assumed to be the combo value, while the value at index 1 is assumed to be the combo text.</summary>
		public extern object store { get; set; }

		/// <summary> If supplied, a header element is created containing this text and added into the top of the dropdown list (defaults to undefined, with no header element)</summary>
		public extern string title { get; set; }

		/// <summary> The width (used as a parameter to {@link Ext.Element#setWidth}) of the dropdown list (defaults to the width of the ComboBox field)</summary>
		public extern double listWidth { get; set; }

		/// <summary> The underlying data field name to bind to this ComboBox (defaults to undefined if mode = 'remote' or 'text' if transforming a select)</summary>
		public extern string displayField { get; set; }

		/// <summary> The underlying data value name to bind to this ComboBox (defaults to undefined if mode = 'remote' or 'value' if transforming a select) Note: use of a valueField requires the user to make a selection in order for a value to be mapped.</summary>
		public extern string valueField { get; set; }

		/// <summary> If specified, a hidden form field with this name is dynamically generated to store the field's data value (defaults to the underlying DOM element's name). Required for the combo's value to automatically post during a form submission.  Note that the hidden field's id will also default to this name if {@link #hiddenId} is not specified.  The combo's id and the hidden field's ids should be different, since no two DOM nodes should share the same id, so if the combo and hidden names are the same, you should specify a unique hiddenId.</summary>
		public extern string hiddenName { get; set; }

		/// <summary> If {@link #hiddenName} is specified, hiddenId can also be provided to give the hidden field a unique id (defaults to the hiddenName).  The hiddenId and combo {@link #id} should be different, since no two DOM nodes should share the same id.</summary>
		public extern string hiddenId { get; set; }

		/// <summary> CSS class to apply to the dropdown list element (defaults to '')</summary>
		public extern string listClass { get; set; }

		/// <summary> CSS class to apply to the selected item in the dropdown list (defaults to 'x-combo-selected')</summary>
		public extern string selectedClass { get; set; }

		/// <summary> An additional CSS class used to style the trigger button.  The trigger will always get the class 'x-form-trigger' and triggerClass will be <b>appended</b> if specified (defaults to 'x-form-arrow-trigger' which displays a downward arrow icon).</summary>
		public extern string triggerClass { get; set; }

		/// <summary>{Boolean/String} True or "sides" for the default effect, "frame" for 4-way shadow, and "drop" for bottom-right</summary>
		public extern object shadow { get; set; }

		/// <summary> A valid anchor position value. See {@link Ext.Element#alignTo} for details on supported anchor positions (defaults to 'tl-bl')</summary>
		public extern string listAlign { get; set; }

		/// <summary> The maximum height in pixels of the dropdown list before scrollbars are shown (defaults to 300)</summary>
		public extern double maxHeight { get; set; }

		/// <summary> The minimum height in pixels of the dropdown list when the list is constrained by its distance to the viewport edges (defaults to 90)</summary>
		public extern double minHeight { get; set; }

		/// <summary> The action to execute when the trigger is clicked.  Use 'all' to run the query specified by the allQuery config option (defaults to 'query')</summary>
		public extern string triggerAction { get; set; }

		/// <summary> The minimum number of characters the user must type before autocomplete and typeahead activate (defaults to 4 if remote or 0 if local, does not apply if editable = false)</summary>
		public extern double minChars { get; set; }

		/// <summary> True to populate and autoselect the remainder of the text being typed after a configurable delay ({@link #typeAheadDelay}) if it matches a known value (defaults to false)</summary>
		public extern bool typeAhead { get; set; }

		/// <summary> The length of time in milliseconds to delay between the start of typing and sending the query to filter the dropdown list (defaults to 500 if mode = 'remote' or 10 if mode = 'local')</summary>
		public extern double queryDelay { get; set; }

		/// <summary> If greater than 0, a paging toolbar is displayed in the footer of the dropdown list and the filter queries will execute with page start and limit parameters.  Only applies when mode = 'remote' (defaults to 0)</summary>
		public extern double pageSize { get; set; }

		/// <summary> True to select any existing text in the field immediately on focus.  Only applies when editable = true (defaults to false)</summary>
		public extern bool selectOnFocus { get; set; }

		/// <summary> Name of the query as it will be passed on the querystring (defaults to 'query')</summary>
		public extern string queryParam { get; set; }

		/// <summary> The text to display in the dropdown list while data is loading.  Only applies when mode = 'remote' (defaults to 'Loading...')</summary>
		public extern string loadingText { get; set; }

		/// <summary> True to add a resize handle to the bottom of the dropdown list (defaults to false)</summary>
		public extern bool resizable { get; set; }

		/// <summary> The height in pixels of the dropdown list resize handle if resizable = true (defaults to 8)</summary>
		public extern double handleHeight { get; set; }

		/// <summary> False to prevent the user from typing text directly into the field, just like a traditional select (defaults to true)</summary>
		public extern bool editable { get; set; }

		/// <summary> The text query to send to the server to return all records for the list with no filtering (defaults to '')</summary>
		public extern string allQuery { get; set; }

		/// <summary> Set to 'local' if the ComboBox loads local data (defaults to 'remote' which loads from the server)</summary>
		public extern string mode { get; set; }

		/// <summary> The minimum width of the dropdown list in pixels (defaults to 70, will be ignored if listWidth has a higher value)</summary>
		public extern double minListWidth { get; set; }

		/// <summary> True to restrict the selected value to one of the values in the list, false to allow the user to set arbitrary text into the field (defaults to false)</summary>
		public extern bool forceSelection { get; set; }

		/// <summary> The length of time in milliseconds to wait until the typeahead text is displayed if typeAhead = true (defaults to 250)</summary>
		public extern double typeAheadDelay { get; set; }

		/// <summary> When using a name/value combo, if the value passed to setValue is not found in the store, valueNotFoundText will be displayed as the field text if defined (defaults to undefined). If this defaut text is used, it means there is no value set and no validation will occur on this field.</summary>
		public extern string valueNotFoundText { get; set; }

		/// <summary> True to not initialize the list for this combo until the field is focused (defaults to true)</summary>
		public extern bool lazyInit { get; set; }

		/// <summary>{String/Ext.XTemplate} The template string, or {@link Ext.XTemplate} instance to use to display each item in the dropdown list. Use this to create custom UI layouts for items in the list. <p> If you wish to preserve the default visual look of list items, add the CSS class name <pre>x-combo-list-item</pre> to the template's container element. <p> <b>The template must contain one or more substitution parameters using field names from the Combo's</b> {@link #store Store}. An example of a custom template would be adding an <pre>ext:qtip</pre> attribute which might display other fields from the Store. <p> The dropdown list is displayed in a DataView. See {@link Ext.DataView} for details.</summary>
		public extern object tpl { get; set; }

		/// <summary>  <b>This setting is required if a custom XTemplate has been specified in {@link #tpl} which assigns a class other than <pre>'x-combo-list-item'</pre> to dropdown list items</b>. A simple CSS selector (e.g. div.some-class or span:first-child) that will be used to determine what nodes the DataView which handles the dropdown display will be working with.</summary>
		public extern string itemSelector { get; set; }

		/// <summary> {@link Ext.DomHelper DomHelper} config object specifying the structure of the trigger element for this Field. (Optional).</p> <p>Specify this when you need a customized element to act as the trigger button for a TriggerField.</p> <p>Note that when using this option, it is the developer's responsibility to ensure correct sizing, positioning and appearance of the trigger.</p></summary>
		public extern object triggerConfigA { get; set; }

		/// <summary> True to hide the trigger element and display only the base text field (defaults to false)</summary>
		public extern bool hideTrigger { get; set; }

		/// <summary> A custom error message to display in place of the default message provided for the {@link #vtype} currently set for this field (defaults to '').  Only applies if vtype is set, else ignored.</summary>
		public extern string vtypeText { get; set; }

		/// <summary> A JavaScript RegExp object used to strip unwanted content from the value before validation (defaults to null).</summary>
		public extern object stripCharsRe { get; set; }

		/// <summary> True if this field should automatically grow and shrink to its content</summary>
		public extern bool grow { get; set; }

		/// <summary> The minimum width to allow when grow = true (defaults to 30)</summary>
		public extern double growMin { get; set; }

		/// <summary> The maximum width to allow when grow = true (defaults to 800)</summary>
		public extern double growMax { get; set; }

		/// <summary> A validation type name as defined in {@link Ext.form.VTypes} (defaults to null)</summary>
		public extern string vtype { get; set; }

		/// <summary> An input mask regular expression that will be used to filter keystrokes that don't match (defaults to null)</summary>
		public extern object maskRe { get; set; }

		/// <summary> True to disable input keystroke filtering (defaults to false)</summary>
		public extern bool disableKeyFilter { get; set; }

		/// <summary> False to validate that the value length > 0 (defaults to true)</summary>
		public extern bool allowBlank { get; set; }

		/// <summary> Minimum input field length required (defaults to 0)</summary>
		public extern double minLength { get; set; }

		/// <summary> Maximum input field length allowed (defaults to Number.MAX_VALUE)</summary>
		public extern double maxLength { get; set; }

		/// <summary> Error text to display if the minimum length validation fails (defaults to "The minimum length for this field is {minLength}")</summary>
		public extern string minLengthText { get; set; }

		/// <summary> Error text to display if the maximum length validation fails (defaults to "The maximum length for this field is {maxLength}")</summary>
		public extern string maxLengthText { get; set; }

		/// <summary> Error text to display if the allow blank validation fails (defaults to "This field is required")</summary>
		public extern string blankText { get; set; }

		/// <summary> A custom validation function to be called during field validation (defaults to null). If specified, this function will be called only after the built-in validations ({@link #allowBlank}, {@link #minLength}, {@link #maxLength}) and any configured {@link #vtype} all return true. This function will be passed the current field value and expected to return boolean true if the value is valid or a string error message if invalid.</summary>
		public extern Delegate validator { get; set; }

		/// <summary> A JavaScript RegExp object to be tested against the field value during validation (defaults to null). If available, this regex will be evaluated only after the basic validators all return true, and will be passed the current field value.  If the test fails, the field will be marked invalid using {@link #regexText}.</summary>
		public extern object regex { get; set; }

		/// <summary> The error text to display if {@link #regex} is used and the test fails during validation (defaults to "")</summary>
		public extern string regexText { get; set; }

		/// <summary> The default text to place into an empty field (defaults to null). Note that this value will be submitted to the server if this field is enabled and configured with a {@link #name}.</summary>
		public extern string emptyText { get; set; }

		/// <summary> The CSS class to apply to an empty field to style the {@link #emptyText} (defaults to 'x-form-empty-field').  This class is automatically added and removed as needed depending on the current field value.</summary>
		public extern string emptyClass { get; set; }

		/// <summary> True to enable the proxying of key events for the HTML input field (defaults to false)</summary>
		public extern bool enableKeyEvents { get; set; }

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

    public class ComboBoxEvents {
        /// <summary>Fires when the dropdown list is expanded
        /// <pre><code>
        /// USAGE: ({Ext.form.ComboBox} combo)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>combo</b></term><description>This combo box</description></item>
        /// </list>
        /// </summary>
        public static string expand { get { return "expand"; } }
        /// <summary>Fires when the dropdown list is collapsed
        /// <pre><code>
        /// USAGE: ({Ext.form.ComboBox} combo)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>combo</b></term><description>This combo box</description></item>
        /// </list>
        /// </summary>
        public static string collapse { get { return "collapse"; } }
        /// <summary>Fires before a list item is selected. Return false to cancel the selection.
        /// <pre><code>
        /// USAGE: ({Ext.form.ComboBox} combo, {Ext.data.Record} record, {Number} index)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>combo</b></term><description>This combo box</description></item>
        /// <item><term><b>record</b></term><description>The data record returned from the underlying store</description></item>
        /// <item><term><b>index</b></term><description>The index of the selected item in the dropdown list</description></item>
        /// </list>
        /// </summary>
        public static string beforeselect { get { return "beforeselect"; } }
        /// <summary>Fires when a list item is selected
        /// <pre><code>
        /// USAGE: ({Ext.form.ComboBox} combo, {Ext.data.Record} record, {Number} index)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>combo</b></term><description>This combo box</description></item>
        /// <item><term><b>record</b></term><description>The data record returned from the underlying store</description></item>
        /// <item><term><b>index</b></term><description>The index of the selected item in the dropdown list</description></item>
        /// </list>
        /// </summary>
        public static string select { get { return "select"; } }
        /// <summary>
        ///     Fires before all queries are processed. Return false to cancel the query or set the queryEvent's
        ///     cancel property to true.
        ///     <li><code>combo</code> : Ext.form.ComboBox <div class="sub-desc">This combo box</div></li>
        ///     <li><code>query</code> : String <div class="sub-desc">The query</div></li>
        ///     <li><code>forceAll</code> : Boolean <div class="sub-desc">True to force "all" query</div></li>
        ///     <li><code>cancel</code> : Boolean <div class="sub-desc">Set to true to cancel the query</div></li>
        ///     </ul>
        /// 
        /// <pre><code>
        /// USAGE: ({Object} queryEvent)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>queryEvent</b></term><description>An object that has these properties:<ul></description></item>
        /// </list>
        /// </summary>
        public static string beforequery { get { return "beforequery"; } }
    }

    public delegate void ComboBoxExpandDelegate(Ext.form.ComboBox combo);
    public delegate void ComboBoxCollapseDelegate(Ext.form.ComboBox combo);
    public delegate void ComboBoxBeforeselectDelegate(Ext.form.ComboBox combo, Ext.data.Record record, double index);
    public delegate void ComboBoxSelectDelegate(Ext.form.ComboBox combo, Ext.data.Record record, double index);
    public delegate void ComboBoxBeforequeryDelegate(object queryEvent);
}
