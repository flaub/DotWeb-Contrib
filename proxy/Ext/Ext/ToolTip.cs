using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext {
	/// <summary>
	///     /**
	///     A standard tooltip implementation for providing additional information when hovering over a target element.
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\tips\ToolTip.js</jssource>
	public class ToolTip : Ext.Tip {

		/// <summary>Create a new Tooltip</summary>
		/// <returns></returns>
		public extern ToolTip();
		/// <summary>Create a new Tooltip</summary>
		/// <param name="config">The configuration options</param>
		/// <returns></returns>
		public extern ToolTip(object config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern ToolTip(Ext.Element config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern ToolTip(string config);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static ToolTip prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.Tip superclass { get; set; }

		/// <summary>The target HTMLElement, Ext.Element or id to associate with this tooltip.</summary>
		public extern object target { get; set; }

		/// <summary>
		///     True to automatically hide the tooltip after the mouse exits the target elementor after the {@link #dismissDelay} has expired if set (defaults to true).  If {@link closable} = true a close
		///     tool button will be rendered into the tooltip header.
		/// </summary>
		public extern bool autoHide { get; set; }

		/// <summary>Delay in milliseconds before the tooltip displays after the mouse enters thetarget element (defaults to 500)</summary>
		public extern double showDelay { get; set; }

		/// <summary>Delay in milliseconds after the mouse exits the target element but before thetooltip actually hides (defaults to 200).  Set to 0 for the tooltip to hide immediately.</summary>
		public extern double hideDelay { get; set; }

		/// <summary>Delay in milliseconds before the tooltip automatically hides (defaults to 5000).To disable automatic hiding, set dismissDelay = 0.</summary>
		public extern double dismissDelay { get; set; }

		/// <summary>An XY offset from the mouse position where the tooltip should be shown (defaults to [15,18]).</summary>
		public extern System.Array mouseOffset { get; set; }

		/// <summary>True to have the tooltip follow the mouse as it moves over the target element (defaults to false).</summary>
		public extern bool trackMouse { get; set; }


		/// <summary>Hides this tooltip if visible.</summary>
		/// <returns></returns>
		public extern virtual void hide();

		/// <summary>Shows this tooltip at the current event target XY position.</summary>
		/// <returns></returns>
		public extern virtual void show();



	}

	[JsAnonymous]
	public class ToolTipConfig : System.DotWeb.JsDynamic {
		/// <summary> The target HTMLElement, Ext.Element or id to associate with this tooltip.</summary>
		public extern object target { get; set; }

		/// <summary> True to automatically hide the tooltip after the mouse exits the target element or after the {@link #dismissDelay} has expired if set (defaults to true).  If {@link closable} = true a close tool button will be rendered into the tooltip header.</summary>
		public extern bool autoHide { get; set; }

		/// <summary> Delay in milliseconds before the tooltip displays after the mouse enters the target element (defaults to 500)</summary>
		public extern double showDelay { get; set; }

		/// <summary> Delay in milliseconds after the mouse exits the target element but before the tooltip actually hides (defaults to 200).  Set to 0 for the tooltip to hide immediately.</summary>
		public extern double hideDelay { get; set; }

		/// <summary> Delay in milliseconds before the tooltip automatically hides (defaults to 5000). To disable automatic hiding, set dismissDelay = 0.</summary>
		public extern double dismissDelay { get; set; }

		/// <summary> An XY offset from the mouse position where the tooltip should be shown (defaults to [15,18]).</summary>
		public extern System.Array mouseOffset { get; set; }

		/// <summary> True to have the tooltip follow the mouse as it moves over the target element (defaults to false).</summary>
		public extern bool trackMouse { get; set; }

		/// <summary> True to render a close tool button into the tooltip header (defaults to false).</summary>
		public extern bool closable { get; set; }

		/// <summary>  Width in pixels of the tip (defaults to auto).  Width will be ignored if it exceeds the bounds of {@link #minWidth} or {@link #maxWidth}.  The maximum supported value is 500.</summary>
		public extern double width { get; set; }

		/// <summary> The minimum width of the tip in pixels (defaults to 40).</summary>
		public extern double minWidth { get; set; }

		/// <summary> The maximum width of the tip in pixels (defaults to 300).  The maximum supported value is 500.</summary>
		public extern double maxWidth { get; set; }

		/// <summary>{Boolean/String} True or "sides" for the default effect, "frame" for 4-way shadow, and "drop" for bottom-right shadow (defaults to "sides").</summary>
		public extern object shadow { get; set; }

		/// <summary> <b>Experimental</b>. The default {@link Ext.Element#alignTo} anchor position value for this tip relative to its element of origin (defaults to "tl-bl?").</summary>
		public extern string defaultAlign { get; set; }

		/// <summary>  <p>A {@link Ext.DomHelper DomHelper} configuration object specifying the element structure of this Panel's {@link #body} Element.</p> <p>This may be used to force the body Element to use a different form of markup than is created automatically. An example of this might be to create a child Panel containing custom content, such as a header, or forcing centering of all Panel content by having the body be a &lt;center&gt; element:</p><code><pre> new Ext.Panel({ title: 'New Message', collapsible: true, renderTo: Ext.getBody(), width: 400, bodyCfg: { tag: 'center', cls: 'x-panel-body' }, items: [{ border: false, header: false, bodyCfg: {tag: 'h2', html: 'Message'} }, { xtype: 'textarea', style: { width: '95%', marginBottom: '10px' } }, new Ext.Button({ text: 'Send', minWidth: '100', style: { marginBottom: '10px' } }) ] });</pre></code></summary>
		public extern object bodyCfg { get; set; }

		/// <summary>  <p>A {@link Ext.DomHelper DomHelper} configuration object specifying the element structure of this Panel's {@link #header} Element.</p></summary>
		public extern object headerCfg { get; set; }

		/// <summary>  <p>A {@link Ext.DomHelper DomHelper} configuration object specifying the element structure of this Panel's {@link #footer} Element.</p></summary>
		public extern object footerCfg { get; set; }

		/// <summary>  The id of the node, a DOM node or an existing Element corresponding to a DIV that is already present in the document that specifies some panel-specific structural markup.  When applyTo is used, constituent parts of the panel can be specified by CSS class name within the main element, and the panel will automatically create those components from that markup. Any required components not specified in the markup will be autogenerated if necessary. The following class names are supported (baseCls will be replaced by {@link #baseCls}): <ul><li>baseCls + '-header'</li> <li>baseCls + '-header-text'</li> <li>baseCls + '-bwrap'</li> <li>baseCls + '-tbar'</li> <li>baseCls + '-body'</li> <li>baseCls + '-bbar'</li> <li>baseCls + '-footer'</li></ul> Using this config, a call to render() is not required.  If applyTo is specified, any value passed for {@link #renderTo} will be ignored and the target element's parent node will automatically be used as the panel's container.</summary>
		public extern object applyTo { get; set; }

		/// <summary>{Object/Array}  <p>The top toolbar of the panel. This can be either an {@link Ext.Toolbar} object or an array of buttons/button configs to be added to the toolbar.  Note that this is not available as a property after render. To access the top toolbar after render, use {@link #getTopToolbar}.</p> <p><b>Note:</b> Although a Toolbar may contain Field components, these will <b>not<b> be updated by a load of an ancestor FormPanel. A Panel's toolbars are not part of the standard Container->Component hierarchy, and so are not scanned to collect form items. Hoverver, the values <b>will</b> be submitted because form submission parameters are collected from the DOM tree.</p></summary>
		public extern object tbar { get; set; }

		/// <summary>{Object/Array}  <p>The bottom toolbar of the panel. This can be either an {@link Ext.Toolbar} object or an array of buttons/button configs to be added to the toolbar.  Note that this is not available as a property after render. To access the bottom toolbar after render, use {@link #getBottomToolbar}.</p> <p><b>Note:</b> Although a Toolbar may contain Field components, these will <b>not<b> be updated by a load of an ancestor FormPanel. A Panel's toolbars are not part of the standard Container->Component hierarchy, and so are not scanned to collect form items. Hoverver, the values <b>will</b> be submitted because form submission parameters are collected from the DOM tree.</p></summary>
		public extern object bbar { get; set; }

		/// <summary>  True to create the Panel's header element explicitly, false to skip creating it.  By default, when header is not specified, if a {@link #title} is set the header will be created automatically, otherwise it will not.  If a title is set but header is explicitly set to false, the header will not be rendered.</summary>
		public extern bool header { get; set; }

		/// <summary>  True to create the footer element explicitly, false to skip creating it.  By default, when footer is not specified, if one or more buttons have been added to the panel the footer will be created automatically, otherwise it will not.</summary>
		public extern bool footer { get; set; }

		/// <summary>  The title text to display in the panel header (defaults to '').  When a title is specified the header element will automatically be created and displayed unless {@link #header} is explicitly set to false.  If you don't want to specify a title at config time, but you may want one later, you must either specify a non-empty title (a blank space ' ' will do) or header:true so that the container element will get created.</summary>
		public extern string title { get; set; }

		/// <summary>  An array of {@link Ext.Button}s or {@link Ext.Button} configs used to add buttons to the footer of this panel.</summary>
		public extern System.Array buttons { get; set; }

		/// <summary>{Object/String/Function}  A valid url spec according to the Updater {@link Ext.Updater#update} method. If autoLoad is not null, the panel will attempt to load its contents immediately upon render.<p> The URL will become the default URL for this panel's {@link #body} element, so it may be {@link Ext.Element#refresh refresh}ed at any time.</p></summary>
		public extern object autoLoad { get; set; }

		/// <summary>  True to render the panel with custom rounded borders, false to render with plain 1px square borders (defaults to false).</summary>
		public extern bool frame { get; set; }

		/// <summary>  True to display the borders of the panel's body element, false to hide them (defaults to true).  By default, the border is a 2px wide inset border, but this can be further altered by setting {@link #bodyBorder} to false.</summary>
		public extern bool border { get; set; }

		/// <summary>  True to display an interior border on the body element of the panel, false to hide it (defaults to true). This only applies when {@link #border} == true.  If border == true and bodyBorder == false, the border will display as a 1px wide inset border, giving the entire body element an inset appearance.</summary>
		public extern bool bodyBorder { get; set; }

		/// <summary>{String/Object/Function}  Custom CSS styles to be applied to the body element in the format expected by {@link Ext.Element#applyStyles} (defaults to null).</summary>
		public extern object bodyStyle { get; set; }

		/// <summary>  A CSS class that will provide a background image to be used as the header icon (defaults to '').  An example custom icon class would be something like: .my-icon { background: url(../images/my-icon.gif) 0 6px no-repeat !important;}</summary>
		public extern string iconCls { get; set; }

		/// <summary>  True to make the panel collapsible and have the expand/collapse toggle button automatically rendered into the header tool button area, false to keep the panel statically sized with no button (defaults to false).</summary>
		public extern bool collapsible { get; set; }

		/// <summary>  An array of tool button configs to be added to the header tool area. When rendered, each tool is stored as an {@link Ext.Element Element} referenced by a public property called <tt><b></b>tools.<i>&lt;tool-type&gt;</i></tt> <p>Each tool config may contain the following properties: <div class="mdetail-params"><ul> <li><b>id</b> : String<div class="sub-desc"><b>Required.</b> The type of tool to create. By default, this assigns a CSS class of the form <tt>x-tool-<i>&lt;tool-type&gt;</i></tt> to the resulting tool Element. Ext provides CSS rules, and an icon sprite containing images for the tool types listed below. The developer may implement custom tools by supplying alternate CSS rules and background images:<ul> <li><tt>toggle</tt> (Created by default when {@link #collapsible} is <tt>true</tt>)</li> <li><tt>close</tt></li> <li><tt>minimize</tt></li> <li><tt>maximize</tt></li> <li><tt>restore</tt></li> <li><tt>gear</tt></li> <li><tt>pin</tt></li> <li><tt>unpin</tt></li> <li><tt>right</tt></li> <li><tt>left</tt></li> <li><tt>up</tt></li> <li><tt>down</tt></li> <li><tt>refresh</tt></li> <li><tt>minus</tt></li> <li><tt>plus</tt></li> <li><tt>help</tt></li> <li><tt>search</tt></li> <li><tt>save</tt></li> <li><tt>print</tt></li> </ul></div></li> <li><b>handler</b> : Function<div class="sub-desc"><b>Required.</b> The function to call when clicked. Arguments passed are:<ul> <li><b>event</b> : Ext.EventObject<div class="sub-desc">The click event.</div></li> <li><b>toolEl</b> : Ext.Element<div class="sub-desc">The tool Element.</div></li> <li><b>Panel</b> : Ext.Panel<div class="sub-desc">The host Panel</div></li> </ul></div></li> <li><b>scope</b> : Object<div class="sub-desc">The scope in which to call the handler.</div></li> <li><b>qtip</b> : String/Object<div class="sub-desc">A tip string, or a config argument to {@link Ext.QuickTip#register}</div></li> <li><b>hidden</b> : Boolean<div class="sub-desc">True to initially render hidden.</div></li> <li><b>on</b> : Object<div class="sub-desc">A listener config object specifiying event listeners in the format of an argument to {@link #addListener}</div></li> </ul></div> Example usage: <pre><code> tools:[{ id:'refresh', qtip: 'Refresh form Data', // hidden:true, handler: function(event, toolEl, panel){ // refresh logic } }] </code></pre> Note that apart from the toggle tool which is provided when a panel is collapsible, these tools only provide the visual button. Any required functionality must be provided by adding handlers that implement the necessary behavior.</summary>
		public extern System.Array tools { get; set; }

		/// <summary>{Ext.Template/Ext.XTemplate}  @type {Ext.Template/Ext.XTemplate} <p>A Template used to create tools in the {@link #header} Element. Defaults to:</p><pre><code> new Ext.Template('&lt;div class="x-tool x-tool-{id}">&amp;#160;&lt;/div>')</code></pre> <p>This may may be overridden to provide a custom DOM structure for tools based upon a more complex XTemplate. The template's data is a single tool configuration object (Not the entire Array) as specified in {@link #tools} Example:</p><pre><code> var win = new Ext.Window({ tools: [{ id: 'download', href: '/MyPdfDoc.pdf' }], toolTemplate: new Ext.XTemplate( '&lt;tpl if="id==\'download\'">', '&lt;a class="x-tool x-tool-pdf" href="{href}">&lt;/a>', '&lt;/tpl>', '&lt;tpl if="id!=\'download\'">', '&lt;div class="x-tool x-tool-{id}">&amp;#160;&lt;/div>', '&lt;/tpl>' ), width:500, height:300, closeAction:'hide' });</code></pre> <p>Note that the CSS class "x-tool-pdf" should have an associated style rule which provides an appropriate background image.</p></summary>
		public extern object toolTemplate { get; set; }

		/// <summary>  True to hide the expand/collapse toggle button when {@link #collapsible} = true, false to display it (defaults to false).</summary>
		public extern bool hideCollapseTool { get; set; }

		/// <summary>  True to allow expanding and collapsing the panel (when {@link #collapsible} = true) by clicking anywhere in the header bar, false to allow it only by clicking to tool button (defaults to false).</summary>
		public extern bool titleCollapse { get; set; }

		/// <summary>  True to use overflow:'auto' on the panel's body element and show scroll bars automatically when necessary, false to clip any overflowing content (defaults to false).</summary>
		public extern bool autoScroll { get; set; }

		/// <summary>  <p>True to float this Panel (absolute position it with automatic shimming and shadow), false to display it inline where it is rendered (defaults to false).</p> <p>Setting floating to true will create an {@link Ext.Layer} encapsulating this Panel's Element and display the Panel at negative offsets so that it is hidden. The position must be set explicitly after render (e.g., myPanel.setPosition(100,100);).</p> <p>When floating a panel you should always assign a fixed width, otherwise it will be auto width and will expand to fill to the right edge of the viewport.</p> <p>This property may also be specified as an object to be used as the configuration object for the {@link Ext.Layer} that will be created.</summary>
		public extern bool floating { get; set; }

		/// <summary>  The number of pixels to offset the shadow if displayed (defaults to 4). Note that this option only applies when floating = true.</summary>
		public extern double shadowOffset { get; set; }

		/// <summary>  False to disable the iframe shim in browsers which need one (defaults to true).  Note that this option only applies when floating = true.</summary>
		public extern bool shim { get; set; }

		/// <summary>{String/Object}  An HTML fragment, or a {@link Ext.DomHelper DomHelper} specification to use as the panel's body content (defaults to ''). The HTML content is added by the Panel's afterRender method, and so the document will not contain this HTML at the time the render event is fired. This content is inserted into the body <i>before</i> any configured {@link #contentEl} is appended.</summary>
		public extern object html { get; set; }

		/// <summary>  The id of an existing HTML node to use as the panel's body content (defaults to ''). The specified Element is appended to the Panel's body Element by the Panel's afterRender method <i>after any configured {@link #html HTML} has been inserted</i>, and so the document will not contain this HTML at the time the render event is fired.</summary>
		public extern string contentEl { get; set; }

		/// <summary>{Object/Array}  A KeyMap config object (in the format expected by {@link Ext.KeyMap#addBinding} used to assign custom key handling to this panel (defaults to null).</summary>
		public extern object keys { get; set; }

		/// <summary>  <p>True to enable dragging of this Panel (defaults to false).</p> <p>For custom drag/drop implementations, an Ext.Panel.DD config could also be passed in this config instead of true. Ext.Panel.DD is an internal, undocumented class which moves a proxy Element around in place of the Panel's element, but provides no other behaviour during dragging or on drop. It is a subclass of {@link Ext.dd.DragSource}, so behaviour may be added by implementing the interface methods of {@link Ext.dd.DragDrop} eg: <pre><code> new Ext.Panel({ title: 'Drag me', x: 100, y: 100, renderTo: Ext.getBody(), floating: true, frame: true, width: 400, height: 200, draggable: { //      Config option of Ext.Panel.DD class. //      It's a floating Panel, so do not show a placeholder proxy in the original position. insertProxy: false, //      Called for each mousemove event while dragging the DD object. onDrag : function(e){ //          Record the x,y position of the drag proxy so that we can //          position the Panel at end of drag. var pel = this.proxy.getEl(); this.x = pel.getLeft(true); this.y = pel.getTop(true); //          Keep the Shadow aligned if there is one. var s = this.panel.getEl().shadow; if (s) { s.realign(this.x, this.y, pel.getWidth(), pel.getHeight()); } }, //      Called on the mouseup event. endDrag : function(e){ this.panel.setPosition(this.x, this.y); } } }).show(); </code></pre></summary>
		public extern bool draggable { get; set; }

		/// <summary>  Adds a tooltip when mousing over the tab of a Ext.Panel which is an item of a Ext.TabPanel. Ext.QuickTips.init() must be called in order for the tips to render.</summary>
		public extern string tabTip { get; set; }

		/// <summary>  Render this panel disabled (default is false). An important note when using the disabled config on panels is that IE will often fail to initialize the disabled mask element correectly if the panel's layout has not yet completed by the time the Panel is disabled during the render process. If you experience this issue, you may need to instead use the {@link afterlayout} event to initialize the disabled state: <pre><code> new Ext.Panel({ ... listeners: { 'afterlayout': { fn: function(p){ p.disable(); }, single: true // important, as many layouts can occur } } }); </code></pre></summary>
		public extern bool disabled { get; set; }

		/// <summary>  True to use height:'auto', false to use fixed height (defaults to false). <b>Note</b>: Setting autoHeight:true means that the browser will manage the panel's height based on its contents, and that Ext will not manage it at all. If the panel is within a layout that manages dimensions (fit, border, etc.) then setting autoHeight:true can cause issues with scrolling and will not generally work as expected since the panel will take on the height of its contents rather than the height required by the Ext layout.</summary>
		public extern bool autoHeight { get; set; }

		/// <summary>  The base CSS class to apply to this panel's element (defaults to 'x-panel').</summary>
		public extern string baseCls { get; set; }

		/// <summary>  A CSS class to add to the panel's element after it has been collapsed (defaults to 'x-panel-collapsed').</summary>
		public extern string collapsedCls { get; set; }

		/// <summary>  True to mask the panel when it is disabled, false to not mask it (defaults to true).  Either way, the panel will always tell its contained elements to disable themselves when it is disabled, but masking the panel can provide an additional visual cue that the panel is disabled.</summary>
		public extern bool maskDisabled { get; set; }

		/// <summary>  True to animate the transition when the panel is collapsed, false to skip the animation (defaults to true if the {@link Ext.Fx} class is available, otherwise false).</summary>
		public extern bool animCollapse { get; set; }

		/// <summary>  True to display the panel title in the header, false to hide it (defaults to true).</summary>
		public extern bool headerAsText { get; set; }

		/// <summary>  The alignment of any buttons added to this panel.  Valid values are 'right,' 'left' and 'center' (defaults to 'right').</summary>
		public extern string buttonAlign { get; set; }

		/// <summary>  True to render the panel collapsed, false to render it expanded (defaults to false).</summary>
		public extern bool collapsed { get; set; }

		/// <summary>  True to make sure the collapse/expand toggle button always renders first (to the left of) any other tools in the panel's title bar, false to render it last (defaults to true).</summary>
		public extern bool collapseFirst { get; set; }

		/// <summary>  Minimum width in pixels of all buttons in this panel (defaults to 75)</summary>
		public extern double minButtonWidth { get; set; }

		/// <summary>  A comma-delimited list of panel elements to initialize when the panel is rendered.  Normally, this list will be generated automatically based on the items added to the panel at config time, but sometimes it might be useful to make sure a structural element is rendered even if not specified at config time (for example, you may want to add a button or toolbar dynamically after the panel has been rendered).  Adding those elements to this list will allocate the required placeholders in the panel when it is rendered.  Valid values are<ul> <li><b>header</b></li> <li><b>tbar</b> (top bar)</li> <li><b>body</b> (required)</li> <li><b>bbar</b> (bottom bar)</li> <li><b>footer</b><li> </ul> Defaults to 'body'.</summary>
		public extern string elements { get; set; }

		/// <summary> The default type of container represented by this object as registered in Ext.ComponentMgr (defaults to 'panel').</summary>
		public extern string defaultType { get; set; }

		/// <summary>  The layout type to be used in this container.  If not specified, a default {@link Ext.layout.ContainerLayout} will be created and used. Specific config values for the chosen layout type can be specified using {@link #layoutConfig}. Valid values are:<ul class="mdetail-params"> <li>absolute</li> <li>accordion</li> <li>anchor</li> <li>border</li> <li>card</li> <li>column</li> <li>fit</li> <li>form</li> <li>table</li></ul></summary>
		public extern string layout { get; set; }

		/// <summary>  This is a config object containing properties specific to the chosen layout (to be used in conjunction with the {@link #layout} config value).  For complete details regarding the valid config options for each layout type, see the layout class corresponding to the type specified:<ul class="mdetail-params"> <li>{@link Ext.layout.Absolute}</li> <li>{@link Ext.layout.Accordion}</li> <li>{@link Ext.layout.AnchorLayout}</li> <li>{@link Ext.layout.BorderLayout}</li> <li>{@link Ext.layout.CardLayout}</li> <li>{@link Ext.layout.ColumnLayout}</li> <li>{@link Ext.layout.FitLayout}</li> <li>{@link Ext.layout.FormLayout}</li> <li>{@link Ext.layout.TableLayout}</li></ul></summary>
		public extern object layoutConfig { get; set; }

		/// <summary>{Boolean/Number}  When set to true (100 milliseconds) or a number of milliseconds, the layout assigned for this container will buffer the frequency it calculates and does a re-layout of components. This is useful for heavy containers or containers with a large quantity of sub-components for which frequent layout calls would be expensive.</summary>
		public extern object bufferResize { get; set; }

		/// <summary>{String/Number}  A string component id or the numeric index of the component that should be initially activated within the container's layout on render.  For example, activeItem: 'item-1' or activeItem: 0 (index 0 = the first item in the container's collection).  activeItem only applies to layout styles that can display items one at a time (like {@link Ext.layout.Accordion}, {@link Ext.layout.CardLayout} and {@link Ext.layout.FitLayout}).  Related to {@link Ext.layout.ContainerLayout#activeItem}.</summary>
		public extern object activeItem { get; set; }

		/// <summary>  A single item, or an array of child Components to be added to this container. Each item can be any type of object based on {@link Ext.Component}.<br><br> Component config objects may also be specified in order to avoid the overhead of constructing a real Component object if lazy rendering might mean that the added Component will not be rendered immediately. To take advantage of this "lazy instantiation", set the {@link Ext.Component#xtype} config property to the registered type of the Component wanted.<br><br> For a list of all available xtypes, see {@link Ext.Component}. If a single item is being passed, it should be passed directly as an object reference (e.g., items: {...}).  Multiple items should be passed as an array of objects (e.g., items: [{...}, {...}]).</summary>
		public extern object items { get; set; }

		/// <summary>  A config object that will be applied to all components added to this container either via the {@link #items} config or via the {@link #add} or {@link #insert} methods.  The defaults config can contain any number of name/value property pairs to be added to each item, and should be valid for the types of items being added to the container.  For example, to automatically apply padding to the body of each of a set of contained {@link Ext.Panel} items, you could pass: defaults: {bodyStyle:'padding:15px'}.</summary>
		public extern object defaults { get; set; }

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

		/// <summary>  An optional extra CSS class that will be added to this component's Element (defaults to '').  This can be useful for adding customized styles to the component or any of its children using standard CSS rules.</summary>
		public extern string cls { get; set; }

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
