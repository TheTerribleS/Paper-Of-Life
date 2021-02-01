using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollowing : MonoBehaviour
{
    public float speed,
                 zLock;
    public Move Player;

    public bool didPlayerDie = false,
                isACinematicActive = false;

    private void Start()
    {
        zLock = transform.position.z;
        CinematicsContainer.StartCinematic += FreezeForCinematic;
        CinematicsContainer.EndCinematic += UnfreezeForCinematic;
    }

    void Update()
    {
        Vector3 Target;

        if (!isACinematicActive)
        {
            Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        else if (didPlayerDie)
            Target = Player.transform.position;
        else
        {
            Target = Player.transform.position;
        }

        Target.z = zLock;

        transform.position = Vector3.MoveTowards(transform.position, Target, (speed * Time.deltaTime) * Vector3.Distance(transform.position, Target));
    }

    public IEnumerator FollowPlayer()
    {
        didPlayerDie = true;
        yield return new WaitForSeconds(3);
        didPlayerDie = false;
    }

    public void FreezeForCinematic()
    {
        isACinematicActive = true;
    }
    public void UnfreezeForCinematic()
    {
        isACinematicActive = false;
    }
}
