// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Base {

	using System;

	public delegate void SamplesSelectedHandler(object o, SamplesSelectedArgs args);

	public class SamplesSelectedArgs : GLib.SignalArgs {
		public Gst.Segment Segment{
			get {
				return (Gst.Segment) Args [0];
			}
		}

		public ulong Pts{
			get {
				return (ulong) Args [1];
			}
		}

		public ulong Dts{
			get {
				return (ulong) Args [2];
			}
		}

		public ulong Duration{
			get {
				return (ulong) Args [3];
			}
		}

		public Gst.Structure Info{
			get {
				return (Gst.Structure) Args [4];
			}
		}

	}
}
