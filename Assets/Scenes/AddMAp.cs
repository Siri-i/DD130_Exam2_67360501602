using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMAp : MonoBehaviour
{
    [SerializeField] GameObject FloorA;
    [SerializeField] GameObject FloorB;
    [SerializeField] GameObject FloorC;
    [SerializeField] GameObject FloorD;

         [SerializeField] GameObject DisaA;
    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {

        DisaA.SetActive(true);
        FloorA.SetActive(true);
        FloorB.SetActive(true);
        FloorC.SetActive(true);
        FloorD.SetActive(true);
    }
}
