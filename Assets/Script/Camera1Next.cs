using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camera1Next : MonoBehaviour
{
    public Transform Options;
    void Start()
    {
        Options.gameObject.SetActive(false);
    }


    public void Next1()
    {
        SceneManager.LoadScene(5);
    }
}