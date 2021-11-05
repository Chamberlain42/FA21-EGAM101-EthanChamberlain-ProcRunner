using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollider : MonoBehaviour
{
    public Enums.Targets ObjectThatCollided = Enums.Targets.ThisObject;
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Transform>().localScale = new Vector3(30f, 1f, 0f);
        GetComponent<Transform>().localPosition = new Vector3(0f, -10f, 0f);

        gameObject.AddComponent<BoxCollider2D>();
        GetComponent<BoxCollider2D>().isTrigger = true;

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(Player);
            

        }

        }


    }
