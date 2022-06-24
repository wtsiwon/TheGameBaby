using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : SingletonDDOL<GameManager>
{
    [Header("boolean")]
    public bool titleUp;//���� ��?
    public bool isUp;
    public bool selectGuide;

    [Space(25f)]
    [Header("�ΰ��� ���")]
    public int Stage;
    public int Step;
    public Image[] slots;
    public Image wordimg;
    public Image picture;//�ܾ ���� �׸�

    [HideInInspector]
    public GameObject guideAnimal;

    [SerializeField]
    private StageScene stage;

    public void StageFnc()
    {
        switch (Stage)
        {
            case 0:
                switch (Step)
                {
                    case 0:
                        slots[0].sprite = stage.stages[0].steps[0].slot1;
                        slots[1].sprite = stage.stages[0].steps[0].slot2;
                        slots[2].sprite = stage.stages[0].steps[0].slot3;


                        break;
                }
                break;
               
        }
    }

}
