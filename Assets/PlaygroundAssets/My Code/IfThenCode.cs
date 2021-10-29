using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Sprite SpriteToShow;
    public Vector3 DesiredPosition;
    public Color DesiredColor;
    public int OrderLayer;
    public int TestVariable;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<BoxCollider2D>();
        gameObject.AddComponent<ConditionArea>();
        if (Time.time > 10f) ;
        {
            gameObject.AddComponent<SpriteRenderer>();

            GetComponent<SpriteRenderer>().color = DesiredColor;

            GetComponent<SpriteRenderer>().sortingOrder = OrderLayer;

            //SpriteToShow = MrSquare;


            GetComponent<SpriteRenderer>().sprite = SpriteToShow;

            GetComponent<Transform>().position = DesiredPosition;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
