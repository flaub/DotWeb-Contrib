using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext {
	/// <summary>
	///     /**
	///     A static {@link Ext.util.TaskRunner} instance that can be used to start and stop arbitrary tasks.
	///     Example usage:<pre><code>
	///     // Start a simple clock task that updates a div once per second
	///     var task = {
	///     run: function(){
	///     Ext.fly('clock').update(new Date().format('g:i:s A'));
	///     },
	///     interval: 1000 //1 second
	///     }
	///     Ext.TaskMgr.start(task);
	///     </code></pre>
	///     */
	///     Ext.TaskMgr = new Ext.util.TaskRunner();
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\util\TaskMgr.js</jssource>
	public class TaskMgr : Ext.util.TaskRunner {

		/// <summary>Auto-generated default constructor</summary>
		/// <returns></returns>
		public extern TaskMgr();
		/// <summary>(defaults to 10)</summary>
		/// <param name="interval">(optional) The minimum precision in milliseconds supported by this TaskRunner instance</param>
		/// <returns></returns>
		public extern TaskMgr(double interval);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static TaskMgr prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.util.TaskRunner superclass { get; set; }




	}
}
