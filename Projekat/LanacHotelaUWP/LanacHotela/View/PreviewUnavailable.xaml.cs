using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LanacHotela.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PreviewUnavailable : Page
    {
        public PreviewUnavailable()
        {
            this.InitializeComponent();
        }
        /// <summary>
        /// Preview unavailable page constructor
        /// </summary>
        /// <param name="paperSize">The printing page paper size</param>
        /// <param name="printableSize">The usable/"printable" area on the page</param>
        public PreviewUnavailable(Size paperSize, Size printableSize)
            : this()
        {
            Page.Width = paperSize.Width;
            Page.Height = paperSize.Height;

            PrintablePage.Width = printableSize.Width;
            PrintablePage.Height = printableSize.Height;
        }
    }
}
