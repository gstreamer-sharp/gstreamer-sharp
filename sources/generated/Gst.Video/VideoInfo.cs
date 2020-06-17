// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class VideoInfo : GLib.Opaque {

		public Gst.Video.VideoFormatInfo Finfo {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("finfo"));
					return Gst.Video.VideoFormatInfo.New ((*raw_ptr));
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("finfo"));
					*raw_ptr = GLib.Marshaller.StructureToPtrAlloc (value);
				}
			}
		}

		public Gst.Video.VideoInterlaceMode InterlaceMode {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("interlace_mode"));
					return (Gst.Video.VideoInterlaceMode) (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("interlace_mode"));
					*raw_ptr = (int) value;
				}
			}
		}

		public Gst.Video.VideoFlags Flags {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("flags"));
					return (Gst.Video.VideoFlags) (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("flags"));
					*raw_ptr = (int) value;
				}
			}
		}

		public int Width {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("width"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("width"));
					*raw_ptr = value;
				}
			}
		}

		public int Height {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("height"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("height"));
					*raw_ptr = value;
				}
			}
		}

		public ulong Size {
			get {
				unsafe {
					UIntPtr* raw_ptr = (UIntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("size"));
					return (ulong) (*raw_ptr);
				}
			}
			set {
				unsafe {
					UIntPtr* raw_ptr = (UIntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("size"));
					*raw_ptr = new UIntPtr (value);
				}
			}
		}

		public int Views {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("views"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("views"));
					*raw_ptr = value;
				}
			}
		}

		public Gst.Video.VideoChromaSite ChromaSite {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("chroma_site"));
					return (Gst.Video.VideoChromaSite) (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("chroma_site"));
					*raw_ptr = (int) value;
				}
			}
		}

		public Gst.Video.VideoColorimetry Colorimetry {
			get {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("colorimetry"));
					return Gst.Video.VideoColorimetry.New ((*raw_ptr));
				}
			}
			set {
				unsafe {
					IntPtr* raw_ptr = (IntPtr*)(((byte*)Handle) + abi_info.GetFieldOffset("colorimetry"));
					*raw_ptr = GLib.Marshaller.StructureToPtrAlloc (value);
				}
			}
		}

		public int ParN {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("par_n"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("par_n"));
					*raw_ptr = value;
				}
			}
		}

		public int ParD {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("par_d"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("par_d"));
					*raw_ptr = value;
				}
			}
		}

		public int FpsN {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("fps_n"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("fps_n"));
					*raw_ptr = value;
				}
			}
		}

		public int FpsD {
			get {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("fps_d"));
					return (*raw_ptr);
				}
			}
			set {
				unsafe {
					int* raw_ptr = (int*)(((byte*)Handle) + abi_info.GetFieldOffset("fps_d"));
					*raw_ptr = value;
				}
			}
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_info_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_video_info_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_info_align(IntPtr raw, IntPtr align);

		public bool Align(Gst.Video.VideoAlignment align) {
			IntPtr native_align = GLib.Marshaller.StructureToPtrAlloc (align);
			bool raw_ret = gst_video_info_align(Handle, native_align);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_align);
			return ret;
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_info_align_full(IntPtr raw, IntPtr align, out UIntPtr plane_size);

		public bool AlignFull(Gst.Video.VideoAlignment align, out ulong plane_size) {
			IntPtr native_align = GLib.Marshaller.StructureToPtrAlloc (align);
			UIntPtr native_plane_size;
			bool raw_ret = gst_video_info_align_full(Handle, native_align, out native_plane_size);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_align);
			plane_size = (ulong) native_plane_size;
			return ret;
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_info_convert(IntPtr raw, int src_format, long src_value, int dest_format, out long dest_value);

		public bool Convert(Gst.Format src_format, long src_value, Gst.Format dest_format, out long dest_value) {
			bool raw_ret = gst_video_info_convert(Handle, (int) src_format, src_value, (int) dest_format, out dest_value);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_info_copy(IntPtr raw);

		public Gst.Video.VideoInfo Copy() {
			IntPtr raw_ret = gst_video_info_copy(Handle);
			Gst.Video.VideoInfo ret = raw_ret == IntPtr.Zero ? null : (Gst.Video.VideoInfo) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Video.VideoInfo), true);
			return ret;
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_info_from_caps(IntPtr raw, IntPtr caps);

		public bool FromCaps(Gst.Caps caps) {
			bool raw_ret = gst_video_info_from_caps(Handle, caps == null ? IntPtr.Zero : caps.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_video_info_init(IntPtr raw);

		public void Init() {
			gst_video_info_init(Handle);
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_info_is_equal(IntPtr raw, IntPtr other);

		public bool IsEqual(Gst.Video.VideoInfo other) {
			bool raw_ret = gst_video_info_is_equal(Handle, other == null ? IntPtr.Zero : other.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_info_set_format(IntPtr raw, int format, uint width, uint height);

		public bool SetFormat(Gst.Video.VideoFormat format, uint width, uint height) {
			bool raw_ret = gst_video_info_set_format(Handle, (int) format, width, height);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gst_video_info_set_interlaced_format(IntPtr raw, int format, int mode, uint width, uint height);

		public bool SetInterlacedFormat(Gst.Video.VideoFormat format, Gst.Video.VideoInterlaceMode mode, uint width, uint height) {
			bool raw_ret = gst_video_info_set_interlaced_format(Handle, (int) format, (int) mode, width, height);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_info_to_caps(IntPtr raw);

		public Gst.Caps ToCaps() {
			IntPtr raw_ret = gst_video_info_to_caps(Handle);
			Gst.Caps ret = raw_ret == IntPtr.Zero ? null : (Gst.Caps) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Caps), true);
			return ret;
		}

		public VideoInfo(IntPtr raw) : base(raw) {}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_info_new();

		public VideoInfo () 
		{
			Raw = gst_video_info_new();
		}

		[DllImport("gstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_video_info_free(IntPtr raw);

		protected override void Free (IntPtr raw)
		{
			gst_video_info_free (raw);
		}

		class FinalizerInfo {
			IntPtr handle;

			public FinalizerInfo (IntPtr handle)
			{
				this.handle = handle;
			}

			public bool Handler ()
			{
				gst_video_info_free (handle);
				return false;
			}
		}

		~VideoInfo ()
		{
			if (!Owned)
				return;
			FinalizerInfo info = new FinalizerInfo (Handle);
			GLib.Timeout.Add (50, new GLib.TimeoutHandler (info.Handler));
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("finfo"
							, 0
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // finfo
							, null
							, "interlace_mode"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("interlace_mode"
							, -1
							, (uint) Marshal.SizeOf(System.Enum.GetUnderlyingType(typeof(Gst.Video.VideoInterlaceMode))) // interlace_mode
							, "finfo"
							, "flags"
							, (long) Marshal.OffsetOf(typeof(GstVideoInfo_interlace_modeAlign), "interlace_mode")
							, 0
							),
						new GLib.AbiField("flags"
							, -1
							, (uint) Marshal.SizeOf(System.Enum.GetUnderlyingType(typeof(Gst.Video.VideoFlags))) // flags
							, "interlace_mode"
							, "width"
							, (long) Marshal.OffsetOf(typeof(GstVideoInfo_flagsAlign), "flags")
							, 0
							),
						new GLib.AbiField("width"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // width
							, "flags"
							, "height"
							, (long) Marshal.OffsetOf(typeof(GstVideoInfo_widthAlign), "width")
							, 0
							),
						new GLib.AbiField("height"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // height
							, "width"
							, "size"
							, (long) Marshal.OffsetOf(typeof(GstVideoInfo_heightAlign), "height")
							, 0
							),
						new GLib.AbiField("size"
							, -1
							, (uint) Marshal.SizeOf(typeof(ulong)) // size
							, "height"
							, "views"
							, (long) Marshal.OffsetOf(typeof(GstVideoInfo_sizeAlign), "size")
							, 0
							),
						new GLib.AbiField("views"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // views
							, "size"
							, "chroma_site"
							, (long) Marshal.OffsetOf(typeof(GstVideoInfo_viewsAlign), "views")
							, 0
							),
						new GLib.AbiField("chroma_site"
							, -1
							, (uint) Marshal.SizeOf(System.Enum.GetUnderlyingType(typeof(Gst.Video.VideoChromaSite))) // chroma_site
							, "views"
							, "colorimetry"
							, (long) Marshal.OffsetOf(typeof(GstVideoInfo_chroma_siteAlign), "chroma_site")
							, 0
							),
						new GLib.AbiField("colorimetry"
							, -1
							, (uint) Marshal.SizeOf(typeof(Gst.Video.VideoColorimetry)) // colorimetry
							, "chroma_site"
							, "par_n"
							, (long) Marshal.OffsetOf(typeof(GstVideoInfo_colorimetryAlign), "colorimetry")
							, 0
							),
						new GLib.AbiField("par_n"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // par_n
							, "colorimetry"
							, "par_d"
							, (long) Marshal.OffsetOf(typeof(GstVideoInfo_par_nAlign), "par_n")
							, 0
							),
						new GLib.AbiField("par_d"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // par_d
							, "par_n"
							, "fps_n"
							, (long) Marshal.OffsetOf(typeof(GstVideoInfo_par_dAlign), "par_d")
							, 0
							),
						new GLib.AbiField("fps_n"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // fps_n
							, "par_d"
							, "fps_d"
							, (long) Marshal.OffsetOf(typeof(GstVideoInfo_fps_nAlign), "fps_n")
							, 0
							),
						new GLib.AbiField("fps_d"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) // fps_d
							, "fps_n"
							, "offset"
							, (long) Marshal.OffsetOf(typeof(GstVideoInfo_fps_dAlign), "fps_d")
							, 0
							),
						new GLib.AbiField("offset"
							, -1
							, (uint) Marshal.SizeOf(typeof(ulong)) * 4 // offset
							, "fps_d"
							, "stride"
							, (long) Marshal.OffsetOf(typeof(GstVideoInfo_offsetAlign), "offset")
							, 0
							),
						new GLib.AbiField("stride"
							, -1
							, (uint) Marshal.SizeOf(typeof(int)) * 4 // stride
							, "offset"
							, "ABI"
							, (long) Marshal.OffsetOf(typeof(GstVideoInfo_strideAlign), "stride")
							, 0
							),
						// union struct ABI.abi
							new GLib.AbiField("ABI.abi.multiview_mode"
								, -1
								, (uint) Marshal.SizeOf(System.Enum.GetUnderlyingType(typeof(Gst.Video.VideoMultiviewMode))) // ABI.abi.multiview_mode
								, "stride"
								, "ABI.abi.multiview_flags"
								, (long) Marshal.OffsetOf(typeof(GstVideoInfo_ABI_abi_multiview_modeAlign), "ABI_abi_multiview_mode")
								, 0
								),
							new GLib.AbiField("ABI.abi.multiview_flags"
								, -1
								, (uint) Marshal.SizeOf(System.Enum.GetUnderlyingType(typeof(Gst.Video.VideoMultiviewFlags))) // ABI.abi.multiview_flags
								, "ABI.abi.multiview_mode"
								, "ABI.abi.field_order"
								, (long) Marshal.OffsetOf(typeof(GstVideoInfo_ABI_abi_multiview_flagsAlign), "ABI_abi_multiview_flags")
								, 0
								),
							new GLib.AbiField("ABI.abi.field_order"
								, -1
								, (uint) Marshal.SizeOf(System.Enum.GetUnderlyingType(typeof(Gst.Video.VideoFieldOrder))) // ABI.abi.field_order
								, "ABI.abi.multiview_flags"
								, null
								, (long) Marshal.OffsetOf(typeof(GstVideoInfo_ABI_abi_field_orderAlign), "ABI_abi_field_order")
								, 0
								),
						// End ABI.abi

						// union struct ABI
							new GLib.AbiField("ABI._gst_reserved"
								, -1
								, (uint) Marshal.SizeOf(typeof(IntPtr)) * 4 // ABI._gst_reserved
								, "stride"
								, null
								, (uint) Marshal.SizeOf(typeof(IntPtr))
								, 0
								),
						// End ABI

						new GLib.AbiField("ABI"
							, -1
							, new List<List<string>>() {  // union ABI
						new List<string>() {"ABI.abi.multiview_mode","ABI.abi.multiview_flags","ABI.abi.field_order"},
						new List<string>() {"ABI._gst_reserved"}
					  }
							, "stride"
							, null
							, 0
							),
					});

				return _abi_info;
			}
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstVideoInfo_interlace_modeAlign
		{
			sbyte f1;
			private Gst.Video.VideoInterlaceMode interlace_mode;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstVideoInfo_flagsAlign
		{
			sbyte f1;
			private Gst.Video.VideoFlags flags;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstVideoInfo_widthAlign
		{
			sbyte f1;
			private int width;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstVideoInfo_heightAlign
		{
			sbyte f1;
			private int height;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstVideoInfo_sizeAlign
		{
			sbyte f1;
			private UIntPtr size;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstVideoInfo_viewsAlign
		{
			sbyte f1;
			private int views;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstVideoInfo_chroma_siteAlign
		{
			sbyte f1;
			private Gst.Video.VideoChromaSite chroma_site;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstVideoInfo_colorimetryAlign
		{
			sbyte f1;
			private Gst.Video.VideoColorimetry colorimetry;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstVideoInfo_par_nAlign
		{
			sbyte f1;
			private int par_n;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstVideoInfo_par_dAlign
		{
			sbyte f1;
			private int par_d;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstVideoInfo_fps_nAlign
		{
			sbyte f1;
			private int fps_n;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstVideoInfo_fps_dAlign
		{
			sbyte f1;
			private int fps_d;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstVideoInfo_offsetAlign
		{
			sbyte f1;
			[MarshalAs (UnmanagedType.ByValArray, SizeConst=4)]
			private ulong[] offset;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstVideoInfo_strideAlign
		{
			sbyte f1;
			[MarshalAs (UnmanagedType.ByValArray, SizeConst=4)]
			private int[] stride;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstVideoInfo_ABI_abi_multiview_modeAlign
		{
			sbyte f1;
			private Gst.Video.VideoMultiviewMode ABI_abi_multiview_mode;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstVideoInfo_ABI_abi_multiview_flagsAlign
		{
			sbyte f1;
			private Gst.Video.VideoMultiviewFlags ABI_abi_multiview_flags;
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct GstVideoInfo_ABI_abi_field_orderAlign
		{
			sbyte f1;
			private Gst.Video.VideoFieldOrder ABI_abi_field_order;
		}


		// End of the ABI representation.

#endregion
	}
}
