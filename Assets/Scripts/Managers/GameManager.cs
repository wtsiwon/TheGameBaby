using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : SingletonDDOL<GameManager>
{
    [Header("boolean")]
    public bool titleUp;//���� ��?
    public bool isUp;
    public bool selectGuide;
    public bool isCorrect;

    [Space(25f)]
    [Header("�ΰ��� ���")]
    public int Stage;
    public int Step;

    [HideInInspector]
    public GameObject guideAnimal;
    public GameObject clear;

    public GameObject currentobj;
    public GameObject draggingobj;

    /// <summary>
    /// ������� �ٽ� �ε��� ���� �ܰ� ������Ʈ�� ����
    /// </summary>
    public void Resetstep()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}