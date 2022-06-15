using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class Guide : MonoBehaviour
{
    public Animation anim;
    private void Enable()
    {
        anim.Play();
    }

    public void GoGuideScene()
    {
        SceneManager.LoadScene("SelectGuide");
    }
}
