using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.util {
	/// <summary>
	///     /**
	///     Provides the ability to execute one or more arbitrary tasks in a multithreaded manner.  Generally, you can use
	///     the singleton {@link Ext.TaskMgr} instead, but if needed, you can create separate instances of TaskRunner.  Any
	///     number of separate tasks can be started at any time and will run independently of each other.  Example usage:
	///     <pre><code>
	///     // Start a simple clock task that updates a div once per second
	///     var task = {
	///     run: function(){
	///     Ext.fly('clock').update(new Date().format('g:i:s A'));
	///     },
	///     interval: 1000 //1 second
	///     }
	///     var runner = new Ext.util.TaskRunner();
	///     runner.start(task);
	///     </code></pre>
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\util\TaskMgr.js</jssource>
	[JsObject]
	public class TaskRunner  {

		/// <summary>(defaults to 10)</summary>
		/// <returns></returns>
		public extern TaskRunner();
		/// <summary>(defaults to 10)</summary>
		/// <param name="interval">(optional) The minimum precision in milliseconds supported by this TaskRunner instance</param>
		/// <returns></returns>
		public extern TaskRunner(double interval);

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static TaskRunner prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }




	}
}
