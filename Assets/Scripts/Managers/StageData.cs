using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageData : SingletonDDOL<StageData>
{
    [SerializeField]
    private StageScene stagedata;
    [SerializeField]
    private Image[] slots;
    [SerializeField]
    private Image words;
    [SerializeField]
    private Image coWords;
    [SerializeField]
    private Image ground;
    [SerializeField]


    /// <summary>
    ///스테이지에 맞는 사진으로 바꿔주는 함수
    /// </summary>
    /// <param name="stagenum">Stage</param>
    public void LoadStage(int stageNum, int step)
    {
        switch (stageNum)
        {
            case 0:
                switch (step)
                {
                    case 0:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                    case 1:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                    case 2:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                }
                break;
            case 1:
                switch (step)
                {
                    case 0:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                    case 1:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                    case 2:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                    case 3:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                    case 4:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                }
                break;
            case 2:
                switch (step)
                {
                    case 0:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                    case 1:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                    case 2:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                    case 3:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                    case 4:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                }
                break;
            case 3:
                switch (step)
                {
                    case 0:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                    case 1:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                    case 2:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                    case 3:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                    case 4:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                }
                break;
            case 4:
                switch (step)
                {
                    case 0:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                    case 1:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                    case 2:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                    case 3:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                    case 4:
                        slots[0].sprite = stagedata.stages[stageNum].steps[step].slot1;
                        slots[1].sprite = stagedata.stages[stageNum].steps[step].slot2;
                        slots[2].sprite = stagedata.stages[stageNum].steps[step].slot3;
                        break;
                }
                break;

        }
    }
}
