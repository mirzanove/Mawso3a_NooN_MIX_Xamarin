using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Org.Xwalk.Core;


namespace com.xamarin.sample.splashscreen
{
    [Activity(Label = "CrossActivity")]
    public class CrossActivity : Activity, XWalkInitializer.IXWalkInitListener, XWalkUpdater.IXWalkUpdateListener
    {
        
            private XWalkInitializer mXWalkInitializer;
            private XWalkUpdater mXWalkUpdater;
            private Org.Xwalk.Core.XWalkView xwv;

            protected override void OnCreate(Bundle bundle)
            {
                base.OnCreate(bundle);

               // this.Window.AddFlags(WindowManagerFlags.Fullscreen);

                mXWalkInitializer = new XWalkInitializer(this, this);
                mXWalkInitializer.InitAsync();

                SetContentView(Resource.Layout.XWalkView);

                xwv = (Org.Xwalk.Core.XWalkView)FindViewById(Resource.Id.xwalkview);

           
            }

            public void OnXWalkInitCompleted()
            {
                if (mXWalkUpdater != null)
                {
                    mXWalkUpdater.DismissDialog();
                }
                xwv.Load("file:///android_asset/index.html", null);

                MainActivity.fa.Finish();

            //throw new NotImplementedException();
        }

            protected override void OnResume()
            {
                base.OnResume();
                mXWalkInitializer.InitAsync();
            }

            public void OnXWalkInitCancelled()
            {
                Finish();
                //throw new NotImplementedException();
            }



            public void OnXWalkInitFailed()
            {
                if (mXWalkUpdater == null)
                {
                    mXWalkUpdater = new XWalkUpdater(this, this);
                }
                mXWalkUpdater.UpdateXWalkRuntime();

                //throw new NotImplementedException();
            }

            public void OnXWalkInitStarted()
            {
                //throw new NotImplementedException();
            }

            public void OnXWalkUpdateCancelled()
            {
                Finish();
                //throw new NotImplementedException();
            }
        }
}