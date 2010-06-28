using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext {
	/// <summary>
	///     /**
	///     Simple date picker class.
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.2\source\widgets\DatePicker.js</jssource>
	public class DatePicker : Ext.Component {

		/// <summary>Create a new DatePicker</summary>
		/// <returns></returns>
		public extern DatePicker();
		/// <summary>Create a new DatePicker</summary>
		/// <param name="config">The config object</param>
		/// <returns></returns>
		public extern DatePicker(object config);
		/// <summary>
		///     element and its id used as the component id.  If a string is passed, it is assumed to be the id of an existing element
		///     and is used as the component id.  Otherwise, it is assumed to be a standard config object and is applied to the component.
		/// </summary>
		/// <param name="config">The configuration options.  If an element is passed, it is set as the internal</param>
		/// <returns></returns>
		public extern DatePicker(Ext.Element config);
		/// <summary>
		///     element and its id used as the component id.  If a string is passed, it is assumed to be the id of an existing element
		///     and is used as the component id.  Otherwise, it is assumed to be a standard config object and is applied to the component.
		/// </summary>
		/// <param name="config">The configuration options.  If an element is passed, it is set as the internal</param>
		/// <returns></returns>
		public extern DatePicker(string config);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static DatePicker prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.Component superclass { get; set; }

		/// <summary>The text to display on the button that selects the current date (defaults to "Today")</summary>
		public extern string todayText { get; set; }

		/// <summary>The text to display on the ok button</summary>
		public extern string okText { get; set; }

		/// <summary>The text to display on the cancel button</summary>
		public extern string cancelText { get; set; }

		/// <summary>The tooltip to display for the button that selects the current date (defaults to "{current date} (Spacebar)")</summary>
		public extern string todayTip { get; set; }

		/// <summary>The error text to display if the minDate validation fails (defaults to "This date is before the minimum date")</summary>
		public extern string minText { get; set; }

		/// <summary>The error text to display if the maxDate validation fails (defaults to "This date is after the maximum date")</summary>
		public extern string maxText { get; set; }

		/// <summary>
		///     The default date format string which can be overriden for localization support.  The format must be
		///     valid according to {@link Date#parseDate} (defaults to 'm/d/y').
		/// </summary>
		public extern string format { get; set; }

		/// <summary>The tooltip to display when the date falls on a disabled day (defaults to "Disabled")</summary>
		public extern string disabledDaysText { get; set; }

		/// <summary>The tooltip text to display when the date falls on a disabled date (defaults to "Disabled")</summary>
		public extern string disabledDatesText { get; set; }

		/// <summary><b>Deprecated</b> (not currently used). True to constrain the date picker to the viewport (defaults to true)</summary>
		public extern bool constrainToViewport { get; set; }

		/// <summary>An array of textual month names which can be overriden for localization support (defaults to Date.monthNames)</summary>
		public extern System.Array monthNames { get; set; }

		/// <summary>An array of textual day names which can be overriden for localization support (defaults to Date.dayNames)</summary>
		public extern System.Array dayNames { get; set; }

		/// <summary>The next month navigation button tooltip (defaults to 'Next Month (Control+Right)')</summary>
		public extern string nextText { get; set; }

		/// <summary>The previous month navigation button tooltip (defaults to 'Previous Month (Control+Left)')</summary>
		public extern string prevText { get; set; }

		/// <summary>The header month selector tooltip (defaults to 'Choose a month (Control+Up/Down to move years)')</summary>
		public extern string monthYearText { get; set; }

		/// <summary>Day index at which the week should begin, 0-based (defaults to 0, which is Sunday)</summary>
		public extern double startDay { get; set; }

		/// <summary>
		///     False to hide the footer area containing the Today button and disable the keyboard handler for spacebar
		///     that selects the current date (defaults to true).
		/// </summary>
		public extern bool showToday { get; set; }

		/// <summary>Minimum allowable date (JavaScript date object, defaults to null)</summary>
		public extern System.DateTime minDate { get; set; }

		/// <summary>Maximum allowable date (JavaScript date object, defaults to null)</summary>
		public extern System.DateTime maxDate { get; set; }

		/// <summary>An array of days to disable, 0-based. For example, [0, 6] disables Sunday and Saturday (defaults to null).</summary>
		public extern System.Array disabledDays { get; set; }

		/// <summary>
		///     JavaScript regular expression used to disable a pattern of dates (defaults to null).  The {@link #disabledDates}
		///     config will generate this regex internally, but if you specify disabledDatesRE it will take precedence over the
		///     disabledDates value.
		/// </summary>
		public extern object disabledDatesRE { get; set; }

		/// <summary>
		///     An array of "dates" to disable, as strings. These strings will be used to build a dynamic regular
		///     expression so they are very powerful. Some examples:
		///     <ul>
		///     <li>["03/08/2003", "09/16/2003"] would disable those exact dates</li>
		///     <li>["03/08", "09/16"] would disable those days for every year</li>
		///     <li>["^03/08"] would only match the beginning (useful if you are using short years)</li>
		///     <li>["03/../2006"] would disable every day in March 2006</li>
		///     <li>["^03"] would disable every day in every March</li>
		///     </ul>
		///     Note that the format of the dates included in the array should exactly match the {@link #format} config.
		///     In order to support regular expressions, if you are using a date format that has "." in it, you will have to
		///     escape the dot when restricting dates. For example: ["03\\.08\\.03"].
		/// </summary>
		public extern System.Array disabledDates { get; set; }


		/// <summary>
		///     Replaces any existing disabled dates with new values and refreshes the DatePicker.
		///     for details on supported values), or a JavaScript regular expression used to disable a pattern of dates.
		/// </summary>
		/// <returns></returns>
		public extern virtual void setDisabledDates();

		/// <summary>
		///     Replaces any existing disabled dates with new values and refreshes the DatePicker.
		///     for details on supported values), or a JavaScript regular expression used to disable a pattern of dates.
		/// </summary>
		/// <param name="disabledDates">An array of date strings (see the {@link #disabledDates} config</param>
		/// <returns></returns>
		public extern virtual void setDisabledDates(System.Array disabledDates);

		/// <summary>
		///     Replaces any existing disabled dates with new values and refreshes the DatePicker.
		///     for details on supported values), or a JavaScript regular expression used to disable a pattern of dates.
		/// </summary>
		/// <param name="disabledDates">An array of date strings (see the {@link #disabledDates} config</param>
		/// <returns></returns>
		public extern virtual void setDisabledDates(object disabledDates);

		/// <summary>
		///     Replaces any existing disabled days (by index, 0-6) with new values and refreshes the DatePicker.
		///     for details on supported values.
		/// </summary>
		/// <returns></returns>
		public extern virtual void setDisabledDays();

		/// <summary>
		///     Replaces any existing disabled days (by index, 0-6) with new values and refreshes the DatePicker.
		///     for details on supported values.
		/// </summary>
		/// <param name="disabledDays">An array of disabled day indexes. See the {@link #disabledDays} config</param>
		/// <returns></returns>
		public extern virtual void setDisabledDays(System.Array disabledDays);

		/// <summary>Replaces any existing {@link #minDate} with the new value and refreshes the DatePicker.</summary>
		/// <returns></returns>
		public extern virtual void setMinDate();

		/// <summary>Replaces any existing {@link #minDate} with the new value and refreshes the DatePicker.</summary>
		/// <param name="value">The minimum date that can be selected</param>
		/// <returns></returns>
		public extern virtual void setMinDate(System.DateTime value);

		/// <summary>Replaces any existing {@link #maxDate} with the new value and refreshes the DatePicker.</summary>
		/// <returns></returns>
		public extern virtual void setMaxDate();

		/// <summary>Replaces any existing {@link #maxDate} with the new value and refreshes the DatePicker.</summary>
		/// <param name="value">The maximum date that can be selected</param>
		/// <returns></returns>
		public extern virtual void setMaxDate(System.DateTime value);

		/// <summary>Sets the value of the date field</summary>
		/// <returns></returns>
		public extern virtual void setValue();

		/// <summary>Sets the value of the date field</summary>
		/// <param name="value">The date to set</param>
		/// <returns></returns>
		public extern virtual void setValue(System.DateTime value);

		/// <summary>Gets the current selected value of the date field</summary>
		/// <returns>Date</returns>
		public extern virtual void getValue();



	}

	[JsAnonymous]
	public class DatePickerConfig : System.DotWeb.JsDynamic {
		/// <summary>  The text to display on the button that selects the current date (defaults to "Today")</summary>
		public extern string todayText { get; set; }

		/// <summary>  The text to display on the ok button</summary>
		public extern string okText { get; set; }

		/// <summary>  The text to display on the cancel button</summary>
		public extern string cancelText { get; set; }

		/// <summary>  The tooltip to display for the button that selects the current date (defaults to "{current date} (Spacebar)")</summary>
		public extern string todayTip { get; set; }

		/// <summary>  The error text to display if the minDate validation fails (defaults to "This date is before the minimum date")</summary>
		public extern string minText { get; set; }

		/// <summary>  The error text to display if the maxDate validation fails (defaults to "This date is after the maximum date")</summary>
		public extern string maxText { get; set; }

		/// <summary>  The default date format string which can be overriden for localization support.  The format must be valid according to {@link Date#parseDate} (defaults to 'm/d/y').</summary>
		public extern string format { get; set; }

		/// <summary>  The tooltip to display when the date falls on a disabled day (defaults to "Disabled")</summary>
		public extern string disabledDaysText { get; set; }

		/// <summary>  The tooltip text to display when the date falls on a disabled date (defaults to "Disabled")</summary>
		public extern string disabledDatesText { get; set; }

		/// <summary>  <b>Deprecated</b> (not currently used). True to constrain the date picker to the viewport (defaults to true)</summary>
		public extern bool constrainToViewport { get; set; }

		/// <summary>  An array of textual month names which can be overriden for localization support (defaults to Date.monthNames)</summary>
		public extern System.Array monthNames { get; set; }

		/// <summary>  An array of textual day names which can be overriden for localization support (defaults to Date.dayNames)</summary>
		public extern System.Array dayNames { get; set; }

		/// <summary>  The next month navigation button tooltip (defaults to 'Next Month (Control+Right)')</summary>
		public extern string nextText { get; set; }

		/// <summary>  The previous month navigation button tooltip (defaults to 'Previous Month (Control+Left)')</summary>
		public extern string prevText { get; set; }

		/// <summary>  The header month selector tooltip (defaults to 'Choose a month (Control+Up/Down to move years)')</summary>
		public extern string monthYearText { get; set; }

		/// <summary>  Day index at which the week should begin, 0-based (defaults to 0, which is Sunday)</summary>
		public extern double startDay { get; set; }

		/// <summary>  False to hide the footer area containing the Today button and disable the keyboard handler for spacebar that selects the current date (defaults to true).</summary>
		public extern bool showToday { get; set; }

		/// <summary>  Minimum allowable date (JavaScript date object, defaults to null)</summary>
		public extern System.DateTime minDate { get; set; }

		/// <summary>  Maximum allowable date (JavaScript date object, defaults to null)</summary>
		public extern System.DateTime maxDate { get; set; }

		/// <summary>  An array of days to disable, 0-based. For example, [0, 6] disables Sunday and Saturday (defaults to null).</summary>
		public extern System.Array disabledDays { get; set; }

		/// <summary>  JavaScript regular expression used to disable a pattern of dates (defaults to null).  The {@link #disabledDates} config will generate this regex internally, but if you specify disabledDatesRE it will take precedence over the disabledDates value.</summary>
		public extern object disabledDatesRE { get; set; }

		/// <summary>  An array of "dates" to disable, as strings. These strings will be used to build a dynamic regular expression so they are very powerful. Some examples: <ul> <li>["03/08/2003", "09/16/2003"] would disable those exact dates</li> <li>["03/08", "09/16"] would disable those days for every year</li> <li>["^03/08"] would only match the beginning (useful if you are using short years)</li> <li>["03/../2006"] would disable every day in March 2006</li> <li>["^03"] would disable every day in every March</li> </ul> Note that the format of the dates included in the array should exactly match the {@link #format} config. In order to support regular expressions, if you are using a date format that has "." in it, you will have to escape the dot when restricting dates. For example: ["03\\.08\\.03"].</summary>
		public extern System.Array disabledDates { get; set; }

		/// <summary> 
		///     The registered xtype to create. This config option is not used when passing a config object into a constructor. This config option is used only when lazy instantiation is being used, and a child item of a Container is being specified not as a fully instantiated Component, but as a Component config object. The xtype will be looked up at render time up to determine what type of child Component to create.
		///     The predefined xtypes are listed at the top of this document.
		///     If you subclass Components to create your own Components, you may register them using Ext.ComponentMgr.registerType in order to be able to take advantage of lazy instantiation and rendering.
		/// </summary>
		public extern string xtype { get; set; }

		/// <summary>  The unique id of this component (defaults to an auto-assigned id).</summary>
		public extern string id { get; set; }

		/// <summary>{String/Object}  A tag name or DomHelper spec to create an element with. This is intended to create shorthand utility components inline via JSON. It should not be used for higher level components which already create their own elements. Example usage: <pre><code> {xtype:'box', autoEl: 'div', cls:'my-class'} {xtype:'box', autoEl: {tag:'blockquote', html:'autoEl is cool!'}} // with DomHelper </code></pre></summary>
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

		/// <summary>  The id of the node, a DOM node or an existing Element corresponding to a DIV that is already present in the document that specifies some structural markup for this component.  When applyTo is used, constituent parts of the component can also be specified by id or CSS class name within the main element, and the component being created may attempt to create its subcomponents from that markup if applicable. Using this config, a call to render() is not required.  If applyTo is specified, any value passed for {@link #renderTo} will be ignored and the target element's parent node will automatically be used as the component's container.</summary>
		public extern object applyTo { get; set; }

		/// <summary>  The id of the node, a DOM node or an existing Element that will be the container to render this component into. Using this config, a call to render() is not required.</summary>
		public extern object renderTo { get; set; }

		/// <summary>  A flag which causes the Component to attempt to restore the state of internal properties from a saved state on startup.<p> For state saving to work, the state manager's provider must have been set to an implementation of {@link Ext.state.Provider} which overrides the {@link Ext.state.Provider#set set} and {@link Ext.state.Provider#get get} methods to save and recall name/value pairs. A built-in implementation, {@link Ext.state.CookieProvider} is available.</p> <p>To set the state provider for the current page:</p> <pre><code> Ext.state.Manager.setProvider(new Ext.state.CookieProvider()); </code></pre> <p>Components attempt to save state when one of the events listed in the {@link #stateEvents} configuration fires.</p> <p>You can perform extra processing on state save and restore by attaching handlers to the {@link #beforestaterestore}, {@link staterestore}, {@link beforestatesave} and {@link statesave} events</p></summary>
		public extern bool stateful { get; set; }

		/// <summary>  The unique id for this component to use for state management purposes (defaults to the component id). <p>See {@link #stateful} for an explanation of saving and restoring Component state.</p></summary>
		public extern string stateId { get; set; }

		/// <summary>  CSS class added to the component when it is disabled (defaults to "x-item-disabled").</summary>
		public extern string disabledClass { get; set; }

		/// <summary>  Whether the component can move the Dom node when rendering (defaults to true).</summary>
		public extern bool allowDomMove { get; set; }

		/// <summary>  True if the component should check for hidden classes (e.g. 'x-hidden' or 'x-hide-display') and remove them on render (defaults to false).</summary>
		public extern bool autoShow { get; set; }

		/// <summary>  How this component should hidden. Supported values are "visibility" (css visibility), "offsets" (negative offset position) and "display" (css display) - defaults to "display".</summary>
		public extern string hideMode { get; set; }

		/// <summary>  True to hide and show the component's container when hide/show is called on the component, false to hide and show the component itself (defaults to false).  For example, this can be used as a shortcut for a hide button on a window by setting hide:true on the button when adding it to its parent container.</summary>
		public extern bool hideParent { get; set; }

		/// <summary> A config object containing one or more event handlers to be added to this object during initialization.  This should be a valid listeners config object as specified in the {@link #addListener} example for attaching multiple handlers at once.</summary>
		public extern object listeners { get; set; }

	}

    public class DatePickerEvents {
        /// <summary>Fires when a date is selected
        /// <pre><code>
        /// USAGE: ({DatePicker} objthis, {Date} date)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>date</b></term><description>The selected date</description></item>
        /// </list>
        /// </summary>
        public static string select { get { return "select"; } }
    }

    public delegate void DatePickerSelectDelegate(DatePicker objthis, System.DateTime date);
}
