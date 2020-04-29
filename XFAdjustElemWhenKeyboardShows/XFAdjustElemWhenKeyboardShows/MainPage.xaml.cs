using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFAdjustElemWhenKeyboardShows
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private List<string> _sampleListData;
        public List<string> SampleListData
        {
            get => _sampleListData;
            set
            {
                _sampleListData = value;
                OnPropertyChanged();
            }
        }

        public MainPage()
        {
            InitializeComponent();

            this.SampleListData = new List<string>
            {
                "item One",
                "item Two",
                "item Three",
                "item Four",
                "item Five",
                "item Six",
            };

            this.BindingContext = this;
        }
    }
}
