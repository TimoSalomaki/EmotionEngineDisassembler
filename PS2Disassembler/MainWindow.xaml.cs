using PS2Disassembler.ViewModel;
using System.Windows;

namespace PS2Disassembler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainViewVM _vm;

        public MainWindow()
        {
            InitializeComponent();

            _vm = new MainViewVM();
            this.DataContext = _vm;
        }
    }
}
