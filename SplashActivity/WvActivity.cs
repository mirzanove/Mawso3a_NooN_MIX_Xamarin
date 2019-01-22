using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;

namespace com.xamarin.sample.splashscreen
{
    [Activity(Label = "WvActivity")]
    public class WvActivity : Activity
    {
        private WebView wv;
        AppPreferences hh;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Webview);
            wv= (WebView)FindViewById(Resource.Id.WV);

            wv.SetWebChromeClient(new WebChromeClient());
            wv.SetWebViewClient(new WebViewClient());
            wv.Settings.JavaScriptEnabled = true;
            wv.Settings.DomStorageEnabled = true;
            wv.Settings.SetSupportZoom(true);
            wv.Settings.DisplayZoomControls = false;
            wv.Settings.BuiltInZoomControls = true;
            wv.Settings.CacheMode = CacheModes.Default;
            wv.Settings.UseWideViewPort = true;
            wv.Settings.LoadWithOverviewMode = true;
            wv.SetInitialScale(1);


            hh = new AppPreferences(this);
            
            if (savedInstanceState == null)
            {
                wv.LoadUrl(hh.getAccessKey("SP_WEBVIEW_PREFS", "file:///android_asset/index.html"), null);
                MainActivity.fa.Finish();
            }


        }

        protected override void OnResume()
        {
            base.OnResume();
            
        }

        public override void OnBackPressed()
        {
            
            if (wv.CanGoBack())
            {
                wv.GoBack();
            }
            else
            {
                base.OnBackPressed();
            }

        }

        public override void OnConfigurationChanged(Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);
        }

        public override void OnSaveInstanceState(Bundle outState, PersistableBundle outPersistentState)
        {
            base.OnSaveInstanceState(outState, outPersistentState);
            wv.SaveState(outState);
        }

        public override void OnRestoreInstanceState(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnRestoreInstanceState(savedInstanceState, persistentState);
            wv.RestoreState(savedInstanceState);
        }


    }
}