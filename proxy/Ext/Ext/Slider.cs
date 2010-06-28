using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext {
	/// <summary>
	///     /**
	///     Slider which supports vertical or horizontal orientation, keyboard adjustments,
	///     configurable snapping, axis clicking and animation. Can be added as an item to
	///     any container. Example usage:
	///     <pre><code>
	///     new Ext.Slider({
	///     renderTo: Ext.getBody(),
	///     width: 200,
	///     value: 50,
	///     increment: 10,
	///     minValue: 0,
	///     maxValue: 100
	///     });
	///     </code></pre>
	///     */
	///     Ext.Slider = Ext.extend(Ext.BoxComponent, {
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.2\source\widgets\Slider.js</jssource>
	public class Slider : Ext.BoxComponent {

		/// <summary>Auto-generated default constructor</summary>
		/// <returns></returns>
		public extern Slider();
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern Slider(Ext.Element config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern Slider(string config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern Slider(object config);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static Slider prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.BoxComponent superclass { get; set; }

		/// <summary>The value to initialize the slider with. Defaults to minValue.</summary>
		public extern double value { get; set; }

		/// <summary>Orient the Slider vertically rather than horizontally, defaults to false.</summary>
		public extern bool vertical { get; set; }

		/// <summary>The minimum value for the Slider. Defaults to 0.</summary>
		public extern double minValue { get; set; }

		/// <summary>The maximum value for the Slider. Defaults to 100.</summary>
		public extern double maxValue { get; set; }

		/// <summary>How many units to change the Slider when adjusting with keyboard navigation. Defaults to 1. If the increment config is larger, it will be used instead.</summary>
		public extern double keyIncrement { get; set; }

		/// <summary>How many units to change the slider when adjusting by drag and drop. Use this option to enable 'snapping'.</summary>
		public extern double increment { get; set; }

		/// <summary>Determines whether or not clicking on the Slider axis will change the slider. Defaults to true</summary>
		public extern bool clickToChange { get; set; }

		/// <summary>Turn on or off animation. Defaults to true</summary>
		public extern bool animate { get; set; }

		/// <summary>True while the thumb is in a drag operation</summary>
		public extern bool dragging { get; set; }


		/// <summary>
		///     Programmatically sets the value of the Slider. Ensures that the value is constrained within
		///     the minValue and maxValue.
		/// </summary>
		/// <returns></returns>
		public extern virtual void setValue();

		/// <summary>
		///     Programmatically sets the value of the Slider. Ensures that the value is constrained within
		///     the minValue and maxValue.
		/// </summary>
		/// <param name="value">The value to set the slider to. (This will be constrained within minValue and maxValue)</param>
		/// <returns></returns>
		public extern virtual void setValue(double value);

		/// <summary>
		///     Programmatically sets the value of the Slider. Ensures that the value is constrained within
		///     the minValue and maxValue.
		/// </summary>
		/// <param name="value">The value to set the slider to. (This will be constrained within minValue and maxValue)</param>
		/// <param name="animate">Turn on or off animation, defaults to true</param>
		/// <returns></returns>
		public extern virtual void setValue(double value, bool animate);

		/// <summary>
		///     Synchronizes the thumb position to the proper proportion of the total component width based
		///     on the current slider {@link #value}.  This will be called automatically when the Slider
		///     is resized by a layout, but if it is rendered auto width, this method can be called from
		///     another resize handler to sync the Slider if necessary.
		/// </summary>
		/// <returns></returns>
		public extern virtual void syncThumb();

		/// <summary>Returns the current value of the slider</summary>
		/// <returns>Number</returns>
		public extern virtual void getValue();



	}

	[JsAnonymous]
	public class SliderConfig : System.DotWeb.JsDynamic {
		/// <summary> The value to initialize the slider with. Defaults to minValue.</summary>
		public extern double value { get; set; }

		/// <summary> Orient the Slider vertically rather than horizontally, defaults to false.</summary>
		public extern bool vertical { get; set; }

		/// <summary> The minimum value for the Slider. Defaults to 0.</summary>
		public extern double minValue { get; set; }

		/// <summary> The maximum value for the Slider. Defaults to 100.</summary>
		public extern double maxValue { get; set; }

		/// <summary> How many units to change the Slider when adjusting with keyboard navigation. Defaults to 1. If the increment config is larger, it will be used instead.</summary>
		public extern double keyIncrement { get; set; }

		/// <summary> How many units to change the slider when adjusting by drag and drop. Use this option to enable 'snapping'.</summary>
		public extern double increment { get; set; }

		/// <summary> Determines whether or not clicking on the Slider axis will change the slider. Defaults to true</summary>
		public extern bool clickToChange { get; set; }

		/// <summary> Turn on or off animation. Defaults to true</summary>
		public extern bool animate { get; set; }

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

		/// <summary>  True to use height:'auto', false to use fixed height. Note: although many components inherit this config option, not all will function as expected with a height of 'auto'. (defaults to false).</summary>
		public extern bool autoHeight { get; set; }

		/// <summary>  True to use width:'auto', false to use fixed width. Note: although many components inherit this config option, not all will function as expected with a width of 'auto'. (defaults to false).</summary>
		public extern bool autoWidth { get; set; }

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

    public class SliderEvents {
        /// <summary>
        ///     Fires before the slider value is changed. By returning false from an event handler,
        ///     you can cancel the event and prevent the slider from changing.
        /// 
        /// <pre><code>
        /// USAGE: ({Ext.Slider} slider, {Number} newValue, {Number} oldValue)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>slider</b></term><description>The slider</description></item>
        /// <item><term><b>newValue</b></term><description>The new value which the slider is being changed to.</description></item>
        /// <item><term><b>oldValue</b></term><description>The old value which the slider was previously.</description></item>
        /// </list>
        /// </summary>
        public static string beforechange { get { return "beforechange"; } }
        /// <summary>Fires when the slider value is changed.
        /// <pre><code>
        /// USAGE: ({Ext.Slider} slider, {Number} newValue)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>slider</b></term><description>The slider</description></item>
        /// <item><term><b>newValue</b></term><description>The new value which the slider has been changed to.</description></item>
        /// </list>
        /// </summary>
        public static string change { get { return "change"; } }
        /// <summary>Fires when the slider value is changed by the user and any drag operations have completed.
        /// <pre><code>
        /// USAGE: ({Ext.Slider} slider, {Number} newValue)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>slider</b></term><description>The slider</description></item>
        /// <item><term><b>newValue</b></term><description>The new value which the slider has been changed to.</description></item>
        /// </list>
        /// </summary>
        public static string changecomplete { get { return "changecomplete"; } }
        /// <summary>Fires after a drag operation has started.
        /// <pre><code>
        /// USAGE: ({Ext.Slider} slider, {Ext.EventObject} e)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>slider</b></term><description>The slider</description></item>
        /// <item><term><b>e</b></term><description>The event fired from Ext.dd.DragTracker</description></item>
        /// </list>
        /// </summary>
        public static string dragstart { get { return "dragstart"; } }
        /// <summary>Fires continuously during the drag operation while the mouse is moving.
        /// <pre><code>
        /// USAGE: ({Ext.Slider} slider, {Ext.EventObject} e)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>slider</b></term><description>The slider</description></item>
        /// <item><term><b>e</b></term><description>The event fired from Ext.dd.DragTracker</description></item>
        /// </list>
        /// </summary>
        public static string drag { get { return "drag"; } }
        /// <summary>Fires after the drag operation has completed.
        /// <pre><code>
        /// USAGE: ({Ext.Slider} slider, {Ext.EventObject} e)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>slider</b></term><description>The slider</description></item>
        /// <item><term><b>e</b></term><description>The event fired from Ext.dd.DragTracker</description></item>
        /// </list>
        /// </summary>
        public static string dragend { get { return "dragend"; } }
    }

    public delegate void SliderBeforechangeDelegate(Ext.Slider slider, double newValue, double oldValue);
    public delegate void SliderChangeDelegate(Ext.Slider slider, double newValue);
    public delegate void SliderChangecompleteDelegate(Ext.Slider slider, double newValue);
    public delegate void SliderDragstartDelegate(Ext.Slider slider, Ext.EventObject e);
    public delegate void SliderDragDelegate(Ext.Slider slider, Ext.EventObject e);
    public delegate void SliderDragendDelegate(Ext.Slider slider, Ext.EventObject e);
}
