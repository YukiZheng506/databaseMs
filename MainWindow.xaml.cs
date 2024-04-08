using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Telerik.Windows.Controls;

namespace DatabaseMSWpfApp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : RadRibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadRibbonButton_Click(object sender, RoutedEventArgs e)
        {
            RadTabItem tTab = MainTabControl.SelectedItem as RadTabItem;
            SignalGridView signalGrid = new SignalGridView();
            tTab.Content = signalGrid;
            MainTabControl.Items.Add(tTab);
            MainTabControl.SelectedItem = tTab;


        }

        private void MainTabControl_SelectionChanged(object sender, RadSelectionChangedEventArgs e)
        {
            if (MainTabControl.SelectedItem != null)
            {
                RadTabItem tTab = MainTabControl.SelectedItem as RadTabItem;
            }
        }
    }
}
