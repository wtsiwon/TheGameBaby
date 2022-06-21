using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;

public class Setting : MonoBehaviour
{
    //�Ѡ���?
    private bool isquitboard;
    private bool issoundboard;
    private bool ismakerboard;

    
    #region �̹�����
    [Header("Images")]
    [SerializeField]
    private Image makerimg;
    [SerializeField]
    private Image quitimg;
    [SerializeField]
    private Image soundsetimg;
    #endregion
    #region buttons
    [Header("��ư��")]
    [SerializeField]
    private Button set;//�������� ��ư���� �ִ� ��ư
    [SerializeField]
    private Button makerbtn;//������
    [SerializeField]
    private Button quitbtn;
    [SerializeField]
    private Button soundsetbtn;//�Ҹ� ���� ��ư

    [SerializeField]
    private Button cancel;
    [SerializeField]
    private Button check;
    [SerializeField]
    #endregion
    #region GameObject
    [SerializeField]
    private GameObject btnsobj;//���ư��� ��ư
    [SerializeField]
    private GameObject settingboard;
    [SerializeField]
    private GameObject soundsetboard;
    [SerializeField]
    private GameObject quitcheckboard;
    [SerializeField]
    private GameObject makerboard;
    #endregion


    private void OnEnable()
    {
        set.onClick.AddListener(() =>
        {
            set.gameObject.SetActive(false);
            btnsobj.gameObject.SetActive(true);
            soundsetimg.GetComponentInChildren<OverUIbutton>().overlay.gameObject.SetActive(false);
            makerimg.GetComponentInChildren<OverUIbutton>().overlay.gameObject.SetActive(false);
            quitimg.GetComponentInChildren<OverUIbutton>().overlay.gameObject.SetActive(false);
            imgRotate();
        });
        makerbtn.onClick.AddListener(() =>
        {
            makerboard.SetActive(true);
            ismakerboard = true;
        });
        quitbtn.onClick.AddListener(() =>
        {
            quitcheckboard.SetActive(true);
            isquitboard = true;
        });
        soundsetbtn.onClick.AddListener(() =>
        {
            soundsetboard.SetActive(true);
            issoundboard = true;
        });


    }

    private void imgRotate()
    {
        btnsobj.transform.DORotate(new Vector3(0,0,0), 0.5f).SetEase(Ease.Flash);
    }
}
