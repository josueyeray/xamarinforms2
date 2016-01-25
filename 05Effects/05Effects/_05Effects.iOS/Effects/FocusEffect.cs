namespace _05Effects.iOS.Effects
{
    using System.ComponentModel;
    using UIKit;
    using Xamarin.Forms.Platform.iOS;

    public class FocusEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
        }

        protected override void OnDetached()
        {
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            if (args.PropertyName == "IsFocused")
            {
                if (Control.BackgroundColor == UIColor.Cyan)
                    Control.BackgroundColor = UIColor.White;
                else
                    Control.BackgroundColor = UIColor.Cyan;
            }
        }
    }
}
