using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.Toolbar {
	/// <summary>
	///     /**
	///     A simple element that adds extra horizontal space between items in a toolbar.
	///     <pre><code>
	///     new Ext.Panel({
	///     tbar : [
	///     'Item 1',
	///     {xtype: 'tbspacer'}, // or ' '
	///     'Item 2'
	///     ]
	///     });
	///     </code></pre>
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\Toolbar.js</jssource>
	public class Spacer : Ext.Toolbar.Item {

		/// <summary>Creates a new Spacer</summary>
		/// <returns></returns>
		public extern Spacer();
		/// <summary>Creates a new Item</summary>
		/// <param name="el"></param>
		/// <returns></returns>
		public extern Spacer(DOMElement el);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static Spacer prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.Toolbar.Item superclass { get; set; }




	}
}
