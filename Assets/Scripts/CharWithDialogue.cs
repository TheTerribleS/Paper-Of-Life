using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharWithDialogue : MonoBehaviour
{
    public string Name,
                  DialogueToShow;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponentInChildren<UIManager>() != null)
        {
            collision.GetComponentInChildren<UIManager>().UpdateAndShowDialogue(Name + ": " + DialogueToShow);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponentInChildren<UIManager>() != null)
        {
            collision.GetComponentInChildren<UIManager>().HideDialogue();
        }
    }
}
