using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject bALL;


    private void Start()
    {
        
        Instantiate(bALL, transform.position, Quaternion.identity);
    }
}
