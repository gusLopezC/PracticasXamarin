using System;
using Xamarin.Forms;
using System.Runtime.CompilerServices;
using Multipedia.Droid;
using Android.Media;
using Android.Content.Res;


[assembly: Xamarin.Forms.Dependency(typeof(Multipedia.Droid.AudioService))]
namespace Multipedia.Droid

{
    public class AudioService : IAudio
    {
        public AudioService()
        {
        }

        public void PlayAudioFile(string fileName)
        {
            var player = new MediaPlayer();
            var fd = global::Android.App.Application.Context.Assets.OpenFd(fileName);
            player.Prepared += (s, e) =>
            {
                player.Start();
            };
            player.SetDataSource(fd.FileDescriptor,fd.StartOffset,fd.Length);
            player.Prepare();
        }
    }
}
