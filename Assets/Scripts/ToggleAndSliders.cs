using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ToggleAndSliders : MonoBehaviour
{
    public AudioSource audioSource; 
    
    public void StopAudio (AudioSource audioSource)
    {
        audioSource.volume = 0f;
    }
}
