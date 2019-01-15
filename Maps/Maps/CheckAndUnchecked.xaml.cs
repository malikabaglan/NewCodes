using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Maps
{
    public partial class CheckAndUnchecked : ContentPage
    {
        public CheckAndUnchecked()
        {
            InitializeComponent();
            this.BindingContext = new ViewModal();
        }
    }
}
