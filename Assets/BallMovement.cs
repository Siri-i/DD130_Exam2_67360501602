using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
   private int RandomNumber;
    [SerializeField] int speed = 5;
    [SerializeField] GameObject PlayerOneSide;
    [SerializeField] GameObject PlayerTwoSide;
    private bool IsOnCollistion;
    private bool IsOnPlayerOneSide ;
    private bool IsOnPPlayerTwoSide ;
    private bool IsStart;
    private Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        IsOnPlayerOneSide = false;
        IsOnPPlayerTwoSide = false;
        IsStart = true; 
        Random();
    }

    // Update is called once per frame
    void Update()
    {


        Move();
        if (IsOnCollistion)
         {
            if (IsOnPlayerOneSide)
            {
                // transform.Translate(Quaternion.Euler(10, -1, 0) * new Vector3(speed, 0, 0) * Time.deltaTime);
                transform.Translate(Quaternion.Euler(10, 0, 0) * new Vector3(speed, 0, 0) * Time.deltaTime);
            }
            else
            {

                transform.Translate(Vector3.left * speed * Time.deltaTime);
               // transform.Translate(Quaternion.Euler(10, 0, 0) * new Vector3(speed, 0, 0) * Time.deltaTime);
            }
        }


   

    }


    private void Move()
    {
        if (IsStart)
        {
            if (RandomNumber == 1)
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);

            }

            if (RandomNumber == 0)
            {
                transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
        }

       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      
        IsStart = false;    
        if (collision.gameObject.CompareTag("Wall1"))
        {
            IsOnPlayerOneSide = true;
            IsOnPPlayerTwoSide = false;
            Debug.Log(" 1");
        }

        if (collision.gameObject.CompareTag("Wall2"))
        {
            IsOnPlayerOneSide = false;
            IsOnPPlayerTwoSide = true;
           
            Debug.Log(" 2");
        }
        IsOnCollistion = true;



    }
    
    void Random()
    {
        RandomNumber = UnityEngine.Random.Range(0, 2);   
        

    }
}
