using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollwPlayer : MonoBehaviour
{
    [SerializeField] Transform Player;
  
    void Update()
    {
        transform.position = Player.transform.position + new Vector3 (0, 0, -5);
    }
}
