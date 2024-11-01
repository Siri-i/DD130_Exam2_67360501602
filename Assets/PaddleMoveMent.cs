using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMoveMent : MonoBehaviour
{
    [SerializeField] int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        { 
          transform.Translate(Vector3.up * speed * Time.deltaTime);
        
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);

        }

    }
}
