using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CarouselM01
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaCarousel : CarouselPage
    {
        public PaginaCarousel()
        {
            InitializeComponent();

        }

        private void BtIr2(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}