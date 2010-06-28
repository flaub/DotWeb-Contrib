using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext {
	/// <summary>
	///     /**
	///     A simple utility class for generically masking elements while loading data.  If the {@link #store}
	///     config option is specified, the masking will be automatically synchronized with the store's loading
	///     process and the mask element will be cached for reuse.  For all other elements, this mask will replace the
	///     element's Updater load indicator and will be destroyed after the initial load.
	///     <p>Example usage:</p>
	///     <pre><code>
	///     // Basic mask:
	///     var myMask = new Ext.LoadMask(Ext.getBody(), {msg:"Please wait..."});
	///     myMask.show();
	///     </code></pre>
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.2\source\widgets\LoadMask.js</jssource>
	[JsObject]
	public class LoadMask  {

		/// <summary>Create a new LoadMask</summary>
		/// <returns></returns>
		public extern LoadMask();
		/// <summary>Create a new LoadMask</summary>
		/// <param name="el">The element or DOM node, or its id</param>
		/// <returns></returns>
		public extern LoadMask(object el);
		/// <summary>Create a new LoadMask</summary>
		/// <param name="el">The element or DOM node, or its id</param>
		/// <param name="config">The config object</param>
		/// <returns></returns>
		public extern LoadMask(object el, object config);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static LoadMask prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>
		///     Optional Store to which the mask is bound. The mask is displayed when a load request is issued, and
		///     hidden on either load sucess, or load fail.
		/// </summary>
		public extern Ext.data.Store store { get; set; }

		/// <summary>
		///     True to create a single-use mask that is automatically destroyed after loading (useful for page loads),
		///     False to persist the mask element reference for multiple uses (e.g., for paged data widgets).  Defaults to false.
		/// </summary>
		public extern bool removeMask { get; set; }

		/// <summary>The text to display in a centered loading message box (defaults to 'Loading...')</summary>
		public extern string msg { get; set; }

		/// <summary>The CSS class to apply to the loading message element (defaults to "x-mask-loading")</summary>
		public extern string msgCls { get; set; }

		/// <summary>Read-only. True if the mask is currently disabled so that it will not be displayed (defaults to false)</summary>
		public extern bool disabled { get; set; }


		/// <summary>Disables the mask to prevent it from being displayed</summary>
		/// <returns></returns>
		public extern virtual void disable();

		/// <summary>Enables the mask so that it can be displayed</summary>
		/// <returns></returns>
		public extern virtual void enable();

		/// <summary>Show this LoadMask over the configured Element.</summary>
		/// <returns></returns>
		public extern virtual void show();

		/// <summary>Hide this LoadMask.</summary>
		/// <returns></returns>
		public extern virtual void hide();



	}

	[JsAnonymous]
	public class LoadMaskConfig : System.DotWeb.JsDynamic {
		/// <summary>  Optional Store to which the mask is bound. The mask is displayed when a load request is issued, and hidden on either load sucess, or load fail.</summary>
		public extern Ext.data.Store store { get; set; }

		/// <summary>  True to create a single-use mask that is automatically destroyed after loading (useful for page loads), False to persist the mask element reference for multiple uses (e.g., for paged data widgets).  Defaults to false.</summary>
		public extern bool removeMask { get; set; }

		/// <summary>  The text to display in a centered loading message box (defaults to 'Loading...')</summary>
		public extern string msg { get; set; }

		/// <summary>  The CSS class to apply to the loading message element (defaults to "x-mask-loading")</summary>
		public extern string msgCls { get; set; }

	}
}
