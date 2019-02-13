using System;
using Xamarin.Forms;

namespace Homework_3_2
{
    public class HobbiePage : ContentPage
    {
        public HobbiePage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

