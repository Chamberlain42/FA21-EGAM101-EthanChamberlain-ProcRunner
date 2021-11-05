using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Sprite EnemySprite;
    private GameObject Player;
    public Color DesiredColor;
    public int OrderLayer;
    public Vector3 LocalPostion;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<SpriteRenderer>();
        gameObject.GetComponent<SpriteRenderer>();
        GetComponent<SpriteRenderer>().color = DesiredColor;

        GetComponent<SpriteRenderer>().sortingOrder = OrderLayer;


        gameObject.GetComponent<BoxCollider2D>();
        gameObject.GetComponent<Patrol>();
        gameObject.GetComponent<Transform>().localPosition = LocalPostion;
        GetComponent<BoxCollider2D>().isTrigger = true;



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(Player);
        }
    }
}
    
