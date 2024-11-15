using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetMap : MonoBehaviour
{
    [SerializeField] GameObject GameOverpointA;
    [SerializeField] GameObject FloorA;
    [SerializeField] GameObject FloorB;
    [SerializeField] GameObject FloorC;
    [SerializeField] GameObject FloorD;
    [SerializeField] GameObject DisaA;
    private void OnCollisionEnter2D(Collision2D collision)
    {


        GameOverpointA.SetActive(true);
        FloorA.SetActive(false);
       // FloorB.SetActive(false);
        FloorC.SetActive(false);
      
        //FloorD.SetActive(false);
    }
}
