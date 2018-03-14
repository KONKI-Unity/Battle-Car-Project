using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour {

	public GameObject bullet;
	public int power;

	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp (0)) { // 0= clique gauche
			GameObject balle = (GameObject)Instantiate(bullet, this.transform.position, Quaternion.identity);
			balle.GetComponent<Rigidbody>().AddForce (Vector3.forward * power);
		}

	}
}
