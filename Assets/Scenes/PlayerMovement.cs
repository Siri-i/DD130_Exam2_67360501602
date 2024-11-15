using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Transform RespawnPoint;
    [SerializeField] Transform RespawnCamLeft;
    [SerializeField] Transform RespawnCamRight;
    [SerializeField] int _speed;
    [SerializeField] int _jumphigh;
    [SerializeField] GameObject GameOverWall;
    // Update is called once per frame
   public Rigidbody2D rb;
    void Update()
    {
       
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * _speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * _speed);
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.AddForce(new Vector2(0, _jumphigh) * 40);
        
        if (collision.gameObject.CompareTag("UpWall"))
        {
          
            transform.position = RespawnPoint.transform.position;
              GameOverWall.SetActive(false);
        }
        if (collision.gameObject.CompareTag("OutOfCamLeft"))
        {
            Debug.Log("OutOfCamLeft");
            transform.position = RespawnCamLeft.transform.position;
           
        }
        if (collision.gameObject.CompareTag("OutOfCamRight"))
        {
         //   Debug.Log("OutOfCamRight");
            transform.position = RespawnCamRight.transform.position;

        }
    }
}
