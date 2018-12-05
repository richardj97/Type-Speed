using System.Collections.Generic;
using System.Speech.Synthesis;

namespace Tpying_Race
{
    class SpeechSynthesizerDevice
    {
        public List<string> GetInstalledVoices()
        {
            List<string> InstalledVoices = new List<string>();

            using (System.Speech.Synthesis.SpeechSynthesizer aSynth = new System.Speech.Synthesis.SpeechSynthesizer())
            {
                foreach (InstalledVoice voices in aSynth.GetInstalledVoices())
                {
                    if (voices.Enabled)
                        InstalledVoices.Add(voices.VoiceInfo.Name);
                }
            }
            return InstalledVoices;
        }
    }
}
