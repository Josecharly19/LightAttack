using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 50; 

    public void TakeDamage(int amount)
    {
        health -= amount; 
        Debug.Log("Enemy took damage: "+ amount);

        if (health <= 0)
        {
            Die();
        }
    }

    void Die ()
    {
        Destroy(gameObject);
    }

}
