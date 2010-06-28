using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.layout {
	/// <summary>
	///     /**
	///     <p>This layout manager is specifically designed for rendering and managing child Components of forms.
	///     It is responsible for rendering the labels of {@link Ext.form.Field Field}s.</p>
	///     <p>This layout manager is used when a Container is configured with the layout:'form' {@link Ext.Container#layout layout} config,
	///     and should generally not need to be created directly via the new keyword. In an application,
	///     it will usually be preferrable to use a {@link Ext.form.FormPanel FormPanel} (which automatically uses FormLayout as its layout
	///     class) since it also provides built-in functionality for loading, validating and submitting the form.</p>
	///     <p>Note that when creating a layout via config, the layout-specific config properties must be passed in via
	///     the {@link Ext.Container#layoutConfig layoutConfig} object which will then be applied internally to the layout.</p>
	///     <p>The {@link Ext.Container Container} <i>using</i> the FormLayout can also accept the following layout-specific config
	///     properties:
	///     <div class="mdetail-params"><ul>
	///     <li><b>hideLabels</b>: (Boolean)<div class="sub-desc">True to hide field labels by default (defaults to false)</div></li>
	///     <li><b>labelAlign</b>: (String)<div class="sub-desc">The default label alignment.  The default value is empty string ''
	///     for left alignment, but specifying 'top' will align the labels above the fields.</div></li>
	///     <li><b>labelPad</b>: (Number)<div class="sub-desc">The default padding in pixels for field labels (defaults to 5).  labelPad only
	///     applies if labelWidth is also specified, otherwise it will be ignored.</div></li>
	///     <li><b>labelWidth</b>: (Number)<div class="sub-desc">The default width in pixels of field labels (defaults to 100)</div></li>
	///     </ul></div></p>
	///     <p>Any type of components can be added to a FormLayout, but items that inherit from {@link Ext.form.Field}
	///     can also supply the following field-specific config properties:
	///     <div class="mdetail-params"><ul>
	///     <li><b>clearCls</b>: (String)<div class="sub-desc">The CSS class to apply to the special clearing div rendered directly after each
	///     form field wrapper (defaults to 'x-form-clear-left')</div></li>
	///     <li><b>fieldLabel</b>: (String)<div class="sub-desc">The text to display as the label for this field (defaults to '')</div></li>
	///     <li><b>hideLabel</b>: (Boolean)<div class="sub-desc">True to hide the label and separator for this field (defaults to false).</div></li>
	///     <li><b>itemCls</b>: (String)<div class="sub-desc">A CSS class to add to the div wrapper that contains this field label
	///     and field element (the default class is 'x-form-item' and itemCls will be added to that).  If supplied,
	///     itemCls at the field level will override the default itemCls supplied at the container level.</div></li>
	///     <li><b>labelSeparator</b>: (String)<div class="sub-desc">The separator to display after the text of the label for this field
	///     (defaults to a colon ':' or the layout's value for {@link #labelSeparator}).  To hide the separator use empty string ''.</div></li>
	///     <li><b>labelStyle</b>: (String)<div class="sub-desc">A CSS style specification string to add to the field label for this field
	///     (defaults to '' or the layout's value for {@link #labelStyle}).</div></li>
	///     </ul></div></p>
	///     Example usage:</p>
	///     <pre><code>
	///     // Required if showing validation messages
	///     Ext.QuickTips.init();
	///     // While you can create a basic Panel with layout:'form', practically
	///     // you should usually use a FormPanel to also get its form functionality
	///     // since it already creates a FormLayout internally.
	///     var form = new Ext.form.FormPanel({
	///     labelWidth: 75,
	///     title: 'Form Layout',
	///     bodyStyle:'padding:15px',
	///     width: 350,
	///     labelPad: 10,
	///     defaultType: 'textfield',
	///     defaults: {
	///     // applied to each contained item
	///     width: 230,
	///     msgTarget: 'side'
	///     },
	///     layoutConfig: {
	///     // layout-specific configs go here
	///     labelSeparator: ''
	///     },
	///     items: [{
	///     fieldLabel: 'First Name',
	///     name: 'first',
	///     allowBlank: false
	///     },{
	///     fieldLabel: 'Last Name',
	///     name: 'last'
	///     },{
	///     fieldLabel: 'Company',
	///     name: 'company'
	///     },{
	///     fieldLabel: 'Email',
	///     name: 'email',
	///     vtype:'email'
	///     }
	///     ],
	///     buttons: [{
	///     text: 'Save'
	///     },{
	///     text: 'Cancel'
	///     }]
	///     });
	///     </code></pre>
	///     */
	///     Ext.layout.FormLayout = Ext.extend(Ext.layout.AnchorLayout, {
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\layout\FormLayout.js</jssource>
	public class FormLayout : Ext.layout.AnchorLayout {

		/// <summary>Auto-generated default constructor</summary>
		/// <returns></returns>
		public extern FormLayout();

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static FormLayout prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.layout.AnchorLayout superclass { get; set; }

		/// <summary>
		///     The standard separator to display after the text of each form label (defaults to a colon ':').  To turn off
		///     separators for all fields in this layout by default specify empty string '' (if the labelSeparator value is
		///     explicitly set at the field level, those will still be displayed).
		/// </summary>
		public extern string labelSeparator { get; set; }




	}

	[JsAnonymous]
	public class FormLayoutConfig : System.DotWeb.JsDynamic {
		/// <summary>  The standard separator to display after the text of each form label (defaults to a colon ':').  To turn off separators for all fields in this layout by default specify empty string '' (if the labelSeparator value is explicitly set at the field level, those will still be displayed).</summary>
		public extern string labelSeparator { get; set; }

		/// <summary>  An optional extra CSS class that will be added to the container (defaults to '').  This can be useful for adding customized styles to the container or any of its children using standard CSS rules.</summary>
		public extern string extraCls { get; set; }

		/// <summary>  True to hide each contained item on render (defaults to false).</summary>
		public extern bool renderHidden { get; set; }

	}
}
