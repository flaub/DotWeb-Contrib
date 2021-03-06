using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.form {
	/// <summary>
	///     /**
	///     <p>Encapsulates the DOM &lt;form> element at the heart of the {@link Ext.form.FormPanel FormPanel} class, and provides
	///     input field management, validation, submission, and form loading services.</p>
	///     <p>By default, Ext Forms are submitted through Ajax, using an instance of {@link Ext.form.Action.Submit}.
	///     To enable normal browser submission of an Ext Form, use the {@link #standardSubmit} config option.</p>
	///     <p><h2>File Uploads</h2>{@link #fileUpload File uploads} are not performed using Ajax submission, that
	///     is they are <b>not</b> performed using XMLHttpRequests. Instead the form is submitted in the standard
	///     manner with the DOM <tt>&lt;form></tt> element temporarily modified to have its
	///     <a href="http://www.w3.org/TR/REC-html40/present/frames.html#adef-target">target</a> set to refer
	///     to a dynamically generated, hidden <tt>&lt;iframe></tt> which is inserted into the document
	///     but removed after the return data has been gathered.</p>
	///     <p>The server response is parsed by the browser to create the document for the IFRAME. If the
	///     server is using JSON to send the return object, then the
	///     <a href="http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.17">Content-Type</a> header
	///     must be set to "text/html" in order to tell the browser to insert the text unchanged into the document body.</p>
	///     <p>Characters which are significant to an HTML parser must be sent as HTML entities, so encode
	///     "&lt;" as "&amp;lt;", "&amp;" as "&amp;amp;" etc.</p>
	///     <p>The response text is retrieved from the document, and a fake XMLHttpRequest object
	///     is created containing a <tt>responseText</tt> property in order to conform to the
	///     requirements of event handlers and callbacks.</p>
	///     <p>Be aware that file upload packets are sent with the content type <a href="http://www.faqs.org/rfcs/rfc2388.html">multipart/form</a>
	///     and some server technologies (notably JEE) may require some custom processing in order to
	///     retrieve parameter names and parameter values from the packet content.</p>
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\form\BasicForm.js</jssource>
	public class BasicForm : Ext.util.Observable {

		/// <summary></summary>
		/// <returns></returns>
		public extern BasicForm();
		/// <summary></summary>
		/// <param name="el">The form element or its id</param>
		/// <returns></returns>
		public extern BasicForm(object el);
		/// <summary></summary>
		/// <param name="el">The form element or its id</param>
		/// <param name="config">Configuration options</param>
		/// <returns></returns>
		public extern BasicForm(object el, object config);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static BasicForm prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.util.Observable superclass { get; set; }

		/// <summary>The request method to use (GET or POST) for form actions if one isn't supplied in the action options.</summary>
		public extern string method { get; set; }

		/// <summary>
		///     An Ext.data.DataReader (e.g. {@link Ext.data.XmlReader}) to be used to read data when executing "load" actions.
		///     This is optional as there is built-in support for processing JSON.
		/// </summary>
		public extern Ext.data.DataReader reader { get; set; }

		/// <summary>
		///     <p>An Ext.data.DataReader (e.g. {@link Ext.data.XmlReader}) to be used to read field error messages returned from "submit" actions.
		///     This is completely optional as there is built-in support for processing JSON.</p>
		///     <p>The Records which provide messages for the invalid Fields must use the Field name (or id) as the Record ID,
		///     and must contain a field called "msg" which contains the error message.</p>
		///     <p>The errorReader does not have to be a full-blown implementation of a DataReader. It simply needs to implement a
		///     <tt>read(xhr)</tt> function which returns an Array of Records in an object with the following structure:<pre><code>
		///     {
		///     records: recordArray
		///     }
		///     </code></pre>
		/// </summary>
		public extern Ext.data.DataReader errorReader { get; set; }

		/// <summary>The URL to use for form actions if one isn't supplied in the action options.</summary>
		public extern string url { get; set; }

		/// <summary>
		///     Set to true if this form is a file upload.
		///     <p>File uploads are not performed using normal "Ajax" techniques, that is they are <b>not</b>
		///     performed using XMLHttpRequests. Instead the form is submitted in the standard manner with the
		///     DOM <tt>&lt;form></tt> element temporarily modified to have its
		///     <a href="http://www.w3.org/TR/REC-html40/present/frames.html#adef-target">target</a> set to refer
		///     to a dynamically generated, hidden <tt>&lt;iframe></tt> which is inserted into the document
		///     but removed after the return data has been gathered.</p>
		///     <p>The server response is parsed by the browser to create the document for the IFRAME. If the
		///     server is using JSON to send the return object, then the
		///     <a href="http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.17">Content-Type</a> header
		///     must be set to "text/html" in order to tell the browser to insert the text unchanged into the document body.</p>
		///     <p>Characters which are significant to an HTML parser must be sent as HTML entities, so encode
		///     "&lt;" as "&amp;lt;", "&amp;" as "&amp;amp;" etc.</p>
		///     <p>The response text is retrieved from the document, and a fake XMLHttpRequest object
		///     is created containing a <tt>responseText</tt> property in order to conform to the
		///     requirements of event handlers and callbacks.</p>
		///     <p>Be aware that file upload packets are sent with the content type <a href="http://www.faqs.org/rfcs/rfc2388.html">multipart/form</a>
		///     and some server technologies (notably JEE) may require some custom processing in order to
		///     retrieve parameter names and parameter values from the packet content.</p>
		/// </summary>
		public extern bool fileUpload { get; set; }

		/// <summary>
		///     <p>Parameters to pass with all requests. e.g. baseParams: {id: '123', foo: 'bar'}.</p>
		///     <p>Parameters are encoded as standard HTTP parameters using {@link Ext#urlEncode}.</p>
		/// </summary>
		public extern object baseParams { get; set; }

		/// <summary>Timeout for form actions in seconds (default is 30 seconds).</summary>
		public extern double timeout { get; set; }

		/// <summary>If set to true, form.reset() resets to the last loadedor setValues() data instead of when the form was first created.</summary>
		public extern bool trackResetOnLoad { get; set; }

		/// <summary>
		///     If set to true, standard HTML form submits are used instead of XHR (Ajax) styleform submissions. (defaults to false)<br>
		///     <p><b>Note:</b> When using standardSubmit, any the options to {@link #submit} are
		///     ignored because Ext's Ajax infrastracture is bypassed. To pass extra parameters, you will need to create
		///     hidden fields within the form.</p>
		/// </summary>
		public extern bool standardSubmit { get; set; }

		/// <summary>
		///     By default wait messages are displayed with Ext.MessageBox.wait. You can target a specific
		///     element by passing it or its id or mask the form itself by passing in true.
		/// </summary>
		public extern object waitMsgTarget { get; set; }


		/// <summary>Get the HTML form Element</summary>
		/// <returns>Ext.Element</returns>
		public extern virtual void getEl();

		/// <summary>Returns true if client-side validation on the form is successful.</summary>
		/// <returns>Boolean</returns>
		public extern virtual void isValid();

		/// <summary>
		///     <p>Returns true if any fields in this form have changed from their original values.</p>
		///     <p>Note that if this BasicForm was configured with {@link #trackResetOnLoad}
		///     then the Fields' <i>original values</i> are updated when the values are loaded by {@link #setValues}.</p>
		/// </summary>
		/// <returns>Boolean</returns>
		public extern virtual void isDirty();

		/// <summary>
		///     Performs a predefined action ({@link Ext.form.Action.Submit} or
		///     {@link Ext.form.Action.Load}) or a custom extension of {@link Ext.form.Action}
		///     to perform application-specific processing.
		///     or instance of {@link Ext.form.Action} to perform.
		///     All of the config options listed below are supported by both the submit
		///     and load actions unless otherwise noted (custom actions could also accept
		///     other config options):<ul>
		///     <li><b>url</b> : String<p style="margin-left:1em">The url for the action (defaults
		///     to the form's url.)</p></li>
		///     <li><b>method</b> : String<p style="margin-left:1em">The form method to use (defaults
		///     to the form's method, or POST if not defined)</p></li>
		///     <li><b>params</b> : String/Object<p style="margin-left:1em">The params to pass
		///     (defaults to the form's baseParams, or none if not defined)</p>
		///     <p>Parameters are encoded as standard HTTP parameters using {@link Ext#urlEncode}.</p></li>
		///     <li><b>headers</b> : Object<p style="margin-left:1em">Request headers to set for the action
		///     (defaults to the form's default headers)</p></li>
		///     <li><b>success</b> : Function<p style="margin-left:1em">The callback that will
		///     be invoked after a successful response.  The function is passed the following parameters:<ul>
		///     <li><code>form</code> : Ext.form.BasicForm<div class="sub-desc">The form that requested the action</div></li>
		///     <li><code>action</code> : Ext.form.Action<div class="sub-desc">The {@link Ext.form.Action Action} object which performed the operation. The {@link Ext.form.Action#result result}
		///     property of this object may be examined to perform custom postprocessing.</div></li>
		///     </ul></p></li>
		///     <li><b>failure</b> : Function<p style="margin-left:1em">The callback that will
		///     be invoked after a failed transaction attempt.  The function
		///     is passed the following parameters:<ul>
		///     <li><code>form</code> : Ext.form.BasicForm<div class="sub-desc">The form that requested the action</div></li>
		///     <li><code>action</code> : Ext.form.Action<div class="sub-desc">The {@link Ext.form.Action Action} object which performed the operation. If an Ajax
		///     error ocurred, the failure type will be in {@link Ext.form.Action#failureType failureType}. The {@link Ext.form.Action#result result}
		///     property of this object may be examined to perform custom postprocessing.</div></li>
		///     </ul></p></li>
		///     <li><b>scope</b> : Object<p style="margin-left:1em">The scope in which to call the
		///     callback functions (The <tt>this</tt> reference for the callback functions).</p></li>
		///     <li><b>clientValidation</b> : Boolean<p style="margin-left:1em">Submit Action only.
		///     Determines whether a Form's fields are validated in a final call to
		///     {@link Ext.form.BasicForm#isValid isValid} prior to submission. Set to <tt>false</tt>
		///     to prevent this. If undefined, pre-submission field validation is performed.</p></li></ul>
		/// </summary>
		/// <returns>BasicForm</returns>
		public extern virtual void doAction();

		/// <summary>
		///     Performs a predefined action ({@link Ext.form.Action.Submit} or
		///     {@link Ext.form.Action.Load}) or a custom extension of {@link Ext.form.Action}
		///     to perform application-specific processing.
		///     or instance of {@link Ext.form.Action} to perform.
		///     All of the config options listed below are supported by both the submit
		///     and load actions unless otherwise noted (custom actions could also accept
		///     other config options):<ul>
		///     <li><b>url</b> : String<p style="margin-left:1em">The url for the action (defaults
		///     to the form's url.)</p></li>
		///     <li><b>method</b> : String<p style="margin-left:1em">The form method to use (defaults
		///     to the form's method, or POST if not defined)</p></li>
		///     <li><b>params</b> : String/Object<p style="margin-left:1em">The params to pass
		///     (defaults to the form's baseParams, or none if not defined)</p>
		///     <p>Parameters are encoded as standard HTTP parameters using {@link Ext#urlEncode}.</p></li>
		///     <li><b>headers</b> : Object<p style="margin-left:1em">Request headers to set for the action
		///     (defaults to the form's default headers)</p></li>
		///     <li><b>success</b> : Function<p style="margin-left:1em">The callback that will
		///     be invoked after a successful response.  The function is passed the following parameters:<ul>
		///     <li><code>form</code> : Ext.form.BasicForm<div class="sub-desc">The form that requested the action</div></li>
		///     <li><code>action</code> : Ext.form.Action<div class="sub-desc">The {@link Ext.form.Action Action} object which performed the operation. The {@link Ext.form.Action#result result}
		///     property of this object may be examined to perform custom postprocessing.</div></li>
		///     </ul></p></li>
		///     <li><b>failure</b> : Function<p style="margin-left:1em">The callback that will
		///     be invoked after a failed transaction attempt.  The function
		///     is passed the following parameters:<ul>
		///     <li><code>form</code> : Ext.form.BasicForm<div class="sub-desc">The form that requested the action</div></li>
		///     <li><code>action</code> : Ext.form.Action<div class="sub-desc">The {@link Ext.form.Action Action} object which performed the operation. If an Ajax
		///     error ocurred, the failure type will be in {@link Ext.form.Action#failureType failureType}. The {@link Ext.form.Action#result result}
		///     property of this object may be examined to perform custom postprocessing.</div></li>
		///     </ul></p></li>
		///     <li><b>scope</b> : Object<p style="margin-left:1em">The scope in which to call the
		///     callback functions (The <tt>this</tt> reference for the callback functions).</p></li>
		///     <li><b>clientValidation</b> : Boolean<p style="margin-left:1em">Submit Action only.
		///     Determines whether a Form's fields are validated in a final call to
		///     {@link Ext.form.BasicForm#isValid isValid} prior to submission. Set to <tt>false</tt>
		///     to prevent this. If undefined, pre-submission field validation is performed.</p></li></ul>
		/// </summary>
		/// <param name="actionName">The name of the predefined action type,</param>
		/// <returns>BasicForm</returns>
		public extern virtual void doAction(string actionName);

		/// <summary>
		///     Performs a predefined action ({@link Ext.form.Action.Submit} or
		///     {@link Ext.form.Action.Load}) or a custom extension of {@link Ext.form.Action}
		///     to perform application-specific processing.
		///     or instance of {@link Ext.form.Action} to perform.
		///     All of the config options listed below are supported by both the submit
		///     and load actions unless otherwise noted (custom actions could also accept
		///     other config options):<ul>
		///     <li><b>url</b> : String<p style="margin-left:1em">The url for the action (defaults
		///     to the form's url.)</p></li>
		///     <li><b>method</b> : String<p style="margin-left:1em">The form method to use (defaults
		///     to the form's method, or POST if not defined)</p></li>
		///     <li><b>params</b> : String/Object<p style="margin-left:1em">The params to pass
		///     (defaults to the form's baseParams, or none if not defined)</p>
		///     <p>Parameters are encoded as standard HTTP parameters using {@link Ext#urlEncode}.</p></li>
		///     <li><b>headers</b> : Object<p style="margin-left:1em">Request headers to set for the action
		///     (defaults to the form's default headers)</p></li>
		///     <li><b>success</b> : Function<p style="margin-left:1em">The callback that will
		///     be invoked after a successful response.  The function is passed the following parameters:<ul>
		///     <li><code>form</code> : Ext.form.BasicForm<div class="sub-desc">The form that requested the action</div></li>
		///     <li><code>action</code> : Ext.form.Action<div class="sub-desc">The {@link Ext.form.Action Action} object which performed the operation. The {@link Ext.form.Action#result result}
		///     property of this object may be examined to perform custom postprocessing.</div></li>
		///     </ul></p></li>
		///     <li><b>failure</b> : Function<p style="margin-left:1em">The callback that will
		///     be invoked after a failed transaction attempt.  The function
		///     is passed the following parameters:<ul>
		///     <li><code>form</code> : Ext.form.BasicForm<div class="sub-desc">The form that requested the action</div></li>
		///     <li><code>action</code> : Ext.form.Action<div class="sub-desc">The {@link Ext.form.Action Action} object which performed the operation. If an Ajax
		///     error ocurred, the failure type will be in {@link Ext.form.Action#failureType failureType}. The {@link Ext.form.Action#result result}
		///     property of this object may be examined to perform custom postprocessing.</div></li>
		///     </ul></p></li>
		///     <li><b>scope</b> : Object<p style="margin-left:1em">The scope in which to call the
		///     callback functions (The <tt>this</tt> reference for the callback functions).</p></li>
		///     <li><b>clientValidation</b> : Boolean<p style="margin-left:1em">Submit Action only.
		///     Determines whether a Form's fields are validated in a final call to
		///     {@link Ext.form.BasicForm#isValid isValid} prior to submission. Set to <tt>false</tt>
		///     to prevent this. If undefined, pre-submission field validation is performed.</p></li></ul>
		/// </summary>
		/// <param name="actionName">The name of the predefined action type,</param>
		/// <param name="options">(optional) The options to pass to the {@link Ext.form.Action}.</param>
		/// <returns>BasicForm</returns>
		public extern virtual void doAction(string actionName, object options);

		/// <summary>
		///     Performs a predefined action ({@link Ext.form.Action.Submit} or
		///     {@link Ext.form.Action.Load}) or a custom extension of {@link Ext.form.Action}
		///     to perform application-specific processing.
		///     or instance of {@link Ext.form.Action} to perform.
		///     All of the config options listed below are supported by both the submit
		///     and load actions unless otherwise noted (custom actions could also accept
		///     other config options):<ul>
		///     <li><b>url</b> : String<p style="margin-left:1em">The url for the action (defaults
		///     to the form's url.)</p></li>
		///     <li><b>method</b> : String<p style="margin-left:1em">The form method to use (defaults
		///     to the form's method, or POST if not defined)</p></li>
		///     <li><b>params</b> : String/Object<p style="margin-left:1em">The params to pass
		///     (defaults to the form's baseParams, or none if not defined)</p>
		///     <p>Parameters are encoded as standard HTTP parameters using {@link Ext#urlEncode}.</p></li>
		///     <li><b>headers</b> : Object<p style="margin-left:1em">Request headers to set for the action
		///     (defaults to the form's default headers)</p></li>
		///     <li><b>success</b> : Function<p style="margin-left:1em">The callback that will
		///     be invoked after a successful response.  The function is passed the following parameters:<ul>
		///     <li><code>form</code> : Ext.form.BasicForm<div class="sub-desc">The form that requested the action</div></li>
		///     <li><code>action</code> : Ext.form.Action<div class="sub-desc">The {@link Ext.form.Action Action} object which performed the operation. The {@link Ext.form.Action#result result}
		///     property of this object may be examined to perform custom postprocessing.</div></li>
		///     </ul></p></li>
		///     <li><b>failure</b> : Function<p style="margin-left:1em">The callback that will
		///     be invoked after a failed transaction attempt.  The function
		///     is passed the following parameters:<ul>
		///     <li><code>form</code> : Ext.form.BasicForm<div class="sub-desc">The form that requested the action</div></li>
		///     <li><code>action</code> : Ext.form.Action<div class="sub-desc">The {@link Ext.form.Action Action} object which performed the operation. If an Ajax
		///     error ocurred, the failure type will be in {@link Ext.form.Action#failureType failureType}. The {@link Ext.form.Action#result result}
		///     property of this object may be examined to perform custom postprocessing.</div></li>
		///     </ul></p></li>
		///     <li><b>scope</b> : Object<p style="margin-left:1em">The scope in which to call the
		///     callback functions (The <tt>this</tt> reference for the callback functions).</p></li>
		///     <li><b>clientValidation</b> : Boolean<p style="margin-left:1em">Submit Action only.
		///     Determines whether a Form's fields are validated in a final call to
		///     {@link Ext.form.BasicForm#isValid isValid} prior to submission. Set to <tt>false</tt>
		///     to prevent this. If undefined, pre-submission field validation is performed.</p></li></ul>
		/// </summary>
		/// <param name="actionName">The name of the predefined action type,</param>
		/// <returns>BasicForm</returns>
		public extern virtual void doAction(object actionName);

		/// <summary>
		///     Performs a predefined action ({@link Ext.form.Action.Submit} or
		///     {@link Ext.form.Action.Load}) or a custom extension of {@link Ext.form.Action}
		///     to perform application-specific processing.
		///     or instance of {@link Ext.form.Action} to perform.
		///     All of the config options listed below are supported by both the submit
		///     and load actions unless otherwise noted (custom actions could also accept
		///     other config options):<ul>
		///     <li><b>url</b> : String<p style="margin-left:1em">The url for the action (defaults
		///     to the form's url.)</p></li>
		///     <li><b>method</b> : String<p style="margin-left:1em">The form method to use (defaults
		///     to the form's method, or POST if not defined)</p></li>
		///     <li><b>params</b> : String/Object<p style="margin-left:1em">The params to pass
		///     (defaults to the form's baseParams, or none if not defined)</p>
		///     <p>Parameters are encoded as standard HTTP parameters using {@link Ext#urlEncode}.</p></li>
		///     <li><b>headers</b> : Object<p style="margin-left:1em">Request headers to set for the action
		///     (defaults to the form's default headers)</p></li>
		///     <li><b>success</b> : Function<p style="margin-left:1em">The callback that will
		///     be invoked after a successful response.  The function is passed the following parameters:<ul>
		///     <li><code>form</code> : Ext.form.BasicForm<div class="sub-desc">The form that requested the action</div></li>
		///     <li><code>action</code> : Ext.form.Action<div class="sub-desc">The {@link Ext.form.Action Action} object which performed the operation. The {@link Ext.form.Action#result result}
		///     property of this object may be examined to perform custom postprocessing.</div></li>
		///     </ul></p></li>
		///     <li><b>failure</b> : Function<p style="margin-left:1em">The callback that will
		///     be invoked after a failed transaction attempt.  The function
		///     is passed the following parameters:<ul>
		///     <li><code>form</code> : Ext.form.BasicForm<div class="sub-desc">The form that requested the action</div></li>
		///     <li><code>action</code> : Ext.form.Action<div class="sub-desc">The {@link Ext.form.Action Action} object which performed the operation. If an Ajax
		///     error ocurred, the failure type will be in {@link Ext.form.Action#failureType failureType}. The {@link Ext.form.Action#result result}
		///     property of this object may be examined to perform custom postprocessing.</div></li>
		///     </ul></p></li>
		///     <li><b>scope</b> : Object<p style="margin-left:1em">The scope in which to call the
		///     callback functions (The <tt>this</tt> reference for the callback functions).</p></li>
		///     <li><b>clientValidation</b> : Boolean<p style="margin-left:1em">Submit Action only.
		///     Determines whether a Form's fields are validated in a final call to
		///     {@link Ext.form.BasicForm#isValid isValid} prior to submission. Set to <tt>false</tt>
		///     to prevent this. If undefined, pre-submission field validation is performed.</p></li></ul>
		/// </summary>
		/// <param name="actionName">The name of the predefined action type,</param>
		/// <param name="options">(optional) The options to pass to the {@link Ext.form.Action}.</param>
		/// <returns>BasicForm</returns>
		public extern virtual void doAction(object actionName, object options);

		/// <summary>
		///     Shortcut to do a submit action.
		///     <p><b>Note:</b> this is ignored when using the {@link #standardSubmit} option.</p>
		///     <p>The following code:</p><pre><code>
		///     myFormPanel.getForm().submit({
		///     clientValidation: true,
		///     url: 'updateConsignment.php',
		///     params: {
		///     newStatus: 'delivered'
		///     },
		///     success: function(form, action) {
		///     Ext.Msg.alert("Success", action.result.msg);
		///     },
		///     failure: function(form, action) {
		///     switch (action.failureType) {
		///     case Ext.form.Action.CLIENT_INVALID:
		///     Ext.Msg.alert("Failure", "Form fields may not be submitted with invalid values");
		///     break;
		///     case Ext.form.Action.CONNECT_FAILURE:
		///     Ext.Msg.alert("Failure", "Ajax communication failed");
		///     break;
		///     case Ext.form.Action.SERVER_INVALID:
		///     Ext.Msg.alert("Failure", action.result.msg);
		///     }
		///     }
		///     });
		///     </code></pre>
		///     would process the following server response for a successful submission:<pre><code>
		///     {
		///     success: true,
		///     msg: 'Consignment updated'
		///     }
		///     </code></pre>
		///     and the following server response for a failed submission:<pre><code>
		///     {
		///     success: false,
		///     msg: 'You do not have permission to perform this operation'
		///     }
		///     </code></pre>
		/// </summary>
		/// <returns>BasicForm</returns>
		public extern virtual void submit();

		/// <summary>
		///     Shortcut to do a submit action.
		///     <p><b>Note:</b> this is ignored when using the {@link #standardSubmit} option.</p>
		///     <p>The following code:</p><pre><code>
		///     myFormPanel.getForm().submit({
		///     clientValidation: true,
		///     url: 'updateConsignment.php',
		///     params: {
		///     newStatus: 'delivered'
		///     },
		///     success: function(form, action) {
		///     Ext.Msg.alert("Success", action.result.msg);
		///     },
		///     failure: function(form, action) {
		///     switch (action.failureType) {
		///     case Ext.form.Action.CLIENT_INVALID:
		///     Ext.Msg.alert("Failure", "Form fields may not be submitted with invalid values");
		///     break;
		///     case Ext.form.Action.CONNECT_FAILURE:
		///     Ext.Msg.alert("Failure", "Ajax communication failed");
		///     break;
		///     case Ext.form.Action.SERVER_INVALID:
		///     Ext.Msg.alert("Failure", action.result.msg);
		///     }
		///     }
		///     });
		///     </code></pre>
		///     would process the following server response for a successful submission:<pre><code>
		///     {
		///     success: true,
		///     msg: 'Consignment updated'
		///     }
		///     </code></pre>
		///     and the following server response for a failed submission:<pre><code>
		///     {
		///     success: false,
		///     msg: 'You do not have permission to perform this operation'
		///     }
		///     </code></pre>
		/// </summary>
		/// <param name="options">The options to pass to the action (see {@link #doAction} for details).<br></param>
		/// <returns>BasicForm</returns>
		public extern virtual void submit(object options);

		/// <summary>Shortcut to do a load action.</summary>
		/// <returns>BasicForm</returns>
		public extern virtual void load();

		/// <summary>Shortcut to do a load action.</summary>
		/// <param name="options">The options to pass to the action (see {@link #doAction} for details)</param>
		/// <returns>BasicForm</returns>
		public extern virtual void load(object options);

		/// <summary>Persists the values in this form into the passed Ext.data.Record object in a beginEdit/endEdit block.</summary>
		/// <returns>BasicForm</returns>
		public extern virtual void updateRecord();

		/// <summary>Persists the values in this form into the passed Ext.data.Record object in a beginEdit/endEdit block.</summary>
		/// <param name="record">The record to edit</param>
		/// <returns>BasicForm</returns>
		public extern virtual void updateRecord(Ext.data.Record record);

		/// <summary>Loads an Ext.data.Record into this form.</summary>
		/// <returns>BasicForm</returns>
		public extern virtual void loadRecord();

		/// <summary>Loads an Ext.data.Record into this form.</summary>
		/// <param name="record">The record to load</param>
		/// <returns>BasicForm</returns>
		public extern virtual void loadRecord(Ext.data.Record record);

		/// <summary>Find a Ext.form.Field in this form by id, dataIndex, name or hiddenName.</summary>
		/// <returns>Field</returns>
		public extern virtual void findField();

		/// <summary>Find a Ext.form.Field in this form by id, dataIndex, name or hiddenName.</summary>
		/// <param name="id">The value to search for</param>
		/// <returns>Field</returns>
		public extern virtual void findField(string id);

		/// <summary>Mark fields in this form invalid in bulk.</summary>
		/// <returns>BasicForm</returns>
		public extern virtual void markInvalid();

		/// <summary>Mark fields in this form invalid in bulk.</summary>
		/// <param name="errors">Either an array in the form [{id:'fieldId', msg:'The message'},...] or an object hash of {id: msg, id2: msg2}</param>
		/// <returns>BasicForm</returns>
		public extern virtual void markInvalid(System.Array errors);

		/// <summary>Mark fields in this form invalid in bulk.</summary>
		/// <param name="errors">Either an array in the form [{id:'fieldId', msg:'The message'},...] or an object hash of {id: msg, id2: msg2}</param>
		/// <returns>BasicForm</returns>
		public extern virtual void markInvalid(object errors);

		/// <summary>
		///     Set values for fields in this form in bulk.
		///     [{id:'clientName', value:'Fred. Olsen Lines'},
		///     {id:'portOfLoading', value:'FXT'},
		///     {id:'portOfDischarge', value:'OSL'} ]</pre></code><br><br>
		///     or an object hash of the form:<br><br><code><pre>
		///     {
		///     clientName: 'Fred. Olsen Lines',
		///     portOfLoading: 'FXT',
		///     portOfDischarge: 'OSL'
		///     }</pre></code><br>
		/// </summary>
		/// <returns>BasicForm</returns>
		public extern virtual void setValues();

		/// <summary>
		///     Set values for fields in this form in bulk.
		///     [{id:'clientName', value:'Fred. Olsen Lines'},
		///     {id:'portOfLoading', value:'FXT'},
		///     {id:'portOfDischarge', value:'OSL'} ]</pre></code><br><br>
		///     or an object hash of the form:<br><br><code><pre>
		///     {
		///     clientName: 'Fred. Olsen Lines',
		///     portOfLoading: 'FXT',
		///     portOfDischarge: 'OSL'
		///     }</pre></code><br>
		/// </summary>
		/// <param name="values">Either an array in the form:<br><br><code><pre></param>
		/// <returns>BasicForm</returns>
		public extern virtual void setValues(System.Array values);

		/// <summary>
		///     Set values for fields in this form in bulk.
		///     [{id:'clientName', value:'Fred. Olsen Lines'},
		///     {id:'portOfLoading', value:'FXT'},
		///     {id:'portOfDischarge', value:'OSL'} ]</pre></code><br><br>
		///     or an object hash of the form:<br><br><code><pre>
		///     {
		///     clientName: 'Fred. Olsen Lines',
		///     portOfLoading: 'FXT',
		///     portOfDischarge: 'OSL'
		///     }</pre></code><br>
		/// </summary>
		/// <param name="values">Either an array in the form:<br><br><code><pre></param>
		/// <returns>BasicForm</returns>
		public extern virtual void setValues(object values);

		/// <summary>
		///     <p>Returns the fields in this form as an object with key/value pairs as they would be submitted using a standard form submit.
		///     If multiple fields exist with the same name they are returned as an array.</p>
		///     <p><b>Note:</b> The values are collected from all enabled HTML input elements within the form, <u>not</u> from
		///     the Ext Field objects. This means that all returned values are Strings (or Arrays of Strings) and that the the
		///     value can potentionally be the emptyText of a field.</p>
		/// </summary>
		/// <returns>String/Object</returns>
		public extern virtual void getValues();

		/// <summary>
		///     <p>Returns the fields in this form as an object with key/value pairs as they would be submitted using a standard form submit.
		///     If multiple fields exist with the same name they are returned as an array.</p>
		///     <p><b>Note:</b> The values are collected from all enabled HTML input elements within the form, <u>not</u> from
		///     the Ext Field objects. This means that all returned values are Strings (or Arrays of Strings) and that the the
		///     value can potentionally be the emptyText of a field.</p>
		/// </summary>
		/// <param name="asString">(optional) Pass true to return the values as a string. (defaults to false, returning an Object)</param>
		/// <returns>String/Object</returns>
		public extern virtual void getValues(bool asString);

		/// <summary>Clears all invalid messages in this form.</summary>
		/// <returns>BasicForm</returns>
		public extern virtual void clearInvalid();

		/// <summary>Resets this form.</summary>
		/// <returns>BasicForm</returns>
		public extern virtual void reset();

		/// <summary>
		///     Add Ext.form Components to this form's Collection. This does not result in rendering of
		///     the passed Component, it just enables the form to validate Fields, and distribute values to
		///     Fields.
		///     <p><b>You will not usually call this function. In order to be rendered, a Field must be added
		///     to a {@link Ext.Container Container}, usually an {@link Ext.form.FormPanel FormPanel}.
		///     The FormPanel to which the field is added takes care of adding the Field to the BasicForm's
		///     collection.</b></p>
		/// </summary>
		/// <returns>BasicForm</returns>
		public extern virtual void add();

		/// <summary>
		///     Add Ext.form Components to this form's Collection. This does not result in rendering of
		///     the passed Component, it just enables the form to validate Fields, and distribute values to
		///     Fields.
		///     <p><b>You will not usually call this function. In order to be rendered, a Field must be added
		///     to a {@link Ext.Container Container}, usually an {@link Ext.form.FormPanel FormPanel}.
		///     The FormPanel to which the field is added takes care of adding the Field to the BasicForm's
		///     collection.</b></p>
		/// </summary>
		/// <param name="args">(optional)</param>
		/// <returns>BasicForm</returns>
		public extern virtual void add(params Field[] args);

		/// <summary>Removes a field from the items collection (does NOT remove its markup).</summary>
		/// <returns>BasicForm</returns>
		public extern virtual void remove();

		/// <summary>Removes a field from the items collection (does NOT remove its markup).</summary>
		/// <param name="field"></param>
		/// <returns>BasicForm</returns>
		public extern virtual void remove(Field field);

		/// <summary>
		///     Iterates through the {@link Ext.form.Field Field}s which have been {@link #add add}ed to this BasicForm,
		///     checks them for an id attribute, and calls {@link Ext.form.Field#applyToMarkup} on the existing dom element with that id.
		/// </summary>
		/// <returns>BasicForm</returns>
		public extern virtual void render();

		/// <summary>Calls {@link Ext#apply} for all fields in this form with the passed object.</summary>
		/// <returns>BasicForm</returns>
		public extern virtual void applyToFields();

		/// <summary>Calls {@link Ext#apply} for all fields in this form with the passed object.</summary>
		/// <param name="values"></param>
		/// <returns>BasicForm</returns>
		public extern virtual void applyToFields(object values);

		/// <summary>Calls {@link Ext#applyIf} for all field in this form with the passed object.</summary>
		/// <returns>BasicForm</returns>
		public extern virtual void applyIfToFields();

		/// <summary>Calls {@link Ext#applyIf} for all field in this form with the passed object.</summary>
		/// <param name="values"></param>
		/// <returns>BasicForm</returns>
		public extern virtual void applyIfToFields(object values);



	}

	[JsAnonymous]
	public class BasicFormConfig : System.DotWeb.JsDynamic {
		/// <summary>  The request method to use (GET or POST) for form actions if one isn't supplied in the action options.</summary>
		public extern string method { get; set; }

		/// <summary>  An Ext.data.DataReader (e.g. {@link Ext.data.XmlReader}) to be used to read data when executing "load" actions. This is optional as there is built-in support for processing JSON.</summary>
		public extern Ext.data.DataReader reader { get; set; }

		/// <summary>  <p>An Ext.data.DataReader (e.g. {@link Ext.data.XmlReader}) to be used to read field error messages returned from "submit" actions. This is completely optional as there is built-in support for processing JSON.</p> <p>The Records which provide messages for the invalid Fields must use the Field name (or id) as the Record ID, and must contain a field called "msg" which contains the error message.</p> <p>The errorReader does not have to be a full-blown implementation of a DataReader. It simply needs to implement a <tt>read(xhr)</tt> function which returns an Array of Records in an object with the following structure:<pre><code> { records: recordArray } </code></pre></summary>
		public extern Ext.data.DataReader errorReader { get; set; }

		/// <summary>  The URL to use for form actions if one isn't supplied in the action options.</summary>
		public extern string url { get; set; }

		/// <summary>  Set to true if this form is a file upload. <p>File uploads are not performed using normal "Ajax" techniques, that is they are <b>not</b> performed using XMLHttpRequests. Instead the form is submitted in the standard manner with the DOM <tt>&lt;form></tt> element temporarily modified to have its <a href="http://www.w3.org/TR/REC-html40/present/frames.html#adef-target">target</a> set to refer to a dynamically generated, hidden <tt>&lt;iframe></tt> which is inserted into the document but removed after the return data has been gathered.</p> <p>The server response is parsed by the browser to create the document for the IFRAME. If the server is using JSON to send the return object, then the <a href="http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.17">Content-Type</a> header must be set to "text/html" in order to tell the browser to insert the text unchanged into the document body.</p> <p>Characters which are significant to an HTML parser must be sent as HTML entities, so encode "&lt;" as "&amp;lt;", "&amp;" as "&amp;amp;" etc.</p> <p>The response text is retrieved from the document, and a fake XMLHttpRequest object is created containing a <tt>responseText</tt> property in order to conform to the requirements of event handlers and callbacks.</p> <p>Be aware that file upload packets are sent with the content type <a href="http://www.faqs.org/rfcs/rfc2388.html">multipart/form</a> and some server technologies (notably JEE) may require some custom processing in order to retrieve parameter names and parameter values from the packet content.</p></summary>
		public extern bool fileUpload { get; set; }

		/// <summary>  <p>Parameters to pass with all requests. e.g. baseParams: {id: '123', foo: 'bar'}.</p> <p>Parameters are encoded as standard HTTP parameters using {@link Ext#urlEncode}.</p></summary>
		public extern object baseParams { get; set; }

		/// <summary> Timeout for form actions in seconds (default is 30 seconds).</summary>
		public extern double timeout { get; set; }

		/// <summary> If set to true, form.reset() resets to the last loaded or setValues() data instead of when the form was first created.</summary>
		public extern bool trackResetOnLoad { get; set; }

		/// <summary> If set to true, standard HTML form submits are used instead of XHR (Ajax) style form submissions. (defaults to false)<br> <p><b>Note:</b> When using standardSubmit, any the options to {@link #submit} are ignored because Ext's Ajax infrastracture is bypassed. To pass extra parameters, you will need to create hidden fields within the form.</p></summary>
		public extern bool standardSubmit { get; set; }

		/// <summary> (optional) A config object containing one or more event handlers to be added to this object during initialization.  This should be a valid listeners config object as specified in the {@link #addListener} example for attaching multiple handlers at once.</summary>
		public extern object listeners { get; set; }

	}

    public class BasicFormEvents {
        /// <summary>Fires before any action is performed. Return false to cancel the action.
        /// <pre><code>
        /// USAGE: ({Form} objthis, {Action} action)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>action</b></term><description>The {@link Ext.form.Action} to be performed</description></item>
        /// </list>
        /// </summary>
        public static string beforeaction { get { return "beforeaction"; } }
        /// <summary>Fires when an action fails.
        /// <pre><code>
        /// USAGE: ({Form} objthis, {Action} action)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>action</b></term><description>The {@link Ext.form.Action} that failed</description></item>
        /// </list>
        /// </summary>
        public static string actionfailed { get { return "actionfailed"; } }
        /// <summary>Fires when an action is completed.
        /// <pre><code>
        /// USAGE: ({Form} objthis, {Action} action)
        /// </code></pre>
        /// <list type="bullet">
        /// <item><term><b>objthis</b></term><description></description></item>
        /// <item><term><b>action</b></term><description>The {@link Ext.form.Action} that completed</description></item>
        /// </list>
        /// </summary>
        public static string actioncomplete { get { return "actioncomplete"; } }
    }

    public delegate void BasicFormBeforeactionDelegate(Ext.form.BasicForm objthis, Ext.form.ActionClass action);
    public delegate void BasicFormActionfailedDelegate(Ext.form.BasicForm objthis, Ext.form.ActionClass action);
    public delegate void BasicFormActioncompleteDelegate(Ext.form.BasicForm objthis, Ext.form.ActionClass action);
}
