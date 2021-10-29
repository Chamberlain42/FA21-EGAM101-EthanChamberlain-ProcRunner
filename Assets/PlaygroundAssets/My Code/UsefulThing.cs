using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsefulThing : MonoBehaviour
{
    public Sprite SpriteToShow;
    public Vector3 DesiredPosition;
    public Color DesiredColor;
    public int OrderLayer;
    // Start is called before the first frame update
    void Start()
    {
        new GameObject();
        gameObject.AddComponent<SpriteRenderer>();

        GetComponent<SpriteRenderer>().color = DesiredColor;

        GetComponent<SpriteRenderer>().sortingOrder = OrderLayer;


        GetComponent<SpriteRenderer>().sprite = SpriteToShow;

        GetComponent<Transform>().position = DesiredPosition;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
