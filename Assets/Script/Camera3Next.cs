using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camera3Next : MonoBehaviour
{
    public Transform Options;
    void Start()
    {
        Options.gameObject.SetActive(false);
    }


    public void Next3()
    {
        SceneManager.LoadScene(7);
    }
}