using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMoveMenttwo : MonoBehaviour
{
    [SerializeField] int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);

        }
    }
}
