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
        mixerMusic.SetFloat("music", music);
    }
    public void SetVolumeSoundEffects(float soundEffects)
    {
        mixerSoundEffects.SetFloat("soundEffects", soundEffects);
    }

}
