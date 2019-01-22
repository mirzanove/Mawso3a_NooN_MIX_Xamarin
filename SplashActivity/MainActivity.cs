using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Android.Preferences;

using Android.Util;
using Android.Widget;
using Java.Util;
using System;
using System.Resources;

namespace com.xamarin.sample.splashscreen
{
 
    [Activity(Label = "@string/ApplicationName", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, Theme = "@style/MyTheme")]
    public class MainActivity : Activity
    {

        public static Activity fa;
      

        protected override void OnCreate(Bundle bundle)
        {

            //Locale locale = new Locale("ar");


            var languageIso = "ar";
            var locale = new Java.Util.Locale(languageIso);// languageIso is locale string
            Java.Util.Locale.Default = locale;
            var config = new Android.Content.Res.Configuration { Locale = locale };
            BaseContext.Resources.UpdateConfiguration(config, BaseContext.Resources.DisplayMetrics);


            base.OnCreate(bundle);
   
            SetContentView(Resource.Layout.Main);
           


            fa = this;

            int currentapiVersion = (int)(Build.VERSION.SdkInt);

            AppPreferences hh = new AppPreferences(this);

            

            if (currentapiVersion >= 19)
            {
               
                if (hh.getAccessKey("PREFERENCE_WEBVIEW_TYPE","null").Equals("null"))
                {

                    getdiag(hh);

                }
                else
                {

                    if (hh.getAccessKey("PREFERENCE_WEBVIEW_TYPE","null").Equals("notCross"))
                    {
                        StartActivity(new Intent(Application.Context, typeof(WvActivity)).AddFlags(ActivityFlags.NoAnimation));

                    }
                    else
                    {
                        StartActivity(new Intent(Application.Context, typeof(CrossActivity)).AddFlags(ActivityFlags.NoAnimation));

                    }



                }

            }
            else
            {

                StartActivity(new Intent(Application.Context, typeof(CrossActivity)).AddFlags(ActivityFlags.NoAnimation));

            }



        }

        protected override void OnResume()
        {
            base.OnResume();

        }



        public void getdiag(AppPreferences hh)
        {


            // setup the alert builder
            AlertDialog.Builder builder = new AlertDialog.Builder(this);
            builder.SetTitle("اختر نوع المتصفح الذي تفضله:");

            // add a radio button list
            String[] animals = { "المتصفح الداخلي الذي يأتي مع الاندرويد...", "المتصفح كروسوك المستقل يحتاج للتثبيت مرة واحدة فقط..." };
            int checkedItem = 0; // cow
            builder.SetSingleChoiceItems(animals, checkedItem, (s, e) => {

                checkedItem = e.Which;
                Log.Debug("hhhhhhhh", e.Which.ToString());

            });

            builder.SetPositiveButton("ok", (s, e) => {

                if (checkedItem == 0)
                {
                    Toast.MakeText(this, "notCross ", ToastLength.Short).Show();

                    hh.saveAccessKey("notCross", "PREFERENCE_WEBVIEW_TYPE");
                    StartActivity(new Intent(Application.Context, typeof(WvActivity)).AddFlags(ActivityFlags.NoAnimation));

                }
                else
                {
                    Toast.MakeText(this, "Cross ", ToastLength.Short).Show();
                    hh.saveAccessKey("Cross", "PREFERENCE_WEBVIEW_TYPE");
                    StartActivity(new Intent(Application.Context, typeof(CrossActivity)).AddFlags(ActivityFlags.NoAnimation));


                }

            });

            AlertDialog dialog = builder.Create();
            dialog.Show();
            dialog.SetCanceledOnTouchOutside(false);



        }

    }










    public class AppPreferences
    {
        private ISharedPreferences mSharedPrefs;
        private ISharedPreferencesEditor mPrefsEditor;
        private Context mContext;

        //private static String PREFERENCE_ACCESS_KEY = "PREFERENCE_WEBVIEW_TYPE";

        public AppPreferences(Context context)
        {
            this.mContext = context;
            mSharedPrefs = PreferenceManager.GetDefaultSharedPreferences(mContext);
            mPrefsEditor = mSharedPrefs.Edit();
        }

        public void saveAccessKey(string key, String PREFERENCE_ACCESS_KEY)
        {
            mPrefsEditor.PutString(PREFERENCE_ACCESS_KEY, key);
            mPrefsEditor.Commit();
        }

        public string getAccessKey(String PREFERENCE_ACCESS_KEY , String def)
        {
            return mSharedPrefs.GetString(PREFERENCE_ACCESS_KEY, def);
        }
    }
}