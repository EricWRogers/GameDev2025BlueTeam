using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DoubleJump : MonoBehaviour
{
    public float multiplier = 2f;
    public float duration = 10f;
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "Player")
        {
            Debug.Log(other.gameObject.name);
            StartCoroutine(Pickup(other));

        }

    }



    IEnumerator Pickup(Collider2D player)
    {

        PlayerStats stats = player.GetComponent<PlayerStats>();
        stats.doubleJumpPU = true;

        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;

        yield return new WaitForSeconds(duration);

        stats.doubleJumpPU = false;

        Destroy(gameObject);
    }
}
