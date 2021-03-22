using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMov : MonoBehaviour
{
    // Start is called before the first frame update
   float inputx, inputz;

    private void Update()
    {
        inputx = Input.GetAxis("Horizontal");
        inputz = Input.GetAxis("Vertical");

        if(inputx!=0)
        {
            transform.position += transform.right * inputx * 5f*Time.deltaTime;
        }

        if(inputz!=0)
        {
            transform.position += transform.forward * inputz *5f* Time.deltaTime;
        }

        if(Input.GetKey("c"))
        {
            transform.position -= transform.up * 5f * Time.deltaTime;
        }

        if (Input.GetKey("space"))
        {
            transform.position += transform.up * 5f * Time.deltaTime;
        }

        if (Input.GetKey("e"))
        {
            transform.Rotate( new Vector3(0f,20f*Time.deltaTime,0f));
        }

        if (Input.GetKey("q"))
        {
            transform.Rotate(new Vector3(0f,-20f * Time.deltaTime, 0f));
        }
    }
}
