using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScreenTrigger : MonoBehaviour
{
   

    // Start is called before the first frame update
    void Start()
    {
  

        GetComponent<Transform>().localScale = new Vector3(.5f, 10f, 0f);
        GetComponent<Transform>().localPosition = new Vector3(5, 0, 0);
        
        gameObject.AddComponent<BoxCollider2D>();
       GetComponent<BoxCollider2D>().isTrigger = true;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().NScreenDesired += 1;

        }
        
       
            }
        
    

}