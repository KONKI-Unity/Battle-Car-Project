
using UnityEngine;
using UnityEngine.Networking;

[System.Serializable]
public class Gun : NetworkBehaviour {

    public string name = "X-50 Machinegun";

    public float damage = 10f;
    public float range = 100f;

    public GameObject weapon;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;
    public float impactForce = 30f;
    public float fireRate = 15f;

    private float fireDelay = 0f;

    void Start()
    {
        if (weapon == null)
        {
            Debug.LogError("Gun.cs : No weapon referenced!");
            this.enabled = false;
        }
    }

    void Update () {
        if (Input.GetButton("Fire1") && Time.time >= fireDelay)
        {
            fireDelay = Time.time + 1f / fireRate;
            Shoot();
            System.Console.WriteLine("Shoot");
        }
	}

    void Shoot()
    {
        muzzleFlash.Play();

        RaycastHit hit;
        if(Physics.Raycast(weapon.transform.position, weapon.transform.forward, out hit, range))
        {
            
            Debug.Log(hit.transform.name);
            System.Console.WriteLine(hit.transform.name);

            
            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamege(damage);
            }

            if(hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
            
            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));

            Destroy(impactGO, 2f);


        }
    }
}
