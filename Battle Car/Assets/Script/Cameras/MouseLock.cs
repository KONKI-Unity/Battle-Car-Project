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

		if (!IsMouseOffScreen ()) {
			rotationX -= Input.GetAxis ("Mouse Y") * sensityvity;
			rotationY += Input.GetAxis ("Mouse X") * sensityvity;



			transform.rotation = Quaternion.Euler (rotationX, rotationY, 0);

		}

	}

	private bool IsMouseOffScreen(){

		if (Input.mousePosition.x <= 2 || Input.mousePosition.y <= 2 || Input.mousePosition.x >= Screen.width || Input.mousePosition.y >= Screen.height)
			return true;

		return false;

	}
}
