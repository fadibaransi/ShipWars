using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeScript : MonoBehaviour {
    public AudioMixer Mixer;

    public void SetLevel(float SliderValue)
    {
        Mixer.SetFloat("Audio Source", Mathf.Log10(SliderValue) * 20);
    }
	
}
