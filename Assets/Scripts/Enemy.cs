using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Random.Range(-3, 3) * Time.deltaTime, Random.Range(-3, 3)* Time.deltaTime);
    }
}
