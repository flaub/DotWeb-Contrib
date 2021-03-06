using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.dd {
	/// <summary>
	///     /**
	///     Defines the interface and base operation of items that that can be
	///     dragged or can be drop targets.  It was designed to be extended, overriding
	///     the event handlers for startDrag, onDrag, onDragOver and onDragOut.
	///     Up to three html elements can be associated with a DragDrop instance:
	///     <ul>
	///     <li>linked element: the element that is passed into the constructor.
	///     This is the element which defines the boundaries for interaction with
	///     other DragDrop objects.</li>
	///     <li>handle element(s): The drag operation only occurs if the element that
	///     was clicked matches a handle element.  By default this is the linked
	///     element, but there are times that you will want only a portion of the
	///     linked element to initiate the drag operation, and the setHandleElId()
	///     method provides a way to define this.</li>
	///     <li>drag element: this represents the element that would be moved along
	///     with the cursor during a drag operation.  By default, this is the linked
	///     element itself as in {@link Ext.dd.DD}.  setDragElId() lets you define
	///     a separate element that would be moved, as in {@link Ext.dd.DDProxy}.
	///     </li>
	///     </ul>
	///     This class should not be instantiated until the onload event to ensure that
	///     the associated elements are available.
	///     The following would define a DragDrop obj that would interact with any
	///     other DragDrop obj in the "group1" group:
	///     <pre>
	///     dd = new Ext.dd.DragDrop("div1", "group1");
	///     </pre>
	///     Since none of the event handlers have been implemented, nothing would
	///     actually happen if you were to run the code above.  Normally you would
	///     override this class or one of the default implementations, but you can
	///     also override the methods you want on an instance of the class...
	///     <pre>
	///     dd.onDragDrop = function(e, id) {
	///     &nbsp;&nbsp;alert("dd was dropped on " + id);
	///     }
	///     </pre>
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\dd\DDCore.js</jssource>
	[JsObject]
	public class DragDrop  {

		/// <summary>
		///     Valid properties for DragDrop:
		///     padding, isTarget, maintainOffset, primaryButtonOnly
		/// </summary>
		/// <returns></returns>
		public extern DragDrop();
		/// <summary>
		///     Valid properties for DragDrop:
		///     padding, isTarget, maintainOffset, primaryButtonOnly
		/// </summary>
		/// <param name="id">of the element that is linked to this instance</param>
		/// <returns></returns>
		public extern DragDrop(string id);
		/// <summary>
		///     Valid properties for DragDrop:
		///     padding, isTarget, maintainOffset, primaryButtonOnly
		/// </summary>
		/// <param name="id">of the element that is linked to this instance</param>
		/// <param name="sGroup">the group of related DragDrop objects</param>
		/// <returns></returns>
		public extern DragDrop(string id, string sGroup);
		/// <summary>
		///     Valid properties for DragDrop:
		///     padding, isTarget, maintainOffset, primaryButtonOnly
		/// </summary>
		/// <param name="id">of the element that is linked to this instance</param>
		/// <param name="sGroup">the group of related DragDrop objects</param>
		/// <param name="config">an object containing configurable attributes</param>
		/// <returns></returns>
		public extern DragDrop(string id, string sGroup, object config);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static DragDrop prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>
		///     The id of the element associated with this object.  This is what we
		///     refer to as the "linked element" because the size and position of
		///     this element is used to determine when the drag and drop objects have
		///     interacted.
		/// </summary>
		public extern string id { get; set; }

		/// <summary>Configuration attributes passed into the constructor</summary>
		public extern object config { get; set; }

		/// <summary>
		///     An object who's property names identify HTML tags to be considered invalid as drag handles.
		///     A non-null property value identifies the tag as invalid. Defaults to the
		///     following value which prevents drag operations from being initiated by &lt;a> elements:<pre><code>
		///     {
		///     A: "A"
		///     }</code></pre>
		/// </summary>
		public extern object invalidHandleTypes { get; set; }

		/// <summary>
		///     An object who's property names identify the IDs of elements to be considered invalid as drag handles.
		///     A non-null property value identifies the ID as invalid. For example, to prevent
		///     dragging from being initiated on element ID "foo", use:<pre><code>
		///     {
		///     foo: true
		///     }</code></pre>
		/// </summary>
		public extern object invalidHandleIds { get; set; }

		/// <summary>An Array of CSS class names for elements to be considered in valid as drag handles.</summary>
		public extern System.Array invalidHandleClasses { get; set; }

		/// <summary>
		///     The group defines a logical collection of DragDrop objects that are
		///     related.  Instances only get events when interacting with other
		///     DragDrop object in the same group.  This lets us define multiple
		///     groups using a single DragDrop subclass if we want.
		/// </summary>
		public extern object groups { get; set; }

		/// <summary>
		///     When set to true, other DD objects in cooperating DDGroups do not receive
		///     notification events when this DD object is dragged over them. Defaults to false.
		/// </summary>
		public extern bool moveOnly { get; set; }

		/// <summary>
		///     By default, all instances can be a drop target.  This can be disabled by
		///     setting isTarget to false.
		/// </summary>
		public extern bool isTarget { get; set; }

		/// <summary>
		///     The padding configured for this drag and drop object for calculating
		///     the drop zone intersection with this object.
		/// </summary>
		public extern int[] padding { get; set; }

		/// <summary>
		///     Maintain offsets when we resetconstraints.  Set to true when you want
		///     the position of the element relative to its parent to stay the same
		///     when the page changes
		/// </summary>
		public extern bool maintainOffset { get; set; }

		/// <summary>
		///     Array of pixel locations the element will snap to if we specified a
		///     horizontal graduation/interval.  This array is generated automatically
		///     when you define a tick interval.
		/// </summary>
		public extern int[] xTicks { get; set; }

		/// <summary>
		///     Array of pixel locations the element will snap to if we specified a
		///     vertical graduation/interval.  This array is generated automatically
		///     when you define a tick interval.
		/// </summary>
		public extern int[] yTicks { get; set; }

		/// <summary>
		///     By default the drag and drop instance will only respond to the primary
		///     button click (left button for a right-handed mouse).  Set to true to
		///     allow drag and drop to start with any mouse click that is propogated
		///     by the browser
		/// </summary>
		public extern bool primaryButtonOnly { get; set; }

		/// <summary>The availabe property is false until the linked dom element is accessible.</summary>
		public extern bool available { get; set; }

		/// <summary>
		///     By default, drags can only be initiated if the mousedown occurs in the
		///     region the linked element is.  This is done in part to work around a
		///     bug in some browsers that mis-report the mousedown if the previous
		///     mouseup happened outside of the window.  This property is set to true
		///     if outer handles are defined.
		///     @default false
		/// </summary>
		public extern bool hasOuterHandles { get; set; }

		/// <summary>Provides default constraint padding to "constrainTo" elements (defaults to {left: 0, right:0, top:0, bottom:0}).</summary>
		public extern object defaultPadding { get; set; }


		/// <summary>Lock this instance</summary>
		/// <returns></returns>
		public extern virtual void lock_();

		/// <summary>Unlock this instace</summary>
		/// <returns></returns>
		public extern virtual void unlock();

		/// <summary>
		///     Abstract method called after a drag/drop object is clicked
		///     and the drag or mousedown time thresholds have beeen met.
		/// </summary>
		/// <returns></returns>
		public extern virtual void startDrag();

		/// <summary>
		///     Abstract method called after a drag/drop object is clicked
		///     and the drag or mousedown time thresholds have beeen met.
		/// </summary>
		/// <param name="X">click location</param>
		/// <returns></returns>
		public extern virtual void startDrag(int X);

		/// <summary>
		///     Abstract method called after a drag/drop object is clicked
		///     and the drag or mousedown time thresholds have beeen met.
		/// </summary>
		/// <param name="X">click location</param>
		/// <param name="Y">click location</param>
		/// <returns></returns>
		public extern virtual void startDrag(int X, int Y);

		/// <summary>
		///     Abstract method called during the onMouseMove event while dragging an
		///     object.
		/// </summary>
		/// <returns></returns>
		public extern virtual void onDrag();

		/// <summary>
		///     Abstract method called during the onMouseMove event while dragging an
		///     object.
		/// </summary>
		/// <param name="e">the mousemove event</param>
		/// <returns></returns>
		public extern virtual void onDrag(Event e);

		/// <summary>
		///     Abstract method called when this element fist begins hovering over
		///     another DragDrop obj
		///     id this is hovering over.  In INTERSECT mode, an array of one or more
		///     dragdrop items being hovered over.
		/// </summary>
		/// <returns></returns>
		public extern virtual void onDragEnter();

		/// <summary>
		///     Abstract method called when this element fist begins hovering over
		///     another DragDrop obj
		///     id this is hovering over.  In INTERSECT mode, an array of one or more
		///     dragdrop items being hovered over.
		/// </summary>
		/// <param name="e">the mousemove event</param>
		/// <returns></returns>
		public extern virtual void onDragEnter(Event e);

		/// <summary>
		///     Abstract method called when this element fist begins hovering over
		///     another DragDrop obj
		///     id this is hovering over.  In INTERSECT mode, an array of one or more
		///     dragdrop items being hovered over.
		/// </summary>
		/// <param name="e">the mousemove event</param>
		/// <param name="id">In POINT mode, the element</param>
		/// <returns></returns>
		public extern virtual void onDragEnter(Event e, object id);

		/// <summary>
		///     Abstract method called when this element is hovering over another
		///     DragDrop obj
		///     id this is hovering over.  In INTERSECT mode, an array of dd items
		///     being hovered over.
		/// </summary>
		/// <returns></returns>
		public extern virtual void onDragOver();

		/// <summary>
		///     Abstract method called when this element is hovering over another
		///     DragDrop obj
		///     id this is hovering over.  In INTERSECT mode, an array of dd items
		///     being hovered over.
		/// </summary>
		/// <param name="e">the mousemove event</param>
		/// <returns></returns>
		public extern virtual void onDragOver(Event e);

		/// <summary>
		///     Abstract method called when this element is hovering over another
		///     DragDrop obj
		///     id this is hovering over.  In INTERSECT mode, an array of dd items
		///     being hovered over.
		/// </summary>
		/// <param name="e">the mousemove event</param>
		/// <param name="id">In POINT mode, the element</param>
		/// <returns></returns>
		public extern virtual void onDragOver(Event e, object id);

		/// <summary>
		///     Abstract method called when we are no longer hovering over an element
		///     id this was hovering over.  In INTERSECT mode, an array of dd items
		///     that the mouse is no longer over.
		/// </summary>
		/// <returns></returns>
		public extern virtual void onDragOut();

		/// <summary>
		///     Abstract method called when we are no longer hovering over an element
		///     id this was hovering over.  In INTERSECT mode, an array of dd items
		///     that the mouse is no longer over.
		/// </summary>
		/// <param name="e">the mousemove event</param>
		/// <returns></returns>
		public extern virtual void onDragOut(Event e);

		/// <summary>
		///     Abstract method called when we are no longer hovering over an element
		///     id this was hovering over.  In INTERSECT mode, an array of dd items
		///     that the mouse is no longer over.
		/// </summary>
		/// <param name="e">the mousemove event</param>
		/// <param name="id">In POINT mode, the element</param>
		/// <returns></returns>
		public extern virtual void onDragOut(Event e, object id);

		/// <summary>
		///     Abstract method called when this item is dropped on another DragDrop
		///     obj
		///     id this was dropped on.  In INTERSECT mode, an array of dd items this
		///     was dropped on.
		/// </summary>
		/// <returns></returns>
		public extern virtual void onDragDrop();

		/// <summary>
		///     Abstract method called when this item is dropped on another DragDrop
		///     obj
		///     id this was dropped on.  In INTERSECT mode, an array of dd items this
		///     was dropped on.
		/// </summary>
		/// <param name="e">the mouseup event</param>
		/// <returns></returns>
		public extern virtual void onDragDrop(Event e);

		/// <summary>
		///     Abstract method called when this item is dropped on another DragDrop
		///     obj
		///     id this was dropped on.  In INTERSECT mode, an array of dd items this
		///     was dropped on.
		/// </summary>
		/// <param name="e">the mouseup event</param>
		/// <param name="id">In POINT mode, the element</param>
		/// <returns></returns>
		public extern virtual void onDragDrop(Event e, object id);

		/// <summary>
		///     Abstract method called when this item is dropped on an area with no
		///     drop target
		/// </summary>
		/// <returns></returns>
		public extern virtual void onInvalidDrop();

		/// <summary>
		///     Abstract method called when this item is dropped on an area with no
		///     drop target
		/// </summary>
		/// <param name="e">the mouseup event</param>
		/// <returns></returns>
		public extern virtual void onInvalidDrop(Event e);

		/// <summary>Fired when we are done dragging the object</summary>
		/// <returns></returns>
		public extern virtual void endDrag();

		/// <summary>Fired when we are done dragging the object</summary>
		/// <param name="e">the mouseup event</param>
		/// <returns></returns>
		public extern virtual void endDrag(Event e);

		/// <summary>Event handler that fires when a drag/drop obj gets a mousedown</summary>
		/// <returns></returns>
		public extern virtual void onMouseDown();

		/// <summary>Event handler that fires when a drag/drop obj gets a mousedown</summary>
		/// <param name="e">the mousedown event</param>
		/// <returns></returns>
		public extern virtual void onMouseDown(Event e);

		/// <summary>Event handler that fires when a drag/drop obj gets a mouseup</summary>
		/// <returns></returns>
		public extern virtual void onMouseUp();

		/// <summary>Event handler that fires when a drag/drop obj gets a mouseup</summary>
		/// <param name="e">the mouseup event</param>
		/// <returns></returns>
		public extern virtual void onMouseUp(Event e);

		/// <summary>
		///     Override the onAvailable method to do what is needed after the initial
		///     position was determined.
		/// </summary>
		/// <returns></returns>
		public extern virtual void onAvailable();

		/// <summary>
		///     Initializes the drag drop object's constraints to restrict movement to a certain element.
		///     Usage:
		///     <pre><code>
		///     var dd = new Ext.dd.DDProxy("dragDiv1", "proxytest",
		///     { dragElId: "existingProxyDiv" });
		///     dd.startDrag = function(){
		///     this.constrainTo("parent-id");
		///     };
		///     </code></pre>
		///     Or you can initalize it using the {@link Ext.Element} object:
		///     <pre><code>
		///     Ext.get("dragDiv1").initDDProxy("proxytest", {dragElId: "existingProxyDiv"}, {
		///     startDrag : function(){
		///     this.constrainTo("parent-id");
		///     }
		///     });
		///     </code></pre>
		///     and can be either a number for symmetrical padding (4 would be equal to {left:4, right:4, top:4, bottom:4}) or
		///     an object containing the sides to pad. For example: {right:10, bottom:10}
		/// </summary>
		/// <returns></returns>
		public extern virtual void constrainTo();

		/// <summary>
		///     Initializes the drag drop object's constraints to restrict movement to a certain element.
		///     Usage:
		///     <pre><code>
		///     var dd = new Ext.dd.DDProxy("dragDiv1", "proxytest",
		///     { dragElId: "existingProxyDiv" });
		///     dd.startDrag = function(){
		///     this.constrainTo("parent-id");
		///     };
		///     </code></pre>
		///     Or you can initalize it using the {@link Ext.Element} object:
		///     <pre><code>
		///     Ext.get("dragDiv1").initDDProxy("proxytest", {dragElId: "existingProxyDiv"}, {
		///     startDrag : function(){
		///     this.constrainTo("parent-id");
		///     }
		///     });
		///     </code></pre>
		///     and can be either a number for symmetrical padding (4 would be equal to {left:4, right:4, top:4, bottom:4}) or
		///     an object containing the sides to pad. For example: {right:10, bottom:10}
		/// </summary>
		/// <param name="constrainTo">The element to constrain to.</param>
		/// <returns></returns>
		public extern virtual void constrainTo(object constrainTo);

		/// <summary>
		///     Initializes the drag drop object's constraints to restrict movement to a certain element.
		///     Usage:
		///     <pre><code>
		///     var dd = new Ext.dd.DDProxy("dragDiv1", "proxytest",
		///     { dragElId: "existingProxyDiv" });
		///     dd.startDrag = function(){
		///     this.constrainTo("parent-id");
		///     };
		///     </code></pre>
		///     Or you can initalize it using the {@link Ext.Element} object:
		///     <pre><code>
		///     Ext.get("dragDiv1").initDDProxy("proxytest", {dragElId: "existingProxyDiv"}, {
		///     startDrag : function(){
		///     this.constrainTo("parent-id");
		///     }
		///     });
		///     </code></pre>
		///     and can be either a number for symmetrical padding (4 would be equal to {left:4, right:4, top:4, bottom:4}) or
		///     an object containing the sides to pad. For example: {right:10, bottom:10}
		/// </summary>
		/// <param name="constrainTo">The element to constrain to.</param>
		/// <param name="pad">(optional) Pad provides a way to specify "padding" of the constraints,</param>
		/// <returns></returns>
		public extern virtual void constrainTo(object constrainTo, object pad);

		/// <summary>
		///     Initializes the drag drop object's constraints to restrict movement to a certain element.
		///     Usage:
		///     <pre><code>
		///     var dd = new Ext.dd.DDProxy("dragDiv1", "proxytest",
		///     { dragElId: "existingProxyDiv" });
		///     dd.startDrag = function(){
		///     this.constrainTo("parent-id");
		///     };
		///     </code></pre>
		///     Or you can initalize it using the {@link Ext.Element} object:
		///     <pre><code>
		///     Ext.get("dragDiv1").initDDProxy("proxytest", {dragElId: "existingProxyDiv"}, {
		///     startDrag : function(){
		///     this.constrainTo("parent-id");
		///     }
		///     });
		///     </code></pre>
		///     and can be either a number for symmetrical padding (4 would be equal to {left:4, right:4, top:4, bottom:4}) or
		///     an object containing the sides to pad. For example: {right:10, bottom:10}
		/// </summary>
		/// <param name="constrainTo">The element to constrain to.</param>
		/// <param name="pad">(optional) Pad provides a way to specify "padding" of the constraints,</param>
		/// <param name="inContent">(optional) Constrain the draggable in the content box of the element (inside padding and borders)</param>
		/// <returns></returns>
		public extern virtual void constrainTo(object constrainTo, object pad, bool inContent);

		/// <summary>
		///     Initializes the drag drop object's constraints to restrict movement to a certain element.
		///     Usage:
		///     <pre><code>
		///     var dd = new Ext.dd.DDProxy("dragDiv1", "proxytest",
		///     { dragElId: "existingProxyDiv" });
		///     dd.startDrag = function(){
		///     this.constrainTo("parent-id");
		///     };
		///     </code></pre>
		///     Or you can initalize it using the {@link Ext.Element} object:
		///     <pre><code>
		///     Ext.get("dragDiv1").initDDProxy("proxytest", {dragElId: "existingProxyDiv"}, {
		///     startDrag : function(){
		///     this.constrainTo("parent-id");
		///     }
		///     });
		///     </code></pre>
		///     and can be either a number for symmetrical padding (4 would be equal to {left:4, right:4, top:4, bottom:4}) or
		///     an object containing the sides to pad. For example: {right:10, bottom:10}
		/// </summary>
		/// <param name="constrainTo">The element to constrain to.</param>
		/// <param name="pad">(optional) Pad provides a way to specify "padding" of the constraints,</param>
		/// <returns></returns>
		public extern virtual void constrainTo(object constrainTo, double pad);

		/// <summary>
		///     Initializes the drag drop object's constraints to restrict movement to a certain element.
		///     Usage:
		///     <pre><code>
		///     var dd = new Ext.dd.DDProxy("dragDiv1", "proxytest",
		///     { dragElId: "existingProxyDiv" });
		///     dd.startDrag = function(){
		///     this.constrainTo("parent-id");
		///     };
		///     </code></pre>
		///     Or you can initalize it using the {@link Ext.Element} object:
		///     <pre><code>
		///     Ext.get("dragDiv1").initDDProxy("proxytest", {dragElId: "existingProxyDiv"}, {
		///     startDrag : function(){
		///     this.constrainTo("parent-id");
		///     }
		///     });
		///     </code></pre>
		///     and can be either a number for symmetrical padding (4 would be equal to {left:4, right:4, top:4, bottom:4}) or
		///     an object containing the sides to pad. For example: {right:10, bottom:10}
		/// </summary>
		/// <param name="constrainTo">The element to constrain to.</param>
		/// <param name="pad">(optional) Pad provides a way to specify "padding" of the constraints,</param>
		/// <param name="inContent">(optional) Constrain the draggable in the content box of the element (inside padding and borders)</param>
		/// <returns></returns>
		public extern virtual void constrainTo(object constrainTo, double pad, bool inContent);

		/// <summary>Returns a reference to the linked element</summary>
		/// <returns>HTMLElement</returns>
		public extern virtual void getEl();

		/// <summary>
		///     Returns a reference to the actual element to drag.  By default this is
		///     the same as the html element, but it can be assigned to another
		///     element. An example of this can be found in Ext.dd.DDProxy
		/// </summary>
		/// <returns>HTMLElement</returns>
		public extern virtual void getDragEl();

		/// <summary>
		///     Sets up the DragDrop object.  Must be called in the constructor of any
		///     Ext.dd.DragDrop subclass
		/// </summary>
		/// <returns></returns>
		public extern virtual void init();

		/// <summary>
		///     Sets up the DragDrop object.  Must be called in the constructor of any
		///     Ext.dd.DragDrop subclass
		/// </summary>
		/// <param name="id">the id of the linked element</param>
		/// <returns></returns>
		public extern virtual void init(object id);

		/// <summary>
		///     Sets up the DragDrop object.  Must be called in the constructor of any
		///     Ext.dd.DragDrop subclass
		/// </summary>
		/// <param name="id">the id of the linked element</param>
		/// <param name="sGroup">the group of related items</param>
		/// <returns></returns>
		public extern virtual void init(object id, string sGroup);

		/// <summary>
		///     Sets up the DragDrop object.  Must be called in the constructor of any
		///     Ext.dd.DragDrop subclass
		/// </summary>
		/// <param name="id">the id of the linked element</param>
		/// <param name="sGroup">the group of related items</param>
		/// <param name="config">configuration attributes</param>
		/// <returns></returns>
		public extern virtual void init(object id, string sGroup, object config);

		/// <summary>
		///     Initializes Targeting functionality only... the object does not
		///     get a mousedown handler.
		/// </summary>
		/// <returns></returns>
		public extern virtual void initTarget();

		/// <summary>
		///     Initializes Targeting functionality only... the object does not
		///     get a mousedown handler.
		/// </summary>
		/// <param name="id">the id of the linked element</param>
		/// <returns></returns>
		public extern virtual void initTarget(object id);

		/// <summary>
		///     Initializes Targeting functionality only... the object does not
		///     get a mousedown handler.
		/// </summary>
		/// <param name="id">the id of the linked element</param>
		/// <param name="sGroup">the group of related items</param>
		/// <returns></returns>
		public extern virtual void initTarget(object id, string sGroup);

		/// <summary>
		///     Initializes Targeting functionality only... the object does not
		///     get a mousedown handler.
		/// </summary>
		/// <param name="id">the id of the linked element</param>
		/// <param name="sGroup">the group of related items</param>
		/// <param name="config">configuration attributes</param>
		/// <returns></returns>
		public extern virtual void initTarget(object id, string sGroup, object config);

		/// <summary>
		///     Applies the configuration parameters that were passed into the constructor.
		///     This is supposed to happen at each level through the inheritance chain.  So
		///     a DDProxy implentation will execute apply config on DDProxy, DD, and
		///     DragDrop in order to get all of the parameters that are available in
		///     each object.
		/// </summary>
		/// <returns></returns>
		public extern virtual void applyConfig();

		/// <summary>
		///     Configures the padding for the target zone in px.  Effectively expands
		///     (or reduces) the virtual object size for targeting calculations.
		///     Supports css-style shorthand; if only one parameter is passed, all sides
		///     will have that padding, and if only two are passed, the top and bottom
		///     will have the first param, the left and right the second.
		/// </summary>
		/// <returns></returns>
		public extern virtual void setPadding();

		/// <summary>
		///     Configures the padding for the target zone in px.  Effectively expands
		///     (or reduces) the virtual object size for targeting calculations.
		///     Supports css-style shorthand; if only one parameter is passed, all sides
		///     will have that padding, and if only two are passed, the top and bottom
		///     will have the first param, the left and right the second.
		/// </summary>
		/// <param name="iTop">Top pad</param>
		/// <returns></returns>
		public extern virtual void setPadding(int iTop);

		/// <summary>
		///     Configures the padding for the target zone in px.  Effectively expands
		///     (or reduces) the virtual object size for targeting calculations.
		///     Supports css-style shorthand; if only one parameter is passed, all sides
		///     will have that padding, and if only two are passed, the top and bottom
		///     will have the first param, the left and right the second.
		/// </summary>
		/// <param name="iTop">Top pad</param>
		/// <param name="iRight">Right pad</param>
		/// <returns></returns>
		public extern virtual void setPadding(int iTop, int iRight);

		/// <summary>
		///     Configures the padding for the target zone in px.  Effectively expands
		///     (or reduces) the virtual object size for targeting calculations.
		///     Supports css-style shorthand; if only one parameter is passed, all sides
		///     will have that padding, and if only two are passed, the top and bottom
		///     will have the first param, the left and right the second.
		/// </summary>
		/// <param name="iTop">Top pad</param>
		/// <param name="iRight">Right pad</param>
		/// <param name="iBot">Bot pad</param>
		/// <returns></returns>
		public extern virtual void setPadding(int iTop, int iRight, int iBot);

		/// <summary>
		///     Configures the padding for the target zone in px.  Effectively expands
		///     (or reduces) the virtual object size for targeting calculations.
		///     Supports css-style shorthand; if only one parameter is passed, all sides
		///     will have that padding, and if only two are passed, the top and bottom
		///     will have the first param, the left and right the second.
		/// </summary>
		/// <param name="iTop">Top pad</param>
		/// <param name="iRight">Right pad</param>
		/// <param name="iBot">Bot pad</param>
		/// <param name="iLeft">Left pad</param>
		/// <returns></returns>
		public extern virtual void setPadding(int iTop, int iRight, int iBot, int iLeft);

		/// <summary>Stores the initial placement of the linked element.</summary>
		/// <returns></returns>
		public extern virtual void setInitPosition();

		/// <summary>Stores the initial placement of the linked element.</summary>
		/// <param name="diffX">the X offset, default 0</param>
		/// <returns></returns>
		public extern virtual void setInitPosition(int diffX);

		/// <summary>Stores the initial placement of the linked element.</summary>
		/// <param name="diffX">the X offset, default 0</param>
		/// <param name="diffY">the Y offset, default 0</param>
		/// <returns></returns>
		public extern virtual void setInitPosition(int diffX, int diffY);

		/// <summary>
		///     Add this instance to a group of related drag/drop objects.  All
		///     instances belong to at least one group, and can belong to as many
		///     groups as needed.
		/// </summary>
		/// <returns></returns>
		public extern virtual void addToGroup();

		/// <summary>
		///     Add this instance to a group of related drag/drop objects.  All
		///     instances belong to at least one group, and can belong to as many
		///     groups as needed.
		/// </summary>
		/// <param name="sGroup">{string} the name of the group</param>
		/// <returns></returns>
		public extern virtual void addToGroup(object sGroup);

		/// <summary>Remove's this instance from the supplied interaction group</summary>
		/// <returns></returns>
		public extern virtual void removeFromGroup();

		/// <summary>Remove's this instance from the supplied interaction group</summary>
		/// <param name="sGroup">The group to drop</param>
		/// <returns></returns>
		public extern virtual void removeFromGroup(string sGroup);

		/// <summary>
		///     Allows you to specify that an element other than the linked element
		///     will be moved with the cursor during a drag
		/// </summary>
		/// <returns></returns>
		public extern virtual void setDragElId();

		/// <summary>
		///     Allows you to specify that an element other than the linked element
		///     will be moved with the cursor during a drag
		/// </summary>
		/// <param name="id">{string} the id of the element that will be used to initiate the drag</param>
		/// <returns></returns>
		public extern virtual void setDragElId(object id);

		/// <summary>
		///     Allows you to specify a child of the linked element that should be
		///     used to initiate the drag operation.  An example of this would be if
		///     you have a content div with text and links.  Clicking anywhere in the
		///     content area would normally start the drag operation.  Use this method
		///     to specify that an element inside of the content div is the element
		///     that starts the drag operation.
		///     initiate the drag.
		/// </summary>
		/// <returns></returns>
		public extern virtual void setHandleElId();

		/// <summary>
		///     Allows you to specify a child of the linked element that should be
		///     used to initiate the drag operation.  An example of this would be if
		///     you have a content div with text and links.  Clicking anywhere in the
		///     content area would normally start the drag operation.  Use this method
		///     to specify that an element inside of the content div is the element
		///     that starts the drag operation.
		///     initiate the drag.
		/// </summary>
		/// <param name="id">{string} the id of the element that will be used to</param>
		/// <returns></returns>
		public extern virtual void setHandleElId(object id);

		/// <summary>
		///     Allows you to set an element outside of the linked element as a drag
		///     handle
		/// </summary>
		/// <returns></returns>
		public extern virtual void setOuterHandleElId();

		/// <summary>
		///     Allows you to set an element outside of the linked element as a drag
		///     handle
		/// </summary>
		/// <param name="id">the id of the element that will be used to initiate the drag</param>
		/// <returns></returns>
		public extern virtual void setOuterHandleElId(object id);

		/// <summary>Remove all drag and drop hooks for this element</summary>
		/// <returns></returns>
		public extern virtual void unreg();

		/// <summary>
		///     Returns true if this instance is locked, or the drag drop mgr is locked
		///     (meaning that all drag/drop is disabled on the page.)
		///     false
		/// </summary>
		/// <returns>boolean</returns>
		public extern virtual void isLocked();

		/// <summary>
		///     Allows you to specify a tag name that should not start a drag operation
		///     when clicked.  This is designed to facilitate embedding links within a
		///     drag handle that do something other than start the drag.
		/// </summary>
		/// <returns></returns>
		public extern virtual void addInvalidHandleType();

		/// <summary>
		///     Allows you to specify a tag name that should not start a drag operation
		///     when clicked.  This is designed to facilitate embedding links within a
		///     drag handle that do something other than start the drag.
		/// </summary>
		/// <param name="tagName">the type of element to exclude</param>
		/// <returns></returns>
		public extern virtual void addInvalidHandleType(string tagName);

		/// <summary>
		///     Lets you to specify an element id for a child of a drag handle
		///     that should not initiate a drag
		/// </summary>
		/// <returns></returns>
		public extern virtual void addInvalidHandleId();

		/// <summary>
		///     Lets you to specify an element id for a child of a drag handle
		///     that should not initiate a drag
		/// </summary>
		/// <param name="id">the element id of the element you wish to ignore</param>
		/// <returns></returns>
		public extern virtual void addInvalidHandleId(string id);

		/// <summary>Lets you specify a css class of elements that will not initiate a drag</summary>
		/// <returns></returns>
		public extern virtual void addInvalidHandleClass();

		/// <summary>Lets you specify a css class of elements that will not initiate a drag</summary>
		/// <param name="cssClass">the class of the elements you wish to ignore</param>
		/// <returns></returns>
		public extern virtual void addInvalidHandleClass(string cssClass);

		/// <summary>Unsets an excluded tag name set by addInvalidHandleType</summary>
		/// <returns></returns>
		public extern virtual void removeInvalidHandleType();

		/// <summary>Unsets an excluded tag name set by addInvalidHandleType</summary>
		/// <param name="tagName">the type of element to unexclude</param>
		/// <returns></returns>
		public extern virtual void removeInvalidHandleType(string tagName);

		/// <summary>Unsets an invalid handle id</summary>
		/// <returns></returns>
		public extern virtual void removeInvalidHandleId();

		/// <summary>Unsets an invalid handle id</summary>
		/// <param name="id">the id of the element to re-enable</param>
		/// <returns></returns>
		public extern virtual void removeInvalidHandleId(string id);

		/// <summary>
		///     Unsets an invalid css class
		///     re-enable
		/// </summary>
		/// <returns></returns>
		public extern virtual void removeInvalidHandleClass();

		/// <summary>
		///     Unsets an invalid css class
		///     re-enable
		/// </summary>
		/// <param name="cssClass">the class of the element(s) you wish to</param>
		/// <returns></returns>
		public extern virtual void removeInvalidHandleClass(string cssClass);

		/// <summary>Checks the tag exclusion list to see if this click should be ignored</summary>
		/// <returns>boolean</returns>
		public extern virtual void isValidHandleChild();

		/// <summary>Checks the tag exclusion list to see if this click should be ignored</summary>
		/// <param name="node">the HTMLElement to evaluate</param>
		/// <returns>boolean</returns>
		public extern virtual void isValidHandleChild(DOMElement node);

		/// <summary>
		///     By default, the element can be dragged any place on the screen.  Use
		///     this method to limit the horizontal travel of the element.  Pass in
		///     0,0 for the parameters if you want to lock the drag to the y axis.
		///     right
		///     element
		///     should move iTickSize pixels at a time.
		/// </summary>
		/// <returns></returns>
		public extern virtual void setXConstraint();

		/// <summary>
		///     By default, the element can be dragged any place on the screen.  Use
		///     this method to limit the horizontal travel of the element.  Pass in
		///     0,0 for the parameters if you want to lock the drag to the y axis.
		///     right
		///     element
		///     should move iTickSize pixels at a time.
		/// </summary>
		/// <param name="iLeft">the number of pixels the element can move to the left</param>
		/// <returns></returns>
		public extern virtual void setXConstraint(int iLeft);

		/// <summary>
		///     By default, the element can be dragged any place on the screen.  Use
		///     this method to limit the horizontal travel of the element.  Pass in
		///     0,0 for the parameters if you want to lock the drag to the y axis.
		///     right
		///     element
		///     should move iTickSize pixels at a time.
		/// </summary>
		/// <param name="iLeft">the number of pixels the element can move to the left</param>
		/// <param name="iRight">the number of pixels the element can move to the</param>
		/// <returns></returns>
		public extern virtual void setXConstraint(int iLeft, int iRight);

		/// <summary>
		///     By default, the element can be dragged any place on the screen.  Use
		///     this method to limit the horizontal travel of the element.  Pass in
		///     0,0 for the parameters if you want to lock the drag to the y axis.
		///     right
		///     element
		///     should move iTickSize pixels at a time.
		/// </summary>
		/// <param name="iLeft">the number of pixels the element can move to the left</param>
		/// <param name="iRight">the number of pixels the element can move to the</param>
		/// <param name="iTickSize">optional parameter for specifying that the</param>
		/// <returns></returns>
		public extern virtual void setXConstraint(int iLeft, int iRight, int iTickSize);

		/// <summary>
		///     Clears any constraints applied to this instance.  Also clears ticks
		///     since they can't exist independent of a constraint at this time.
		/// </summary>
		/// <returns></returns>
		public extern virtual void clearConstraints();

		/// <summary>Clears any tick interval defined for this instance</summary>
		/// <returns></returns>
		public extern virtual void clearTicks();

		/// <summary>
		///     By default, the element can be dragged any place on the screen.  Set
		///     this to limit the vertical travel of the element.  Pass in 0,0 for the
		///     parameters if you want to lock the drag to the x axis.
		///     element should move iTickSize pixels at a time.
		/// </summary>
		/// <returns></returns>
		public extern virtual void setYConstraint();

		/// <summary>
		///     By default, the element can be dragged any place on the screen.  Set
		///     this to limit the vertical travel of the element.  Pass in 0,0 for the
		///     parameters if you want to lock the drag to the x axis.
		///     element should move iTickSize pixels at a time.
		/// </summary>
		/// <param name="iUp">the number of pixels the element can move up</param>
		/// <returns></returns>
		public extern virtual void setYConstraint(int iUp);

		/// <summary>
		///     By default, the element can be dragged any place on the screen.  Set
		///     this to limit the vertical travel of the element.  Pass in 0,0 for the
		///     parameters if you want to lock the drag to the x axis.
		///     element should move iTickSize pixels at a time.
		/// </summary>
		/// <param name="iUp">the number of pixels the element can move up</param>
		/// <param name="iDown">the number of pixels the element can move down</param>
		/// <returns></returns>
		public extern virtual void setYConstraint(int iUp, int iDown);

		/// <summary>
		///     By default, the element can be dragged any place on the screen.  Set
		///     this to limit the vertical travel of the element.  Pass in 0,0 for the
		///     parameters if you want to lock the drag to the x axis.
		///     element should move iTickSize pixels at a time.
		/// </summary>
		/// <param name="iUp">the number of pixels the element can move up</param>
		/// <param name="iDown">the number of pixels the element can move down</param>
		/// <param name="iTickSize">optional parameter for specifying that the</param>
		/// <returns></returns>
		public extern virtual void setYConstraint(int iUp, int iDown, int iTickSize);

		/// <summary>resetConstraints must be called if you manually reposition a dd element.</summary>
		/// <returns></returns>
		public extern virtual void resetConstraints();

		/// <summary>resetConstraints must be called if you manually reposition a dd element.</summary>
		/// <param name="maintainOffset"></param>
		/// <returns></returns>
		public extern virtual void resetConstraints(bool maintainOffset);

		/// <summary>toString method</summary>
		/// <returns>string</returns>
		public extern virtual void toString();



	}
}
