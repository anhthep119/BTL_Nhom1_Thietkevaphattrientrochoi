using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSetting : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void Setvolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
