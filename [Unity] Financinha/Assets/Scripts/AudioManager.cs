using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class AudioManager : MonoBehaviour
{

    public AudioMixer mixerMusic;
    public AudioMixer mixerSoundEffects;
    public void SetVolumeMusic(float music)
    {
        mixerMusic.SetFloat("volume", music);
    }
    public void SetVolumeSoundEffects(float soundEffects)
    {
        mixerSoundEffects.SetFloat("Effect", soundEffects);
    }

}
