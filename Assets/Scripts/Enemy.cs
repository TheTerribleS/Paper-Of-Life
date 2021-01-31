using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Enemy : MonoBehaviour
{
    public float xMovement,
                 yMovement;

    public float speed = 1;

    private void Start()
    {
        xMovement = speed;
        yMovement = speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(xMovement * Time.deltaTime, yMovement * Time.deltaTime);
    }

}
