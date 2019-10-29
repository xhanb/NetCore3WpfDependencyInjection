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
using Microsoft.Extensions.Options;
using NetCore3WpfDependencyInjection.Services;

namespace NetCore3WpfDependencyInjection
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ISampleService sampleService;
        private readonly AppSettings settings;

        public MainWindow(ISampleService sampleService,
            IOptions<AppSettings> settings)
        {
            InitializeComponent();

            this.sampleService = sampleService;
            this.settings = settings.Value;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var serviceData =await sampleService.GetCurrentDate();
            var settingsData = settings;
            TextBox1.Text = $"serviceData:{serviceData}{Environment.NewLine}settingsData:{settings.AppName}";
        }
    }
}
