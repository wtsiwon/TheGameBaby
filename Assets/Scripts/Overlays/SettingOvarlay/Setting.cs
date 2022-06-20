using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Setting : MonoBehaviour
{
    #region buttons
    [Header("버튼들")]
    [SerializeField]
    private Button set;//여러가지 버튼들이 있는 버튼
    //[SerializeField]
    //private Button setting;//설정
    [SerializeField]
    private Button makerbtn;//제작자
    [SerializeField]
    private Button quitbtn;
    [SerializeField]
    private Button gotitlebtn;//타이틀로가는 버튼
    #endregion
    [SerializeField]
    private GameObject btnsobj;//돌아가는 버튼
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
