using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public List<GameObject> platforms = new List<GameObject>();

    public int offset;

    void Start()
    {
        for (int i = 0; i < platforms.Count; i++)
        {
            Instantiate(platforms[i], new Vector3(0, 0, i * 86), transform.rotation);
            offset += 86;
        }
    }

    public GameObject myPlatform;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            Recycle(myPlatform);
        }
    }

    public void Recycle(GameObject platform)
    {
        platform.transform.position = new Vector3 (0, 0, offset);
        offset += 86;
    }
}


