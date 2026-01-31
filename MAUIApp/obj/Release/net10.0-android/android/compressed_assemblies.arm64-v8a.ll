; ModuleID = 'compressed_assemblies.arm64-v8a.ll'
source_filename = "compressed_assemblies.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android21"

%struct.CompressedAssemblyDescriptor = type {
	i32, ; uint32_t uncompressed_file_size
	i1, ; bool loaded
	i32 ; uint32_t buffer_offset
}

@compressed_assembly_count = dso_local local_unnamed_addr constant i32 152, align 4

@compressed_assembly_descriptors = dso_local local_unnamed_addr global [152 x %struct.CompressedAssemblyDescriptor] [
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 0; uint32_t buffer_offset
	}, ; 0: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15672, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 15624; uint32_t buffer_offset
	}, ; 1: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15632, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 31296; uint32_t buffer_offset
	}, ; 2: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15672, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 46928; uint32_t buffer_offset
	}, ; 3: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 62600; uint32_t buffer_offset
	}, ; 4: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 78224; uint32_t buffer_offset
	}, ; 5: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 93848; uint32_t buffer_offset
	}, ; 6: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15632, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 109472; uint32_t buffer_offset
	}, ; 7: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 125104; uint32_t buffer_offset
	}, ; 8: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 140728; uint32_t buffer_offset
	}, ; 9: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 156352; uint32_t buffer_offset
	}, ; 10: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15672, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 171976; uint32_t buffer_offset
	}, ; 11: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15632, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 187648; uint32_t buffer_offset
	}, ; 12: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15672, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 203280; uint32_t buffer_offset
	}, ; 13: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 218952; uint32_t buffer_offset
	}, ; 14: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 234576; uint32_t buffer_offset
	}, ; 15: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 250200; uint32_t buffer_offset
	}, ; 16: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15672, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 265824; uint32_t buffer_offset
	}, ; 17: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 281496; uint32_t buffer_offset
	}, ; 18: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 297120; uint32_t buffer_offset
	}, ; 19: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 312744; uint32_t buffer_offset
	}, ; 20: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15632, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 328368; uint32_t buffer_offset
	}, ; 21: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 344000; uint32_t buffer_offset
	}, ; 22: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 359624; uint32_t buffer_offset
	}, ; 23: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 375248; uint32_t buffer_offset
	}, ; 24: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 390872; uint32_t buffer_offset
	}, ; 25: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 406496; uint32_t buffer_offset
	}, ; 26: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15672, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 422120; uint32_t buffer_offset
	}, ; 27: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 437792; uint32_t buffer_offset
	}, ; 28: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15664, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 453416; uint32_t buffer_offset
	}, ; 29: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 469080; uint32_t buffer_offset
	}, ; 30: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 484704; uint32_t buffer_offset
	}, ; 31: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 500328; uint32_t buffer_offset
	}, ; 32: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 15624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 515952; uint32_t buffer_offset
	}, ; 33: Microsoft.Maui.Controls.resources
	%struct.CompressedAssemblyDescriptor {
		i32 6144, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 531576; uint32_t buffer_offset
	}, ; 34: _Microsoft.Android.Resource.Designer
	%struct.CompressedAssemblyDescriptor {
		i32 18432, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 537720; uint32_t buffer_offset
	}, ; 35: CommunityToolkit.Mvvm
	%struct.CompressedAssemblyDescriptor {
		i32 14848, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 556152; uint32_t buffer_offset
	}, ; 36: Microsoft.Extensions.Configuration
	%struct.CompressedAssemblyDescriptor {
		i32 6656, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 571000; uint32_t buffer_offset
	}, ; 37: Microsoft.Extensions.Configuration.Abstractions
	%struct.CompressedAssemblyDescriptor {
		i32 46592, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 577656; uint32_t buffer_offset
	}, ; 38: Microsoft.Extensions.DependencyInjection
	%struct.CompressedAssemblyDescriptor {
		i32 26624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 624248; uint32_t buffer_offset
	}, ; 39: Microsoft.Extensions.DependencyInjection.Abstractions
	%struct.CompressedAssemblyDescriptor {
		i32 8192, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 650872; uint32_t buffer_offset
	}, ; 40: Microsoft.Extensions.Diagnostics.Abstractions
	%struct.CompressedAssemblyDescriptor {
		i32 7168, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 659064; uint32_t buffer_offset
	}, ; 41: Microsoft.Extensions.FileProviders.Abstractions
	%struct.CompressedAssemblyDescriptor {
		i32 6144, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 666232; uint32_t buffer_offset
	}, ; 42: Microsoft.Extensions.Hosting.Abstractions
	%struct.CompressedAssemblyDescriptor {
		i32 17920, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 672376; uint32_t buffer_offset
	}, ; 43: Microsoft.Extensions.Logging
	%struct.CompressedAssemblyDescriptor {
		i32 19456, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 690296; uint32_t buffer_offset
	}, ; 44: Microsoft.Extensions.Logging.Abstractions
	%struct.CompressedAssemblyDescriptor {
		i32 16896, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 709752; uint32_t buffer_offset
	}, ; 45: Microsoft.Extensions.Options
	%struct.CompressedAssemblyDescriptor {
		i32 9216, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 726648; uint32_t buffer_offset
	}, ; 46: Microsoft.Extensions.Primitives
	%struct.CompressedAssemblyDescriptor {
		i32 6144, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 735864; uint32_t buffer_offset
	}, ; 47: Microsoft.IdentityModel.Abstractions
	%struct.CompressedAssemblyDescriptor {
		i32 31232, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 742008; uint32_t buffer_offset
	}, ; 48: Microsoft.IdentityModel.JsonWebTokens
	%struct.CompressedAssemblyDescriptor {
		i32 15872, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 773240; uint32_t buffer_offset
	}, ; 49: Microsoft.IdentityModel.Logging
	%struct.CompressedAssemblyDescriptor {
		i32 37376, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 789112; uint32_t buffer_offset
	}, ; 50: Microsoft.IdentityModel.Tokens
	%struct.CompressedAssemblyDescriptor {
		i32 1929992, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 826488; uint32_t buffer_offset
	}, ; 51: Microsoft.Maui.Controls
	%struct.CompressedAssemblyDescriptor {
		i32 135432, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 2756480; uint32_t buffer_offset
	}, ; 52: Microsoft.Maui.Controls.Xaml
	%struct.CompressedAssemblyDescriptor {
		i32 862720, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 2891912; uint32_t buffer_offset
	}, ; 53: Microsoft.Maui
	%struct.CompressedAssemblyDescriptor {
		i32 60928, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 3754632; uint32_t buffer_offset
	}, ; 54: Microsoft.Maui.Essentials
	%struct.CompressedAssemblyDescriptor {
		i32 208648, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 3815560; uint32_t buffer_offset
	}, ; 55: Microsoft.Maui.Graphics
	%struct.CompressedAssemblyDescriptor {
		i32 723368, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 4024208; uint32_t buffer_offset
	}, ; 56: Newtonsoft.Json
	%struct.CompressedAssemblyDescriptor {
		i32 107520, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 4747576; uint32_t buffer_offset
	}, ; 57: SQLite-net
	%struct.CompressedAssemblyDescriptor {
		i32 5632, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 4855096; uint32_t buffer_offset
	}, ; 58: SQLitePCLRaw.batteries_v2
	%struct.CompressedAssemblyDescriptor {
		i32 51200, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 4860728; uint32_t buffer_offset
	}, ; 59: SQLitePCLRaw.core
	%struct.CompressedAssemblyDescriptor {
		i32 5120, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 4911928; uint32_t buffer_offset
	}, ; 60: SQLitePCLRaw.lib.e_sqlite3.android
	%struct.CompressedAssemblyDescriptor {
		i32 36864, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 4917048; uint32_t buffer_offset
	}, ; 61: SQLitePCLRaw.provider.e_sqlite3
	%struct.CompressedAssemblyDescriptor {
		i32 27136, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 4953912; uint32_t buffer_offset
	}, ; 62: System.IdentityModel.Tokens.Jwt
	%struct.CompressedAssemblyDescriptor {
		i32 73728, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 4981048; uint32_t buffer_offset
	}, ; 63: Xamarin.AndroidX.Activity
	%struct.CompressedAssemblyDescriptor {
		i32 583680, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 5054776; uint32_t buffer_offset
	}, ; 64: Xamarin.AndroidX.AppCompat
	%struct.CompressedAssemblyDescriptor {
		i32 17920, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 5638456; uint32_t buffer_offset
	}, ; 65: Xamarin.AndroidX.AppCompat.AppCompatResources
	%struct.CompressedAssemblyDescriptor {
		i32 18944, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 5656376; uint32_t buffer_offset
	}, ; 66: Xamarin.AndroidX.CardView
	%struct.CompressedAssemblyDescriptor {
		i32 22528, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 5675320; uint32_t buffer_offset
	}, ; 67: Xamarin.AndroidX.Collection.Jvm
	%struct.CompressedAssemblyDescriptor {
		i32 78336, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 5697848; uint32_t buffer_offset
	}, ; 68: Xamarin.AndroidX.CoordinatorLayout
	%struct.CompressedAssemblyDescriptor {
		i32 596992, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 5776184; uint32_t buffer_offset
	}, ; 69: Xamarin.AndroidX.Core
	%struct.CompressedAssemblyDescriptor {
		i32 26624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 6373176; uint32_t buffer_offset
	}, ; 70: Xamarin.AndroidX.CursorAdapter
	%struct.CompressedAssemblyDescriptor {
		i32 9728, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 6399800; uint32_t buffer_offset
	}, ; 71: Xamarin.AndroidX.CustomView
	%struct.CompressedAssemblyDescriptor {
		i32 47104, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 6409528; uint32_t buffer_offset
	}, ; 72: Xamarin.AndroidX.DrawerLayout
	%struct.CompressedAssemblyDescriptor {
		i32 236032, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 6456632; uint32_t buffer_offset
	}, ; 73: Xamarin.AndroidX.Fragment
	%struct.CompressedAssemblyDescriptor {
		i32 23552, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 6692664; uint32_t buffer_offset
	}, ; 74: Xamarin.AndroidX.Lifecycle.Common.Jvm
	%struct.CompressedAssemblyDescriptor {
		i32 18944, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 6716216; uint32_t buffer_offset
	}, ; 75: Xamarin.AndroidX.Lifecycle.LiveData.Core
	%struct.CompressedAssemblyDescriptor {
		i32 32768, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 6735160; uint32_t buffer_offset
	}, ; 76: Xamarin.AndroidX.Lifecycle.ViewModel.Android
	%struct.CompressedAssemblyDescriptor {
		i32 13824, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 6767928; uint32_t buffer_offset
	}, ; 77: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.Android
	%struct.CompressedAssemblyDescriptor {
		i32 39424, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 6781752; uint32_t buffer_offset
	}, ; 78: Xamarin.AndroidX.Loader
	%struct.CompressedAssemblyDescriptor {
		i32 92672, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 6821176; uint32_t buffer_offset
	}, ; 79: Xamarin.AndroidX.Navigation.Common.Android
	%struct.CompressedAssemblyDescriptor {
		i32 19456, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 6913848; uint32_t buffer_offset
	}, ; 80: Xamarin.AndroidX.Navigation.Fragment
	%struct.CompressedAssemblyDescriptor {
		i32 65536, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 6933304; uint32_t buffer_offset
	}, ; 81: Xamarin.AndroidX.Navigation.Runtime.Android
	%struct.CompressedAssemblyDescriptor {
		i32 27136, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 6998840; uint32_t buffer_offset
	}, ; 82: Xamarin.AndroidX.Navigation.UI
	%struct.CompressedAssemblyDescriptor {
		i32 457728, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 7025976; uint32_t buffer_offset
	}, ; 83: Xamarin.AndroidX.RecyclerView
	%struct.CompressedAssemblyDescriptor {
		i32 12288, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 7483704; uint32_t buffer_offset
	}, ; 84: Xamarin.AndroidX.SavedState.SavedState.Android
	%struct.CompressedAssemblyDescriptor {
		i32 24576, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 7495992; uint32_t buffer_offset
	}, ; 85: Xamarin.AndroidX.Security.SecurityCrypto
	%struct.CompressedAssemblyDescriptor {
		i32 41984, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 7520568; uint32_t buffer_offset
	}, ; 86: Xamarin.AndroidX.SwipeRefreshLayout
	%struct.CompressedAssemblyDescriptor {
		i32 62976, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 7562552; uint32_t buffer_offset
	}, ; 87: Xamarin.AndroidX.ViewPager
	%struct.CompressedAssemblyDescriptor {
		i32 40448, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 7625528; uint32_t buffer_offset
	}, ; 88: Xamarin.AndroidX.ViewPager2
	%struct.CompressedAssemblyDescriptor {
		i32 675840, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 7665976; uint32_t buffer_offset
	}, ; 89: Xamarin.Google.Android.Material
	%struct.CompressedAssemblyDescriptor {
		i32 345088, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 8341816; uint32_t buffer_offset
	}, ; 90: Xamarin.Google.Crypto.Tink.Android
	%struct.CompressedAssemblyDescriptor {
		i32 90624, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 8686904; uint32_t buffer_offset
	}, ; 91: Xamarin.Kotlin.StdLib
	%struct.CompressedAssemblyDescriptor {
		i32 28672, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 8777528; uint32_t buffer_offset
	}, ; 92: Xamarin.KotlinX.Coroutines.Core.Jvm
	%struct.CompressedAssemblyDescriptor {
		i32 91648, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 8806200; uint32_t buffer_offset
	}, ; 93: Xamarin.KotlinX.Serialization.Core.Jvm
	%struct.CompressedAssemblyDescriptor {
		i32 152064, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 8897848; uint32_t buffer_offset
	}, ; 94: MyMAUIApp
	%struct.CompressedAssemblyDescriptor {
		i32 229888, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 9049912; uint32_t buffer_offset
	}, ; 95: Microsoft.CSharp
	%struct.CompressedAssemblyDescriptor {
		i32 25600, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 9279800; uint32_t buffer_offset
	}, ; 96: System.Collections.Concurrent
	%struct.CompressedAssemblyDescriptor {
		i32 19456, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 9305400; uint32_t buffer_offset
	}, ; 97: System.Collections.NonGeneric
	%struct.CompressedAssemblyDescriptor {
		i32 12288, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 9324856; uint32_t buffer_offset
	}, ; 98: System.Collections.Specialized
	%struct.CompressedAssemblyDescriptor {
		i32 32768, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 9337144; uint32_t buffer_offset
	}, ; 99: System.Collections
	%struct.CompressedAssemblyDescriptor {
		i32 14336, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 9369912; uint32_t buffer_offset
	}, ; 100: System.ComponentModel.Primitives
	%struct.CompressedAssemblyDescriptor {
		i32 144896, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 9384248; uint32_t buffer_offset
	}, ; 101: System.ComponentModel.TypeConverter
	%struct.CompressedAssemblyDescriptor {
		i32 5120, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 9529144; uint32_t buffer_offset
	}, ; 102: System.ComponentModel
	%struct.CompressedAssemblyDescriptor {
		i32 12288, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 9534264; uint32_t buffer_offset
	}, ; 103: System.Console
	%struct.CompressedAssemblyDescriptor {
		i32 520192, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 9546552; uint32_t buffer_offset
	}, ; 104: System.Data.Common
	%struct.CompressedAssemblyDescriptor {
		i32 40448, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 10066744; uint32_t buffer_offset
	}, ; 105: System.Diagnostics.DiagnosticSource
	%struct.CompressedAssemblyDescriptor {
		i32 19968, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 10107192; uint32_t buffer_offset
	}, ; 106: System.Diagnostics.TraceSource
	%struct.CompressedAssemblyDescriptor {
		i32 36864, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 10127160; uint32_t buffer_offset
	}, ; 107: System.Drawing.Primitives
	%struct.CompressedAssemblyDescriptor {
		i32 5120, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 10164024; uint32_t buffer_offset
	}, ; 108: System.Drawing
	%struct.CompressedAssemblyDescriptor {
		i32 60416, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 10169144; uint32_t buffer_offset
	}, ; 109: System.Formats.Asn1
	%struct.CompressedAssemblyDescriptor {
		i32 22016, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 10229560; uint32_t buffer_offset
	}, ; 110: System.IO.Compression.Brotli
	%struct.CompressedAssemblyDescriptor {
		i32 32256, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 10251576; uint32_t buffer_offset
	}, ; 111: System.IO.Compression
	%struct.CompressedAssemblyDescriptor {
		i32 6656, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 10283832; uint32_t buffer_offset
	}, ; 112: System.IO.Pipelines
	%struct.CompressedAssemblyDescriptor {
		i32 432128, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 10290488; uint32_t buffer_offset
	}, ; 113: System.Linq.Expressions
	%struct.CompressedAssemblyDescriptor {
		i32 66048, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 10722616; uint32_t buffer_offset
	}, ; 114: System.Linq
	%struct.CompressedAssemblyDescriptor {
		i32 16384, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 10788664; uint32_t buffer_offset
	}, ; 115: System.Memory
	%struct.CompressedAssemblyDescriptor {
		i32 12288, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 10805048; uint32_t buffer_offset
	}, ; 116: System.Net.Http.Json
	%struct.CompressedAssemblyDescriptor {
		i32 128000, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 10817336; uint32_t buffer_offset
	}, ; 117: System.Net.Http
	%struct.CompressedAssemblyDescriptor {
		i32 39424, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 10945336; uint32_t buffer_offset
	}, ; 118: System.Net.Primitives
	%struct.CompressedAssemblyDescriptor {
		i32 7680, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 10984760; uint32_t buffer_offset
	}, ; 119: System.Net.Requests
	%struct.CompressedAssemblyDescriptor {
		i32 5120, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 10992440; uint32_t buffer_offset
	}, ; 120: System.Numerics.Vectors
	%struct.CompressedAssemblyDescriptor {
		i32 20992, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 10997560; uint32_t buffer_offset
	}, ; 121: System.ObjectModel
	%struct.CompressedAssemblyDescriptor {
		i32 74240, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 11018552; uint32_t buffer_offset
	}, ; 122: System.Private.Uri
	%struct.CompressedAssemblyDescriptor {
		i32 45056, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 11092792; uint32_t buffer_offset
	}, ; 123: System.Private.Xml.Linq
	%struct.CompressedAssemblyDescriptor {
		i32 1350656, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 11137848; uint32_t buffer_offset
	}, ; 124: System.Private.Xml
	%struct.CompressedAssemblyDescriptor {
		i32 5120, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 12488504; uint32_t buffer_offset
	}, ; 125: System.Reflection.Emit.ILGeneration
	%struct.CompressedAssemblyDescriptor {
		i32 5120, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 12493624; uint32_t buffer_offset
	}, ; 126: System.Reflection.Emit.Lightweight
	%struct.CompressedAssemblyDescriptor {
		i32 5120, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 12498744; uint32_t buffer_offset
	}, ; 127: System.Reflection.Primitives
	%struct.CompressedAssemblyDescriptor {
		i32 9216, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 12503864; uint32_t buffer_offset
	}, ; 128: System.Runtime.InteropServices
	%struct.CompressedAssemblyDescriptor {
		i32 5120, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 12513080; uint32_t buffer_offset
	}, ; 129: System.Runtime.Loader
	%struct.CompressedAssemblyDescriptor {
		i32 89088, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 12518200; uint32_t buffer_offset
	}, ; 130: System.Runtime.Numerics
	%struct.CompressedAssemblyDescriptor {
		i32 8192, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 12607288; uint32_t buffer_offset
	}, ; 131: System.Runtime.Serialization.Formatters
	%struct.CompressedAssemblyDescriptor {
		i32 6144, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 12615480; uint32_t buffer_offset
	}, ; 132: System.Runtime.Serialization.Primitives
	%struct.CompressedAssemblyDescriptor {
		i32 15360, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 12621624; uint32_t buffer_offset
	}, ; 133: System.Runtime
	%struct.CompressedAssemblyDescriptor {
		i32 6144, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 12636984; uint32_t buffer_offset
	}, ; 134: System.Security.Claims
	%struct.CompressedAssemblyDescriptor {
		i32 124416, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 12643128; uint32_t buffer_offset
	}, ; 135: System.Security.Cryptography
	%struct.CompressedAssemblyDescriptor {
		i32 5120, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 12767544; uint32_t buffer_offset
	}, ; 136: System.Text.Encoding.Extensions
	%struct.CompressedAssemblyDescriptor {
		i32 29696, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 12772664; uint32_t buffer_offset
	}, ; 137: System.Text.Encodings.Web
	%struct.CompressedAssemblyDescriptor {
		i32 414720, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 12802360; uint32_t buffer_offset
	}, ; 138: System.Text.Json
	%struct.CompressedAssemblyDescriptor {
		i32 336384, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 13217080; uint32_t buffer_offset
	}, ; 139: System.Text.RegularExpressions
	%struct.CompressedAssemblyDescriptor {
		i32 5120, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 13553464; uint32_t buffer_offset
	}, ; 140: System.Threading.Thread
	%struct.CompressedAssemblyDescriptor {
		i32 12288, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 13558584; uint32_t buffer_offset
	}, ; 141: System.Threading
	%struct.CompressedAssemblyDescriptor {
		i32 8192, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 13570872; uint32_t buffer_offset
	}, ; 142: System.Web.HttpUtility
	%struct.CompressedAssemblyDescriptor {
		i32 4608, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 13579064; uint32_t buffer_offset
	}, ; 143: System.Xml.Linq
	%struct.CompressedAssemblyDescriptor {
		i32 5632, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 13583672; uint32_t buffer_offset
	}, ; 144: System.Xml.ReaderWriter
	%struct.CompressedAssemblyDescriptor {
		i32 5120, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 13589304; uint32_t buffer_offset
	}, ; 145: System.Xml.XDocument
	%struct.CompressedAssemblyDescriptor {
		i32 5120, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 13594424; uint32_t buffer_offset
	}, ; 146: System
	%struct.CompressedAssemblyDescriptor {
		i32 9216, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 13599544; uint32_t buffer_offset
	}, ; 147: netstandard
	%struct.CompressedAssemblyDescriptor {
		i32 2176512, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 13608760; uint32_t buffer_offset
	}, ; 148: System.Private.CoreLib
	%struct.CompressedAssemblyDescriptor {
		i32 171008, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 15785272; uint32_t buffer_offset
	}, ; 149: Java.Interop
	%struct.CompressedAssemblyDescriptor {
		i32 21536, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 15956280; uint32_t buffer_offset
	}, ; 150: Mono.Android.Runtime
	%struct.CompressedAssemblyDescriptor {
		i32 2044416, ; uint32_t uncompressed_file_size
		i1 false, ; bool loaded
		i32 15977816; uint32_t buffer_offset
	} ; 151: Mono.Android
], align 4

@uncompressed_assemblies_data_size = dso_local local_unnamed_addr constant i32 18022232, align 4

@uncompressed_assemblies_data_buffer = dso_local local_unnamed_addr global [18022232 x i8] zeroinitializer, align 1

; Metadata
!llvm.module.flags = !{!0, !1, !7, !8, !9, !10}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!llvm.ident = !{!2}
!2 = !{!".NET for Android remotes/origin/release/10.0.1xx @ 01024bb616e7b80417a2c6d320885bfdb956f20a"}
!3 = !{!4, !4, i64 0}
!4 = !{!"any pointer", !5, i64 0}
!5 = !{!"omnipotent char", !6, i64 0}
!6 = !{!"Simple C++ TBAA"}
!7 = !{i32 1, !"branch-target-enforcement", i32 0}
!8 = !{i32 1, !"sign-return-address", i32 0}
!9 = !{i32 1, !"sign-return-address-all", i32 0}
!10 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
