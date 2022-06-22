using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : SingletonDDOL<GameManager>
{
    public bool titleUp;//Ω√¿€ «‘?
    public int Stage;
    public bool isUp;
    public bool selectGuide;

    public Image[] slots;
    public Image wordimg;

    [HideInInspector]
    public GameObject guideAnimal;

    [SerializeField]
    private StageScene stage;

    public void StageFnc()
    {
        switch (Stage)
        {
            case 1:
                for (int i = 0; i < 3; i++)
                {
                    slots[i].sprite = stage.stages[1].slot1;
                }
                
                break;
        }
    }

}
