using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Views;
using Android.Content.Res;
using System.IO;

using Android.Util;
using Android.Content;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using System.Text.RegularExpressions;
using Org.Xwalk.Core;

namespace XWalk
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Org.Xwalk.Core.XWalkActivity
    {

  
        public Org.Xwalk.Core.XWalkView xwv;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            xwv = (Org.Xwalk.Core.XWalkView)FindViewById(Resource.Id.xwalkview);
        }

        protected override void OnXWalkReady()
        {
            

            /* var view = new RelativeLayout(this.BaseContext);
             var mp = ViewGroup.LayoutParams.MatchParent;
             xwv = new Org.Xwalk.Core.XWalkView(this.BaseContext, this);
             view.AddView(xwv);
             this.AddContentView(view, new ViewGroup.LayoutParams(mp, mp));
             xwv.SetResourceClient(new XWalkResourceClient(xwv));
             xwv.SetUIClient(new XWalkUIClient(xwv));
             xwv.LoadUrl("file:///android_asset/index.html");*/

            xwv.Load("file:///android_asset/index.html", null);

        }




    }
}

