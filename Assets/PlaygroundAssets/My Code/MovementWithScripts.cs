using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementWithScripts : MonoBehaviour
{
    public int LayerOrder;
    public Sprite Player;
    public Vector3 StartingPosition;
    public Color DesiredColor;
   
 
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<SpriteRenderer>();

        GetComponent<SpriteRenderer>().sprite = Player;

        GetComponent<SpriteRenderer>().color = DesiredColor;
        
        GetComponent<Transform>().position = StartingPosition;

        GetComponent<SpriteRenderer>().sortingOrder = LayerOrder;
        
        gameObject.AddComponent<Rigidbody2D>();
        
        gameObject.AddComponent<BoxCollider2D>();

        gameObject.AddComponent<Move>();

        gameObject.AddComponent<Jump>();
        
        GetComponent<Move>();

        GetComponent<Jump>();

        








    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
