using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text Dialogue;
    public CinematicsContainer Cinematics;

    private void Start()
    {
        Dialogue.gameObject.SetActive(false);
        Cinematics.StartImagesCinematic("Intro");
    }

    public void UpdateAndShowDialogue(string newDialogue)
    {
        Dialogue.gameObject.SetActive(true);
        Dialogue.text = newDialogue;
    }
    public void HideDialogue()
    {
        Dialogue.gameObject.SetActive(false);
    }
}
