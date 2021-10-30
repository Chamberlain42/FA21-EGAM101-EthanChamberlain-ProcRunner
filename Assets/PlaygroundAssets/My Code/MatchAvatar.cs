using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchAvatar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position = new Vector3(GameObject.Find("TheAvatar").transform.position.x, 0, -10);
    }
}
