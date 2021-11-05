using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSetup : MonoBehaviour
{
    public Sprite SquareSprite;
    public Vector2 DesiredScale;
    public Color DesiredColor;
    public int OrderLayer;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<SpriteRenderer>();

        GetComponent<SpriteRenderer>().sprite = SquareSprite;
        GetComponent<SpriteRenderer>().color = DesiredColor;
       
        //This spot???? V
        GetComponent<SpriteRenderer>().sortingOrder = OrderLayer;

        //GetComponent<Transform>().position = DesiredPosition;
        GetComponent<Transform>().localScale = DesiredScale;
        

        gameObject.AddComponent<Rigidbody2D>();
        gameObject.AddComponent<BoxCollider2D>();
        GetComponent<Rigidbody2D>().gravityScale = 0;
        GetComponent<Rigidbody2D>().mass = 10000f;
        //gameObject.AddComponent<ConditionArea>();
        //GetComponent<ConditionArea>().filterByTag = true;




    }

}
   