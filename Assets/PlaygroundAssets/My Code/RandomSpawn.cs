using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject Sprite1;
    // Start is called before the first frame update
    void Start()
    {
        float randomNumber;
        Random.Range(-10, 10);
        randomNumber = Random.value;
        GetComponent<Transform>().localEulerAngles = new Vector3(randomNumber, randomNumber, 0);
        GetComponent<Transform>().localPosition = new Vector3(randomNumber, randomNumber, 0);
        Instantiate(Sprite1);

        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
