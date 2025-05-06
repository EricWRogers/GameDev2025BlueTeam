using UnityEngine;

public class FlipSprite : MonoBehaviour
{
    public SpriteRenderer renderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            renderer.flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            renderer.flipX = false;
        }
    }
}
