using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScreen : MonoBehaviour
{
    public int NScreenCreated;
    public int NScreenDesried;

    public GameObject AvatarPrefab;
    public GameObject ScreenPrefab;

    private GameObject avatarInstance;
    // Start is called before the first frame update
    void Start()
    {
        avatarInstance = Instantiate(AvatarPrefab);
        avatarInstance.transform.position = new Vector3(0, 0, 0);

        NScreenCreated = 0;
        NScreenDesried = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (NScreenCreated > NScreenCreated)
        {
            GameObject newScreen =Instantiate(ScreenPrefab);
            newScreen.transform.localPosition = new Vector3(10 * NScreenCreated, 0, 0);
            newScreen.name = "Screen" + NScreenCreated;
            NScreenCreated += 1;
        }
    }
}
