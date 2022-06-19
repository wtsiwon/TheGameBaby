using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer settingover;
    [SerializeField]
    private Button setting;
    [SerializeField]
    private Button maker;

    private void OnMouseEnter()
    {
        settingover.gameObject.SetActive(true);
    }
    private void OnMouseExit()
    {
        settingover.gameObject.SetActive(false);
    }
}
