using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ESoundType
{
    BGM,
    SFX,
    first,
    second,
    third,
    fourth,
    fifth
}
public class SoundManager : SingletonDDOL<SoundManager>
{
    [SerializeField]
    private List<AudioClip> firstaudio = new List<AudioClip>();
    [SerializeField]
    private List<AudioClip> secondaudio = new List<AudioClip>();
    [SerializeField]
    private List<AudioClip> thirdaudio = new List<AudioClip>();
    [SerializeField]
    private List<AudioClip> fourthaudio = new List<AudioClip>();
    [SerializeField]
    private List<AudioClip> fifthaudio = new List<AudioClip>();
    [SerializeField]
    private List<AudioClip> BGM = new List<AudioClip>();
    [SerializeField]
    private List<AudioClip> SFX = new List<AudioClip>();

    private Dictionary<ESoundType, List<AudioClip>> sounds = new Dictionary<ESoundType, List<AudioClip>>();
    private Dictionary<string, List<AudioClip>> soundclip = new Dictionary<string, List<AudioClip>>();

    private void Start()
    {
        foreach(var sound in BGM)
        {
            sounds[ESoundType.BGM].Add(sound);
        }
        foreach(var sound in SFX)
        {
            sounds[ESoundType.SFX].Add(sound);
        }
    }
    public AudioClip GetAudio(ESoundType soundtype, string name)
    {
        AudioClip audioClip;

        return null;
    }
    /// <summary>
    /// 나레이션 종류받아서 정하는 함수
    /// </summary>
    /// <param name="sound">열거형으로 나레이션 종류를 정함</param>

    public void SelectNarration(ESoundType sound)
    {
        sounds[sound] = null;

        switch(sound)
        {
            case ESoundType.first:
                foreach(var audio in firstaudio)
                {
                    sounds[sound].Add(audio);
                }
                break;
            case ESoundType.second:
                foreach (var audio in secondaudio)
                {
                    sounds[sound].Add(audio);
                }
                break;
            case ESoundType.third:
                foreach (var audio in thirdaudio)
                {
                    sounds[sound].Add(audio);
                }
                break;
            case ESoundType.fourth:
                foreach (var audio in fourthaudio)
                {
                    sounds[sound].Add(audio);
                }
                break;
            case ESoundType.fifth:
                foreach (var audio in fifthaudio)
                {
                    sounds[sound].Add(audio);
                }
                break;
        }
    }
}
