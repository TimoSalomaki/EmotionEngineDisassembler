using ICSharpCode.AvalonEdit.Highlighting;
using ICSharpCode.AvalonEdit.Highlighting.Xshd;
using PS2Disassembler.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Windows;
using System.Xml;
using Microsoft.Win32;
using PS2Disassembler.Core;

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

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            var parsedBuffers = new List<byte[]>();
            var disassembler = new Disassembler();
            var outputBuilder = new StringBuilder();
            var stopWatch = new Stopwatch();

            if (openFileDialog.ShowDialog() == true)
            {
                stopWatch.Start();
                var fileName = openFileDialog.FileName;
                var fInfo = new FileInfo(openFileDialog.FileName);

                using var fileStream = fInfo.OpenRead();

                //bool success = GC.TryStartNoGCRegion(110000000);

                var buffer = new byte[41 * 2048];
                var parsedBuffer = new byte[32 * 2048];

                do
                {
                    var inputLength = 0;
                    var bufferDataLength = FillBuffer(fileStream, buffer);

                    if (bufferDataLength == 0)
                        break;

                    for (int i = 0, pI = 0; i < bufferDataLength; i += 41)
                    {
                        for (int j = i; j < i + 40; j += 10, pI += 8)
                        {
                            if (j + 8 < buffer.Length)
                            {
                                parsedBuffer[pI] = buffer[j + 7];
                                parsedBuffer[pI + 1] = buffer[j + 8];
                                parsedBuffer[pI + 2] = buffer[j + 5];
                                parsedBuffer[pI + 3] = buffer[j + 6];
                                parsedBuffer[pI + 4] = buffer[j + 2];
                                parsedBuffer[pI + 5] = buffer[j + 3];
                                parsedBuffer[pI + 6] = buffer[j];
                                parsedBuffer[pI + 7] = buffer[j + 1];
                                inputLength += 8;
                            }
                        }
                    }

                    disassembler.DisassembleByteArray(parsedBuffer, inputLength, ref outputBuilder);

                    //parsedBuffers.Add(parsedBuffer);

                } while (true);
            }
            stopWatch.Stop();
            _vm.StatusText = stopWatch.Elapsed.ToString();

            //GC.EndNoGCRegion();

            _vm.Output.BeginUpdate();
            _vm.Output.Replace(0, _vm.Output.TextLength, outputBuilder.ToString());
            _vm.Output.EndUpdate();


            //_vm.DisassembleByteArrays(parsedBuffers);
        }

        private static int FillBuffer(Stream stream, byte[] buffer)
        {
            int read;
            int totalRead = 0;

            do
            {
                read = stream.Read(buffer, totalRead, buffer.Length - totalRead);
                totalRead += read;

            } while (read > 0 && totalRead < buffer.Length);

            return totalRead;
        }
    }
}
