using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    [Header("버튼들")]
    [SerializeField]
    private Button set;//여러가지 버튼들이 있는 버튼
    //[SerializeField]
    //private Button setting;//설정
    [SerializeField]
    private Button maker;//제작자
    [SerializeField]
    private Button quit;
    [SerializeField]
    private Button gotitle;//타이틀로가는 버튼

    [SerializeField]
    private GameObject btns;//돌아가는 버튼
    Quaternion Base = new Quaternion(0, 0, -180, 0);
    private void OnEnable()
    {
        btns.transform.rotation = Base;

        set.onClick.AddListener(() =>
        {
            btns.gameObject.SetActive(true);
            imgRotate();
        });

    }

    private void imgRotate()
    {
        Quaternion quaternion = new Quaternion(0, 0, 0, 0);
        Quaternion.Slerp(Base, quaternion, 1f);
    }

}
