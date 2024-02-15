using Android.App;
using Android.Runtime;
using MvvmCross.Core;//.Platforms.Android.Views;
using MvvmCross.Droid.Platform;
using RetriX.Android.Platform;
using System;

namespace RetriX.Android
{
    [Application]
    public class App //: MvxAndroidApplication<CustomSetup<Shared.App>, Shared.App>
    {
        public App(IntPtr javaReference, JniHandleOwnership transfer)
            : base()//(javaReference, transfer)
        {
        }
    }
}