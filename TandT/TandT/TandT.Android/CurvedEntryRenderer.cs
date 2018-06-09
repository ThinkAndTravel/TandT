using System;
using System.ComponentModel;
using Android.Content;
using Android.Graphics.Drawables;
using Android.Util;
using CustomControls;
using CryptoNextForms.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CurvedEntryRenderer))]
namespace CryptoNextForms.Droid
{
    public class CurvedEntryRenderer:EntryRenderer
    {
        private GradientDrawable _gradientBackground;

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);

            var view = (CustomEntry)Element;
            if (view == null) return;

            Paint(view);
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if
            (e.PropertyName == CustomEntry.CustomBorderColorProperty.PropertyName ||
             e.PropertyName == CustomEntry.CustomBorderRadiusProperty.PropertyName ||
             e.PropertyName == CustomEntry.CustomBorderWidthProperty.PropertyName)
            {

                if (Element != null)
                {
                    Paint((CustomEntry)Element);
                }
            }
        }
        private void Paint(CustomEntry view)
        {
            _gradientBackground = new GradientDrawable();
            _gradientBackground.SetShape(ShapeType.Rectangle);
            _gradientBackground.SetColor(view.CustomBackgroundColor.ToAndroid());

            // Thickness of the stroke line
            _gradientBackground.SetStroke((int)view.CustomBorderWidth, view.CustomBorderColor.ToAndroid());

            // Radius for the curves
            _gradientBackground.SetCornerRadius(
                DpToPixels(this.Context, Convert.ToSingle(view.CustomBorderRadius)));

            // set the background of the label
            Control.SetBackground(_gradientBackground);
        }

        public static float DpToPixels(Context context, float valueInDp)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, valueInDp, metrics);
        }
    }
}