using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int Hp;
    public GameObject enemy;
    void Update()
    {
        if (Hp <= 0)
        {
            GameObject.Destroy(enemy);
        }
    }
}
