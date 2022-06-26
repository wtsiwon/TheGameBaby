using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageData : SingletonDDOL<StageData>
{
    [SerializeField]
    private StageScene[] stagedata;

    [SerializeField]
    private GameObject[] slots;
    [SerializeField]
    private GameObject words;
    [SerializeField]
    private GameObject coWords;

    [SerializeField]
    private Image ground;


    /// <summary>
    ///���������� �´� �������� �ٲ��ִ� �Լ�
    /// </summary>
    /// <param name="stagenum">Stage</param>
    /// <param name="step">�ܰ�</param>
    public void LoadStage(int stageNum, int step)
    {
        ground.sprite = stagedata[stageNum].ground;
        for (int i = 0; i < 3; i++)
        {
            slots[i] = stagedata[stageNum].steps[step].slot[i];
        }
        coWords = stagedata[stageNum].steps[step].coword;
        words = stagedata[stageNum].steps[step].word;
    }
}
