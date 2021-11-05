using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    public GameObject ParentPlatform;
    public int Spawnrate;
    public GameObject DeathCollider;
   // public GameObject Sprite2;
    
    // Start is called before the first frame update
    void Start()
    {
        float randomNumber;
        Random.Range(-2, 4);
        randomNumber = Random.value;
        GameObject PlatformReference;
        PlatformReference = Instantiate(ParentPlatform);
        PlatformReference.GetComponent<Transform>().SetParent(gameObject.GetComponent<Transform>());
        PlatformReference.transform.localPosition = new Vector3(-10, Random.Range(-4, 4), 0);

        Random.Range(0, 4);
        randomNumber = Random.value;
       
        PlatformReference = Instantiate(ParentPlatform);
        PlatformReference.GetComponent<Transform>().SetParent(gameObject.GetComponent<Transform>());
        PlatformReference.transform.localPosition = new Vector3(-4, Random.Range(-4, 4), 0);

        Random.Range(0, 2);
        randomNumber = Random.value;
        
        PlatformReference = Instantiate(ParentPlatform);
        PlatformReference.GetComponent<Transform>().SetParent(gameObject.GetComponent<Transform>());
        PlatformReference.transform.localPosition = new Vector3(3, Random.Range(-4, 4), 0);

        Random.Range(0, 4);
        randomNumber = Random.value;
        
        PlatformReference = Instantiate(ParentPlatform);
        PlatformReference.GetComponent<Transform>().SetParent(gameObject.GetComponent<Transform>());
        PlatformReference.transform.localPosition = new Vector3(10, Random.Range(-4, 4), 0);

        GameObject DeathBorder;
        DeathBorder = Instantiate(DeathCollider);
        DeathBorder.GetComponent<BoxCollider2D>();
        DeathBorder.GetComponent<Transform>().localPosition = new Vector3(0, -6, 0);
        DeathBorder.GetComponent<Transform>().localScale = new Vector3(20, 1, 0);



       // randomNumber = Random.Range(1, 10);
       //  if (randomNumber > Spawnrate)
        {
          // Instantiate();


        }







    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
