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

    public GameObject word;//맞추기 전 글자
    public GameObject coword;//맞추고 나오는 글자
    public Sprite guideimg;//단어에 대한 사진
}
