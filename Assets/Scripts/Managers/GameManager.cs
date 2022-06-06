using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [HideInInspector]
    public bool titleUp;//Ω√¿€ «‘?
    public bool[] Stage = new bool[5];
}
