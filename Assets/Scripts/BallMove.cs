using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{

   public  Rigidbody r;
    // Start is called before the first frame update
    private void Start()
    {
        r.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        r.AddForce(0f, 0f, 2f);
    }
}
