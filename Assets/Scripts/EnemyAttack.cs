using UnityEngine;
using System. Threading. Tasks;

public class EnemyAttack : MonoBehaviour
{
    public float t = 0.0f;
    public float attwait = 1.0f;
    public PlayerStats playerStats;
    public int AttDamage = 1;

    public bool hitted = false;

    void Update()
    {
        t += Time.deltaTime; 
        
        if (hitted && t > attwait)
        {
            t = 0.0f;
            playerStats.health -= AttDamage;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            hitted = true;
            
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            hitted = false;
        }
    }
}
