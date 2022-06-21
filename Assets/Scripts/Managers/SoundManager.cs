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
    /// <summary>
    /// 사운드 사져오는데 여러가지 요소를 넣어서 가져온다
    /// </summary>
    /// <param name="soundtype">어떤?</param>
    /// <param name="name">거기서 무슨?</param>
    /// <param name="volum">소리크기는?</param>
    /// <param name="pitch">이건 뭐야</param>
    /// <returns></returns>
    public AudioClip PlayAudio(ESoundType soundtype, string name, float volum, float pitch = 1)
    {
        AudioSource audioSource = null;
        //사운드 타입을 넣고 꺼내고 싶은것을 꺼내야 하는데 index로 하면 어케 알어 야발어케하지 ㅋㅋ
        //audioSource = sounds[soundtype];

        
        
        

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
