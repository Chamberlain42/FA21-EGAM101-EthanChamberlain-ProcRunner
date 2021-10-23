using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Sprite SpriteToShow;
    public Vector3 DesiredPosition;
    public Color DesiredColor;
    public int OrderLayer;
    public float speed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<SpriteRenderer>();

        GetComponent<SpriteRenderer>().color = DesiredColor;
        GetComponent<SpriteRenderer>().sortingOrder = OrderLayer;

        GetComponent<SpriteRenderer>().sprite = SpriteToShow;

        GetComponent<Transform>().position = DesiredPosition;

    }

    // Update is called once per frame
    void Update()
    {
        //what is the player doing with the controls
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"), 0);
        //update the ships position each frame
        transform.position += move
            * speed * Time.deltaTime;
    }
}
