using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManger : MonoBehaviour
{
    public GameObject PlatformPrefab;
    public GameObject ReferencePlatformOne, ReferencePlatormTwo;

    // Start is called before the first frame update
    void Start()
    {
        ReferencePlatformOne = Instantiate(PlatformPrefab);
        ReferencePlatformOne.name = "PlatformOne";


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
