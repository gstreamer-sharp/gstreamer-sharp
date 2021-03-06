// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.WebRTC {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class WebRTCDTLSTransport : Gst.Object {

		public WebRTCDTLSTransport (IntPtr raw) : base(raw) {}

		protected WebRTCDTLSTransport() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}

		[GLib.Property ("certificate")]
		public string Certificate {
			get {
				GLib.Value val = GetProperty ("certificate");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("certificate", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("client")]
		public bool Client {
			get {
				GLib.Value val = GetProperty ("client");
				bool ret = (bool) val;
				val.Dispose ();
				return ret;
			}
			set {
				GLib.Value val = new GLib.Value(value);
				SetProperty("client", val);
				val.Dispose ();
			}
		}

		[GLib.Property ("remote-certificate")]
		public string RemoteCertificate {
			get {
				GLib.Value val = GetProperty ("remote-certificate");
				string ret = (string) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("session-id")]
		public uint SessionId {
			get {
				GLib.Value val = GetProperty ("session-id");
				uint ret = (uint) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("state")]
		public Gst.WebRTC.WebRTCDTLSTransportState State {
			get {
				GLib.Value val = GetProperty ("state");
				Gst.WebRTC.WebRTCDTLSTransportState ret = (Gst.WebRTC.WebRTCDTLSTransportState) (Enum) val;
				val.Dispose ();
				return ret;
			}
		}

		[GLib.Property ("transport")]
		public Gst.WebRTC.WebRTCICETransport Transport {
			get {
				GLib.Value val = GetProperty ("transport");
				Gst.WebRTC.WebRTCICETransport ret = (Gst.WebRTC.WebRTCICETransport) val;
				val.Dispose ();
				return ret;
			}
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (Gst.Object.class_abi.Fields);

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gstwebrtc-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_webrtc_dtls_transport_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_webrtc_dtls_transport_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}


		static WebRTCDTLSTransport ()
		{
			GtkSharp.GstreamerSharp.ObjectManager.Initialize ();
		}

		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (Gst.Object.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
