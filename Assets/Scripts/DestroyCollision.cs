using UnityEngine;

public class DestroyCollision : MonoBehaviour
{
    public int maxHealth;
    
    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

        if (--currentHealth == 0)
            Destroy(gameObject);
    }
}
