using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer settingImg;
    [SerializeField]
    private Button setting;

    private void OnMouseEnter()
    {
        settingImg.gameObject.SetActive(true);
    }
    private void OnMouseExit()
    {
        settingImg.gameObject.SetActive(false);
    }
}
