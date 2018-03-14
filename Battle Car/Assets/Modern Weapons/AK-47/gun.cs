using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

	public GameObject bullet;
	public int power;
	public float damage;

	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonUp (0)) { // 0= clique gauche
			GameObject balle = (GameObject)Instantiate(bullet, this.transform.position, Quaternion.identity);
			balle.GetComponent<Rigidbody>().AddForce (Vector3.forward * power * Time.deltaTime);
		}

	}

	void OnTriggerEnter (Collider other){

		var destruction = other.transform.GetComponent<Destruction> ();
		if (destruction == null)
			return;
		destruction.TakeDamage (damage);
	}
}
