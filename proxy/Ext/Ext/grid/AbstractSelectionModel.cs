using System;
using System.DotWeb;
using DotWeb.Client;

namespace Ext.grid {
	/// <summary>
	///     /**
	///     Abstract base class for grid SelectionModels.  It provides the interface that should be
	///     implemented by descendant classes.  This class should not be directly instantiated.
	/// </summary>
	/// <jssource>D:\src\git\DotWeb\contrib\proxy\ExtJsParser\ext-2.3\widgets\grid\AbstractSelectionModel.js</jssource>
	public class AbstractSelectionModel : Ext.util.Observable {

		/// <summary></summary>
		/// <returns></returns>
		public extern AbstractSelectionModel();

		/// <summary></summary>
		/// <summary>The reference to the prototype the every object of this type is constructed with</summary>
		public extern static AbstractSelectionModel prototype { get; set; }

		/// <summary>The reference to the constructor function</summary>
		public extern static Delegate constructor { get; set; }

		/// <summary>The reference to the class that this class inherits from</summary>
		public extern static Ext.util.Observable superclass { get; set; }

		/// <summary>The GridPanel for which this SelectionModel is handling selection. Read-only.</summary>
		public extern object grid { get; set; }


		/// <summary>Locks the selections.</summary>
		/// <returns></returns>
		public extern virtual void lock_();

		/// <summary>Unlocks the selections.</summary>
		/// <returns></returns>
		public extern virtual void unlock();

		/// <summary>Returns true if the selections are locked.</summary>
		/// <returns>Boolean</returns>
		public extern virtual void isLocked();



	}

	[JsAnonymous]
	public class AbstractSelectionModelConfig : System.DotWeb.JsDynamic {
		/// <summary> (optional) A config object containing one or more event handlers to be added to this object during initialization.  This should be a valid listeners config object as specified in the {@link #addListener} example for attaching multiple handlers at once.</summary>
		public extern object listeners { get; set; }

	}
}
