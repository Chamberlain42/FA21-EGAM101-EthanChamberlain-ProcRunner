using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotTouch : MonoBehaviour
{
    public Vector3 DesiredScale;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Danger";
        GetComponent<Transform>().localScale = DesiredScale;
        gameObject.AddComponent<AreaEffector2D>();
        gameObject.AddComponent<Rigidbody2D>();
        gameObject.AddComponent<BoxCollider2D>();


        // if comes into contact with something destroy it
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") 
        {
            gameObject.GetComponent<DestroyAction>(); 
                }
    }
}
