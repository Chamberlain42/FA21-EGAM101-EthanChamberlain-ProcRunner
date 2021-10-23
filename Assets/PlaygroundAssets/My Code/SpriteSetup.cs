using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSetup : MonoBehaviour
{
    public Sprite SpriteToShow;
    public Vector3 DesiredPosition;
    public Color DesiredColor;
    public int OrderLayer;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<SpriteRenderer>();

        GetComponent<SpriteRenderer>().color = DesiredColor;

        GetComponent<SpriteRenderer>().sortingOrder = OrderLayer;


        GetComponent<SpriteRenderer>().sprite = SpriteToShow;

        GetComponent<Transform>().position = DesiredPosition;

       

        



        

        //GetComponent<Rigidbody2D>().gravityScale = 0;
    }
}
