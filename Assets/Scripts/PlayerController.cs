using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    public float speed = 10.0f;
    // 
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // FixedUpdate runs 52 times a second
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (h != 0.0f || v != 0.0f)
        {
            Vector2 direction = new Vector2(h, v).normalized;
            rigidbody2D.AddForce(direction * speed);
        }
        
    }
}
