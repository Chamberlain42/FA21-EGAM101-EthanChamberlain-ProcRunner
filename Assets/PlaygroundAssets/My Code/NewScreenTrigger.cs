using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScreenTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Transform>().localScale = new Vector3(0, 0, 0);
        gameObject.AddComponent<BoxCollider2D>();
        GetComponent<BoxCollider2D>().isTrigger = true;
    }

}