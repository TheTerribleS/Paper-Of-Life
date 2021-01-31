using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1;
    Rigidbody2D rb;
    public float xForce,
                 yForce;
    public UIManager UI;

    public bool didPlayerDie = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 Target;
        
        if (!didPlayerDie)
        {
            Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        else
        {
            Target = Vector3.zero;
        }
        
        Target.z = transform.position.z;

        if (Target.x > transform.position.x)
        {
            xForce = speed;
        }
        else
        {
            xForce = -speed;
        }

        if (Target.y > transform.position.y)
        {
            yForce = speed;
        }
        else
        {
            yForce = -speed;
        }

        rb.AddForce(new Vector2(xForce, yForce));       
    }

    public IEnumerator WaitForCamera()
    {
        didPlayerDie = true;
        yield return new WaitForSeconds(3);
        didPlayerDie = false;
    }
}
