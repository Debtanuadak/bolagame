using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    Vector3 moffset;
    float mzcoord;
    private void OnMouseDown()
    {
        mzcoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        moffset = gameObject.transform.position - GetMouseWorldPos();
    }

    Vector3 GetMouseWorldPos()
    {
        Vector3 mousepoint = Input.mousePosition;

        mousepoint.z = mzcoord;

        return Camera.main.ScreenToWorldPoint(mousepoint);
    }
    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + moffset;
    }
}
