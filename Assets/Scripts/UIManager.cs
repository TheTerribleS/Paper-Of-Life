﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text Dialogue;

    private void Start()
    {
        Dialogue.gameObject.SetActive(false);
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
