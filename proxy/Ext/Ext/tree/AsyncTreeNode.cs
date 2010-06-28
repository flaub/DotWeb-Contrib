using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.tree {
	/// <summary>
	///     /**
	///     @cfg {TreeLoader} loader A TreeLoader to be used by this node (defaults to the loader defined on the tree)
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\tree\AsyncTreeNode.js</jssource>
	public class AsyncTreeNode : Ext.tree.TreeNode {

		/// <summary></summary>
		/// <returns></returns>
		public extern AsyncTreeNode();
		/// <summary></summary>
		/// <param name="attributes">The attributes/config for the node or just a string with the text for the node</param>
		/// <returns></returns>
		public extern AsyncTreeNode(object attributes);
		/// <summary></summary>
		/// <param name="attributes">The attributes/config for the node or just a string with the text for the node</param>
		/// <returns></returns>
		public extern AsyncTreeNode(string attributes);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static AsyncTreeNode prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.tree.TreeNode superclass { get; set; }

		/// <summary>The loader used by this node (defaults to using the tree's defined loader)</summary>
		public extern TreeLoader loader { get; set; }


		/// <summary>Returns true if this node is currently loading</summary>
		/// <returns>Boolean</returns>
		public extern virtual void isLoading();

		/// <summary>Returns true if this node has been loaded</summary>
		/// <returns>Boolean</returns>
		public extern virtual void isLoaded();

		/// <summary>Trigger a reload for this node</summary>
		/// <returns></returns>
		public extern virtual void reload();

		/// <summary>Trigger a reload for this node</summary>
		/// <param name="callback"></param>
		/// <returns></returns>
		public extern virtual void reload(Delegate callback);



	}

	[JsAnonymous]
	public class AsyncTreeNodeConfig : System.DotWeb.JsDynamic {
		/// <summary> A TreeLoader to be used by this node (defaults to the loader defined on the tree)</summary>
		public extern TreeLoader loader { get; set; }

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

    public class AsyncTreeNodeEvents {
        /// <summary>Fires before this node is loaded, return false to cancel
        /// <pre><code>
        /// USAGE: ({Node} objthis)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description>This node</description></item>
        /// </list>
        /// </summary>
        public static string beforeload { get { return "beforeload"; } }
        /// <summary>Fires when this node is loaded
        /// <pre><code>
        /// USAGE: ({Node} objthis)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description>This node</description></item>
        /// </list>
        /// </summary>
        public static string load { get { return "load"; } }
    }

    public delegate void AsyncTreeNodeBeforeloadDelegate(Ext.data.Node objthis);
    public delegate void AsyncTreeNodeLoadDelegate(Ext.data.Node objthis);
}
