using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementWithScripts : MonoBehaviour
{
    public int LayerOrder;
    public Sprite SpriteToShow;
    public Vector3 StartingPosition;
    public Color DesiredColor;
    public float Speed =3f;
 
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<SpriteRenderer>();
       
        GetComponent<SpriteRenderer>().sprite = SpriteToShow;
        
        GetComponent<SpriteRenderer>().color = DesiredColor;
        
        GetComponent<Transform>().position = StartingPosition;
        
        GetComponent<SpriteRenderer>().sortingOrder = LayerOrder;
        
        gameObject.AddComponent<Move>();

        gameObject.AddComponent<Jump>();

        gameObject.AddComponent<Rigidbody2D>();
        gameObject.AddComponent<BoxCollider2D>();
        GetComponent<Rigidbody2D>().gravityScale = 0;



        



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
