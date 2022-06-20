using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;

public class Setting : MonoBehaviour
{
    #region �̹�����
    [Header("Images")]
    [SerializeField]
    private Image makerimg;
    [SerializeField]
    private Image quitimg;
    [SerializeField]
    private Image gotitleimg;
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
    private Button gotitlebtn;//Ÿ��Ʋ�ΰ��� ��ư
    #endregion
    #region GameObject
    [SerializeField]
    private GameObject btnsobj;//���ư��� ��ư
    [SerializeField]
    private GameObject settingboard;
    [SerializeField]
    private GameObject titlecheckboard;
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
            gotitleimg.GetComponentInChildren<OverUIbutton>().overlay.gameObject.SetActive(false);
            makerimg.GetComponentInChildren<OverUIbutton>().overlay.gameObject.SetActive(false);
            quitimg.GetComponentInChildren<OverUIbutton>().overlay.gameObject.SetActive(false);
            imgRotate();
        });
        makerbtn.onClick.AddListener(() =>
        {
            makerboard.SetActive(true);
        });

    }

    private void imgRotate()
    {
        btnsobj.transform.DORotate(new Vector3(0,0,0), 1f).SetEase(Ease.Flash);
    }

}
