using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public List<AudioClip> auClips = new List<AudioClip>();
    private int tempValue;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayAudio()
    {
        tempValue = Random.Range(0, 4);
        print(tempValue);
        audioSource.clip = auClips[tempValue];
        audioSource.Play();
    }
}