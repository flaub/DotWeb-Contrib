using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.form.Action {
	/// <summary>
	///     /**
	///     <p>A class which handles submission of data from {@link Ext.form.BasicForm Form}s
	///     and processes the returned response.</p>
	///     <p>Instances of this class are only created by a {@link Ext.form.BasicForm Form} when
	///     {@link Ext.form.BasicForm#submit submit}ting.</p>
	///     <p>A response packet must contain a boolean <tt style="font-weight:bold">success</tt> property, and, optionally
	///     an <tt style="font-weight:bold">errors</tt> property. The <tt style="font-weight:bold">errors</tt> property contains error
	///     messages for invalid fields.</p>
	///     <p>By default, response packets are assumed to be JSON, so a typical response
	///     packet may look like this:</p><pre><code>
	///     {
	///     success: false,
	///     errors: {
	///     clientCode: "Client not found",
	///     portOfLoading: "This field must not be null"
	///     }
	///     }</code></pre>
	///     <p>Other data may be placed into the response for processing by the {@link Ext.form.BasicForm}'s callback
	///     or event handler methods. The object decoded from this JSON is available in the {@link #result} property.</p>
	///     <p>Alternatively, if an {@link #errorReader} is specified as an {@link Ext.data.XmlReader XmlReader}:</p><pre><code>
	///     errorReader: new Ext.data.XmlReader({
	///     record : 'field',
	///     success: '@success'
	///     }, [
	///     'id', 'msg'
	///     ]
	///     )
	///     </code></pre>
	///     <p>then the results may be sent back in XML format:</p><pre><code>
	///     &lt;?xml version="1.0" encoding="UTF-8"?&gt;
	///     &lt;message success="false"&gt;
	///     &lt;errors&gt;
	///     &lt;field&gt;
	///     &lt;id&gt;clientCode&lt;/id&gt;
	///     &lt;msg&gt;&lt;![CDATA[Code not found. &lt;br /&gt;&lt;i&gt;This is a test validation message from the server &lt;/i&gt;]]&gt;&lt;/msg&gt;
	///     &lt;/field&gt;
	///     &lt;field&gt;
	///     &lt;id&gt;portOfLoading&lt;/id&gt;
	///     &lt;msg&gt;&lt;![CDATA[Port not found. &lt;br /&gt;&lt;i&gt;This is a test validation message from the server &lt;/i&gt;]]&gt;&lt;/msg&gt;
	///     &lt;/field&gt;
	///     &lt;/errors&gt;
	///     &lt;/message&gt;
	///     </code></pre>
	///     <p>Other elements may be placed into the response XML for processing by the {@link Ext.form.BasicForm}'s callback
	///     or event handler methods. The XML document is available in the {@link #errorReader}'s {@link Ext.data.XmlReader#xmlData xmlData} property.</p>
	///     */
	///     Ext.form.Action.Submit = function(form, options){
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\form\Action.js</jssource>
	public class Submit : Ext.form.ActionClass {

		/// <summary>Auto-generated default constructor</summary>
		/// <returns></returns>
		public extern Submit();

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static Submit prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.form.ActionClass superclass { get; set; }

		/// <summary>
		///     <b>Optional. JSON is interpreted with no need for an errorReader.</b><p>A Reader which reads a single record from the returned data. The DataReader's <b>success</b> property specifies
		///     how submission success is determined. The Record's data provides the error messages to apply to any invalid form Fields.</p>.
		/// </summary>
		public extern Ext.data.DataReader errorReader { get; set; }

		/// <summary>
		///     Determines whether a Form's fields are validatedin a final call to {@link Ext.form.BasicForm#isValid isValid} prior to submission.
		///     Pass <tt>false</tt> in the Form's submit options to prevent this. If not defined, pre-submission field validation
		///     is performed.
		/// </summary>
		public extern bool clientValidation { get; set; }




	}

	[JsAnonymous]
	public class SubmitConfig : System.DotWeb.JsDynamic {
		/// <summary> <b>Optional. JSON is interpreted with no need for an errorReader.</b> <p>A Reader which reads a single record from the returned data. The DataReader's <b>success</b> property specifies how submission success is determined. The Record's data provides the error messages to apply to any invalid form Fields.</p>.</summary>
		public extern Ext.data.DataReader errorReader { get; set; }

		/// <summary> Determines whether a Form's fields are validated in a final call to {@link Ext.form.BasicForm#isValid isValid} prior to submission. Pass <tt>false</tt> in the Form's submit options to prevent this. If not defined, pre-submission field validation is performed.</summary>
		public extern bool clientValidation { get; set; }

		/// <summary> The URL that the Action is to invoke.</summary>
		public extern string url { get; set; }

		/// <summary> When set to <tt><b>true</b></tt>, causes the Form to be {@link Ext.form.BasicForm.reset reset} on Action success. If specified, this happens <b>before</b> the {@link #success} callback is called and before the Form's {@link Ext.form.BasicForm.actioncomplete actioncomplete} event fires.</summary>
		public extern bool reset { get; set; }

		/// <summary> The HTTP method to use to access the requested URL. Defaults to the {@link Ext.form.BasicForm}'s method, or if that is not specified, the underlying DOM form's method.</summary>
		public extern string method { get; set; }

		/// <summary> parameter values to pass. These are added to the Form's {@link Ext.form.BasicForm#baseParams} and passed to the specified URL along with the Form's input fields.</p> <p>Parameters are encoded as standard HTTP parameters using {@link Ext#urlEncode}.</p></summary>
		public extern object paramsExtra { get; set; }

		/// <summary> The number of milliseconds to wait for a server response before failing with the {@link #failureType} as {@link #Action.CONNECT_FAILURE}.</summary>
		public extern double timeout { get; set; }

		/// <summary> The function to call when a valid success return packet is recieved. The function is passed the following parameters:<ul class="mdetail-params"> <li><b>form</b> : Ext.form.BasicForm<div class="sub-desc">The form that requested the action</div></li> <li><b>action</b> : Ext.form.Action<div class="sub-desc">The Action class. The {@link #result} property of this object may be examined to perform custom postprocessing.</div></li> </ul></summary>
		public extern Delegate success { get; set; }

		/// <summary> The function to call when a failure packet was recieved, or when an error ocurred in the Ajax communication. The function is passed the following parameters:<ul class="mdetail-params"> <li><b>form</b> : Ext.form.BasicForm<div class="sub-desc">The form that requested the action</div></li> <li><b>action</b> : Ext.form.Action<div class="sub-desc">The Action class. If an Ajax error ocurred, the failure type will be in {@link #failureType}. The {@link #result} property of this object may be examined to perform custom postprocessing.</div></li> </ul></summary>
		public extern Delegate failure { get; set; }

		/// <summary> The scope in which to call the callback functions (The <tt>this</tt> reference for the callback functions).</summary>
		public extern object scope { get; set; }

		/// <summary> The message to be displayed by a call to {@link Ext.MessageBox#wait} during the time the action is being processed.</summary>
		public extern string waitMsg { get; set; }

		/// <summary> The title to be displayed by a call to {@link Ext.MessageBox#wait} during the time the action is being processed.</summary>
		public extern string waitTitle { get; set; }

	}
}
