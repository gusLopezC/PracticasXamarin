using Xamarin.Forms;

namespace Multipedia
{
    public partial class MultipediaPage : ContentPage
    {
        public MultipediaPage()
        {
            InitializeComponent();
            btnPlay.Clicked+= BtnPlay_Clicked;
        }

        private void BtnPlay_Clicked(object sender, System.EventArgs e)
        {
            EjecutarAudio("Audio.mp3");
        }
        private void EjecutarAudio(string v){
            DependencyService.Get<IAudio>().PlayAudioFile(v);
        }
    }
}
