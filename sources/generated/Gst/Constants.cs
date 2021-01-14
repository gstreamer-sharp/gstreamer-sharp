// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Constants {

		public const string ALLOCATOR_SYSMEM = @"SystemMemory";
		public const int BUFFER_COPY_ALL = 15;
		public const int BUFFER_COPY_METADATA = 7;
		public const ulong BUFFER_OFFSET_NONE = 18446744073709551615;
		public const int CAN_INLINE = 1;
		public const string CAPS_FEATURE_MEMORY_SYSTEM_MEMORY = @"memory:SystemMemory";
		public const ulong CLOCK_TIME_NONE = 18446744073709551615;
		public const int DEBUG_BG_MASK = 240;
		public const int DEBUG_FG_MASK = 15;
		public const int DEBUG_FORMAT_MASK = 65280;
		public const string ELEMENT_FACTORY_KLASS_DECODER = @"Decoder";
		public const string ELEMENT_FACTORY_KLASS_DECRYPTOR = @"Decryptor";
		public const string ELEMENT_FACTORY_KLASS_DEMUXER = @"Demuxer";
		public const string ELEMENT_FACTORY_KLASS_DEPAYLOADER = @"Depayloader";
		public const string ELEMENT_FACTORY_KLASS_ENCODER = @"Encoder";
		public const string ELEMENT_FACTORY_KLASS_ENCRYPTOR = @"Encryptor";
		public const string ELEMENT_FACTORY_KLASS_FORMATTER = @"Formatter";
		public const string ELEMENT_FACTORY_KLASS_HARDWARE = @"Hardware";
		public const string ELEMENT_FACTORY_KLASS_MEDIA_AUDIO = @"Audio";
		public const string ELEMENT_FACTORY_KLASS_MEDIA_IMAGE = @"Image";
		public const string ELEMENT_FACTORY_KLASS_MEDIA_METADATA = @"Metadata";
		public const string ELEMENT_FACTORY_KLASS_MEDIA_SUBTITLE = @"Subtitle";
		public const string ELEMENT_FACTORY_KLASS_MEDIA_VIDEO = @"Video";
		public const string ELEMENT_FACTORY_KLASS_MUXER = @"Muxer";
		public const string ELEMENT_FACTORY_KLASS_PARSER = @"Parser";
		public const string ELEMENT_FACTORY_KLASS_PAYLOADER = @"Payloader";
		public const string ELEMENT_FACTORY_KLASS_SINK = @"Sink";
		public const string ELEMENT_FACTORY_KLASS_SRC = @"Source";
		public const string ELEMENT_METADATA_AUTHOR = @"author";
		public const string ELEMENT_METADATA_DESCRIPTION = @"description";
		public const string ELEMENT_METADATA_DOC_URI = @"doc-uri";
		public const string ELEMENT_METADATA_ICON_NAME = @"icon-name";
		public const string ELEMENT_METADATA_KLASS = @"klass";
		public const string ELEMENT_METADATA_LONGNAME = @"long-name";
		public const string ERROR_SYSTEM = @"system error: %s";
		public const int EVENT_NUM_SHIFT = 8;
		public const int EVENT_TYPE_BOTH = 3;
		public const uint FLAG_SET_MASK_EXACT = 4294967295;
		public const long FORMAT_PERCENT_MAX = 1000000;
		public const long FORMAT_PERCENT_SCALE = 10000;
		public const string FOURCC_FORMAT = @"c%c%c%c";
		public const int GROUP_ID_INVALID = 0;
		public const string LICENSE_UNKNOWN = @"unknown";
		public const int LOCK_FLAG_READWRITE = 3;
		public const int MAP_READWRITE = 3;
		public const string META_TAG_MEMORY_STR = @"memory";
		public const long MSECOND = 1000000;
		public const int PARAM_CONDITIONALLY_AVAILABLE = 16384;
		public const int PARAM_CONTROLLABLE = 512;
		public const int PARAM_DOC_SHOW_DEFAULT = 8192;
		public const int PARAM_MUTABLE_PAUSED = 2048;
		public const int PARAM_MUTABLE_PLAYING = 4096;
		public const int PARAM_MUTABLE_READY = 1024;
		public const int PARAM_USER_SHIFT = 65536;
		public const string PROTECTION_SYSTEM_ID_CAPS_FIELD = @"protection-system";
		public const string PROTECTION_UNSPECIFIED_SYSTEM_ID = @"unspecified-system-id";
		public const string PTR_FORMAT = @"paA";
		public const int QUERY_NUM_SHIFT = 8;
		public const int QUERY_TYPE_BOTH = 3;
		public const long SECOND = 1000000000;
		public const string SEGMENT_FORMAT = @"paB";
		public const int SEGMENT_INSTANT_FLAGS = 912;
		public const int SEQNUM_INVALID = 0;
		public const string STIMEP_FORMAT = @"paS";
		public const string STIME_FORMAT = @"c%";
		public const string TAG_ALBUM = @"album";
		public const string TAG_ALBUM_ARTIST = @"album-artist";
		public const string TAG_ALBUM_ARTIST_SORTNAME = @"album-artist-sortname";
		public const string TAG_ALBUM_GAIN = @"replaygain-album-gain";
		public const string TAG_ALBUM_PEAK = @"replaygain-album-peak";
		public const string TAG_ALBUM_SORTNAME = @"album-sortname";
		public const string TAG_ALBUM_VOLUME_COUNT = @"album-disc-count";
		public const string TAG_ALBUM_VOLUME_NUMBER = @"album-disc-number";
		public const string TAG_APPLICATION_DATA = @"application-data";
		public const string TAG_APPLICATION_NAME = @"application-name";
		public const string TAG_ARTIST = @"artist";
		public const string TAG_ARTIST_SORTNAME = @"artist-sortname";
		public const string TAG_ATTACHMENT = @"attachment";
		public const string TAG_AUDIO_CODEC = @"audio-codec";
		public const string TAG_BEATS_PER_MINUTE = @"beats-per-minute";
		public const string TAG_BITRATE = @"bitrate";
		public const string TAG_CODEC = @"codec";
		public const string TAG_COMMENT = @"comment";
		public const string TAG_COMPOSER = @"composer";
		public const string TAG_COMPOSER_SORTNAME = @"composer-sortname";
		public const string TAG_CONDUCTOR = @"conductor";
		public const string TAG_CONTACT = @"contact";
		public const string TAG_CONTAINER_FORMAT = @"container-format";
		public const string TAG_COPYRIGHT = @"copyright";
		public const string TAG_COPYRIGHT_URI = @"copyright-uri";
		public const string TAG_DATE = @"date";
		public const string TAG_DATE_TIME = @"datetime";
		public const string TAG_DESCRIPTION = @"description";
		public const string TAG_DEVICE_MANUFACTURER = @"device-manufacturer";
		public const string TAG_DEVICE_MODEL = @"device-model";
		public const string TAG_DURATION = @"duration";
		public const string TAG_ENCODED_BY = @"encoded-by";
		public const string TAG_ENCODER = @"encoder";
		public const string TAG_ENCODER_VERSION = @"encoder-version";
		public const string TAG_EXTENDED_COMMENT = @"extended-comment";
		public const string TAG_GENRE = @"genre";
		public const string TAG_GEO_LOCATION_CAPTURE_DIRECTION = @"geo-location-capture-direction";
		public const string TAG_GEO_LOCATION_CITY = @"geo-location-city";
		public const string TAG_GEO_LOCATION_COUNTRY = @"geo-location-country";
		public const string TAG_GEO_LOCATION_ELEVATION = @"geo-location-elevation";
		public const string TAG_GEO_LOCATION_HORIZONTAL_ERROR = @"geo-location-horizontal-error";
		public const string TAG_GEO_LOCATION_LATITUDE = @"geo-location-latitude";
		public const string TAG_GEO_LOCATION_LONGITUDE = @"geo-location-longitude";
		public const string TAG_GEO_LOCATION_MOVEMENT_DIRECTION = @"geo-location-movement-direction";
		public const string TAG_GEO_LOCATION_MOVEMENT_SPEED = @"geo-location-movement-speed";
		public const string TAG_GEO_LOCATION_NAME = @"geo-location-name";
		public const string TAG_GEO_LOCATION_SUBLOCATION = @"geo-location-sublocation";
		public const string TAG_GROUPING = @"grouping";
		public const string TAG_HOMEPAGE = @"homepage";
		public const string TAG_IMAGE = @"image";
		public const string TAG_IMAGE_ORIENTATION = @"image-orientation";
		public const string TAG_INTERPRETED_BY = @"interpreted-by";
		public const string TAG_ISRC = @"isrc";
		public const string TAG_KEYWORDS = @"keywords";
		public const string TAG_LANGUAGE_CODE = @"language-code";
		public const string TAG_LANGUAGE_NAME = @"language-name";
		public const string TAG_LICENSE = @"license";
		public const string TAG_LICENSE_URI = @"license-uri";
		public const string TAG_LOCATION = @"location";
		public const string TAG_LYRICS = @"lyrics";
		public const string TAG_MAXIMUM_BITRATE = @"maximum-bitrate";
		public const string TAG_MIDI_BASE_NOTE = @"midi-base-note";
		public const string TAG_MINIMUM_BITRATE = @"minimum-bitrate";
		public const string TAG_NOMINAL_BITRATE = @"nominal-bitrate";
		public const string TAG_ORGANIZATION = @"organization";
		public const string TAG_PERFORMER = @"performer";
		public const string TAG_PREVIEW_IMAGE = @"preview-image";
		public const string TAG_PRIVATE_DATA = @"private-data";
		public const string TAG_PUBLISHER = @"publisher";
		public const string TAG_REFERENCE_LEVEL = @"replaygain-reference-level";
		public const string TAG_SERIAL = @"serial";
		public const string TAG_SHOW_EPISODE_NUMBER = @"show-episode-number";
		public const string TAG_SHOW_NAME = @"show-name";
		public const string TAG_SHOW_SEASON_NUMBER = @"show-season-number";
		public const string TAG_SHOW_SORTNAME = @"show-sortname";
		public const string TAG_SUBTITLE_CODEC = @"subtitle-codec";
		public const string TAG_TITLE = @"title";
		public const string TAG_TITLE_SORTNAME = @"title-sortname";
		public const string TAG_TRACK_COUNT = @"track-count";
		public const string TAG_TRACK_GAIN = @"replaygain-track-gain";
		public const string TAG_TRACK_NUMBER = @"track-number";
		public const string TAG_TRACK_PEAK = @"replaygain-track-peak";
		public const string TAG_USER_RATING = @"user-rating";
		public const string TAG_VERSION = @"version";
		public const string TAG_VIDEO_CODEC = @"video-codec";
		public const string TIMEP_FORMAT = @"paT";
		public const string TIME_FORMAT = @"u:%02u:%02u.%09u";
		public const int TOC_REPEAT_COUNT_INFINITE = -1;
		public const int URI_NO_PORT = 0;
		public const int VALUE_EQUAL = 0;
		public const int VALUE_GREATER_THAN = 1;
		public const int VALUE_LESS_THAN = -1;
		public const int VALUE_UNORDERED = 2;
		public const int VERSION_MAJOR = 1;
		public const int VERSION_MICRO = 3;
		public const int VERSION_MINOR = 18;
		public const int VERSION_NANO = 1;
#endregion
	}
}
