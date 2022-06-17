using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Guide : MonoBehaviour
{
    private void OnEnable()
    {
        Invoke(nameof(GoGuideSelect), 2.5f);
    }
    public void GoGuideSelect()
    {
        SceneManager.LoadScene("SelectGuide");
    }
}
