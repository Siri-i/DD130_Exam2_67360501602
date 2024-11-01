using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System;

public class Text : MonoBehaviour
{
    private int score;
    [SerializeField] GameObject Ball;
    [SerializeField] GameObject Wall; 
    private TextMeshPro textMeshPro;  
    // Start is called before the first frame update
    void Start()
    {
        score = 0;  
        textMeshPro = GetComponent<TextMeshPro>();   
    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Ball.gameObject.CompareTag("Wall1") || Ball.gameObject.CompareTag("Wall2"))
        {
            score++;
            Debug.Log(score);
        }
    


    }
}
