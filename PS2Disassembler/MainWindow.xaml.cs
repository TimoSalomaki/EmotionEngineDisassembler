using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using PS2Disassembler.ViewModel;
using System;
using System.Windows;
using System.Xml;

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

            var assembly = this.GetType().Assembly;

            using (var stream = assembly.GetManifestResourceStream(assembly.GetName().Name + ".MIPSSyntax.xshd"))
            {
                using (var reader = new XmlTextReader(stream))
                {
                    AssemblyEditor.SyntaxHighlighting = HighlightingLoader.Load(reader, HighlightingManager.Instance);
                }
            }

            _vm = new MainViewVM();
            this.DataContext = _vm;
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
        }
    }
}
