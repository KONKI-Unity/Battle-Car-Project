using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour {

	public GameObject Arm1;
	public GameObject Arm2;
	int weaponOut = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.E)){
			Debug.Log ("Pressed E");
			RaycastHit hit;
			if(Physics.Raycast(Camera.main.transform.position,transform.forward, out hit)){
				if(hit.transform.tag=="item"){
					if(hit.transform.gameObject.name.Contains("Arm2")){
						if(weaponOut == 1){
							Destroy(hit.transform.gameObject);
							Instantiate(Arm2,transform.root.transform.position+new Vector3(0,2,0),Quaternion.identity);
						}else if(weaponOut == 2){
							Destroy(hit.transform.gameObject);
							Instantiate(Arm1,transform.root.transform.position+new Vector3(0,2,0),Quaternion.identity);
						}
						changeWeapon (1);
					}else if(hit.transform.gameObject.name.Contains("Arm1")){
						
						if (weaponOut == 1){
							Destroy(hit.transform.gameObject);
							Instantiate(Arm2,transform.root.transform.position+new Vector3(0,2,0),Quaternion.identity);
						}else if(weaponOut==2){
							Destroy(hit.transform.gameObject);
							Instantiate(Arm1,transform.root.transform.position+new Vector3(0,2,0),Quaternion.identity);
						}
						changeWeapon(2);
						}
					}
				}
			}
		}
		


			void changeWeapon(int weapon){
		if (weapon == 1) {
			weaponOut = 1;
			transform.Find ("Arm1").gameObject.SetActive (false);
			transform.Find ("Arm2").gameObject.SetActive (true);
				}else if(weapon == 2){
			weaponOut = 2;
			transform.Find ("Arm1").gameObject.SetActive (true);
			transform.Find ("Arm2").gameObject.SetActive (false);
				}
			}
}
