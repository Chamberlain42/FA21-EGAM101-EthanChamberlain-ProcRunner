using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PercentSpawn : MonoBehaviour
{
    public GameObject Sprite1;
    public Vector3 DesiredPosition;
    //public GameObject Sprite2;
    public float Spawnrate;
    

    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<SpriteRenderer>();

        GetComponent<Transform>().position = DesiredPosition;

        
        
        


        float randomNumber;
        randomNumber = Random.Range(1, 10);
        if (randomNumber > Spawnrate) 
        {
            Instantiate(Sprite1);


        }
        //else
        //{ Instantiate(Sprite2);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
