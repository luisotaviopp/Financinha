using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class AudioManager : MonoBehaviour
{

    public AudioMixer mixerMusic;
    public AudioMixer mixerSoundEffects;

    public AudioSource mainAudioSource;
    public AudioClip coinSoundClip;

    private void Start()
    {
        mainAudioSource = gameObject.GetComponent<AudioSource>();
    }

    public void SetVolumeMusic(float music)
    {
        mixerMusic.SetFloat("volume", music);
    }

    public void SetVolumeSoundEffects(float soundEffects)
    {
        mixerSoundEffects.SetFloat("Effect", soundEffects);
    }


    public void PlayCoinSound()
    {
        mainAudioSource.clip = coinSoundClip;
        mainAudioSource.Play();
    }
}
