using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    public GameObject ParentPlatform;
    public int Spawnrate;
    
    // Start is called before the first frame update
    void Start()
    {
        float randomNumber;
        Random.Range(-2, 4);
        randomNumber = Random.value;
        GameObject PlatformReference;
        PlatformReference = Instantiate(ParentPlatform);
        PlatformReference.GetComponent<Transform>().SetParent(gameObject.GetComponent<Transform>());
        PlatformReference.transform.localPosition = new Vector2(-7, Random.Range(-3, 3));

        Random.Range(0, 4);
        randomNumber = Random.value;
       
        PlatformReference = Instantiate(ParentPlatform);
        PlatformReference.GetComponent<Transform>().SetParent(gameObject.GetComponent<Transform>());
        PlatformReference.transform.localPosition = new Vector2(-3, Random.Range(-3, 3));

        Random.Range(0, 2);
        randomNumber = Random.value;
        
        PlatformReference = Instantiate(ParentPlatform);
        PlatformReference.GetComponent<Transform>().SetParent(gameObject.GetComponent<Transform>());
        PlatformReference.transform.localPosition = new Vector2(3, Random.Range(-3, 3));

        Random.Range(0, 4);
        randomNumber = Random.value;
        
        PlatformReference = Instantiate(ParentPlatform);
        PlatformReference.GetComponent<Transform>().SetParent(gameObject.GetComponent<Transform>());
        PlatformReference.transform.localPosition = new Vector2(0, Random.Range(-3, 3));

        randomNumber = Random.Range(1, 10);
        if (randomNumber > Spawnrate)
        {
            Instantiate(ParentPlatform);


        }







    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
