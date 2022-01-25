using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_Basics
{
    public partial class QuotesPage : ContentPage
    {
        private int _index = 0;
        private string[] _quotes = new string[]
        {
            "Life is like riding a bicycle. To keep your balance, you must keep moving.",
            "You can't blame gravity for falling in love.",
            "Look deep into nature, and then you will understand everything better."
        };
        public QuotesPage()
        {
            InitializeComponent();

           
        }

      void ChangeClick(object s, EventArgs e)
        {
            _index++;
            if (_index >= _quotes.Length)
                _index = 0;

            Quotes.Text = _quotes[_index];
        }
    }
}
