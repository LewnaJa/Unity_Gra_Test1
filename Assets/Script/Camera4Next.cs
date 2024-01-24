using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camera4Next : MonoBehaviour
{
    public Transform Options;
    void Start()
    {
        Options.gameObject.SetActive(false);
    }


    public void Next4()
    {
        SceneManager.LoadScene(8);
    }
}