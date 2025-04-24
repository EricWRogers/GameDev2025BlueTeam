using UnityEngine;

public class Powerup : MonoBehaviour
{

    public GameObject pickupEffect;
   void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup();
        }
    }

    void Pickup()
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);



        Destroy(gameObject);
    }



}
