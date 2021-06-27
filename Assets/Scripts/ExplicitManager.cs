using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExplicitManager : MonoBehaviour
{
    // 1 = enabled
    // 0 = disabled - default value

    //check if it is enabled through other scripts - get this class
    // public ExplicitManager explicitManager (set object in editor so you don't get an error)
    // if(PlayerPrefs.GetInt("Explicit") == 1) {
    //  load the EXPLICIT scene you need here, then else statement if its 0 to load the NON EXPLICIT scene
    // }
    void Start()
    {
        PlayerPrefs.SetInt("Explicit", 0);
        Debug.Log(PlayerPrefs.GetInt("Explicit").ToString());
    }

    public void EnableExplicit()
    {
        PlayerPrefs.SetInt("Explicit", 1);
        Debug.Log(PlayerPrefs.GetInt("Explicit").ToString());
    }

    public void DisableExplicit()
    {
        PlayerPrefs.SetInt("Explicit", 0);
        Debug.Log(PlayerPrefs.GetInt("Explicit").ToString());
    }

    //example of how to load scene through other scripts, make sure you get a reference to this class

    public void LoadScene()
    {
        if(PlayerPrefs.GetInt("Explicit") == 1)
        {
            SceneManager.LoadScene("ExplicitScene");
        }
        if(PlayerPrefs.GetInt("Explicit") == 0)
        {
            SceneManager.LoadScene("NonExplicitScene");
        }
    }
}
