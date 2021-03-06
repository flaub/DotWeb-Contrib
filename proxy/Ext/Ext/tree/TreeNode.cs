using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.tree {
	/// <summary>
	///     /**
	///     @cfg {String} text The text for this node
	///     @cfg {Boolean} expanded true to start the node expanded
	///     @cfg {Boolean} allowDrag False to make this node undraggable if {@link #draggable} = true (defaults to true)
	///     @cfg {Boolean} allowDrop False if this node cannot have child nodes dropped on it (defaults to true)
	///     @cfg {Boolean} disabled true to start the node disabled
	///     @cfg {String} icon The path to an icon for the node. The preferred way to do this
	///     is to use the cls or iconCls attributes and add the icon via a CSS background image.
	///     @cfg {String} cls A css class to be added to the node
	///     @cfg {String} iconCls A css class to be added to the nodes icon element for applying css background images
	///     @cfg {String} href URL of the link used for the node (defaults to #)
	///     @cfg {String} hrefTarget target frame for the link
	///     @cfg {Boolean} hidden True to render hidden. (Defaults to false).
	///     @cfg {String} qtip An Ext QuickTip for the node
	///     @cfg {Boolean} expandable If set to true, the node will always show a plus/minus icon, even when empty
	///     @cfg {String} qtipCfg An Ext QuickTip config for the node (used instead of qtip)
	///     @cfg {Boolean} singleClickExpand True for single click expand on this node
	///     @cfg {Function} uiProvider A UI <b>class</b> to use for this node (defaults to Ext.tree.TreeNodeUI)
	///     @cfg {Boolean} checked True to render a checked checkbox for this node, false to render an unchecked checkbox
	///     (defaults to undefined with no checkbox rendered)
	///     @cfg {Boolean} draggable True to make this node draggable (defaults to false)
	///     @cfg {Boolean} isTarget False to not allow this node to act as a drop target (defaults to true)
	///     @cfg {Boolean} allowChildren False to not allow this node to have child nodes (defaults to true)
	///     @cfg {Boolean} editable False to not allow this node to be edited by an (@link Ext.tree.TreeEditor} (defaults to true)
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\tree\TreeNode.js</jssource>
	public class TreeNode : Ext.data.Node {

		/// <summary></summary>
		/// <returns></returns>
		public extern TreeNode();
		/// <summary></summary>
		/// <param name="attributes">The attributes/config for the node or just a string with the text for the node</param>
		/// <returns></returns>
		public extern TreeNode(object attributes);
		/// <summary></summary>
		/// <param name="attributes">The attributes/config for the node or just a string with the text for the node</param>
		/// <returns></returns>
		public extern TreeNode(string attributes);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static TreeNode prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.data.Node superclass { get; set; }

		/// <summary>Read-only. The text for this node. To change it use setText().</summary>
		public extern string text { get; set; }

		/// <summary>True if this node is disabled.</summary>
		public extern bool disabled { get; set; }

		/// <summary>True if this node is hidden.</summary>
		public extern bool hidden { get; set; }

		/// <summary>Read-only. The UI for this node</summary>
		public extern TreeNodeUI ui { get; set; }


		/// <summary>Returns true if this node is expanded</summary>
		/// <returns>Boolean</returns>
		public extern virtual void isExpanded();

		/// <summary>
		///     Returns the UI object for this node.
		///     node. Unless otherwise specified in the {@link #uiProvider}, this will be an instance
		///     of {@link Ext.tree.TreeNodeUI}
		/// </summary>
		/// <returns>TreeNodeUI</returns>
		public extern virtual void getUI();

		/// <summary>Sets the text for this node</summary>
		/// <returns></returns>
		public extern virtual void setText();

		/// <summary>Sets the text for this node</summary>
		/// <param name="text"></param>
		/// <returns></returns>
		public extern virtual void setText(string text);

		/// <summary>Triggers selection of this node</summary>
		/// <returns></returns>
		public extern virtual void select();

		/// <summary>Triggers deselection of this node</summary>
		/// <returns></returns>
		public extern virtual void unselect();

		/// <summary>Returns true if this node is selected</summary>
		/// <returns>Boolean</returns>
		public extern virtual void isSelected();

		/// <summary>
		///     Expand this node.
		///     expanding this node completes (does not wait for deep expand to complete).
		///     Called with 1 parameter, this node.
		/// </summary>
		/// <returns></returns>
		public extern virtual void expand();

		/// <summary>
		///     Expand this node.
		///     expanding this node completes (does not wait for deep expand to complete).
		///     Called with 1 parameter, this node.
		/// </summary>
		/// <param name="deep">(optional) True to expand all children as well</param>
		/// <returns></returns>
		public extern virtual void expand(bool deep);

		/// <summary>
		///     Expand this node.
		///     expanding this node completes (does not wait for deep expand to complete).
		///     Called with 1 parameter, this node.
		/// </summary>
		/// <param name="deep">(optional) True to expand all children as well</param>
		/// <param name="anim">(optional) false to cancel the default animation</param>
		/// <returns></returns>
		public extern virtual void expand(bool deep, bool anim);

		/// <summary>
		///     Expand this node.
		///     expanding this node completes (does not wait for deep expand to complete).
		///     Called with 1 parameter, this node.
		/// </summary>
		/// <param name="deep">(optional) True to expand all children as well</param>
		/// <param name="anim">(optional) false to cancel the default animation</param>
		/// <param name="callback">(optional) A callback to be called when</param>
		/// <returns></returns>
		public extern virtual void expand(bool deep, bool anim, Delegate callback);

		/// <summary>Collapse this node.</summary>
		/// <returns></returns>
		public extern virtual void collapse();

		/// <summary>Collapse this node.</summary>
		/// <param name="deep">(optional) True to collapse all children as well</param>
		/// <returns></returns>
		public extern virtual void collapse(bool deep);

		/// <summary>Collapse this node.</summary>
		/// <param name="deep">(optional) True to collapse all children as well</param>
		/// <param name="anim">(optional) false to cancel the default animation</param>
		/// <returns></returns>
		public extern virtual void collapse(bool deep, bool anim);

		/// <summary>Toggles expanded/collapsed state of the node</summary>
		/// <returns></returns>
		public extern virtual void toggle();

		/// <summary>
		///     Ensures all parent nodes are expanded, and if necessary, scrolls
		///     the node into view.
		/// </summary>
		/// <returns></returns>
		public extern virtual void ensureVisible();

		/// <summary>
		///     Ensures all parent nodes are expanded, and if necessary, scrolls
		///     the node into view.
		/// </summary>
		/// <param name="callback">(optional) A function to call when the node has been made visible.</param>
		/// <returns></returns>
		public extern virtual void ensureVisible(Delegate callback);

		/// <summary>Expand all child nodes</summary>
		/// <returns></returns>
		public extern virtual void expandChildNodes();

		/// <summary>Expand all child nodes</summary>
		/// <param name="deep">(optional) true if the child nodes should also expand their child nodes</param>
		/// <returns></returns>
		public extern virtual void expandChildNodes(bool deep);

		/// <summary>Collapse all child nodes</summary>
		/// <returns></returns>
		public extern virtual void collapseChildNodes();

		/// <summary>Collapse all child nodes</summary>
		/// <param name="deep">(optional) true if the child nodes should also collapse their child nodes</param>
		/// <returns></returns>
		public extern virtual void collapseChildNodes(bool deep);

		/// <summary>Disables this node</summary>
		/// <returns></returns>
		public extern virtual void disable();

		/// <summary>Enables this node</summary>
		/// <returns></returns>
		public extern virtual void enable();



	}

	[JsAnonymous]
	public class TreeNodeConfig : System.DotWeb.JsDynamic {
		/// <summary> The text for this node</summary>
		public extern string text { get; set; }

		/// <summary> true to start the node expanded</summary>
		public extern bool expanded { get; set; }

		/// <summary> False to make this node undraggable if {@link #draggable} = true (defaults to true)</summary>
		public extern bool allowDrag { get; set; }

		/// <summary> False if this node cannot have child nodes dropped on it (defaults to true)</summary>
		public extern bool allowDrop { get; set; }

		/// <summary> true to start the node disabled</summary>
		public extern bool disabled { get; set; }

		/// <summary> The path to an icon for the node. The preferred way to do this</summary>
		public extern string icon { get; set; }

		/// <summary> A css class to be added to the node</summary>
		public extern string cls { get; set; }

		/// <summary> A css class to be added to the nodes icon element for applying css background images</summary>
		public extern string iconCls { get; set; }

		/// <summary> URL of the link used for the node (defaults to #)</summary>
		public extern string href { get; set; }

		/// <summary> target frame for the link</summary>
		public extern string hrefTarget { get; set; }

		/// <summary> True to render hidden. (Defaults to false).</summary>
		public extern bool hidden { get; set; }

		/// <summary> An Ext QuickTip for the node</summary>
		public extern string qtip { get; set; }

		/// <summary> If set to true, the node will always show a plus/minus icon, even when empty</summary>
		public extern bool expandable { get; set; }

		/// <summary> An Ext QuickTip config for the node (used instead of qtip)</summary>
		public extern string qtipCfg { get; set; }

		/// <summary> True for single click expand on this node</summary>
		public extern bool singleClickExpand { get; set; }

		/// <summary> A UI <b>class</b> to use for this node (defaults to Ext.tree.TreeNodeUI)</summary>
		public extern Delegate uiProvider { get; set; }

		/// <summary> True to render a checked checkbox for this node, false to render an unchecked checkbox</summary>
		public extern bool checked_ { get; set; }

		/// <summary> True to make this node draggable (defaults to false)</summary>
		public extern bool draggable { get; set; }

		/// <summary> False to not allow this node to act as a drop target (defaults to true)</summary>
		public extern bool isTarget { get; set; }

		/// <summary> False to not allow this node to have child nodes (defaults to true)</summary>
		public extern bool allowChildren { get; set; }

		/// <summary> False to not allow this node to be edited by an (@link Ext.tree.TreeEditor} (defaults to true)</summary>
		public extern bool editable { get; set; }

		/// <summary> true if this node is a leaf and does not have children</summary>
		public extern bool leaf { get; set; }

		/// <summary> The id for this node. If one is not specified, one is generated.</summary>
		public extern string id { get; set; }

		/// <summary> (optional) A config object containing one or more event handlers to be added to this object during initialization.  This should be a valid listeners config object as specified in the {@link #addListener} example for attaching multiple handlers at once.</summary>
		public extern object listeners { get; set; }

	}

    public class TreeNodeEvents {
        /// <summary>Fires when the text for this node is changed
        /// <pre><code>
        /// USAGE: ({Node} objthis, {String} text, {String} oldText)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description>This node</description></item>
        /// <item><term><b>text</b></term><description>The new text</description></item>
        /// <item><term><b>oldText</b></term><description>The old text</description></item>
        /// </list>
        /// </summary>
        public static string textchange { get { return "textchange"; } }
        /// <summary>Fires before this node is expanded, return false to cancel.
        /// <pre><code>
        /// USAGE: ({Node} objthis, {Boolean} deep, {Boolean} anim)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description>This node</description></item>
        /// <item><term><b>deep</b></term><description></description></item>
        /// <item><term><b>anim</b></term><description></description></item>
        /// </list>
        /// </summary>
        public static string beforeexpand { get { return "beforeexpand"; } }
        /// <summary>Fires before this node is collapsed, return false to cancel.
        /// <pre><code>
        /// USAGE: ({Node} objthis, {Boolean} deep, {Boolean} anim)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description>This node</description></item>
        /// <item><term><b>deep</b></term><description></description></item>
        /// <item><term><b>anim</b></term><description></description></item>
        /// </list>
        /// </summary>
        public static string beforecollapse { get { return "beforecollapse"; } }
        /// <summary>Fires when this node is expanded
        /// <pre><code>
        /// USAGE: ({Node} objthis)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description>This node</description></item>
        /// </list>
        /// </summary>
        public static string expand { get { return "expand"; } }
        /// <summary>Fires when the disabled status of this node changes
        /// <pre><code>
        /// USAGE: ({Node} objthis, {Boolean} disabled)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description>This node</description></item>
        /// <item><term><b>disabled</b></term><description></description></item>
        /// </list>
        /// </summary>
        public static string disabledchange { get { return "disabledchange"; } }
        /// <summary>Fires when this node is collapsed
        /// <pre><code>
        /// USAGE: ({Node} objthis)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description>This node</description></item>
        /// </list>
        /// </summary>
        public static string collapse { get { return "collapse"; } }
        /// <summary>Fires before click processing. Return false to cancel the default action.
        /// <pre><code>
        /// USAGE: ({Node} objthis, {Ext.EventObject} e)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description>This node</description></item>
        /// <item><term><b>e</b></term><description>The event object</description></item>
        /// </list>
        /// </summary>
        public static string beforeclick { get { return "beforeclick"; } }
        /// <summary>Fires when this node is clicked
        /// <pre><code>
        /// USAGE: ({Node} objthis, {Ext.EventObject} e)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description>This node</description></item>
        /// <item><term><b>e</b></term><description>The event object</description></item>
        /// </list>
        /// </summary>
        public static string click { get { return "click"; } }
        /// <summary>Fires when a node with a checkbox's checked property changes
        /// <pre><code>
        /// USAGE: ({Node} objthis, {Boolean} chckd)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description>This node</description></item>
        /// <item><term><b>chckd</b></term><description></description></item>
        /// </list>
        /// </summary>
        public static string checkchange { get { return "checkchange"; } }
        /// <summary>Fires when this node is double clicked
        /// <pre><code>
        /// USAGE: ({Node} objthis, {Ext.EventObject} e)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description>This node</description></item>
        /// <item><term><b>e</b></term><description>The event object</description></item>
        /// </list>
        /// </summary>
        public static string dblclick { get { return "dblclick"; } }
        /// <summary>Fires when this node is right clicked
        /// <pre><code>
        /// USAGE: ({Node} objthis, {Ext.EventObject} e)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description>This node</description></item>
        /// <item><term><b>e</b></term><description>The event object</description></item>
        /// </list>
        /// </summary>
        public static string contextmenu { get { return "contextmenu"; } }
        /// <summary>Fires right before the child nodes for this node are rendered
        /// <pre><code>
        /// USAGE: ({Node} objthis)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description>This node</description></item>
        /// </list>
        /// </summary>
        public static string beforechildrenrendered { get { return "beforechildrenrendered"; } }
    }

    public delegate void TreeNodeTextchangeDelegate(Ext.data.Node objthis, string text, string oldText);
    public delegate void TreeNodeBeforeexpandDelegate(Ext.data.Node objthis, bool deep, bool anim);
    public delegate void TreeNodeBeforecollapseDelegate(Ext.data.Node objthis, bool deep, bool anim);
    public delegate void TreeNodeExpandDelegate(Ext.data.Node objthis);
    public delegate void TreeNodeDisabledchangeDelegate(Ext.data.Node objthis, bool disabled);
    public delegate void TreeNodeCollapseDelegate(Ext.data.Node objthis);
    public delegate void TreeNodeBeforeclickDelegate(Ext.data.Node objthis, Ext.EventObject e);
    public delegate void TreeNodeClickDelegate(Ext.data.Node objthis, Ext.EventObject e);
    public delegate void TreeNodeCheckchangeDelegate(Ext.data.Node objthis, bool chckd);
    public delegate void TreeNodeDblclickDelegate(Ext.data.Node objthis, Ext.EventObject e);
    public delegate void TreeNodeContextmenuDelegate(Ext.data.Node objthis, Ext.EventObject e);
    public delegate void TreeNodeBeforechildrenrenderedDelegate(Ext.data.Node objthis);
}
