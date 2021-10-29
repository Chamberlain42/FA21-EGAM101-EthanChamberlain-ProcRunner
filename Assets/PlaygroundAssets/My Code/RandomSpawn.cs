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
        Sprite1.transform.eulerAngles = new Vector3(0, 0, Random.Range(0, 360));
        Sprite1.transform.position = new Vector2(Random.Range(-5, 5), Random.Range(-5, 5));
        Instantiate(Sprite1);

        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
