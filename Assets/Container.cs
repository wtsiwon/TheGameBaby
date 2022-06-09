using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Container : MonoBehaviour
{
    public string Name;
    public Image finishedImage;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var words = collision.GetComponent<Word>();
        if(words.isCorrect == true && GameManager.Instance.isUp == true)
        {
            finishedImage.gameObject.SetActive(true);
        }
    }
}
