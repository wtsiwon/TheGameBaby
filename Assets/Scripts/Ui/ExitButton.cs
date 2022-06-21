using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    public Button exitButton;
    public Image backG;

    private void OnEnable()
    {
        exitButton.onClick.AddListener(() =>
        {
            backG.gameObject.SetActive(false);
        });
    }
}
