using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{

    public float speed;
    public Text countText;
    public Text winText;

    
    private int count;

    void Start()
    {
        
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void FixedUpdate()
    {
       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 3)
        {
            winText.text = "You Win!";
        }
    }
}