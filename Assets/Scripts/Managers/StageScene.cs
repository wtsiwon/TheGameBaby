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
    public Steps[] steps;
}
[System.Serializable]
public struct Steps
{
    public Sprite slot1;
    public Sprite slot2;
    public Sprite slot3;

    public Sprite word;//���߱� �� ����
    public Sprite coword;//���߰� ������ ����
    public Sprite back;//background
    public Sprite ground;
    public Sprite guideimg;//�ܾ ���� ����
}
