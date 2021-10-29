using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SometimeObsticles : MonoBehaviour
{
    public GameObject UnusedPrefab;
    public GameObject ReferenceUnusedOne, ReferenceUnusedTwo;
    public Sprite NewSprite;
    public GameObject ReferenceNewObject;

    // Start is called before the first frame update
    void Start()
    {
        ReferenceUnusedOne = Instantiate(UnusedPrefab);
        ReferenceUnusedOne.name = "Unused One";

        ReferenceUnusedTwo = Instantiate(UnusedPrefab);
        ReferenceUnusedTwo.name = "Unused Two";

        ReferenceNewObject = new GameObject();
        ReferenceNewObject.AddComponent<SpriteRenderer>();
        ReferenceNewObject.GetComponent<SpriteRenderer>().sprite = NewSprite;
        ReferenceNewObject.GetComponent<Transform>().localPosition = new Vector3(0, 6, 0);

        Color leftColor, middleColor, rightColor;
        leftColor = new Color(0, 1, 0);
        middleColor = new Color(0, 0, 1);
        rightColor = new Color(1, 0, 0);

        //float randomNumber;
        //randomNumber = Random.value;
        //if (randomNumber > .6f - .001 * Time.time)
       // {
          //  ReferenceNewObject = new GameObject();
           // ReferenceNewObject.AddComponent<SpriteRenderer>();
          //  ReferenceNewObject.GetComponent<SpriteRenderer>().sprite = NewSprite;
         //   ReferenceNewObject.GetComponent<Transform>().SetParent(ReferenceUnusedOne.transform);
         //   ReferenceNewObject.GetComponent<Transform>().localPosition = new Vector3(0, 0, 0);
         //   ReferenceNewObject.GetComponent<Transform>().localEulerAngles = new Vector3(0, 0, 0);

        //    if (ReferenceNewObject.GetComponent<Transform>().localPosition.x <= -.5f) ;
         //   {
        //        ReferenceNewObject.GetComponent<SpriteRenderer>().color = leftColor;
        //    }
        //    if (ReferenceNewObject.GetComponent<Transform>().localPosition.x > -.5f &&
        //        ReferenceNewObject.GetComponent<Transform>().localPosition.x < .5f)
        //    {
        //        ReferenceNewObject.GetComponent<SpriteRenderer>().color = middleColor;
        //    }
        //    if (ReferenceNewObject.GetComponent<Transform>().localPosition.x >= .5f)
         //   {
                //ReferenceNewObject.GetComponent<SpriteRenderer>().color = rightColor;
            }
        }



