using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuideBtnAct : MonoBehaviour
{
    [SerializeField]
    private GameObject guide;
    [SerializeField]
    private Button selectBtn;

    private void Start()
    {
        selectBtn.onClick.AddListener(() =>
        {

        });
    }

}
