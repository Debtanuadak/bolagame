using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attract : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;

    private void OnTriggerstay(Collider other)
    {
        if(other.CompareTag("cube"))
        {
            transform.position = Vector3.MoveTowards(transform.position, other.transform.position, speed * Time.deltaTime);
        }
    }
}
