using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [HideInInspector]
    public bool titleUp;//���� ��?
    public List<bool> stage = new List<bool>();
    public bool isUp;

}
