using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Enemy : MonoBehaviour
{
    float xMovement,
          yMovement;

    public float speed = 1;

    private void Start()
    {
        SetDirection();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(xMovement * Time.deltaTime, yMovement * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall") || collision.gameObject.GetComponent<PlayerDeathManager>()  != null)
        {
            SetDirection(gameObject.transform.position, collision.transform.position);
        }
    }

    void SetDirection()
    {
        xMovement = - speed;
        yMovement = speed;
    }

    void SetDirection(Vector3 playerPosition, Vector3 objectPosition)
    {
        if (Mathf.Abs(playerPosition.x - objectPosition.x) < Mathf.Abs(playerPosition.y - objectPosition.y) )
        {
            if (xMovement > 0)
                xMovement = -speed;
            else
                xMovement = speed;
        }
        else
        {
            if (yMovement > 0)
                yMovement = -speed;
            else
                yMovement = speed;
        }
    }
}
