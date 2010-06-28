using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.data {
	/// <summary>
	///     /**
	///     <p>This class encpasulates the field definition information specified in the field definition objects
	///     passed to {@link Ext.data.Record#create}.</p>
	///     <p>Developers do not need to instantiate this class. Instances are created by {@link Ext.data.Record.create}
	///     and cached in the {@link Ext.data.Record#fields fields} property of the created Record constructor's <b>prototype.</b></p>
	///     */
	///     Ext.data.Field = function(config){
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\data\DataField.js</jssource>
	[JsObject]
	public class Field  {

		/// <summary>Auto-generated default constructor</summary>
		/// <returns></returns>
		public extern Field();

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static Field prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>
		///     The name by which the field is referenced within the Record. This is referenced by,
		///     for example, the <em>dataIndex</em> property in column definition objects passed to {@link Ext.grid.ColumnModel}
		/// </summary>
		public extern string name { get; set; }

		/// <summary>
		///     (Optional) The data type for conversion to displayable value. Possible values are
		///     <div class="mdetail-params"><ul><li>auto (Default, implies no conversion)</li>
		///     <li>string</li>
		///     <li>int</li>
		///     <li>float</li>
		///     <li>boolean</li>
		///     <li>date</li></ul></div>
		/// </summary>
		public extern string type { get; set; }

		/// <summary>
		///     (Optional) A function which converts the value provided by the Reader into an object that will be stored
		///     in the Record. It is passed the following parameters:<ul>
		///     <li><b>v</b> : Mixed<div class="sub-desc">The data value as read by the Reader.</div></li>
		///     <li><b>rec</b> : Mixed<div class="sub-desc">The data object containing the row as read by the Reader.
		///     Depending on Reader type, this could be an Array, an object, or an XML element.</div></li>
		///     </ul>
		/// </summary>
		public extern Delegate convert { get; set; }

		/// <summary>
		///     (Optional) A format string for the {@link Date#parseDate Date.parseDate} function, or "timestamp" if the
		///     value provided by the Reader is a UNIX timestamp, or "time" if the value provided by the Reader is a
		///     javascript millisecond timestamp.
		/// </summary>
		public extern string dateFormat { get; set; }

		/// <summary>
		///     (Optional) The default value used <b>when a Record is being created by a
		///     {@link Ext.data.Reader Reader}</b> when the item referenced by the <b><tt>mapping</tt></b> does not exist in the data object
		///     (i.e. undefined). (defaults to "")
		/// </summary>
		public extern object defaultValue { get; set; }

		/// <summary>
		///     (Optional) A path specification for use by the {@link Ext.data.Reader} implementation
		///     that is creating the Record to access the data value from the data object. If an {@link Ext.data.JsonReader}
		///     is being used, then this is a string containing the javascript expression to reference the data relative to
		///     the Record item's root. If an {@link Ext.data.XmlReader} is being used, this is an {@link Ext.DomQuery} path
		///     to the data item relative to the Record element. If the mapping expression is the same as the field name,
		///     this may be omitted.
		/// </summary>
		public extern string mapping { get; set; }

		/// <summary>
		///     (Optional) A function which converts a Field's value to a comparable value in order to ensure correct
		///     sort ordering. Predefined functions are provided in {@link Ext.data.SortTypes}
		/// </summary>
		public extern Delegate sortType { get; set; }

		/// <summary>(Optional) Initial direction to sort. "ASC" or "DESC"</summary>
		public extern string sortDir { get; set; }




	}

	[JsAnonymous]
	public class FieldConfig : System.DotWeb.JsDynamic {
		/// <summary>  The name by which the field is referenced within the Record. This is referenced by, for example, the <em>dataIndex</em> property in column definition objects passed to {@link Ext.grid.ColumnModel}</summary>
		public extern string name { get; set; }

		/// <summary>  (Optional) The data type for conversion to displayable value. Possible values are <div class="mdetail-params"><ul><li>auto (Default, implies no conversion)</li> <li>string</li> <li>int</li> <li>float</li> <li>boolean</li> <li>date</li></ul></div></summary>
		public extern string type { get; set; }

		/// <summary>  (Optional) A function which converts the value provided by the Reader into an object that will be stored in the Record. It is passed the following parameters:<ul> <li><b>v</b> : Mixed<div class="sub-desc">The data value as read by the Reader.</div></li> <li><b>rec</b> : Mixed<div class="sub-desc">The data object containing the row as read by the Reader. Depending on Reader type, this could be an Array, an object, or an XML element.</div></li> </ul></summary>
		public extern Delegate convert { get; set; }

		/// <summary>  (Optional) A format string for the {@link Date#parseDate Date.parseDate} function, or "timestamp" if the value provided by the Reader is a UNIX timestamp, or "time" if the value provided by the Reader is a javascript millisecond timestamp.</summary>
		public extern string dateFormat { get; set; }

		/// <summary>  (Optional) The default value used <b>when a Record is being created by a {@link Ext.data.Reader Reader}</b> when the item referenced by the <b><tt>mapping</tt></b> does not exist in the data object (i.e. undefined). (defaults to "")</summary>
		public extern object defaultValue { get; set; }

		/// <summary>  (Optional) A path specification for use by the {@link Ext.data.Reader} implementation that is creating the Record to access the data value from the data object. If an {@link Ext.data.JsonReader} is being used, then this is a string containing the javascript expression to reference the data relative to the Record item's root. If an {@link Ext.data.XmlReader} is being used, this is an {@link Ext.DomQuery} path to the data item relative to the Record element. If the mapping expression is the same as the field name, this may be omitted.</summary>
		public extern string mapping { get; set; }

		/// <summary>  (Optional) A function which converts a Field's value to a comparable value in order to ensure correct sort ordering. Predefined functions are provided in {@link Ext.data.SortTypes}</summary>
		public extern Delegate sortType { get; set; }

		/// <summary>  (Optional) Initial direction to sort. "ASC" or "DESC"</summary>
		public extern string sortDir { get; set; }

	}
}
