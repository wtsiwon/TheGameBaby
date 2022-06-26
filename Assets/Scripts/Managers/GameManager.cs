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

    public Image currentimg;
    public Image draggingimg;

    /// <summary>
    /// ������� �ٽ� �ε��� ���� �ܰ� ������Ʈ�� ����
    /// </summary>
    public void Resets()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}