using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioMixer0 : MonoBehaviour
{
    public AudioMixer masterMixer;
    public Slider audioSLider;
    public Slider SFXsLider;


    public void AudioControl()
    {
        float sound = audioSLider.value;
        float soundSfx = SFXsLider.value;

        if (sound == -40f) masterMixer.SetFloat("BGM", -80);
        else masterMixer.SetFloat("BGM", sound);

        if (sound == -40f) masterMixer.SetFloat("SFX", -80);
        else masterMixer.SetFloat("SFX", soundSfx);
    }
    
}
