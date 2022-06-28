using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    [HideInInspector]
    public GameObject guideAnimal;
    public GameObject clear;

    public GameObject currentobj;
    public GameObject draggingobj;

    /// <summary>
    /// 현재씬을 다시 로드해 다음 단계 오브젝트로 변경
    /// </summary>
    public void Resetstep()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}