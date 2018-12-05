using System;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;

namespace Tpying_Race
{
    class SpeechSynthesizer
    {
        public  System.Speech.Synthesis.SpeechSynthesizer aSynth = new System.Speech.Synthesis.SpeechSynthesizer();
        private PromptBuilder pBuilder = new PromptBuilder();
        private SpeechRecognitionEngine sRecognition = new SpeechRecognitionEngine();
        private Thread BeginSpeech;
        private string sentence;

        public void Speak(string sentence, int rate)
        {
            this.sentence = sentence;
            aSynth.Rate = rate;
            BeginSpeech = new Thread(Asynth);
            BeginSpeech.Start();
        }
        public void Asynth()
        {
            try
            {
                aSynth.SpeakAsyncCancelAll();
                pBuilder.ClearContent();
                pBuilder.AppendText(sentence);
                aSynth.Speak(pBuilder);
            }
            catch { return; }
        }
        public void PauseAsynth()
        {
            aSynth.Pause();
        }
        public void ContinueAsynth()
        {
            aSynth.Resume();
        }
        public void AbortAsynth()
        {
            ((IDisposable)aSynth).Dispose();
        }
    }
}
