using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "SceneNum", menuName = "Scenes/SceneData", order = 1)]
public class StageScene : ScriptableObject
{
    public Stage[] stages;
}

[System.Serializable]
public class Stage
{
    public Sprite slot1;
    public Sprite slot2;
    public Sprite slot3;
           
    public Sprite word;//맞추기 전 글자
    public Sprite coword;//맞추고 나오는 글자
    public Sprite back;
    public Sprite ground;
}
