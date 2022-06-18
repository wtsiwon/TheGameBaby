using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [HideInInspector]
    public bool titleUp;//Ω√¿€ «‘?
    public int Stage;
    public bool isUp;
    public bool selectGuide;

    [HideInInspector]
    public GameObject guideAnimal;

}
