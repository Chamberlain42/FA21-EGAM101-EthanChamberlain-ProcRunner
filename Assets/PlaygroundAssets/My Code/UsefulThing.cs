using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsefulThing : MonoBehaviour
{
    public Sprite ChildOneSprite;
    public Sprite ChildTwoSprite;
    public Sprite ChildThreeSprite;
    public Sprite ParentSprite;
    public Vector2 DesiredPosition, DesiredPositionCOne, DesiredPositionCTwo, DesiredPositionCThree;
    public Color DesiredColor, DesiredColorCOne, DesiredColorCTwo, DesiredColorCThree;
    public int OrderLayer, OrderLayerCOne, OrderLayerCTwo, OrderLayerCThree;
    // Start is called before the first frame update
    void Start()
    {
        GameObject Parent;
        Parent = new GameObject();
        Parent.name = "Parent";
        Parent.AddComponent<SpriteRenderer>();
        Parent.GetComponent<SpriteRenderer>();
        Parent.GetComponent<SpriteRenderer>().color = DesiredColor;
        Parent.GetComponent<SpriteRenderer>().sortingOrder = OrderLayer;
        Parent.GetComponent<SpriteRenderer>().sprite = ParentSprite;
        Parent.GetComponent<Transform>().position = DesiredPosition;

        GameObject ChildOne;
        ChildOne = new GameObject();
        ChildOne.name = "ChildOne";
        ChildOne.AddComponent<SpriteRenderer>();
        ChildOne.GetComponent<SpriteRenderer>();
        ChildOne.GetComponent<SpriteRenderer>().color = DesiredColorCOne;
        ChildOne.GetComponent<SpriteRenderer>().sortingOrder = OrderLayerCOne;
        ChildOne.GetComponent<SpriteRenderer>().sprite = ChildOneSprite;
        ChildOne.transform.localPosition

        GameObject ChildTwo;
        ChildTwo = new GameObject();
        ChildTwo.name = "ChildTwo";
        ChildOne.AddComponent<SpriteRenderer>();
        ChildOne.GetComponent<SpriteRenderer>();
        ChildOne.GetComponent<SpriteRenderer>().color = DesiredColorCTwo;
        ChildOne.GetComponent<SpriteRenderer>().sortingOrder = OrderLayerCTwo;
        ChildOne.GetComponent<SpriteRenderer>().sprite = ChildTwoSprite;
        ChildOne.transform.position = (-1, 0, 0);

        GameObject ChildThree;
        ChildThree = new GameObject();
        ChildThree.name = "ChildThree";
        ChildOne.AddComponent<SpriteRenderer>();
        ChildOne.GetComponent<SpriteRenderer>();
        ChildOne.GetComponent<SpriteRenderer>().color = DesiredColorCThree;
        ChildOne.GetComponent<SpriteRenderer>().sortingOrder = OrderLayerCThree;
        ChildOne.GetComponent<SpriteRenderer>().sprite = ChildThreeSprite;
        ChildOne.transform.position = (-1, 0, 0);





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
