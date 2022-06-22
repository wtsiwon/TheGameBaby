using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "SceneNum", menuName = "Scenes/SceneData", order = 1)]
public class StageScene : ScriptableObject
{
    public Stage[] stage;
}

[System.Serializable]
public class Stage
{
    public Image slot1;
    public Image slot2;
    public Image slot3;
    
    public Image word;
    public Image back;
    public Image ground;
}
