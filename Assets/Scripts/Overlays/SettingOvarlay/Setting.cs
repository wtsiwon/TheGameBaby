using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.EventSystems;

public class Setting : MonoBehaviour
{
    #region 이미지들
    [Header("Images")]
    [SerializeField]
    private Image makerimg;
    [SerializeField]
    private Image quitimg;
    [SerializeField]
    private Image gotitleimg;
    #endregion
    #region buttons
    [Header("버튼들")]
    [SerializeField]
    private Button set;//여러가지 버튼들이 있는 버튼
    [SerializeField]
    private Button makerbtn;//제작자
    [SerializeField]
    private Button quitbtn;
    [SerializeField]
    private Button gotitlebtn;//타이틀로가는 버튼
    #endregion
    #region GameObject
    [SerializeField]
    private GameObject btnsobj;//돌아가는 버튼
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
