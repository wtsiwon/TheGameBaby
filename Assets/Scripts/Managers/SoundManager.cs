using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum ESoundType
{
    BGM,
    SFX,
    first,
    second,
    third,
    fourth,
    fifth,
    End
}
public class AudioSourceClass
{
    public AudioSource audiosource;
    public float audioVolume;
}
public class SoundManager : SingletonDDOL<SoundManager>
{
    #region ����Lists
    [Header("Sounds")]
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
    #endregion

    //������� �̸����� �з��� �ִ� Dictionary
    private Dictionary<string, AudioClip> audioClips = new Dictionary<string, AudioClip>();
    //
    private Dictionary<ESoundType, AudioSourceClass> audioSourceClasses = new Dictionary<ESoundType, AudioSourceClass>();

    //�����Ҷ� ���带 ��ųʸ��� �߰�����
    private void Awake()
    {
        //Resources���� �ȿ� Sounds���� �ȿ� �ִ�  AudioClip�� ���� �����´�
        AudioClip[] clips = Resources.LoadAll<AudioClip>("Sounds/");
        //������ AudioClips�� Dictionary�� �߰�
        foreach (AudioClip clip in clips)
        {
            audioClips[clip.name] = clip;
        }
        //Enum�� �̸��� string���� ��ȯ����
        string[] enumNames = Enum.GetNames(typeof(ESoundType));

        //���ӿ�����Ʈ�� ����� Ŭ��������ŭ �����ϰ� ����� Ŭ������ �׿� �´� �ڽ� ������Ʈ�� �����Ѵ�
        for (int i = 0; i < (int)ESoundType.End; i++)
        {
            GameObject AudioSourceobj = new GameObject(enumNames[i]);
            AudioSourceobj.transform.SetParent(transform);
            AudioSourceClass sourceClass
                = new AudioSourceClass
                { audiosource = AudioSourceobj.AddComponent<AudioSource>(), audioVolume = 0.5f };
            audioSourceClasses[(ESoundType)i] = sourceClass;
        }

        audioSourceClasses[ESoundType.BGM].audiosource.loop = true;
    }
    /// <summary>
    /// ���� �������µ� �������� ��Ҹ� �־ �����´�
    /// </summary>
    /// <param name="soundtype">�?</param>
    /// <param name="name">�ű⼭ ����?</param>
    /// <param name="volume">�Ҹ�ũ���?</param>
    /// <param name="pitch">�̰� ����</param>
    /// <returns></returns>
    public AudioClip PlaySoundClip(string clipname, ESoundType type, float volume = 0.5f, float pitch = 1)
    {
        AudioClip clip = audioClips[clipname];
        audioSourceClasses[type].audiosource.pitch = pitch;

        //���� ����
        float curVolume = volume * audioSourceClasses[type].audioVolume;
        //���� BGM�� Ʋ���ٸ� Ʋ��
        if(type == ESoundType.BGM)
        {
            audioSourceClasses[ESoundType.BGM].audiosource.clip = clip;
            audioSourceClasses[ESoundType.BGM].audiosource.volume = curVolume;
            audioSourceClasses[ESoundType.BGM].audiosource.Play();
        }
        else//PlayOneShot
        {
            audioSourceClasses[type].audiosource.PlayOneShot(clip, curVolume);
        }

        return clip;
    }
}
