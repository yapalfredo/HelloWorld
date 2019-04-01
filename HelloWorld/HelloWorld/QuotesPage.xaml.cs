using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotesPage : ContentPage
    {
        public string[] myQuotes ={"My life is my messagen", "Stay hungry. Stay foolish",
                                    "Every noble work is at first impossible", "Fall seven times, stand up eigh",
                                    "You matter"};
        public string displayQuote;
        public int index = 0;

        public QuotesPage ()
		{
			InitializeComponent ();
            displayQuote = myQuotes[index];            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if( index > 4 )
            {
                index = 0;
            }
            displayQuote = myQuotes[index];
            labelSecond.Text = displayQuote;
            index++;
        }
    }
}