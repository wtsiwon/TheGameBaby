using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnClick : MonoBehaviour
{
    public void GoStageSelect()
    {
        SceneManager.LoadScene("SelectStage");
    }
}
