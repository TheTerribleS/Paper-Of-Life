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
        xMovement = Random.Range(-1, 2) * speed;
        yMovement = Random.Range(-1, 2) * speed;
    }

    void SetDirection(Vector3 playerPosition, Vector3 objectPosition)
    {
        if (Mathf.Abs(playerPosition.x - objectPosition.x) < Mathf.Abs(playerPosition.y - objectPosition.y) )
        {
            if (playerPosition.x > objectPosition.x)
                xMovement = Random.Range(0, 2) * speed;
            else
                xMovement = Random.Range(-1, 1) * speed;
        }
        else
        {
            if (playerPosition.y < objectPosition.y)
                yMovement = Random.Range(0, 2) * speed;
            else
                yMovement = Random.Range(-1, 1) * speed;
        }
    }
}
