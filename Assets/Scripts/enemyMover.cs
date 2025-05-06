using Mono.Cecil.Cil;
using UnityEngine;

public class enemyMover : MonoBehaviour
{
    public EnemyAttack EA;
    public float m = .01f;

    public bool target = false;
    public GameObject attackthing;
    void Start()
    {
        
    }

    void Update()
    {
        if (target == true)
        {
            transform.Translate(0,0,0);
            attackthing.SetActive(true);

        }

        else
        {
            transform.Translate( m , 0 , 0);
            attackthing.SetActive(false);

        }
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wall")
        {
            transform.Rotate(0 , 180, 0);
            //m = m * -1;
        }
        if (other.tag == "Player")
        {
            target = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player" && target == true)
        {
            target = false;
        }
    }
}
