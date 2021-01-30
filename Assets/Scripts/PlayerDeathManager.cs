using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class PlayerDeathManager : MonoBehaviour
{
    Vector3 SpawnPoint;
    Checkpoint PlayerCheckpoint;

    public float speed = 0.5f;

    private void Awake()
    {
        SpawnPoint = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if collision is a trap or enemy
        if ((collision.gameObject.GetComponent<Trap>() != null) || (collision.gameObject.GetComponent<Enemy>() != null))
        {
            //HERE: call function for blackout animation
            if (PlayerCheckpoint != null)
            {
                transform.position = PlayerCheckpoint.transform.position;
            }
            else
            {
                transform.position = SpawnPoint;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Checkpoint>() != null)
        {
            if (PlayerCheckpoint != null)
            {
                PlayerCheckpoint.GetComponent<SpriteShapeRenderer>().color = Color.black;
                PlayerCheckpoint.GetComponent<SpriteShapeRenderer>().color = new Color(190, 236, 37, 1f);
            } 
            PlayerCheckpoint = collision.GetComponent<Checkpoint>();
            PlayerCheckpoint.GetComponent<SpriteShapeRenderer>().color = Color.black;
            PlayerCheckpoint.GetComponent<SpriteShapeRenderer>().color = new Color(190, 236, 37, 0.5f);
        }
    }


}
