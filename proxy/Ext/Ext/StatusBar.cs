using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext {
	/// <summary>
	///     /**
	///     <p>Basic status bar component that can be used as the bottom toolbar of any {@link Ext.Panel}.  In addition to
	///     supporting the standard {@link Ext.Toolbar} interface for adding buttons, menus and other items, the StatusBar
	///     provides a greedy status element that can be aligned to either side and has convenient methods for setting the
	///     status text and icon.  You can also indicate that something is processing using the {@link #showBusy} method.</p>
	///     <p><b>Note:</b> Although StatusBar supports xtype:'statusbar', at this time Ext.Toolbar (the base class) does
	///     not support xtype.  For this reason, if you are adding Toolbar items into the StatusBar you must declare it
	///     using the "new StatusBar()" syntax for the items to render correctly.</p>
	///     <pre><code>
	///     new Ext.Panel({
	///     title: 'StatusBar',
	///     // etc.
	///     bbar: new Ext.StatusBar({
	///     id: 'my-status',
	///     // defaults to use when the status is cleared:
	///     defaultText: 'Default status text',
	///     defaultIconCls: 'default-icon',
	///     // values to set initially:
	///     text: 'Ready',
	///     iconCls: 'ready-icon',
	///     // any standard Toolbar items:
	///     items: [{
	///     text: 'A Button'
	///     }, '-', 'Plain Text']
	///     })
	///     });
	///     // Update the status bar later in code:
	///     var sb = Ext.getCmp('my-status');
	///     sb.setStatus({
	///     text: 'OK',
	///     iconCls: 'ok-icon',
	///     clear: true // auto-clear after a set interval
	///     });
	///     // Set the status bar to show that something is processing:
	///     sb.showBusy();
	///     // processing....
	///     sb.clearStatus(); // once completeed
	///     </code></pre>
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\StatusBar.js</jssource>
	public class StatusBar : Ext.ToolbarClass {

		/// <summary>Creates a new StatusBar</summary>
		/// <returns></returns>
		public extern StatusBar();
		/// <summary>Creates a new StatusBar</summary>
		/// <param name="config">A config object</param>
		/// <returns></returns>
		public extern StatusBar(object config);
		/// <summary>Creates a new StatusBar</summary>
		/// <param name="config">A config object</param>
		/// <returns></returns>
		public extern StatusBar(System.Array config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern StatusBar(Ext.Element config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern StatusBar(string config);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static StatusBar prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.ToolbarClass superclass { get; set; }

		/// <summary>
		///     The alignment of the status element within the overall StatusBar layout.  When the StatusBar is rendered,
		///     it creates an internal div containing the status text and icon.  Any additional Toolbar items added in the
		///     StatusBar's {@link #items} config, or added via {@link #add} or any of the supported add* methods, will be
		///     rendered, in added order, to the opposite side.  The status element is greedy, so it will automatically
		///     expand to take up all sapce left over by any other items.  Example usage:
		///     <pre><code>
		///     // Create a left-aligned status bar containing a button,
		///     // separator and text item that will be right-aligned (default):
		///     new Ext.Panel({
		///     title: 'StatusBar',
		///     // etc.
		///     bbar: new Ext.StatusBar({
		///     defaultText: 'Default status text',
		///     id: 'status-id',
		///     items: [{
		///     text: 'A Button'
		///     }, '-', 'Plain Text']
		///     })
		///     });
		///     // By adding the statusAlign config, this will create the
		///     // exact same toolbar, except the status and toolbar item
		///     // layout will be reversed from the previous example:
		///     new Ext.Panel({
		///     title: 'StatusBar',
		///     // etc.
		///     bbar: new Ext.StatusBar({
		///     defaultText: 'Default status text',
		///     id: 'status-id',
		///     statusAlign: 'right',
		///     items: [{
		///     text: 'A Button'
		///     }, '-', 'Plain Text']
		///     })
		///     });
		///     </code></pre>
		/// </summary>
		public extern string statusAlign { get; set; }

		/// <summary>
		///     The default {@link #text} value.  This will be used anytime the status bar is cleared with the
		///     <tt>useDefaults:true</tt> option (defaults to '').
		/// </summary>
		public extern string defaultText { get; set; }

		/// <summary>
		///     The default {@link #iconCls} value (see the iconCls docs for additional details about customizing the icon).
		///     This will be used anytime the status bar is cleared with the <tt>useDefaults:true</tt> option (defaults to '').
		/// </summary>
		public extern string defaultIconCls { get; set; }

		/// <summary>A string that will be rendered into the status element as the status message (defaults to '');</summary>
		public extern string text { get; set; }

		/// <summary>
		///     A CSS class that will be applied to the status element and is expected to provide a background image that will
		///     serve as the status bar icon (defaults to '').  The class is applied directly to the div that also contains the
		///     status text, so the rule should provide the appropriate padding on the div to make room for the image.
		///     Example usage:<pre><code>
		///     // Example CSS rule:
		///     .x-statusbar .x-status-custom {
		///     padding-left: 25px;
		///     background: transparent url(images/custom-icon.gif) no-repeat 3px 3px;
		///     }
		///     // Initializing the status bar:
		///     var sb = new Ext.StatusBar({
		///     defaultIconCls: 'x-status-custom'
		///     });
		///     // Setting it in code:
		///     sb.setStatus({
		///     text: 'New status',
		///     iconCls: 'x-status-custom'
		///     });
		///     </code></pre>
		/// </summary>
		public extern string iconCls { get; set; }

		/// <summary>The base class applied to the containing element for this component on render (defaults to 'x-statusbar')</summary>
		public extern string cls { get; set; }

		/// <summary>
		///     The default {@link #iconCls} applied when calling {@link #showBusy} (defaults to 'x-status-busy'). It can be
		///     overridden at any time by passing the <tt>iconCls</tt> argument into <tt>showBusy</tt>. See the
		///     iconCls docs for additional details about customizing the icon.
		/// </summary>
		public extern string busyIconCls { get; set; }

		/// <summary>
		///     The default {@link #text} applied when calling {@link #showBusy} (defaults to 'Loading...'). It can be
		///     overridden at any time by passing the <tt>text</tt> argument into <tt>showBusy</tt>.
		/// </summary>
		public extern string busyText { get; set; }

		/// <summary>
		///     The number of milliseconds to wait after setting the status via {@link #setStatus} before automatically
		///     clearing the status text and icon (defaults to 5000).  Note that this only applies when passing the
		///     <tt>clear</tt> argument to setStatus since that is the only way to defer clearing the status.  This can
		///     be overridden by specifying a different <tt>wait</tt> value in setStatus. Calls to {@link #clearStatus}
		///     always clear the status bar immediately and ignore this value.
		/// </summary>
		public extern double autoClear { get; set; }


		/// <summary>
		///     Sets the status {@link #text} and/or {@link #iconCls}. Also supports automatically clearing the
		///     status that was set after a specified interval.
		///     to be the status text (and all other options are defaulted as explained below). A config
		///     object containing any or all of the following properties can be passed:<ul>
		///     <li><tt>text</tt> {String} : (optional) The status text to display.  If not specified, any current
		///     status text will remain unchanged.</li>
		///     <li><tt>iconCls</tt> {String} : (optional) The CSS class used to customize the status icon (see
		///     {@link #iconCls} for details). If not specified, any current iconCls will remain unchanged.</li>
		///     <li><tt>clear</tt> {Boolean/Number/Object} : (optional) Allows you to set an internal callback that will
		///     automatically clear the status text and iconCls after a specified amount of time has passed. If clear is not
		///     specified, the new status will not be auto-cleared and will stay until updated again or cleared using
		///     {@link #clearStatus}. If <tt>true</tt> is passed, the status will be cleared using {@link #autoClear},
		///     {@link #defaultText} and {@link #defaultIconCls} via a fade out animation. If a numeric value is passed,
		///     it will be used as the callback interval (in milliseconds), overriding the {@link #autoClear} value.
		///     All other options will be defaulted as with the boolean option.  To customize any other options,
		///     you can pass an object in the format:<ul>
		///     <li><tt>wait</tt> {Number} : (optional) The number of milliseconds to wait before clearing
		///     (defaults to {@link #autoClear}).</li>
		///     <li><tt>anim</tt> {Number} : (optional) False to clear the status immediately once the callback
		///     executes (defaults to true which fades the status out).</li>
		///     <li><tt>useDefaults</tt> {Number} : (optional) False to completely clear the status text and iconCls
		///     (defaults to true which uses {@link #defaultText} and {@link #defaultIconCls}).</li>
		///     </ul></li></ul>
		///     Example usage:<pre><code>
		///     // Simple call to update the text
		///     statusBar.setStatus('New status');
		///     // Set the status and icon, auto-clearing with default options:
		///     statusBar.setStatus({
		///     text: 'New status',
		///     iconCls: 'x-status-custom',
		///     clear: true
		///     });
		///     // Auto-clear with custom options:
		///     statusBar.setStatus({
		///     text: 'New status',
		///     iconCls: 'x-status-custom',
		///     clear: {
		///     wait: 8000,
		///     anim: false,
		///     useDefaults: false
		///     }
		///     });
		///     </code></pre>
		/// </summary>
		/// <returns>Ext.StatusBar</returns>
		public extern virtual void setStatus();

		/// <summary>
		///     Sets the status {@link #text} and/or {@link #iconCls}. Also supports automatically clearing the
		///     status that was set after a specified interval.
		///     to be the status text (and all other options are defaulted as explained below). A config
		///     object containing any or all of the following properties can be passed:<ul>
		///     <li><tt>text</tt> {String} : (optional) The status text to display.  If not specified, any current
		///     status text will remain unchanged.</li>
		///     <li><tt>iconCls</tt> {String} : (optional) The CSS class used to customize the status icon (see
		///     {@link #iconCls} for details). If not specified, any current iconCls will remain unchanged.</li>
		///     <li><tt>clear</tt> {Boolean/Number/Object} : (optional) Allows you to set an internal callback that will
		///     automatically clear the status text and iconCls after a specified amount of time has passed. If clear is not
		///     specified, the new status will not be auto-cleared and will stay until updated again or cleared using
		///     {@link #clearStatus}. If <tt>true</tt> is passed, the status will be cleared using {@link #autoClear},
		///     {@link #defaultText} and {@link #defaultIconCls} via a fade out animation. If a numeric value is passed,
		///     it will be used as the callback interval (in milliseconds), overriding the {@link #autoClear} value.
		///     All other options will be defaulted as with the boolean option.  To customize any other options,
		///     you can pass an object in the format:<ul>
		///     <li><tt>wait</tt> {Number} : (optional) The number of milliseconds to wait before clearing
		///     (defaults to {@link #autoClear}).</li>
		///     <li><tt>anim</tt> {Number} : (optional) False to clear the status immediately once the callback
		///     executes (defaults to true which fades the status out).</li>
		///     <li><tt>useDefaults</tt> {Number} : (optional) False to completely clear the status text and iconCls
		///     (defaults to true which uses {@link #defaultText} and {@link #defaultIconCls}).</li>
		///     </ul></li></ul>
		///     Example usage:<pre><code>
		///     // Simple call to update the text
		///     statusBar.setStatus('New status');
		///     // Set the status and icon, auto-clearing with default options:
		///     statusBar.setStatus({
		///     text: 'New status',
		///     iconCls: 'x-status-custom',
		///     clear: true
		///     });
		///     // Auto-clear with custom options:
		///     statusBar.setStatus({
		///     text: 'New status',
		///     iconCls: 'x-status-custom',
		///     clear: {
		///     wait: 8000,
		///     anim: false,
		///     useDefaults: false
		///     }
		///     });
		///     </code></pre>
		/// </summary>
		/// <param name="config">A config object specifying what status to set, or a string assumed</param>
		/// <returns>Ext.StatusBar</returns>
		public extern virtual void setStatus(object config);

		/// <summary>
		///     Sets the status {@link #text} and/or {@link #iconCls}. Also supports automatically clearing the
		///     status that was set after a specified interval.
		///     to be the status text (and all other options are defaulted as explained below). A config
		///     object containing any or all of the following properties can be passed:<ul>
		///     <li><tt>text</tt> {String} : (optional) The status text to display.  If not specified, any current
		///     status text will remain unchanged.</li>
		///     <li><tt>iconCls</tt> {String} : (optional) The CSS class used to customize the status icon (see
		///     {@link #iconCls} for details). If not specified, any current iconCls will remain unchanged.</li>
		///     <li><tt>clear</tt> {Boolean/Number/Object} : (optional) Allows you to set an internal callback that will
		///     automatically clear the status text and iconCls after a specified amount of time has passed. If clear is not
		///     specified, the new status will not be auto-cleared and will stay until updated again or cleared using
		///     {@link #clearStatus}. If <tt>true</tt> is passed, the status will be cleared using {@link #autoClear},
		///     {@link #defaultText} and {@link #defaultIconCls} via a fade out animation. If a numeric value is passed,
		///     it will be used as the callback interval (in milliseconds), overriding the {@link #autoClear} value.
		///     All other options will be defaulted as with the boolean option.  To customize any other options,
		///     you can pass an object in the format:<ul>
		///     <li><tt>wait</tt> {Number} : (optional) The number of milliseconds to wait before clearing
		///     (defaults to {@link #autoClear}).</li>
		///     <li><tt>anim</tt> {Number} : (optional) False to clear the status immediately once the callback
		///     executes (defaults to true which fades the status out).</li>
		///     <li><tt>useDefaults</tt> {Number} : (optional) False to completely clear the status text and iconCls
		///     (defaults to true which uses {@link #defaultText} and {@link #defaultIconCls}).</li>
		///     </ul></li></ul>
		///     Example usage:<pre><code>
		///     // Simple call to update the text
		///     statusBar.setStatus('New status');
		///     // Set the status and icon, auto-clearing with default options:
		///     statusBar.setStatus({
		///     text: 'New status',
		///     iconCls: 'x-status-custom',
		///     clear: true
		///     });
		///     // Auto-clear with custom options:
		///     statusBar.setStatus({
		///     text: 'New status',
		///     iconCls: 'x-status-custom',
		///     clear: {
		///     wait: 8000,
		///     anim: false,
		///     useDefaults: false
		///     }
		///     });
		///     </code></pre>
		/// </summary>
		/// <param name="config">A config object specifying what status to set, or a string assumed</param>
		/// <returns>Ext.StatusBar</returns>
		public extern virtual void setStatus(string config);

		/// <summary>
		///     Clears the status {@link #text} and {@link #iconCls}. Also supports clearing via an optional fade out animation.
		///     object is not specified the status will be cleared using the defaults below:<ul>
		///     <li><tt>anim</tt> {Boolean} : (optional) True to clear the status by fading out the status element (defaults
		///     to false which clears immediately).</li>
		///     <li><tt>useDefaults</tt> {Boolean} : (optional) True to reset the text and icon using {@link #defaultText} and
		///     {@link #defaultIconCls} (defaults to false which sets the text to '' and removes any existing icon class).</li>
		///     </ul>
		/// </summary>
		/// <returns>Ext.StatusBar</returns>
		public extern virtual void clearStatus();

		/// <summary>
		///     Clears the status {@link #text} and {@link #iconCls}. Also supports clearing via an optional fade out animation.
		///     object is not specified the status will be cleared using the defaults below:<ul>
		///     <li><tt>anim</tt> {Boolean} : (optional) True to clear the status by fading out the status element (defaults
		///     to false which clears immediately).</li>
		///     <li><tt>useDefaults</tt> {Boolean} : (optional) True to reset the text and icon using {@link #defaultText} and
		///     {@link #defaultIconCls} (defaults to false which sets the text to '' and removes any existing icon class).</li>
		///     </ul>
		/// </summary>
		/// <param name="config">(optional) A config object containing any or all of the following properties.  If this</param>
		/// <returns>Ext.StatusBar</returns>
		public extern virtual void clearStatus(object config);

		/// <summary>Convenience method for setting the status text directly.  For more flexible options see {@link #setStatus}.</summary>
		/// <returns>Ext.StatusBar</returns>
		public extern virtual void setText();

		/// <summary>Convenience method for setting the status text directly.  For more flexible options see {@link #setStatus}.</summary>
		/// <param name="text">(optional) The text to set (defaults to '')</param>
		/// <returns>Ext.StatusBar</returns>
		public extern virtual void setText(string text);

		/// <summary>Returns the current status text.</summary>
		/// <returns>String</returns>
		public extern virtual void getText();

		/// <summary>
		///     Convenience method for setting the status icon directly.  For more flexible options see {@link #setStatus}.
		///     See {@link #iconCls} for complete details about customizing the icon.
		/// </summary>
		/// <returns>Ext.StatusBar</returns>
		public extern virtual void setIcon();

		/// <summary>
		///     Convenience method for setting the status icon directly.  For more flexible options see {@link #setStatus}.
		///     See {@link #iconCls} for complete details about customizing the icon.
		/// </summary>
		/// <param name="iconCls">(optional) The icon class to set (defaults to '', and any current icon class is removed)</param>
		/// <returns>Ext.StatusBar</returns>
		public extern virtual void setIcon(string iconCls);

		/// <summary>
		///     Convenience method for setting the status text and icon to special values that are pre-configured to indicate
		///     a "busy" state, usually for loading or processing activities.
		///     string to use as the status text (in which case all other options for setStatus will be defaulted).  Use the
		///     <tt>text</tt> and/or <tt>iconCls</tt> properties on the config to override the default {@link #busyText}
		///     and {@link #busyIconCls} settings. If the config argument is not specified, {@link #busyText} and
		///     {@link #busyIconCls} will be used in conjunction with all of the default options for {@link #setStatus}.
		/// </summary>
		/// <returns>Ext.StatusBar</returns>
		public extern virtual void showBusy();

		/// <summary>
		///     Convenience method for setting the status text and icon to special values that are pre-configured to indicate
		///     a "busy" state, usually for loading or processing activities.
		///     string to use as the status text (in which case all other options for setStatus will be defaulted).  Use the
		///     <tt>text</tt> and/or <tt>iconCls</tt> properties on the config to override the default {@link #busyText}
		///     and {@link #busyIconCls} settings. If the config argument is not specified, {@link #busyText} and
		///     {@link #busyIconCls} will be used in conjunction with all of the default options for {@link #setStatus}.
		/// </summary>
		/// <param name="config">(optional) A config object in the same format supported by {@link #setStatus}, or a</param>
		/// <returns>Ext.StatusBar</returns>
		public extern virtual void showBusy(object config);

		/// <summary>
		///     Convenience method for setting the status text and icon to special values that are pre-configured to indicate
		///     a "busy" state, usually for loading or processing activities.
		///     string to use as the status text (in which case all other options for setStatus will be defaulted).  Use the
		///     <tt>text</tt> and/or <tt>iconCls</tt> properties on the config to override the default {@link #busyText}
		///     and {@link #busyIconCls} settings. If the config argument is not specified, {@link #busyText} and
		///     {@link #busyIconCls} will be used in conjunction with all of the default options for {@link #setStatus}.
		/// </summary>
		/// <param name="config">(optional) A config object in the same format supported by {@link #setStatus}, or a</param>
		/// <returns>Ext.StatusBar</returns>
		public extern virtual void showBusy(string config);



	}

	[JsAnonymous]
	public class StatusBarConfig : System.DotWeb.JsDynamic {
		/// <summary>  The alignment of the status element within the overall StatusBar layout.  When the StatusBar is rendered, it creates an internal div containing the status text and icon.  Any additional Toolbar items added in the StatusBar's {@link #items} config, or added via {@link #add} or any of the supported add* methods, will be rendered, in added order, to the opposite side.  The status element is greedy, so it will automatically expand to take up all sapce left over by any other items.  Example usage: <pre><code> // Create a left-aligned status bar containing a button, // separator and text item that will be right-aligned (default): new Ext.Panel({ title: 'StatusBar', // etc. bbar: new Ext.StatusBar({ defaultText: 'Default status text', id: 'status-id', items: [{ text: 'A Button' }, '-', 'Plain Text'] }) }); // By adding the statusAlign config, this will create the // exact same toolbar, except the status and toolbar item // layout will be reversed from the previous example: new Ext.Panel({ title: 'StatusBar', // etc. bbar: new Ext.StatusBar({ defaultText: 'Default status text', id: 'status-id', statusAlign: 'right', items: [{ text: 'A Button' }, '-', 'Plain Text'] }) }); </code></pre></summary>
		public extern string statusAlign { get; set; }

		/// <summary>  The default {@link #text} value.  This will be used anytime the status bar is cleared with the <tt>useDefaults:true</tt> option (defaults to '').</summary>
		public extern string defaultText { get; set; }

		/// <summary>  The default {@link #iconCls} value (see the iconCls docs for additional details about customizing the icon). This will be used anytime the status bar is cleared with the <tt>useDefaults:true</tt> option (defaults to '').</summary>
		public extern string defaultIconCls { get; set; }

		/// <summary>  A string that will be rendered into the status element as the status message (defaults to '');</summary>
		public extern string text { get; set; }

		/// <summary>  A CSS class that will be applied to the status element and is expected to provide a background image that will serve as the status bar icon (defaults to '').  The class is applied directly to the div that also contains the status text, so the rule should provide the appropriate padding on the div to make room for the image. Example usage:<pre><code> // Example CSS rule: .x-statusbar .x-status-custom { padding-left: 25px; background: transparent url(images/custom-icon.gif) no-repeat 3px 3px; } // Initializing the status bar: var sb = new Ext.StatusBar({ defaultIconCls: 'x-status-custom' }); // Setting it in code: sb.setStatus({ text: 'New status', iconCls: 'x-status-custom' }); </code></pre></summary>
		public extern string iconCls { get; set; }

		/// <summary>  The base class applied to the containing element for this component on render (defaults to 'x-statusbar')</summary>
		public extern string cls { get; set; }

		/// <summary>  The default {@link #iconCls} applied when calling {@link #showBusy} (defaults to 'x-status-busy'). It can be overridden at any time by passing the <tt>iconCls</tt> argument into <tt>showBusy</tt>. See the iconCls docs for additional details about customizing the icon.</summary>
		public extern string busyIconCls { get; set; }

		/// <summary>  The default {@link #text} applied when calling {@link #showBusy} (defaults to 'Loading...'). It can be overridden at any time by passing the <tt>text</tt> argument into <tt>showBusy</tt>.</summary>
		public extern string busyText { get; set; }

		/// <summary>  The number of milliseconds to wait after setting the status via {@link #setStatus} before automatically clearing the status text and icon (defaults to 5000).  Note that this only applies when passing the <tt>clear</tt> argument to setStatus since that is the only way to defer clearing the status.  This can be overridden by specifying a different <tt>wait</tt> value in setStatus. Calls to {@link #clearStatus} always clear the status bar immediately and ignore this value.</summary>
		public extern double autoClear { get; set; }

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
