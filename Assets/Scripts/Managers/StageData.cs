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
    ///스테이지에 맞는 사진으로 바꿔주는 함수
    /// </summary>
    /// <param name="stagenum">Stage</param>
    public void LoadStage(int stageNum,int step)
    {
        switch (stageNum)
        {
            case 0:
                ground.sprite = stagedata[stageNum].ground;
                switch (step)
                {
                    case 0:
                        for (int i = 0; i < 3; i++)
                        {
                            slots[i] = stagedata[stageNum].steps[step].slot[i];
                        }
                        break;
                }
                break;
        }
    }
}
