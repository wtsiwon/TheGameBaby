using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnManager : SingletonDDOL<BtnManager>
{
    [SerializeField]
    private Button[] guideButton;
    private List<bool> isOverlay = new List<bool>();

    private void Start()
    {
        //for (int i = 0; i < guideButton.Length; i++)
        //{
        //    isOverlay[i] = guideButton[i].GetComponent<GuideSelect>();
        //}
    }


}
