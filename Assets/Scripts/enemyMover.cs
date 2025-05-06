using Mono.Cecil.Cil;
using UnityEngine;

public class enemyMover : MonoBehaviour
{
    public float m = .01f;

    public bool target = false;
    void Start()
    {
        
    }

    void Update()
    {
        if (target == true)
        {
            
            transform.Translate(0,0,0);
        }

        else
        {
            transform.Translate( m , 0 , 0);
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
