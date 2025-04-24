using Mono.Cecil.Cil;
using UnityEngine;

public class enemyMover : MonoBehaviour
{
    public float m = .01f;

    void Start()
    {
        
    }

    void Update()
    {
        print(m);
        transform.Translate( m , 0 , 0);
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
            //
        }
    }

}
