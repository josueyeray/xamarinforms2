namespace _05Effects.Droid.Effects
{
    using Android.Graphics;
    using Xamarin.Forms.Platform.Android;
    public class FocusEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            Control.FocusChange += Control_FocusChange;
        }

        protected override void OnDetached()
        {
            Control.FocusChange -= Control_FocusChange;
        }

        private void Control_FocusChange(object sender, Android.Views.View.FocusChangeEventArgs e)
        {
            if (e.HasFocus)
                Control.SetBackgroundColor(Color.Cyan);
            else
                Control.SetBackgroundColor(Color.White);
        }
    }
}