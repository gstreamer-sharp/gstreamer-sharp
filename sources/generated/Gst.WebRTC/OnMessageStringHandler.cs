// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.WebRTC {

	using System;

	public delegate void OnMessageStringHandler(object o, OnMessageStringArgs args);

	public class OnMessageStringArgs : GLib.SignalArgs {
		public string Data{
			get {
				return (string) Args [0];
			}
		}

	}
}
