using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace _03Pinch.Views
{
    public partial class MainPage : ContentPage
    {
        private double startScale = 0;
        private double currentScale = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void PinchUpdated_Event(object sender, PinchGestureUpdatedEventArgs e)
        {
            Image img = (Image)sender;
            switch (e.Status)
            {
                case GestureStatus.Started:
                    {
                        this.startScale = this.Scale;
                    }
                    break;
                case GestureStatus.Running:
                    this.currentScale += (e.Scale - 1) * this.startScale;
                    this.currentScale = Math.Max(1, this.currentScale);
                    this.Scale = currentScale;
                    break;
                case GestureStatus.Completed:
                    break;
                default:
                    break;
            }
        }
    }
}
