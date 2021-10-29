using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManger : MonoBehaviour
{
    public GameObject PlatformPrefab;
    public GameObject ReferencePlatformOne, ReferencePlatormTwo;
    public Sprite BushSprite;
    public GameObject ReferenceToBushGameObject;

    // Start is called before the first frame update
    void Start()
    {
        ReferencePlatformOne = Instantiate(PlatformPrefab);
        ReferencePlatformOne.name = "PlatformOne";

        ReferencePlatormTwo = Instantiate(PlatformPrefab);
        ReferencePlatormTwo.name = "PlatformTwo";

        ReferenceToBushGameObject = new GameObject();
        ReferenceToBushGameObject.AddComponent<SpriteRenderer>();
        ReferenceToBushGameObject.GetComponent<SpriteRenderer>().sprite = BushSprite;
        ReferenceToBushGameObject.GetComponent<Transform>().localPosition = new Vector3(0, 0, 0);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
