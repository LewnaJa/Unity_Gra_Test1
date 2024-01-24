using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Transform Options;
    void Start()
    {
        Options.gameObject.SetActive(false);
    }


    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Setting()
    {
        Options.gameObject.SetActive(true);
    }

    public void SettingsBack()
    {
        Options.gameObject.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exitted");
    }
}
