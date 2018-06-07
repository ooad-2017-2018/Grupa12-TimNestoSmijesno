using LanacHotela.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;


namespace LanacHotela.Model
{
    public partial class MainPage : Page
    {
        public const string FEATURE_NAME = "Printing C# Sample";
        internal static object Current;
        List<Scenario> scenarios = new List<Scenario>
        {
            new Scenario() { Title="Basic", ClassType=typeof(Scenario1Basic)},

        };
    }

    public class Scenario
    {
        public string Title { get; set; }
        public Type ClassType { get; set; }
    }
}
