
using UnityEngine;
using UnityEngine.Networking;

public class PlayerShoot : NetworkBehaviour {

    [SerializeField]
    private GameObject weapon;

    void Start()
    {
        if(weapon == null)
        {
            Debug.LogError("PlayerShoot : No weapon referenced!");
            this.enabled = false;
        }
    }
    void Update()
    {
        
    }
}
