using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "SceneNum", menuName = "Scenes/SceneData", order = 1)]
public class StageScene : ScriptableObject
{
    public Steps[] steps;
    public Sprite ground;//ground
}
[System.Serializable]
public struct Steps
{
    public GameObject[] slot;

    public GameObject word;//���߱� �� ����
    public GameObject coword;//���߰� ������ ����
    public Sprite guideimg;//�ܾ ���� ����
}
