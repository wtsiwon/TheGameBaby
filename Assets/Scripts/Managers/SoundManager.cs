using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ESoundType
{
    BGM,
    SFX,
    Narration
}
public class SoundManager : SingletonDDOL<SoundManager>
{
    [SerializeField]
    public List<AudioSource> audioSources = new List<AudioSource>();

    private Dictionary<ESoundType, AudioClip> sounds = new Dictionary<ESoundType, AudioClip>();

    private void Start()
    {
        foreach (var audio in audioSources)
        {
            //Dictionary에 List에 있는 사운드 삽입
        }
    }
}
