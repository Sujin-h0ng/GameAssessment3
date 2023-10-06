using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip ghostNormalStateClip;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(audioSource.clip);
    }

    void Update()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.clip = ghostNormalStateClip;
            audioSource.Play();
            this.enabled = false;
        }
    }
}

