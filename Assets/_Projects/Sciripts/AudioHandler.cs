using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _crashSound,_finishSound;

    public void PlayCrashSound()
    {
        _audioSource.clip = _crashSound;
        _audioSource.Play();    
    }

    public void PlayFinishSound()
    {
        _audioSource.clip = _finishSound;
        _audioSource.Play();
    }

}
