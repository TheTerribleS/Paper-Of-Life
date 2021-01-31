using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CinematicsContainer : MonoBehaviour
{
    public Image DisplayOfFrame;

    public int currentScene;

    public CinematicScenes currentCinematic;
    
    public List<CinematicScenes> CinematicScenes;

    public void StartImagesCinematic(string NameOfScene)
    {
         currentCinematic = CinematicScenes.Find(x => x.CinematicSceneName == NameOfScene);
        currentScene = 0;
         DisplayOfFrame.sprite = currentCinematic.CinematicFrames[currentScene];
    }

    public void NextScene()
    {
        if (currentScene == currentCinematic.CinematicFrames.Count)
        {
            DisplayOfFrame.gameObject.SetActive(false);
        }
        else
        {
            currentScene++;
            DisplayOfFrame.sprite = currentCinematic.CinematicFrames[currentScene];
        }
    }

    public void PreviousScene()
    {
        if (currentScene != 0)
        {
            currentScene--;
            DisplayOfFrame.sprite = currentCinematic.CinematicFrames[currentScene];
        }
    }
}

[System.Serializable]
public class CinematicScenes
{
    public string CinematicSceneName;
    public List<Sprite> CinematicFrames;

    CinematicScenes()
    {

    }
}
