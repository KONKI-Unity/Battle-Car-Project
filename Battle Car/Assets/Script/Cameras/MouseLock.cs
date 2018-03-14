using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLock : MonoBehaviour {

	public float rotationX;
	public float rotationY;
	public float sensityvity = 5f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space")) {
            if (!IsMouseOffScreen())
            {
                rotationX -= Input.GetAxis("Mouse Y") * sensityvity;
                rotationY += Input.GetAxis("Mouse X") * sensityvity;



                transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);

            }
            
        }
		

	}

    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }

   

    private bool IsMouseOffScreen(){

		if (Input.mousePosition.x <= 0 || Input.mousePosition.y <= 0 || Input.mousePosition.x >= Screen.width || Input.mousePosition.y >= Screen.height)
			return true;

		return false;

	}
}
