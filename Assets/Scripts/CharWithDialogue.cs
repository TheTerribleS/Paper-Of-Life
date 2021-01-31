using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharWithDialogue : MonoBehaviour
{
    public string Name,
                  DialogueToShow;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Move>().GetComponent<UIManager>() != null)
        {
            collision.GetComponent<Move>().GetComponent<UIManager>().UpdateAndShowDialogue(Name + ": " + DialogueToShow);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Move>().GetComponent<UIManager>() != null)
        {
            collision.GetComponent<Move>().GetComponent<UIManager>().HideDialogue();
        }
    }
}
