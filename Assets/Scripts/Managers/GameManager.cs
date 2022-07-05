using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[System.Serializable]
public class obj
{
    public GameObject[] coobj;
}
public class GameManager : SingletonDDOL<GameManager>
{
    [Header("boolean")]
    public bool titleUp;//시작 함?
    public bool isUp;
    public bool selectGuide;
    public bool isCorrect;

    [Space(25f)]
    [Header("인게임 요소")]
    public int Stage;
    public int Step;

    [Space(25f)]
    [Header("맞은 오브젝트")]
    public obj[] objs;
    

    public Dictionary<int, int> stagestep = new Dictionary<int, int>();
    public Dictionary<Dictionary<int, int>, GameObject> obj = new Dictionary<Dictionary<int, int>, GameObject>();

    [HideInInspector]
    public GameObject guideAnimal;
    public GameObject clear;

    public GameObject currentobj;
    public GameObject draggingobj;

    private void Start()
    {

        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {
        //        if(i == 0 && j == 2)
        //        {
        //            break;
        //        }
        //        stagestep.Add(i, j);
        //    }
        //}
        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //    {
        //        if (i == 0 && j == 2)
        //        {
        //            break;
        //        }
        //        obj.Add(stagestep, objs[i,j]);
        //    }
        //}
    }
    /// <summary>
    /// 현재씬을 다시 로드해 다음 단계 오브젝트로 변경
    /// </summary>
    public void Resetstep()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        isCorrect = false;
    }
}