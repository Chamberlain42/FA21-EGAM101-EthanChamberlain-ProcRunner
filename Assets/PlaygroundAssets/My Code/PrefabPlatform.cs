using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabPlatform : MonoBehaviour
{
    public GameObject PlatformPrefab;
    private GameObject ReferencingPlatformOne, ReferencingPlatformTwo, ReferencingPlatformThree, ReferencingPlatformFour;
    //public Vector2 Position;

    // Start is called before the first frame update
    void Start()
    {
        ReferencingPlatformOne = PlatformPrefab;
        ReferencingPlatformOne.name = "PlatformOne";
        ReferencingPlatformOne.gameObject.tag = "Platform";

        ReferencingPlatformTwo = PlatformPrefab;
        ReferencingPlatformTwo.name = "PlatformTwo";

        ReferencingPlatformThree = PlatformPrefab;
        ReferencingPlatformThree.name = "PlatformThree";

        ReferencingPlatformFour = PlatformPrefab;
        ReferencingPlatformFour.name = "PlatformFour";

        //Platform 1
        float randomNumber;
        Random.Range(-2, 4);
        randomNumber = Random.value;
        //ReferencingPlatformOne.transform.eulerAngles = new Vector3(0, 0, Random.Range(0, 360));
        ReferencingPlatformOne.transform.position = new Vector2(-7, Random.Range(-3, 3));
        Instantiate(ReferencingPlatformOne);

        //Platform 2
        Random.Range(0, 4);
        randomNumber = Random.value;
        //ReferencingPlatformOne.transform.eulerAngles = new Vector3(0, 0, Random.Range(0, 360));
        ReferencingPlatformTwo.transform.position = new Vector2(-3, Random.Range(-3, 3));
        Instantiate(ReferencingPlatformTwo);

        //Platform 3
        Random.Range(-4, 2);
        randomNumber = Random.value;
        //ReferencingPlatformOne.transform.eulerAngles = new Vector3(0, 0, Random.Range(0, 360));
        ReferencingPlatformThree.transform.position = new Vector2(3, Random.Range(-3, 3));
        Instantiate(ReferencingPlatformThree);

        //Platform 4
        Random.Range(0, 2);
        randomNumber = Random.value;
        //ReferencingPlatformOne.transform.eulerAngles = new Vector3(0, 0, Random.Range(0, 360));
        ReferencingPlatformFour.transform.position = new Vector2(8
            , Random.Range(-3, 3));
        Instantiate(ReferencingPlatformFour);







    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
