using System;

namespace Problem {
    class Program {
        static void Main(string[] args) {
            Player player = new Player();

            Play(player, "millioni alih roz");


            Record(player, " of nature");
        }

        static void Play(IPlayable player, in string songTitle) {
            player.Play();
            System.Console.Write(" " + songTitle);
            System.Console.WriteLine();

            player.PausePlaying();
            System.Console.Write(" " + songTitle);
            System.Console.WriteLine();

            player.StopPlaying();
            System.Console.WriteLine(" " + songTitle);
            System.Console.WriteLine();
        }

        static void Record(IRecordable recorder, in string soundTitle) {
            recorder.Record();
            System.Console.Write(" " + soundTitle);
            System.Console.WriteLine();

            recorder.PauseRecording();
            System.Console.Write(" " + soundTitle);
            System.Console.WriteLine();

            recorder.StopRecording();
            System.Console.WriteLine(" " + soundTitle);
            System.Console.WriteLine();
        }
    }


    interface IPlayable {
        void Play();
        void PausePlaying();
        void StopPlaying();
    }

    interface IRecordable {
        void Record();
        void PauseRecording();
        void StopRecording(); 
    }

    class Player : IPlayable, IRecordable {
        public void Play() {
            System.Console.Write("Playing music");
        }
        public void PausePlaying() {
            System.Console.Write("Paused playing music");
        }

        public void StopPlaying() {
            System.Console.Write("Stoped playing music");
        }
        
        public void Record() {
            System.Console.Write("Recording sound");
        }
        public void PauseRecording() {
            System.Console.Write("Paused recording sound");
        }
        public void StopRecording() {
            System.Console.Write("Stoped recording sound");
        }
    }
}
