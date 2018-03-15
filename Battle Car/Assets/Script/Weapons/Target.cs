
using UnityEngine;

public class Target : MonoBehaviour {

	public float health = 200f;

    public void TakeDamege(float amount)
    {
        health -= amount;
        if(health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
