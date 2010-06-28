using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext {
	/// <summary>
	///     /**
	///     An extended {@link Ext.Element} object that supports a shadow and shim, constrain to viewport and
	///     automatic maintaining of shadow/shim positions.
	///     @cfg {Boolean} shim False to disable the iframe shim in browsers which need one (defaults to true)
	///     @cfg {String/Boolean} shadow True to automatically create an {@link Ext.Shadow}, or a string indicating the
	///     shadow's display {@link Ext.Shadow#mode}. False to disable the shadow. (defaults to false)
	///     @cfg {Object} dh DomHelper object config to create element with (defaults to {tag: "div", cls: "x-layer"}).
	///     @cfg {Boolean} constrain False to disable constrain to viewport (defaults to true)
	///     @cfg {String} cls CSS class to add to the element
	///     @cfg {Number} zindex Starting z-index (defaults to 11000)
	///     @cfg {Number} shadowOffset Number of pixels to offset the shadow (defaults to 3)
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\Layer.js</jssource>
	public class Layer : Ext.Element {

		/// <summary></summary>
		/// <returns></returns>
		public extern Layer();
		/// <summary></summary>
		/// <param name="config">An object with config options.</param>
		/// <returns></returns>
		public extern Layer(object config);
		/// <summary></summary>
		/// <param name="config">An object with config options.</param>
		/// <param name="existingEl">(optional) Uses an existing DOM element. If the element is not found it creates it.</param>
		/// <returns></returns>
		public extern Layer(object config, string existingEl);
		/// <summary></summary>
		/// <param name="config">An object with config options.</param>
		/// <param name="existingEl">(optional) Uses an existing DOM element. If the element is not found it creates it.</param>
		/// <returns></returns>
		public extern Layer(object config, DOMElement existingEl);
		/// <summary></summary>
		/// <param name="element"></param>
		/// <returns></returns>
		public extern Layer(string element);
		/// <summary></summary>
		/// <param name="element"></param>
		/// <param name="forceNew">(optional) By default the constructor checks to see if there is already an instance of this element in the cache and if there is it returns the same instance. This will skip that check (useful for extending this class).</param>
		/// <returns></returns>
		public extern Layer(string element, bool forceNew);
		/// <summary></summary>
		/// <param name="element"></param>
		/// <returns></returns>
		public extern Layer(DOMElement element);
		/// <summary></summary>
		/// <param name="element"></param>
		/// <param name="forceNew">(optional) By default the constructor checks to see if there is already an instance of this element in the cache and if there is it returns the same instance. This will skip that check (useful for extending this class).</param>
		/// <returns></returns>
		public extern Layer(DOMElement element, bool forceNew);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static Layer prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.Element superclass { get; set; }


		/// <summary>
		///     Sets the z-index of this layer and adjusts any shadow and shim z-indexes. The layer z-index is automatically
		///     incremented by two more than the value passed in so that it always shows above any shadow or shim (the shadow
		///     element, if any, will be assigned z-index + 1, and the shim element, if any, will be assigned the unmodified z-index).
		/// </summary>
		/// <returns>Layer</returns>
		public extern virtual void setZIndex();

		/// <summary>
		///     Sets the z-index of this layer and adjusts any shadow and shim z-indexes. The layer z-index is automatically
		///     incremented by two more than the value passed in so that it always shows above any shadow or shim (the shadow
		///     element, if any, will be assigned z-index + 1, and the shim element, if any, will be assigned the unmodified z-index).
		/// </summary>
		/// <param name="zindex">The new z-index to set</param>
		/// <returns>Layer</returns>
		public extern virtual void setZIndex(double zindex);



	}

	[JsAnonymous]
	public class LayerConfig : System.DotWeb.JsDynamic {
		/// <summary> False to disable the iframe shim in browsers which need one (defaults to true)</summary>
		public extern bool shim { get; set; }

		/// <summary>{String/Boolean} True to automatically create an {@link Ext.Shadow}, or a string indicating the</summary>
		public extern object shadow { get; set; }

		/// <summary> DomHelper object config to create element with (defaults to {tag: "div", cls: "x-layer"}).</summary>
		public extern object dh { get; set; }

		/// <summary> False to disable constrain to viewport (defaults to true)</summary>
		public extern bool constrain { get; set; }

		/// <summary> CSS class to add to the element</summary>
		public extern string cls { get; set; }

		/// <summary> Starting z-index (defaults to 11000)</summary>
		public extern double zindex { get; set; }

		/// <summary> Number of pixels to offset the shadow (defaults to 3)</summary>
		public extern double shadowOffset { get; set; }

	}
}
