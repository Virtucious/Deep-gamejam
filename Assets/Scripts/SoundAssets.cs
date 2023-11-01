using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundAssets : MonoBehaviour
{
    public static SoundAssets instance;
    public SoundAudioClip[] soundAudioClipArray;


    [System.Serializable]
    public class SoundAudioClip
    {
        public SoundManager.Sound sound;
        public AudioClip audioClip;
    }

    private void Awake()
    {
        instance = this;
    }
}
