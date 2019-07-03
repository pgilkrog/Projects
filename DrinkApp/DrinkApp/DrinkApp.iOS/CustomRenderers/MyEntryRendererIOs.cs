using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrinkApp.iOS.CustomRenderers;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(Entry), typeof(MyEntryRendererIOs))]
namespace DrinkApp.iOS.CustomRenderers
{
    public class MyEntryRendererIOs : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BackgroundColor = UIColor.FromRGB(240, 248, 255);
                Control.TintColor = UIColor.FromRGB(240, 248, 255);
            }
        }
    }
}