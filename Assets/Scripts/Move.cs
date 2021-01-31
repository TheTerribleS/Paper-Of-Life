using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    void Update()
    {
        Vector3 Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Target.z = transform.position.z;

        transform.position = Vector3.MoveTowards(transform.position, Target, (speed * Time.deltaTime) * Vector3.Distance(transform.position, Target));
    }
}
