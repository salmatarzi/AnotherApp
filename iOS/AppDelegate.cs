using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using InstabugLib;

namespace AnotherApp.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());


            MobileCenter.Start("bee61df3-b1d5-4c9d-acaa-4f765ac3e82e",
                   typeof(Analytics), typeof(Crashes));

            Instabug.StartWithToken("0edda632c31ef9fe70e39cafd2dc241a", IBGInvocationEvent.FloatingButton);

            return base.FinishedLaunching(app, options);
        }
    }
}
