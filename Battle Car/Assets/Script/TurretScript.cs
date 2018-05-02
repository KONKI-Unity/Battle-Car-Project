using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretScript : MonoBehaviour {

    public Camera cam;

    void Update()
    {
        Vector3 mousePositionVector3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);

        mousePositionVector3 = cam.ScreenToWorldPoint(mousePositionVector3);
    }
}
