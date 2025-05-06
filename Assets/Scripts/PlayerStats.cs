using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using SuperPupSystems.Helper;

// Stashed changes

public class PlayerStats : MonoBehaviour
{
    public float health = 10f;
    public float strength = 1;
    public bool doubleJumpPU = false;
    public bool wallClimbPU = false;
    public bool strengthPU = false;
    public bool dashPU = false;
    public bool airDashPU = false;
    public SpriteRenderer graphic;
    public float flashLine = 2;
    public Timer timer;

    void FixedUpdate()
    {
        // set
        // graphic.color = (health <= 2) ? Color.red : Color.white;

        //graphic.color = (graphic.color == Color.white) ? Color.red : Color.white;
    	if (health > flashLine)
		graphic.color = Color.white;
	
	if (timer.timeLeft <= 0.0f && health <= flashLine)
		Swap();
    }

    public void Swap()
    {
        graphic.color = (graphic.color == Color.white) ? Color.red : Color.white;
    
        if (health <= flashLine)
            timer.StartTimer();
    }
}
