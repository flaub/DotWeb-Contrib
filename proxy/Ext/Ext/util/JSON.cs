using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.util {
	/// <summary>
	///     /**
	///     Modified version of Douglas Crockford"s json.js that doesn"t
	///     mess with the Object prototype
	///     http://www.json.org/js.html
	///     */
	///     Ext.util.JSON = new (function(){
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\util\JSON.js</jssource>
	[JsObject]
	public class JSON  {

		/// <summary>Auto-generated default constructor</summary>
		/// <returns></returns>
		public extern JSON();

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static JSON prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }


		/// <summary>Encodes an Object, Array or other value</summary>
		/// <returns>String</returns>
		public extern static void encode();

		/// <summary>Encodes an Object, Array or other value</summary>
		/// <param name="o">The variable to encode</param>
		/// <returns>String</returns>
		public extern static void encode(object o);

		/// <summary>Decodes (parses) a JSON string to an object. If the JSON is invalid, this function throws a SyntaxError.</summary>
		/// <returns>Object</returns>
		public extern static void decode();

		/// <summary>Decodes (parses) a JSON string to an object. If the JSON is invalid, this function throws a SyntaxError.</summary>
		/// <param name="json">The JSON string</param>
		/// <returns>Object</returns>
		public extern static void decode(string json);



	}
}
