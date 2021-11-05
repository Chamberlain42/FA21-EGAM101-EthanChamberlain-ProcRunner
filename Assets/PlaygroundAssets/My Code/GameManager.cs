using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int NScreenCreated;
    public int NScreenDesired;

    public GameObject AvatarPrefab;
    public GameObject ScreenPrefab;

    private GameObject avatarInstance;
    private GameObject newScreenTriggerInstance;
    
    // Start is called before the first frame update
    void Start()
    {
        avatarInstance = Instantiate(AvatarPrefab);
        avatarInstance.transform.position = new Vector3(0, 0, 0);

        NScreenCreated = 0;
        NScreenDesired = 1;
       
        newScreenTriggerInstance = new GameObject();
        newScreenTriggerInstance.name = "NewScreenTriggerObject";
        newScreenTriggerInstance.AddComponent<NewScreenTrigger>();
        newScreenTriggerInstance.GetComponent<Transform>().position = new Vector3(30 * NScreenCreated, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (NScreenCreated < NScreenDesired)
        {
            GameObject newScreen = Instantiate(ScreenPrefab);
            newScreen.transform.localPosition = new Vector3(30 * NScreenCreated, 0, 0);
            newScreen.name = "Screen" + NScreenCreated;
            NScreenCreated += 1;
        }
    }
}
