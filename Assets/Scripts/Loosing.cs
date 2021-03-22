using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loosing : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            canvas.SetActive(true);
            Debug.Log("lost");
        }
    }
}
