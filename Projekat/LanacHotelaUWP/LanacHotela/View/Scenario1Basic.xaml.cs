using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Windows.Graphics.Printing;
using LanacHotela;
using LanacHotela.Model;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace LanacHotela.View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Scenario1Basic : Page
    {
        private PrintHelper printHelper;
        public Scenario1Basic()
        {
            this.InitializeComponent();

        }
        private async void OnPrintButtonClick(object sender, RoutedEventArgs e)
        {
            try
            {
                // Show print UI
                await PrintManager.ShowPrintUIAsync();

            }
            catch
            {
                // Printing cannot proceed at this time
                ContentDialog noPrintingDialog = new ContentDialog()
                {
                    Title = "Printing error",
                    Content = "\nSorry, printing can't proceed at this time.",
                    PrimaryButtonText = "OK"
                };
                await noPrintingDialog.ShowAsync();
            }
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (PrintManager.IsSupported())
            {
                // Tell the user how to print
                MainPage.Current.NotifyUser("Print contract registered with customization, use the Print button to print.", NotifyType.StatusMessage);
            }
            else
            {
                // Remove the print button
                InvokePrintingButton.Visibility = Visibility.Collapsed;

                // Inform user that Printing is not supported
                MainPage.Current.NotifyUser("Printing is not supported.", NotifyType.ErrorMessage);

                // Printing-related event handlers will never be called if printing
                // is not supported, but it's okay to register for them anyway.
            }

            // Initalize common helper class and register for printing
            printHelper = new PrintHelper(this);
            printHelper.RegisterForPrinting();

            // Initialize print content for this scenario
            printHelper.PreparePrintContent(new PageToPrint());
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            if (printHelper != null)
            {
                printHelper.UnregisterForPrinting();
            }
        }

        private void dugmenazad_Click(object sender, RoutedEventArgs e)
        {
            Page nova = new MojiHoteli();
            this.Content = nova;
        }
    }
}
