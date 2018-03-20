// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct VideoOverlayComposition : IEquatable<VideoOverlayComposition> {


		public static Gst.Video.VideoOverlayComposition Zero = new Gst.Video.VideoOverlayComposition ();

		public static Gst.Video.VideoOverlayComposition New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Video.VideoOverlayComposition.Zero;
			return (Gst.Video.VideoOverlayComposition) Marshal.PtrToStructure (raw, typeof (Gst.Video.VideoOverlayComposition));
		}

		[DllImport("libgstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_overlay_composition_new(IntPtr rectangle);

		public static VideoOverlayComposition New(Gst.Video.VideoOverlayRectangle rectangle)
		{
			VideoOverlayComposition result = VideoOverlayComposition.New (gst_video_overlay_composition_new(rectangle == null ? IntPtr.Zero : rectangle.Handle));
			return result;
		}

		[DllImport("libgstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_overlay_composition_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_video_overlay_composition_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_video_overlay_composition_add_rectangle(IntPtr raw, IntPtr rectangle);

		public void AddRectangle(Gst.Video.VideoOverlayRectangle rectangle) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			gst_video_overlay_composition_add_rectangle(this_as_native, rectangle == null ? IntPtr.Zero : rectangle.Handle);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
		}

		[DllImport("libgstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_overlay_composition_blend(IntPtr raw, IntPtr video_buf);

		public bool Blend(Gst.Video.VideoFrame video_buf) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr native_video_buf = GLib.Marshaller.StructureToPtrAlloc (video_buf);
			bool raw_ret = gst_video_overlay_composition_blend(this_as_native, native_video_buf);
			bool ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			Marshal.FreeHGlobal (native_video_buf);
			return ret;
		}

		[DllImport("libgstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_overlay_composition_get_rectangle(IntPtr raw, uint n);

		public Gst.Video.VideoOverlayRectangle GetRectangle(uint n) {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = gst_video_overlay_composition_get_rectangle(this_as_native, n);
			Gst.Video.VideoOverlayRectangle ret = raw_ret == IntPtr.Zero ? null : (Gst.Video.VideoOverlayRectangle) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Video.VideoOverlayRectangle), false);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport("libgstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_video_overlay_composition_get_seqnum(IntPtr raw);

		public uint Seqnum { 
			get {
				IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
				System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
				uint raw_ret = gst_video_overlay_composition_get_seqnum(this_as_native);
				uint ret = raw_ret;
				ReadNative (this_as_native, ref this);
				System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
				return ret;
			}
		}

		[DllImport("libgstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_overlay_composition_make_writable(IntPtr raw);

		public Gst.Video.VideoOverlayComposition MakeWritable() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			IntPtr raw_ret = gst_video_overlay_composition_make_writable(this_as_native);
			Gst.Video.VideoOverlayComposition ret = Gst.Video.VideoOverlayComposition.New (raw_ret);
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		[DllImport("libgstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern uint gst_video_overlay_composition_n_rectangles(IntPtr raw);

		public uint NRectangles() {
			IntPtr this_as_native = System.Runtime.InteropServices.Marshal.AllocHGlobal (System.Runtime.InteropServices.Marshal.SizeOf (this));
			System.Runtime.InteropServices.Marshal.StructureToPtr (this, this_as_native, false);
			uint raw_ret = gst_video_overlay_composition_n_rectangles(this_as_native);
			uint ret = raw_ret;
			ReadNative (this_as_native, ref this);
			System.Runtime.InteropServices.Marshal.FreeHGlobal (this_as_native);
			return ret;
		}

		static void ReadNative (IntPtr native, ref Gst.Video.VideoOverlayComposition target)
		{
			target = New (native);
		}

		public bool Equals (VideoOverlayComposition other)
		{
			return true;
		}

		public override bool Equals (object other)
		{
			return other is VideoOverlayComposition && Equals ((VideoOverlayComposition) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode ();
		}

		public static explicit operator GLib.Value (Gst.Video.VideoOverlayComposition boxed)
		{
			GLib.Value val = GLib.Value.Empty;
			val.Init (Gst.Video.VideoOverlayComposition.GType);
			val.Val = boxed;
			return val;
		}

		public static explicit operator Gst.Video.VideoOverlayComposition (GLib.Value val)
		{
			return (Gst.Video.VideoOverlayComposition) val.Val;
		}
#endregion
	}
}