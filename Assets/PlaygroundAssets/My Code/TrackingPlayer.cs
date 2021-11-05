using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingPlayer : MonoBehaviour
{
    public string Player;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Transform>().position = new Vector3(GameObject.Find(Player).transform.position.x, 0, -10);
    }
}
