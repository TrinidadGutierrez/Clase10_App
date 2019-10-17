using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Clase10_App.Views
{
    public class Index : ContentPage
    {
        public Index()
        {
            /*Content = new Label { Text = "Hello World" };*/
            // Es lo mismo que ponerlo asi
            /*  Label label = new Label();
            label.Text = "Hello World";*/
            Label label = new Label();
            label.Text = "Hello World";
            label.FontSize = 25;
            label.TextColor = Color.Black;
            label.BackgroundColor = Color.LightPink;
            label.HorizontalOptions = LayoutOptions.EndAndExpand;

            Label label1 =
                new Label
            { Text = "zaraza", TextColor = Color.DarkGreen};
            StackLayout stackLayout = new StackLayout();
            stackLayout.Children.Add(label);
            stackLayout.Children.Add(label1);

            Content = stackLayout;
        }
    }
}
 