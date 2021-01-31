using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    Enemy parentEnemy;
    public bool right,
                left,
                up,
                down;
    
    // Start is called before the first frame update
    void Start()
    {
        parentEnemy = GetComponentInParent<Enemy>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("I read the collision");
        if (right)
            parentEnemy.xMovement = -parentEnemy.speed;
        else if (left)
            parentEnemy.xMovement = parentEnemy.speed;
        else if (up)
            parentEnemy.yMovement = -parentEnemy.speed;
        else if (down)
            parentEnemy.yMovement = parentEnemy.speed;
    }
}
