using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Vector3 targetPosition;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Move>() != null)
        {
            other.transform.position = targetPosition;
            Camera.main.transform.position = targetPosition;
        }
    }
}
