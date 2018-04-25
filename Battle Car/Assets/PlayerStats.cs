using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsPlayer : MonoBehaviour {


	public Image vie;
	public float life, maxlife; 
	public Text pdv;

	// Use this for initialization
	void Start () {
		life = maxlife;
	}

	// Update is called once per frame
	void Update () {
		vie.fillAmount = life / maxlife;
		pdv.text = life.ToString () + "/" + maxlife.ToString ();
	}
}
