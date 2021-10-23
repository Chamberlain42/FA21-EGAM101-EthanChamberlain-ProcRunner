using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
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

        gameObject.AddComponent<BoxCollider2D>();
        gameObject.AddComponent<AreaEffector2D>();
        
        GetComponent<BoxCollider2D>().isTrigger = true;
        
        GetComponent<BoxCollider2D>().usedByEffector = true;

        GetComponent<AreaEffector2D>().forceAngle = 1;
        GetComponent<AreaEffector2D>().forceMagnitude = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
