using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext {
	/// <summary>
	///     /**
	///     <p>Base class for any {@link Ext.BoxComponent} that can contain other components. The most commonly
	///     used Container classes are {@link Ext.Panel}, {@link Ext.Window} and {@link Ext.TabPanel}, but you can
	///     create a lightweight Container to encapsulate an HTML element that is created to your
	///     specifications at render time by using the {@link Ext.Component#autoEl autoEl} config option
	///     which takes the form of a {@link Ext.DomHelper DomHelper} specification. If you do not need
	///     the capabilities offered by the above mentioned classes, for instance embedded
	///     {@link Ext.layout.ColumnLayout column} layouts inside FormPanels, then this is a useful technique.</p>
	///     <p>The code below illustrates both how to explicitly <i>create</i> a Container, and how to implicitly
	///     create one using the <b><tt>'container'</tt></b> xtype:<pre><code>
	///     var embeddedColumns = new Ext.Container({
	///     autoEl: {},
	///     layout: 'column',
	///     defaults: {
	///     xtype: 'container',
	///     autoEl: {},
	///     layout: 'form',
	///     columnWidth: 0.5,
	///     style: {
	///     padding: '10px'
	///     }
	///     },
	///     items: [{
	///     items: {
	///     xtype: 'datefield',
	///     name: 'startDate',
	///     fieldLabel: 'Start date'
	///     }
	///     }, {
	///     items: {
	///     xtype: 'datefield',
	///     name: 'endDate',
	///     fieldLabel: 'End date'
	///     }
	///     }]
	///     });</code></pre></p>
	///     Containers handle the basic behavior of containing items, namely adding, inserting and removing them.
	///     The specific layout logic required to visually render contained items is delegated to any one of the different
	///     {@link #layout} classes available.</p>
	///     <p>When either specifying child {@link #items} of a Container, or dynamically adding components to a Container,
	///     remember to consider how you wish the Container to arrange those child elements, and whether those child elements
	///     need to be sized using one of Ext's built-in layout schemes.</p>
	///     <p>By default, Containers use the {@link Ext.layout.ContainerLayout ContainerLayout} scheme. This simply renders
	///     child components, appending them one after the other inside the Container, and does not apply any sizing at all.
	///     This is a common source of confusion when widgets like GridPanels or TreePanels are added to Containers for
	///     which no layout has been specified. If a Container is left to use the ContainerLayout scheme, none of its child
	///     components will be resized, or changed in any way when the Container is resized.</p>
	///     <p>A very common example of this is where a developer will attempt to add a GridPanel to a TabPanel by wrapping
	///     the GridPanel <i>inside</i> a wrapping Panel and add that wrapping Panel to the TabPanel. This misses the point that
	///     Ext's inheritance means that a GridPanel <b>is</b> a Component which can be added unadorned into a Container. If
	///     that wrapping Panel has no layout configuration, then the GridPanel will not be sized as expected.<p>
	///     <p>Below is an example of adding a newly created GridPanel to a TabPanel. A TabPanel uses {@link Ext.layout.CardLayout}
	///     as its layout manager which means all its child items are sized to fit exactly into its client area. The following
	///     code requires prior knowledge of how to create GridPanels. See {@link Ext.grid.GridPanel}, {@link Ext.data.Store}
	///     and {@link Ext.data.JsonReader} as well as the grid examples in the Ext installation's <tt>examples/grid</tt>
	///     directory.</p><pre><code>
	///     //  Create the GridPanel.
	///     myGrid = new Ext.grid.GridPanel({
	///     store: myStore,
	///     columns: myColumnModel,
	///     title: 'Results',
	///     });
	///     myTabPanel.add(myGrid);
	///     myTabPanel.setActiveTab(myGrid);
	///     </code></pre>
	///     */
	///     Ext.Container = Ext.extend(Ext.BoxComponent, {
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\Container.js</jssource>
	public class Container : Ext.BoxComponent {

		/// <summary>Auto-generated default constructor</summary>
		/// <returns></returns>
		public extern Container();
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern Container(Ext.Element config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern Container(string config);
		/// <summary></summary>
		/// <param name="config">The configuration options.</param>
		/// <returns></returns>
		public extern Container(object config);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static Container prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.BoxComponent superclass { get; set; }

		/// <summary>
		///     The layout type to be used in this container.  If not specified, a default {@link Ext.layout.ContainerLayout}
		///     will be created and used. Specific config values for the chosen layout type can be specified using
		///     {@link #layoutConfig}. Valid values are:<ul class="mdetail-params">
		///     <li>absolute</li>
		///     <li>accordion</li>
		///     <li>anchor</li>
		///     <li>border</li>
		///     <li>card</li>
		///     <li>column</li>
		///     <li>fit</li>
		///     <li>form</li>
		///     <li>table</li></ul>
		/// </summary>
		public extern string layout { get; set; }

		/// <summary>
		///     This is a config object containing properties specific to the chosen layout (to be used in conjunction with
		///     the {@link #layout} config value).  For complete details regarding the valid config options for each layout
		///     type, see the layout class corresponding to the type specified:<ul class="mdetail-params">
		///     <li>{@link Ext.layout.Absolute}</li>
		///     <li>{@link Ext.layout.Accordion}</li>
		///     <li>{@link Ext.layout.AnchorLayout}</li>
		///     <li>{@link Ext.layout.BorderLayout}</li>
		///     <li>{@link Ext.layout.CardLayout}</li>
		///     <li>{@link Ext.layout.ColumnLayout}</li>
		///     <li>{@link Ext.layout.FitLayout}</li>
		///     <li>{@link Ext.layout.FormLayout}</li>
		///     <li>{@link Ext.layout.TableLayout}</li></ul>
		/// </summary>
		public extern object layoutConfig { get; set; }

		/// <summary>
		///     When set to true (100 milliseconds) or a number of milliseconds, the layout assigned for this container will buffer
		///     the frequency it calculates and does a re-layout of components. This is useful for heavy containers or containers
		///     with a large quantity of sub-components for which frequent layout calls would be expensive.
		/// </summary>
		public extern object bufferResize { get; set; }

		/// <summary>
		///     A string component id or the numeric index of the component that should be initially activated within the
		///     container's layout on render.  For example, activeItem: 'item-1' or activeItem: 0 (index 0 = the first
		///     item in the container's collection).  activeItem only applies to layout styles that can display
		///     items one at a time (like {@link Ext.layout.Accordion}, {@link Ext.layout.CardLayout} and
		///     {@link Ext.layout.FitLayout}).  Related to {@link Ext.layout.ContainerLayout#activeItem}.
		/// </summary>
		public extern object activeItem { get; set; }

		/// <summary>
		///     A single item, or an array of child Components to be added to this container.
		///     Each item can be any type of object based on {@link Ext.Component}.<br><br>
		///     Component config objects may also be specified in order to avoid the overhead
		///     of constructing a real Component object if lazy rendering might mean that the
		///     added Component will not be rendered immediately. To take advantage of this
		///     "lazy instantiation", set the {@link Ext.Component#xtype} config property to
		///     the registered type of the Component wanted.<br><br>
		///     For a list of all available xtypes, see {@link Ext.Component}.
		///     If a single item is being passed, it should be passed directly as an object
		///     reference (e.g., items: {...}).  Multiple items should be passed as an array
		///     of objects (e.g., items: [{...}, {...}]).
		/// </summary>
		public extern object items { get; set; }

		/// <summary>
		///     A config object that will be applied to all components added to this container either via the {@link #items}
		///     config or via the {@link #add} or {@link #insert} methods.  The defaults config can contain any number of
		///     name/value property pairs to be added to each item, and should be valid for the types of items
		///     being added to the container.  For example, to automatically apply padding to the body of each of a set of
		///     contained {@link Ext.Panel} items, you could pass: defaults: {bodyStyle:'padding:15px'}.
		/// </summary>
		public extern object defaults { get; set; }


		/// <summary>
		///     <p>Returns the Element to be used to contain the child Components of this Container.</p>
		///     <p>An implementation is provided which returns the Container's {@link #getEl Element}, but
		///     if there is a more complex structure to a Container, this may be overridden to return
		///     the element into which the {@link #layout layout} renders child Components.</p>
		/// </summary>
		/// <returns>Ext.Element</returns>
		public extern virtual void getLayoutTarget();

		/// <summary>
		///     <p>Adds a {@link Ext.Component Component} to this Container. Fires the {@link #beforeadd} event before
		///     adding, then fires the {@link #add} event after the component has been added.</p>
		///     <p>You will never call the render method of a child Component when using a Container.
		///     Child Components are rendered by this Container's {@link #layout} manager when
		///     this Container is first rendered.</p>
		///     <p>Certain layout managers allow dynamic addition of child components. Those that do
		///     include {@link Ext.layout.CardLayout}, {@link Ext.layout.AnchorLayout},
		///     {@link Ext.layout.FormLayout}, {@link Ext.layout.TableLayout}.</p>
		///     <p>If the Container is already rendered when add is called, you may need to call
		///     {@link #doLayout} to refresh the view which causes any unrendered child Components
		///     to be rendered. This is required so that you can add multiple child components if needed
		///     while only refreshing the layout once.</p>
		///     <p>When creating complex UIs, it is important to remember that sizing and positioning
		///     of child items is the responsibility of the Container's {@link #layout} manager. If
		///     you expect child items to be sized in response to user interactions, you must
		///     specify a layout manager which creates and manages the type of layout you have in mind.</p>
		///     <p><b>Omitting the {@link #layout} config means that a basic layout manager is
		///     used which does nothnig but render child components sequentially into the Container.
		///     No sizing or positioning will be performed in this situation.</b></p>
		///     Ext uses lazy rendering, and will only render the added Component should
		///     it become necessary, that is: when the Container is layed out either on first render
		///     or in response to a {@link #doLayout} call.<br><br>
		///     A Component config object may be passed instead of an instantiated Component object.
		///     The type of Component created from a config object is determined by the {@link Ext.Component#xtype xtype}
		///     config property. If no xtype is configured, the Container's {@link #defaultType}
		///     is used.<br><br>
		///     For a list of all available xtypes, see {@link Ext.Component}.
		///     added with the Container's default config values applied.
		///     <p>example:</p><pre><code>
		///     var myNewGrid = new Ext.grid.GridPanel({
		///     store: myStore,
		///     colModel: myColModel
		///     });
		///     myTabPanel.add(myNewGrid);
		///     myTabPanel.setActiveTab(myNewGrid);
		///     </code></pre>
		/// </summary>
		/// <returns>Ext.Component</returns>
		public extern virtual void add();

		/// <summary>
		///     <p>Adds a {@link Ext.Component Component} to this Container. Fires the {@link #beforeadd} event before
		///     adding, then fires the {@link #add} event after the component has been added.</p>
		///     <p>You will never call the render method of a child Component when using a Container.
		///     Child Components are rendered by this Container's {@link #layout} manager when
		///     this Container is first rendered.</p>
		///     <p>Certain layout managers allow dynamic addition of child components. Those that do
		///     include {@link Ext.layout.CardLayout}, {@link Ext.layout.AnchorLayout},
		///     {@link Ext.layout.FormLayout}, {@link Ext.layout.TableLayout}.</p>
		///     <p>If the Container is already rendered when add is called, you may need to call
		///     {@link #doLayout} to refresh the view which causes any unrendered child Components
		///     to be rendered. This is required so that you can add multiple child components if needed
		///     while only refreshing the layout once.</p>
		///     <p>When creating complex UIs, it is important to remember that sizing and positioning
		///     of child items is the responsibility of the Container's {@link #layout} manager. If
		///     you expect child items to be sized in response to user interactions, you must
		///     specify a layout manager which creates and manages the type of layout you have in mind.</p>
		///     <p><b>Omitting the {@link #layout} config means that a basic layout manager is
		///     used which does nothnig but render child components sequentially into the Container.
		///     No sizing or positioning will be performed in this situation.</b></p>
		///     Ext uses lazy rendering, and will only render the added Component should
		///     it become necessary, that is: when the Container is layed out either on first render
		///     or in response to a {@link #doLayout} call.<br><br>
		///     A Component config object may be passed instead of an instantiated Component object.
		///     The type of Component created from a config object is determined by the {@link Ext.Component#xtype xtype}
		///     config property. If no xtype is configured, the Container's {@link #defaultType}
		///     is used.<br><br>
		///     For a list of all available xtypes, see {@link Ext.Component}.
		///     added with the Container's default config values applied.
		///     <p>example:</p><pre><code>
		///     var myNewGrid = new Ext.grid.GridPanel({
		///     store: myStore,
		///     colModel: myColModel
		///     });
		///     myTabPanel.add(myNewGrid);
		///     myTabPanel.setActiveTab(myNewGrid);
		///     </code></pre>
		/// </summary>
		/// <param name="component">The Component to add.<br><br></param>
		/// <returns>Ext.Component</returns>
		public extern virtual void add(Ext.Component component);

		/// <summary>
		///     <p>Adds a {@link Ext.Component Component} to this Container. Fires the {@link #beforeadd} event before
		///     adding, then fires the {@link #add} event after the component has been added.</p>
		///     <p>You will never call the render method of a child Component when using a Container.
		///     Child Components are rendered by this Container's {@link #layout} manager when
		///     this Container is first rendered.</p>
		///     <p>Certain layout managers allow dynamic addition of child components. Those that do
		///     include {@link Ext.layout.CardLayout}, {@link Ext.layout.AnchorLayout},
		///     {@link Ext.layout.FormLayout}, {@link Ext.layout.TableLayout}.</p>
		///     <p>If the Container is already rendered when add is called, you may need to call
		///     {@link #doLayout} to refresh the view which causes any unrendered child Components
		///     to be rendered. This is required so that you can add multiple child components if needed
		///     while only refreshing the layout once.</p>
		///     <p>When creating complex UIs, it is important to remember that sizing and positioning
		///     of child items is the responsibility of the Container's {@link #layout} manager. If
		///     you expect child items to be sized in response to user interactions, you must
		///     specify a layout manager which creates and manages the type of layout you have in mind.</p>
		///     <p><b>Omitting the {@link #layout} config means that a basic layout manager is
		///     used which does nothnig but render child components sequentially into the Container.
		///     No sizing or positioning will be performed in this situation.</b></p>
		///     Ext uses lazy rendering, and will only render the added Component should
		///     it become necessary, that is: when the Container is layed out either on first render
		///     or in response to a {@link #doLayout} call.<br><br>
		///     A Component config object may be passed instead of an instantiated Component object.
		///     The type of Component created from a config object is determined by the {@link Ext.Component#xtype xtype}
		///     config property. If no xtype is configured, the Container's {@link #defaultType}
		///     is used.<br><br>
		///     For a list of all available xtypes, see {@link Ext.Component}.
		///     added with the Container's default config values applied.
		///     <p>example:</p><pre><code>
		///     var myNewGrid = new Ext.grid.GridPanel({
		///     store: myStore,
		///     colModel: myColModel
		///     });
		///     myTabPanel.add(myNewGrid);
		///     myTabPanel.setActiveTab(myNewGrid);
		///     </code></pre>
		/// </summary>
		/// <param name="component">The Component to add.<br><br></param>
		/// <returns>Ext.Component</returns>
		public extern virtual void add(object component);

		/// <summary>
		///     Inserts a Component into this Container at a specified index. Fires the
		///     {@link #beforeadd} event before inserting, then fires the {@link #add} event after the
		///     Component has been inserted.
		///     into the Container's items collection
		///     Ext uses lazy rendering, and will only render the inserted Component should
		///     it become necessary.<br><br>
		///     A Component config object may be passed in order to avoid the overhead of
		///     constructing a real Component object if lazy rendering might mean that the
		///     inserted Component will not be rendered immediately. To take advantage of
		///     this "lazy instantiation", set the {@link Ext.Component#xtype} config
		///     property to the registered type of the Component wanted.<br><br>
		///     For a list of all available xtypes, see {@link Ext.Component}.
		///     inserted with the Container's default config values applied.
		/// </summary>
		/// <returns>Ext.Component</returns>
		public extern virtual void insert();

		/// <summary>
		///     Inserts a Component into this Container at a specified index. Fires the
		///     {@link #beforeadd} event before inserting, then fires the {@link #add} event after the
		///     Component has been inserted.
		///     into the Container's items collection
		///     Ext uses lazy rendering, and will only render the inserted Component should
		///     it become necessary.<br><br>
		///     A Component config object may be passed in order to avoid the overhead of
		///     constructing a real Component object if lazy rendering might mean that the
		///     inserted Component will not be rendered immediately. To take advantage of
		///     this "lazy instantiation", set the {@link Ext.Component#xtype} config
		///     property to the registered type of the Component wanted.<br><br>
		///     For a list of all available xtypes, see {@link Ext.Component}.
		///     inserted with the Container's default config values applied.
		/// </summary>
		/// <param name="index">The index at which the Component will be inserted</param>
		/// <returns>Ext.Component</returns>
		public extern virtual void insert(double index);

		/// <summary>
		///     Inserts a Component into this Container at a specified index. Fires the
		///     {@link #beforeadd} event before inserting, then fires the {@link #add} event after the
		///     Component has been inserted.
		///     into the Container's items collection
		///     Ext uses lazy rendering, and will only render the inserted Component should
		///     it become necessary.<br><br>
		///     A Component config object may be passed in order to avoid the overhead of
		///     constructing a real Component object if lazy rendering might mean that the
		///     inserted Component will not be rendered immediately. To take advantage of
		///     this "lazy instantiation", set the {@link Ext.Component#xtype} config
		///     property to the registered type of the Component wanted.<br><br>
		///     For a list of all available xtypes, see {@link Ext.Component}.
		///     inserted with the Container's default config values applied.
		/// </summary>
		/// <param name="index">The index at which the Component will be inserted</param>
		/// <param name="component">The child Component to insert.<br><br></param>
		/// <returns>Ext.Component</returns>
		public extern virtual void insert(double index, Ext.Component component);

		/// <summary>
		///     Removes a component from this container.  Fires the {@link #beforeremove} event before removing, then fires
		///     the {@link #remove} event after the component has been removed.
		///     Defaults to the value of this Container's {@link #autoDestroy} config.
		/// </summary>
		/// <returns>Ext.Component</returns>
		public extern virtual void remove();

		/// <summary>
		///     Removes a component from this container.  Fires the {@link #beforeremove} event before removing, then fires
		///     the {@link #remove} event after the component has been removed.
		///     Defaults to the value of this Container's {@link #autoDestroy} config.
		/// </summary>
		/// <param name="component">The component reference or id to remove.</param>
		/// <returns>Ext.Component</returns>
		public extern virtual void remove(Component component);

		/// <summary>
		///     Removes a component from this container.  Fires the {@link #beforeremove} event before removing, then fires
		///     the {@link #remove} event after the component has been removed.
		///     Defaults to the value of this Container's {@link #autoDestroy} config.
		/// </summary>
		/// <param name="component">The component reference or id to remove.</param>
		/// <param name="autoDestroy">(optional) True to automatically invoke the removed Component's {@link Ext.Component#destroy} function.</param>
		/// <returns>Ext.Component</returns>
		public extern virtual void remove(Component component, bool autoDestroy);

		/// <summary>
		///     Removes a component from this container.  Fires the {@link #beforeremove} event before removing, then fires
		///     the {@link #remove} event after the component has been removed.
		///     Defaults to the value of this Container's {@link #autoDestroy} config.
		/// </summary>
		/// <param name="component">The component reference or id to remove.</param>
		/// <returns>Ext.Component</returns>
		public extern virtual void remove(string component);

		/// <summary>
		///     Removes a component from this container.  Fires the {@link #beforeremove} event before removing, then fires
		///     the {@link #remove} event after the component has been removed.
		///     Defaults to the value of this Container's {@link #autoDestroy} config.
		/// </summary>
		/// <param name="component">The component reference or id to remove.</param>
		/// <param name="autoDestroy">(optional) True to automatically invoke the removed Component's {@link Ext.Component#destroy} function.</param>
		/// <returns>Ext.Component</returns>
		public extern virtual void remove(string component, bool autoDestroy);

		/// <summary>
		///     Removes all components from this container.
		///     Defaults to the value of this Container's {@link #autoDestroy} config.
		/// </summary>
		/// <returns>Array</returns>
		public extern virtual void removeAll();

		/// <summary>
		///     Removes all components from this container.
		///     Defaults to the value of this Container's {@link #autoDestroy} config.
		/// </summary>
		/// <param name="autoDestroy">(optional) True to automatically invoke the removed Component's {@link Ext.Component#destroy} function.</param>
		/// <returns>Array</returns>
		public extern virtual void removeAll(bool autoDestroy);

		/// <summary>Gets a direct child Component by id, or by index.</summary>
		/// <returns>Ext.Component</returns>
		public extern virtual void getComponent();

		/// <summary>Gets a direct child Component by id, or by index.</summary>
		/// <param name="id">or index of child Component to return.</param>
		/// <returns>Ext.Component</returns>
		public extern virtual void getComponent(string id);

		/// <summary>Gets a direct child Component by id, or by index.</summary>
		/// <param name="id">or index of child Component to return.</param>
		/// <returns>Ext.Component</returns>
		public extern virtual void getComponent(double id);

		/// <summary>
		///     Force this container's layout to be recalculated. A call to this function is required after adding a new component
		///     to an already rendered container, or possibly after changing sizing/position properties of child components.
		///     calc layouts as required (defaults to false, which calls doLayout recursively for each subcontainer)
		/// </summary>
		/// <returns></returns>
		public extern virtual void doLayout();

		/// <summary>
		///     Force this container's layout to be recalculated. A call to this function is required after adding a new component
		///     to an already rendered container, or possibly after changing sizing/position properties of child components.
		///     calc layouts as required (defaults to false, which calls doLayout recursively for each subcontainer)
		/// </summary>
		/// <param name="shallow">(optional) True to only calc the layout of this component, and let child components auto</param>
		/// <returns></returns>
		public extern virtual void doLayout(bool shallow);

		/// <summary>
		///     Returns the layout currently in use by the container.  If the container does not currently have a layout
		///     set, a default {@link Ext.layout.ContainerLayout} will be created and set as the container's layout.
		/// </summary>
		/// <returns>ContainerLayout</returns>
		public extern virtual void getLayout();

		/// <summary>
		///     Bubbles up the component/container heirarchy, calling the specified function with each component. The scope (<i>this</i>) of
		///     function call will be the scope provided or the current component. The arguments to the function
		///     will be the args provided or the current component. If the function returns false at any point,
		///     the bubble is stopped.
		/// </summary>
		/// <returns></returns>
		public extern virtual void bubble();

		/// <summary>
		///     Bubbles up the component/container heirarchy, calling the specified function with each component. The scope (<i>this</i>) of
		///     function call will be the scope provided or the current component. The arguments to the function
		///     will be the args provided or the current component. If the function returns false at any point,
		///     the bubble is stopped.
		/// </summary>
		/// <param name="fn">The function to call</param>
		/// <returns></returns>
		public extern virtual void bubble(Delegate fn);

		/// <summary>
		///     Bubbles up the component/container heirarchy, calling the specified function with each component. The scope (<i>this</i>) of
		///     function call will be the scope provided or the current component. The arguments to the function
		///     will be the args provided or the current component. If the function returns false at any point,
		///     the bubble is stopped.
		/// </summary>
		/// <param name="fn">The function to call</param>
		/// <param name="scope">(optional) The scope of the function (defaults to current node)</param>
		/// <returns></returns>
		public extern virtual void bubble(Delegate fn, object scope);

		/// <summary>
		///     Bubbles up the component/container heirarchy, calling the specified function with each component. The scope (<i>this</i>) of
		///     function call will be the scope provided or the current component. The arguments to the function
		///     will be the args provided or the current component. If the function returns false at any point,
		///     the bubble is stopped.
		/// </summary>
		/// <param name="fn">The function to call</param>
		/// <param name="scope">(optional) The scope of the function (defaults to current node)</param>
		/// <param name="args">(optional) The args to call the function with (default to passing the current component)</param>
		/// <returns></returns>
		public extern virtual void bubble(Delegate fn, object scope, System.Array args);

		/// <summary>
		///     Cascades down the component/container heirarchy from this component (called first), calling the specified function with
		///     each component. The scope (<i>this</i>) of
		///     function call will be the scope provided or the current component. The arguments to the function
		///     will be the args provided or the current component. If the function returns false at any point,
		///     the cascade is stopped on that branch.
		/// </summary>
		/// <returns></returns>
		public extern virtual void cascade();

		/// <summary>
		///     Cascades down the component/container heirarchy from this component (called first), calling the specified function with
		///     each component. The scope (<i>this</i>) of
		///     function call will be the scope provided or the current component. The arguments to the function
		///     will be the args provided or the current component. If the function returns false at any point,
		///     the cascade is stopped on that branch.
		/// </summary>
		/// <param name="fn">The function to call</param>
		/// <returns></returns>
		public extern virtual void cascade(Delegate fn);

		/// <summary>
		///     Cascades down the component/container heirarchy from this component (called first), calling the specified function with
		///     each component. The scope (<i>this</i>) of
		///     function call will be the scope provided or the current component. The arguments to the function
		///     will be the args provided or the current component. If the function returns false at any point,
		///     the cascade is stopped on that branch.
		/// </summary>
		/// <param name="fn">The function to call</param>
		/// <param name="scope">(optional) The scope of the function (defaults to current component)</param>
		/// <returns></returns>
		public extern virtual void cascade(Delegate fn, object scope);

		/// <summary>
		///     Cascades down the component/container heirarchy from this component (called first), calling the specified function with
		///     each component. The scope (<i>this</i>) of
		///     function call will be the scope provided or the current component. The arguments to the function
		///     will be the args provided or the current component. If the function returns false at any point,
		///     the cascade is stopped on that branch.
		/// </summary>
		/// <param name="fn">The function to call</param>
		/// <param name="scope">(optional) The scope of the function (defaults to current component)</param>
		/// <param name="args">(optional) The args to call the function with (defaults to passing the current component)</param>
		/// <returns></returns>
		public extern virtual void cascade(Delegate fn, object scope, System.Array args);

		/// <summary>Find a component under this container at any level by id</summary>
		/// <returns>Ext.Component</returns>
		public extern virtual void findById();

		/// <summary>Find a component under this container at any level by id</summary>
		/// <param name="id"></param>
		/// <returns>Ext.Component</returns>
		public extern virtual void findById(string id);

		/// <summary>
		///     Find a component under this container at any level by xtype or class
		///     the default), or true to check whether this Component is directly of the specified xtype.
		/// </summary>
		/// <returns>Array</returns>
		public extern virtual void findByType();

		/// <summary>
		///     Find a component under this container at any level by xtype or class
		///     the default), or true to check whether this Component is directly of the specified xtype.
		/// </summary>
		/// <param name="xtype">The xtype string for a component, or the class of the component directly</param>
		/// <returns>Array</returns>
		public extern virtual void findByType(string xtype);

		/// <summary>
		///     Find a component under this container at any level by xtype or class
		///     the default), or true to check whether this Component is directly of the specified xtype.
		/// </summary>
		/// <param name="xtype">The xtype string for a component, or the class of the component directly</param>
		/// <param name="shallow">(optional) False to check whether this Component is descended from the xtype (this is</param>
		/// <returns>Array</returns>
		public extern virtual void findByType(string xtype, bool shallow);

		/// <summary>
		///     Find a component under this container at any level by xtype or class
		///     the default), or true to check whether this Component is directly of the specified xtype.
		/// </summary>
		/// <param name="xtype">The xtype string for a component, or the class of the component directly</param>
		/// <returns>Array</returns>
		public extern virtual void findByType(object xtype);

		/// <summary>
		///     Find a component under this container at any level by xtype or class
		///     the default), or true to check whether this Component is directly of the specified xtype.
		/// </summary>
		/// <param name="xtype">The xtype string for a component, or the class of the component directly</param>
		/// <param name="shallow">(optional) False to check whether this Component is descended from the xtype (this is</param>
		/// <returns>Array</returns>
		public extern virtual void findByType(object xtype, bool shallow);

		/// <summary>Find a component under this container at any level by property</summary>
		/// <returns>Array</returns>
		public extern virtual void find();

		/// <summary>Find a component under this container at any level by property</summary>
		/// <param name="prop"></param>
		/// <returns>Array</returns>
		public extern virtual void find(string prop);

		/// <summary>Find a component under this container at any level by property</summary>
		/// <param name="prop"></param>
		/// <param name="value"></param>
		/// <returns>Array</returns>
		public extern virtual void find(string prop, string value);

		/// <summary>
		///     Find a component under this container at any level by a custom function. If the passed function returns
		///     true, the component will be included in the results. The passed function is called with the arguments (component, this container).
		/// </summary>
		/// <returns>Array</returns>
		public extern virtual void findBy();

		/// <summary>
		///     Find a component under this container at any level by a custom function. If the passed function returns
		///     true, the component will be included in the results. The passed function is called with the arguments (component, this container).
		/// </summary>
		/// <param name="fcn"></param>
		/// <returns>Array</returns>
		public extern virtual void findBy(Delegate fcn);

		/// <summary>
		///     Find a component under this container at any level by a custom function. If the passed function returns
		///     true, the component will be included in the results. The passed function is called with the arguments (component, this container).
		/// </summary>
		/// <param name="fcn"></param>
		/// <param name="scope">(optional)</param>
		/// <returns>Array</returns>
		public extern virtual void findBy(Delegate fcn, object scope);



	}

	[JsAnonymous]
	public class ContainerConfig : System.DotWeb.JsDynamic {
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

    public class ContainerEvents {
        /// <summary>Fires when the components in this container are arranged by the associated layout manager.
        /// <pre><code>
        /// USAGE: ({Ext.Container} objthis, {ContainerLayout} layout)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>layout</b></term><description>The ContainerLayout implementation for this container</description></item>
        /// </list>
        /// </summary>
        public static string afterlayout { get { return "afterlayout"; } }
        /// <summary>
        ///     Fires before any {@link Ext.Component} is added or inserted into the container.
        ///     A handler can return false to cancel the add.
        /// 
        /// <pre><code>
        /// USAGE: ({Ext.Container} objthis, {Ext.Component} component, {Number} index)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>component</b></term><description>The component being added</description></item>
        /// <item><term><b>index</b></term><description>The index at which the component will be added to the container's items collection</description></item>
        /// </list>
        /// </summary>
        public static string beforeadd { get { return "beforeadd"; } }
        /// <summary>
        ///     Fires before any {@link Ext.Component} is removed from the container.  A handler can return
        ///     false to cancel the remove.
        /// 
        /// <pre><code>
        /// USAGE: ({Ext.Container} objthis, {Ext.Component} component)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>component</b></term><description>The component being removed</description></item>
        /// </list>
        /// </summary>
        public static string beforeremove { get { return "beforeremove"; } }
        /// <summary>Fires after any {@link Ext.Component} is added or inserted into the container.
        /// <pre><code>
        /// USAGE: ({Ext.Container} objthis, {Ext.Component} component, {Number} index)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>component</b></term><description>The component that was added</description></item>
        /// <item><term><b>index</b></term><description>The index at which the component was added to the container's items collection</description></item>
        /// </list>
        /// </summary>
        public static string add { get { return "add"; } }
        /// <summary>Fires after any {@link Ext.Component} is removed from the container.
        /// <pre><code>
        /// USAGE: ({Ext.Container} objthis, {Ext.Component} component)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>component</b></term><description>The component that was removed</description></item>
        /// </list>
        /// </summary>
        public static string remove { get { return "remove"; } }
    }

    public delegate void ContainerAfterlayoutDelegate(Ext.Container objthis, Ext.layout.ContainerLayout layout);
    public delegate void ContainerBeforeaddDelegate(Ext.Container objthis, Ext.Component component, double index);
    public delegate void ContainerBeforeremoveDelegate(Ext.Container objthis, Ext.Component component);
    public delegate void ContainerAddDelegate(Ext.Container objthis, Ext.Component component, double index);
    public delegate void ContainerRemoveDelegate(Ext.Container objthis, Ext.Component component);
}
