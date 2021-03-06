using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.util {
	/// <summary>
	///     /**
	///     Abstract base class that provides a common interface for publishing events. Subclasses are expected to
	///     to have a property "events" with all the events defined.<br>
	///     For example:
	///     <pre><code>
	///     Employee = function(name){
	///     this.name = name;
	///     this.addEvents({
	///     "fired" : true,
	///     "quit" : true
	///     });
	///     }
	///     Ext.extend(Employee, Ext.util.Observable);
	///     </code></pre>
	///     */
	///     Ext.util.Observable = function(){
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\util\Observable.js</jssource>
	[JsObject]
	public class Observable  {

		/// <summary>Auto-generated default constructor</summary>
		/// <returns></returns>
		public extern Observable();

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static Observable prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>
		///     (optional) A config object containing one or more event handlers to be added to thisobject during initialization.  This should be a valid listeners config object as specified in the
		///     {@link #addListener} example for attaching multiple handlers at once.
		/// </summary>
		public extern object listeners { get; set; }


		/// <summary>Fires the specified event with the passed parameters (minus the event name).</summary>
		/// <returns>Boolean</returns>
		public extern virtual void fireEvent();

		/// <summary>Fires the specified event with the passed parameters (minus the event name).</summary>
		/// <param name="eventName"></param>
		/// <returns>Boolean</returns>
		public extern virtual void fireEvent(string eventName);

		/// <summary>Fires the specified event with the passed parameters (minus the event name).</summary>
		/// <param name="eventName"></param>
		/// <param name="args">Variable number of parameters are passed to handlers</param>
		/// <returns>Boolean</returns>
		public extern virtual void fireEvent(string eventName, params object[] args);

		/// <summary>
		///     Appends an event handler to this component
		///     <b>If omitted, defaults to the object which fired the event.</b>
		///     properties. This may contain any of the following properties:<ul>
		///     <li><b>scope</b> : Object<div class="sub-desc">The scope (<code><b>this</b></code> reference) in which the handler function is executed.
		///     <b>If omitted, defaults to the object which fired the event.</b></div></li>
		///     <li><b>delay</b> : Number<div class="sub-desc">The number of milliseconds to delay the invocation of the handler after the event fires.</div></li>
		///     <li><b>single</b> : Boolean<div class="sub-desc">True to add a handler to handle just the next firing of the event, and then remove itself.</div></li>
		///     <li><b>buffer</b> : Number<div class="sub-desc">Causes the handler to be scheduled to run in an {@link Ext.util.DelayedTask} delayed
		///     by the specified number of milliseconds. If the event fires again within that time, the original
		///     handler is <em>not</em> invoked, but the new handler is scheduled in its place.</div></li>
		///     <li><b>target</b> : Observable<div class="sub-desc">Only call the handler if the event was fired on the target Observable, <i>not</i>
		///     if the event was bubbled up from a child Observable.</div></li>
		///     </ul><br>
		///     <p>
		///     <b>Combining Options</b><br>
		///     Using the options argument, it is possible to combine different types of listeners:<br>
		///     <br>
		///     A delayed, one-time listener.
		///     <pre><code>
		///     myDataView.on('click', this.onClick, this, {
		///     single: true,
		///     delay: 100
		///     });</code></pre>
		///     <p>
		///     <b>Attaching multiple handlers in 1 call</b><br>
		///     The method also allows for a single argument to be passed which is a config object containing properties
		///     which specify multiple handlers.
		///     <p>
		///     <pre><code>
		///     myGridPanel.on({
		///     'click' : {
		///     fn: this.onClick,
		///     scope: this,
		///     delay: 100
		///     },
		///     'mouseover' : {
		///     fn: this.onMouseOver,
		///     scope: this
		///     },
		///     'mouseout' : {
		///     fn: this.onMouseOut,
		///     scope: this
		///     }
		///     });</code></pre>
		///     <p>
		///     Or a shorthand syntax:<br>
		///     <pre><code>
		///     myGridPanel.on({
		///     'click' : this.onClick,
		///     'mouseover' : this.onMouseOver,
		///     'mouseout' : this.onMouseOut,
		///     scope: this
		///     });</code></pre>
		/// </summary>
		/// <returns></returns>
		public extern virtual void addListener();

		/// <summary>
		///     Appends an event handler to this component
		///     <b>If omitted, defaults to the object which fired the event.</b>
		///     properties. This may contain any of the following properties:<ul>
		///     <li><b>scope</b> : Object<div class="sub-desc">The scope (<code><b>this</b></code> reference) in which the handler function is executed.
		///     <b>If omitted, defaults to the object which fired the event.</b></div></li>
		///     <li><b>delay</b> : Number<div class="sub-desc">The number of milliseconds to delay the invocation of the handler after the event fires.</div></li>
		///     <li><b>single</b> : Boolean<div class="sub-desc">True to add a handler to handle just the next firing of the event, and then remove itself.</div></li>
		///     <li><b>buffer</b> : Number<div class="sub-desc">Causes the handler to be scheduled to run in an {@link Ext.util.DelayedTask} delayed
		///     by the specified number of milliseconds. If the event fires again within that time, the original
		///     handler is <em>not</em> invoked, but the new handler is scheduled in its place.</div></li>
		///     <li><b>target</b> : Observable<div class="sub-desc">Only call the handler if the event was fired on the target Observable, <i>not</i>
		///     if the event was bubbled up from a child Observable.</div></li>
		///     </ul><br>
		///     <p>
		///     <b>Combining Options</b><br>
		///     Using the options argument, it is possible to combine different types of listeners:<br>
		///     <br>
		///     A delayed, one-time listener.
		///     <pre><code>
		///     myDataView.on('click', this.onClick, this, {
		///     single: true,
		///     delay: 100
		///     });</code></pre>
		///     <p>
		///     <b>Attaching multiple handlers in 1 call</b><br>
		///     The method also allows for a single argument to be passed which is a config object containing properties
		///     which specify multiple handlers.
		///     <p>
		///     <pre><code>
		///     myGridPanel.on({
		///     'click' : {
		///     fn: this.onClick,
		///     scope: this,
		///     delay: 100
		///     },
		///     'mouseover' : {
		///     fn: this.onMouseOver,
		///     scope: this
		///     },
		///     'mouseout' : {
		///     fn: this.onMouseOut,
		///     scope: this
		///     }
		///     });</code></pre>
		///     <p>
		///     Or a shorthand syntax:<br>
		///     <pre><code>
		///     myGridPanel.on({
		///     'click' : this.onClick,
		///     'mouseover' : this.onMouseOver,
		///     'mouseout' : this.onMouseOut,
		///     scope: this
		///     });</code></pre>
		/// </summary>
		/// <param name="eventName">The type of event to listen for</param>
		/// <returns></returns>
		public extern virtual void addListener(string eventName);

		/// <summary>
		///     Appends an event handler to this component
		///     <b>If omitted, defaults to the object which fired the event.</b>
		///     properties. This may contain any of the following properties:<ul>
		///     <li><b>scope</b> : Object<div class="sub-desc">The scope (<code><b>this</b></code> reference) in which the handler function is executed.
		///     <b>If omitted, defaults to the object which fired the event.</b></div></li>
		///     <li><b>delay</b> : Number<div class="sub-desc">The number of milliseconds to delay the invocation of the handler after the event fires.</div></li>
		///     <li><b>single</b> : Boolean<div class="sub-desc">True to add a handler to handle just the next firing of the event, and then remove itself.</div></li>
		///     <li><b>buffer</b> : Number<div class="sub-desc">Causes the handler to be scheduled to run in an {@link Ext.util.DelayedTask} delayed
		///     by the specified number of milliseconds. If the event fires again within that time, the original
		///     handler is <em>not</em> invoked, but the new handler is scheduled in its place.</div></li>
		///     <li><b>target</b> : Observable<div class="sub-desc">Only call the handler if the event was fired on the target Observable, <i>not</i>
		///     if the event was bubbled up from a child Observable.</div></li>
		///     </ul><br>
		///     <p>
		///     <b>Combining Options</b><br>
		///     Using the options argument, it is possible to combine different types of listeners:<br>
		///     <br>
		///     A delayed, one-time listener.
		///     <pre><code>
		///     myDataView.on('click', this.onClick, this, {
		///     single: true,
		///     delay: 100
		///     });</code></pre>
		///     <p>
		///     <b>Attaching multiple handlers in 1 call</b><br>
		///     The method also allows for a single argument to be passed which is a config object containing properties
		///     which specify multiple handlers.
		///     <p>
		///     <pre><code>
		///     myGridPanel.on({
		///     'click' : {
		///     fn: this.onClick,
		///     scope: this,
		///     delay: 100
		///     },
		///     'mouseover' : {
		///     fn: this.onMouseOver,
		///     scope: this
		///     },
		///     'mouseout' : {
		///     fn: this.onMouseOut,
		///     scope: this
		///     }
		///     });</code></pre>
		///     <p>
		///     Or a shorthand syntax:<br>
		///     <pre><code>
		///     myGridPanel.on({
		///     'click' : this.onClick,
		///     'mouseover' : this.onMouseOver,
		///     'mouseout' : this.onMouseOut,
		///     scope: this
		///     });</code></pre>
		/// </summary>
		/// <param name="eventName">The type of event to listen for</param>
		/// <param name="handler">The method the event invokes</param>
		/// <returns></returns>
		public extern virtual void addListener(string eventName, Delegate handler);

		/// <summary>
		///     Appends an event handler to this component
		///     <b>If omitted, defaults to the object which fired the event.</b>
		///     properties. This may contain any of the following properties:<ul>
		///     <li><b>scope</b> : Object<div class="sub-desc">The scope (<code><b>this</b></code> reference) in which the handler function is executed.
		///     <b>If omitted, defaults to the object which fired the event.</b></div></li>
		///     <li><b>delay</b> : Number<div class="sub-desc">The number of milliseconds to delay the invocation of the handler after the event fires.</div></li>
		///     <li><b>single</b> : Boolean<div class="sub-desc">True to add a handler to handle just the next firing of the event, and then remove itself.</div></li>
		///     <li><b>buffer</b> : Number<div class="sub-desc">Causes the handler to be scheduled to run in an {@link Ext.util.DelayedTask} delayed
		///     by the specified number of milliseconds. If the event fires again within that time, the original
		///     handler is <em>not</em> invoked, but the new handler is scheduled in its place.</div></li>
		///     <li><b>target</b> : Observable<div class="sub-desc">Only call the handler if the event was fired on the target Observable, <i>not</i>
		///     if the event was bubbled up from a child Observable.</div></li>
		///     </ul><br>
		///     <p>
		///     <b>Combining Options</b><br>
		///     Using the options argument, it is possible to combine different types of listeners:<br>
		///     <br>
		///     A delayed, one-time listener.
		///     <pre><code>
		///     myDataView.on('click', this.onClick, this, {
		///     single: true,
		///     delay: 100
		///     });</code></pre>
		///     <p>
		///     <b>Attaching multiple handlers in 1 call</b><br>
		///     The method also allows for a single argument to be passed which is a config object containing properties
		///     which specify multiple handlers.
		///     <p>
		///     <pre><code>
		///     myGridPanel.on({
		///     'click' : {
		///     fn: this.onClick,
		///     scope: this,
		///     delay: 100
		///     },
		///     'mouseover' : {
		///     fn: this.onMouseOver,
		///     scope: this
		///     },
		///     'mouseout' : {
		///     fn: this.onMouseOut,
		///     scope: this
		///     }
		///     });</code></pre>
		///     <p>
		///     Or a shorthand syntax:<br>
		///     <pre><code>
		///     myGridPanel.on({
		///     'click' : this.onClick,
		///     'mouseover' : this.onMouseOver,
		///     'mouseout' : this.onMouseOut,
		///     scope: this
		///     });</code></pre>
		/// </summary>
		/// <param name="eventName">The type of event to listen for</param>
		/// <param name="handler">The method the event invokes</param>
		/// <param name="scope">(optional) The scope (<code><b>this</b></code> reference) in which the handler function is executed.</param>
		/// <returns></returns>
		public extern virtual void addListener(string eventName, Delegate handler, object scope);

		/// <summary>
		///     Appends an event handler to this component
		///     <b>If omitted, defaults to the object which fired the event.</b>
		///     properties. This may contain any of the following properties:<ul>
		///     <li><b>scope</b> : Object<div class="sub-desc">The scope (<code><b>this</b></code> reference) in which the handler function is executed.
		///     <b>If omitted, defaults to the object which fired the event.</b></div></li>
		///     <li><b>delay</b> : Number<div class="sub-desc">The number of milliseconds to delay the invocation of the handler after the event fires.</div></li>
		///     <li><b>single</b> : Boolean<div class="sub-desc">True to add a handler to handle just the next firing of the event, and then remove itself.</div></li>
		///     <li><b>buffer</b> : Number<div class="sub-desc">Causes the handler to be scheduled to run in an {@link Ext.util.DelayedTask} delayed
		///     by the specified number of milliseconds. If the event fires again within that time, the original
		///     handler is <em>not</em> invoked, but the new handler is scheduled in its place.</div></li>
		///     <li><b>target</b> : Observable<div class="sub-desc">Only call the handler if the event was fired on the target Observable, <i>not</i>
		///     if the event was bubbled up from a child Observable.</div></li>
		///     </ul><br>
		///     <p>
		///     <b>Combining Options</b><br>
		///     Using the options argument, it is possible to combine different types of listeners:<br>
		///     <br>
		///     A delayed, one-time listener.
		///     <pre><code>
		///     myDataView.on('click', this.onClick, this, {
		///     single: true,
		///     delay: 100
		///     });</code></pre>
		///     <p>
		///     <b>Attaching multiple handlers in 1 call</b><br>
		///     The method also allows for a single argument to be passed which is a config object containing properties
		///     which specify multiple handlers.
		///     <p>
		///     <pre><code>
		///     myGridPanel.on({
		///     'click' : {
		///     fn: this.onClick,
		///     scope: this,
		///     delay: 100
		///     },
		///     'mouseover' : {
		///     fn: this.onMouseOver,
		///     scope: this
		///     },
		///     'mouseout' : {
		///     fn: this.onMouseOut,
		///     scope: this
		///     }
		///     });</code></pre>
		///     <p>
		///     Or a shorthand syntax:<br>
		///     <pre><code>
		///     myGridPanel.on({
		///     'click' : this.onClick,
		///     'mouseover' : this.onMouseOver,
		///     'mouseout' : this.onMouseOut,
		///     scope: this
		///     });</code></pre>
		/// </summary>
		/// <param name="eventName">The type of event to listen for</param>
		/// <param name="handler">The method the event invokes</param>
		/// <param name="scope">(optional) The scope (<code><b>this</b></code> reference) in which the handler function is executed.</param>
		/// <param name="options">(optional) An object containing handler configuration</param>
		/// <returns></returns>
		public extern virtual void addListener(string eventName, Delegate handler, object scope, object options);

		/// <summary>Removes a listener</summary>
		/// <returns></returns>
		public extern virtual void removeListener();

		/// <summary>Removes a listener</summary>
		/// <param name="eventName">The type of event to listen for</param>
		/// <returns></returns>
		public extern virtual void removeListener(string eventName);

		/// <summary>Removes a listener</summary>
		/// <param name="eventName">The type of event to listen for</param>
		/// <param name="handler">The handler to remove</param>
		/// <returns></returns>
		public extern virtual void removeListener(string eventName, Delegate handler);

		/// <summary>Removes a listener</summary>
		/// <param name="eventName">The type of event to listen for</param>
		/// <param name="handler">The handler to remove</param>
		/// <param name="scope">(optional) The scope (this object) for the handler</param>
		/// <returns></returns>
		public extern virtual void removeListener(string eventName, Delegate handler, object scope);

		/// <summary>Removes all listeners for this object</summary>
		/// <returns></returns>
		public extern virtual void purgeListeners();

		/// <summary>Relays selected events from the specified Observable as if the events were fired by <tt><b>this</b></tt>.</summary>
		/// <returns></returns>
		public extern virtual void relayEvents();

		/// <summary>Relays selected events from the specified Observable as if the events were fired by <tt><b>this</b></tt>.</summary>
		/// <param name="o">The Observable whose events this object is to relay.</param>
		/// <returns></returns>
		public extern virtual void relayEvents(object o);

		/// <summary>Relays selected events from the specified Observable as if the events were fired by <tt><b>this</b></tt>.</summary>
		/// <param name="o">The Observable whose events this object is to relay.</param>
		/// <param name="events">Array of event names to relay.</param>
		/// <returns></returns>
		public extern virtual void relayEvents(object o, System.Array events);

		/// <summary>Used to define events on this Observable</summary>
		/// <returns></returns>
		public extern virtual void addEvents();

		/// <summary>Used to define events on this Observable</summary>
		/// <param name="obj">The object with the events defined</param>
		/// <returns></returns>
		public extern virtual void addEvents(object obj);

		/// <summary>Checks to see if this object has any listeners for a specified event</summary>
		/// <returns>Boolean</returns>
		public extern virtual void hasListener();

		/// <summary>Checks to see if this object has any listeners for a specified event</summary>
		/// <param name="eventName">The name of the event to check for</param>
		/// <returns>Boolean</returns>
		public extern virtual void hasListener(string eventName);

		/// <summary>Suspend the firing of all events. (see {@link #resumeEvents})</summary>
		/// <returns></returns>
		public extern virtual void suspendEvents();

		/// <summary>Resume firing events. (see {@link #suspendEvents})</summary>
		/// <returns></returns>
		public extern virtual void resumeEvents();

		/// <summary>
		///     Appends an event handler to this element (shorthand for addListener)
		///     function. The handler function's "this" context.
		/// </summary>
		/// <returns></returns>
		public extern virtual void on();

		/// <summary>
		///     Appends an event handler to this element (shorthand for addListener)
		///     function. The handler function's "this" context.
		/// </summary>
		/// <param name="eventName">The type of event to listen for</param>
		/// <returns></returns>
		public extern virtual void on(string eventName);

		/// <summary>
		///     Appends an event handler to this element (shorthand for addListener)
		///     function. The handler function's "this" context.
		/// </summary>
		/// <param name="eventName">The type of event to listen for</param>
		/// <param name="handler">The method the event invokes</param>
		/// <returns></returns>
		public extern virtual void on(string eventName, Delegate handler);

		/// <summary>
		///     Appends an event handler to this element (shorthand for addListener)
		///     function. The handler function's "this" context.
		/// </summary>
		/// <param name="eventName">The type of event to listen for</param>
		/// <param name="handler">The method the event invokes</param>
		/// <param name="scope">(optional) The scope in which to execute the handler</param>
		/// <returns></returns>
		public extern virtual void on(string eventName, Delegate handler, object scope);

		/// <summary>
		///     Appends an event handler to this element (shorthand for addListener)
		///     function. The handler function's "this" context.
		/// </summary>
		/// <param name="eventName">The type of event to listen for</param>
		/// <param name="handler">The method the event invokes</param>
		/// <param name="scope">(optional) The scope in which to execute the handler</param>
		/// <param name="options">(optional)</param>
		/// <returns></returns>
		public extern virtual void on(string eventName, Delegate handler, object scope, object options);

		/// <summary>Removes a listener (shorthand for removeListener)</summary>
		/// <returns></returns>
		public extern virtual void un();

		/// <summary>Removes a listener (shorthand for removeListener)</summary>
		/// <param name="eventName">The type of event to listen for</param>
		/// <returns></returns>
		public extern virtual void un(string eventName);

		/// <summary>Removes a listener (shorthand for removeListener)</summary>
		/// <param name="eventName">The type of event to listen for</param>
		/// <param name="handler">The handler to remove</param>
		/// <returns></returns>
		public extern virtual void un(string eventName, Delegate handler);

		/// <summary>Removes a listener (shorthand for removeListener)</summary>
		/// <param name="eventName">The type of event to listen for</param>
		/// <param name="handler">The handler to remove</param>
		/// <param name="scope">(optional) The scope (this object) for the handler</param>
		/// <returns></returns>
		public extern virtual void un(string eventName, Delegate handler, object scope);

		/// <summary>
		///     Starts capture on the specified Observable. All events will be passed
		///     to the supplied function with the event name + standard signature of the event
		///     <b>before</b> the event is fired. If the supplied function returns false,
		///     the event will not fire.
		/// </summary>
		/// <returns></returns>
		public extern static void capture();

		/// <summary>
		///     Starts capture on the specified Observable. All events will be passed
		///     to the supplied function with the event name + standard signature of the event
		///     <b>before</b> the event is fired. If the supplied function returns false,
		///     the event will not fire.
		/// </summary>
		/// <param name="o">The Observable to capture</param>
		/// <returns></returns>
		public extern static void capture(Observable o);

		/// <summary>
		///     Starts capture on the specified Observable. All events will be passed
		///     to the supplied function with the event name + standard signature of the event
		///     <b>before</b> the event is fired. If the supplied function returns false,
		///     the event will not fire.
		/// </summary>
		/// <param name="o">The Observable to capture</param>
		/// <param name="fn">The function to call</param>
		/// <returns></returns>
		public extern static void capture(Observable o, Delegate fn);

		/// <summary>
		///     Starts capture on the specified Observable. All events will be passed
		///     to the supplied function with the event name + standard signature of the event
		///     <b>before</b> the event is fired. If the supplied function returns false,
		///     the event will not fire.
		/// </summary>
		/// <param name="o">The Observable to capture</param>
		/// <param name="fn">The function to call</param>
		/// <param name="scope">(optional) The scope (this object) for the fn</param>
		/// <returns></returns>
		public extern static void capture(Observable o, Delegate fn, object scope);

		/// <summary>Removes <b>all</b> added captures from the Observable.</summary>
		/// <returns></returns>
		public extern static void releaseCapture();

		/// <summary>Removes <b>all</b> added captures from the Observable.</summary>
		/// <param name="o">The Observable to release</param>
		/// <returns></returns>
		public extern static void releaseCapture(Observable o);



	}

	[JsAnonymous]
	public class ObservableConfig : System.DotWeb.JsDynamic {
		/// <summary> (optional) A config object containing one or more event handlers to be added to this object during initialization.  This should be a valid listeners config object as specified in the {@link #addListener} example for attaching multiple handlers at once.</summary>
		public extern object listeners { get; set; }

	}
}
