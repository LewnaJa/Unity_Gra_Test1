using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camera0Next : MonoBehaviour
{
    public Transform Options;
    void Start()
    {
        Options.gameObject.SetActive(false);
    }


    public void Next()
    {
        SceneManager.LoadScene(4);
    }
}