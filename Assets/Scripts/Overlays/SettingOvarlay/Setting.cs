using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Setting : MonoBehaviour
{
    #region buttons
    [Header("��ư��")]
    [SerializeField]
    private Button set;//�������� ��ư���� �ִ� ��ư
    //[SerializeField]
    //private Button setting;//����
    [SerializeField]
    private Button makerbtn;//������
    [SerializeField]
    private Button quitbtn;
    [SerializeField]
    private Button gotitlebtn;//Ÿ��Ʋ�ΰ��� ��ư
    #endregion
    [SerializeField]
    private GameObject btnsobj;//���ư��� ��ư
    [SerializeField]
    private GameObject settingboard;
    [SerializeField]
    private GameObject titlecheckboard;
    [SerializeField]
    private GameObject quitcheckboard;


    private void OnEnable()
    {
        set.onClick.AddListener(() =>
        {
            set.gameObject.SetActive(false);
            btnsobj.gameObject.SetActive(true);
            imgRotate();
        });
    }

    private void imgRotate()
    {
        btnsobj.transform.DORotate(new Vector3(0,0,0), 1f).SetEase(Ease.Flash);
    }

}
