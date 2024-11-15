using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using static UnityEngine.UI.Image;

public class MovingFloor : MonoBehaviour
{
    // Start is called before the first frame update
   private float count = 0;
    public float alphalevel;
    public SpriteRenderer SpriteRenderer;
    [SerializeField] GameObject Floor;
    float number = 0.5f;
    void Start()
    {
     //GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alphalevel);
     SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        alphalevel = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
       

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        count = alphalevel;
        SpriteRenderer.color = new Color(1f, 1f, 1f, alphalevel);
        alphalevel--;
        if (alphalevel== 0) 
        { Floor.SetActive(false); }


    }

}
