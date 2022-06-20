using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    [Header("��ư��")]
    [SerializeField]
    private Button set;//�������� ��ư���� �ִ� ��ư
    //[SerializeField]
    //private Button setting;//����
    [SerializeField]
    private Button maker;//������
    [SerializeField]
    private Button quit;
    [SerializeField]
    private Button gotitle;//Ÿ��Ʋ�ΰ��� ��ư

    [SerializeField]
    private GameObject btns;//���ư��� ��ư
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
