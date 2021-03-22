using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generate : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 3f;
    
    public Rigidbody cube;
    public Rigidbody plane;

    public GameObject msg;

    int level1c = 10;
    int level1p = 3;

    private void Start()
    {
        currentTime = startingTime;

    }

    // Update is called once per frame
    public void instantiate()
    {
        if (level1c > 0)
        {
            Instantiate(cube);
            level1c--;
        }

        else
        {
            msg.SetActive(true);
        }
     


    }

    public void instantiatePlane()
    {
        if (level1p > 0)
        {
            Instantiate(plane);
            level1p--;
        }

        else
        {
            msg.SetActive(true);
        }
    }
}
