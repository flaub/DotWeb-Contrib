using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.data {
	/// <summary>
	///     /**
	///     Small helper class to make creating Stores for remotely-loaded JSON data easier. JsonStore is pre-configured
	///     with a built-in {@link Ext.data.HttpProxy} and {@link Ext.data.JsonReader}.  If you require some other proxy/reader
	///     combination then you'll have to create a basic {@link Ext.data.Store} configured as needed.<br/>
	///     <pre><code>
	///     var store = new Ext.data.JsonStore({
	///     url: 'get-images.php',
	///     root: 'images',
	///     fields: ['name', 'url', {name:'size', type: 'float'}, {name:'lastmod', type:'date'}]
	///     });
	///     </code></pre>
	///     This would consume a returned object of the form:
	///     <pre><code>
	///     {
	///     images: [
	///     {name: 'Image one', url:'/GetImage.php?id=1', size:46.5, lastmod: new Date(2007, 10, 29)},
	///     {name: 'Image Two', url:'/GetImage.php?id=2', size:43.2, lastmod: new Date(2007, 10, 30)}
	///     ]
	///     }
	///     </code></pre>
	///     An object literal of this form could also be used as the {@link #data} config option.
	///     <b>Note: Although they are not listed, this class inherits all of the config options of Store,
	///     JsonReader.</b>
	///     @cfg {String} url  The URL from which to load data through an HttpProxy. Either this
	///     option, or the {@link #data} option must be specified.
	///     @cfg {Object} data  A data object readable by this object's JsonReader. Either this
	///     option, or the {@link #url} option must be specified.
	///     @cfg {Array} fields  Either an Array of field definition objects as passed to
	///     {@link Ext.data.Record#create}, or a {@link Ext.data.Record Record} constructor created using {@link Ext.data.Record#create}.<br>
	///     <p>This config is used to create the <tt>recordType</tt> parameter to the {@link Ext.data.JsonReader#JsonReader JsonReader}
	///     constructor that is implicitly called, and creates the {@link Ext.data.Record Record definition} used by the Store.
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\data\JsonStore.js</jssource>
	public class JsonStore : Ext.data.Store {

		/// <summary></summary>
		/// <returns></returns>
		public extern JsonStore();
		/// <summary></summary>
		/// <param name="config"></param>
		/// <returns></returns>
		public extern JsonStore(object config);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static JsonStore prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.data.Store superclass { get; set; }




	}

	[JsAnonymous]
	public class JsonStoreConfig : System.DotWeb.JsDynamic {
		/// <summary> The URL from which to load data through an HttpProxy. Either this</summary>
		public extern string url { get; set; }

		/// <summary> A data object readable by this object's JsonReader. Either this</summary>
		public extern object data { get; set; }

		/// <summary> Either an Array of field definition objects as passed to</summary>
		public extern System.Array fields { get; set; }

		/// <summary> If passed, the id to use to register with the StoreMgr</summary>
		public extern string storeId { get; set; }

		/// <summary>{Boolean/Object} If passed, this store's load method is automatically called after creation with the autoLoad object</summary>
		public extern object autoLoad { get; set; }

		/// <summary> The Proxy object which provides access to a data object.</summary>
		public extern Ext.data.DataProxy proxy { get; set; }

		/// <summary> The DataReader object which processes the data object and returns an Array of Ext.data.Record objects which are cached keyed by their <em>id</em> property.</summary>
		public extern Ext.data.DataReader reader { get; set; }

		/// <summary> object containing properties which are to be sent as parameters.</p> <p>Parameters are encoded as standard HTTP parameters using {@link Ext#urlEncode}.</p> on any HTTP request</summary>
		public extern object baseParamsAn { get; set; }

		/// <summary> A config object in the format: {field: "fieldName", direction: "ASC|DESC"} to specify the sort order in the request of a remote Store's {@link #load} operation.  Note that for local sorting, the direction property is case-sensitive.</summary>
		public extern object sortInfo { get; set; }

		/// <summary> True if sorting is to be handled by requesting the Proxy to provide a refreshed version of the data object in sorted order, as opposed to sorting the Record cache in place (defaults to false). <p>If remote sorting is specified, then clicking on a column header causes the current page to be requested from the server with the addition of the following two parameters: <div class="mdetail-params"><ul> <li><b>sort</b> : String<p class="sub-desc">The name (as specified in the Record's Field definition) of the field to sort on.</p></li> <li><b>dir</b> : String<p class="sub-desc">The direction of the sort, "ASC" or "DESC" (case-sensitive).</p></li> </ul></div></p></summary>
		public extern bool remoteSort { get; set; }

		/// <summary> True to clear all modified record information each time the store is loaded or when a record is removed. (defaults to false).</summary>
		public extern bool pruneModifiedRecords { get; set; }

		/// <summary> (optional) A config object containing one or more event handlers to be added to this object during initialization.  This should be a valid listeners config object as specified in the {@link #addListener} example for attaching multiple handlers at once.</summary>
		public extern object listeners { get; set; }

	}
}
