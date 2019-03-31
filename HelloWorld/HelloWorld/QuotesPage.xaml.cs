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
		public QuotesPage ()
		{
			InitializeComponent ();
		}

        string[] quotes = { "My life is my messagen", "Stay hungry. Stay foolish",
                            "Every noble work is at first impossible", "Fall seven times, stand up eigh",
                            "You matter"};


	}
}