using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace App1
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Binding binding = new Binding();
        public MainPage()
        {
            this.InitializeComponent();

        }

        private async void ClickHandler(object sender, RoutedEventArgs e)
        {
            MediaElement mediaElement = new MediaElement();
            var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
            Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream = await synth.SynthesizeTextToStreamAsync("Пашел нахуй черт");
            mediaElement.SetSource(stream, stream.ContentType);
            binding.GetValue(Text);
            mediaElement.Play();

        }

        private void ChangeTextValue(TextBlock textBlock, string textNewValue)
        {
            textBlock.Text = textNewValue;
        }
        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        void FindTextNode(string nodeName)
        {
            
        }
        
    }
}
