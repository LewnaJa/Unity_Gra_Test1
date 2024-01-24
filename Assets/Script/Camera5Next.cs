using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camera5Next : MonoBehaviour
{
    public Transform Options;
    void Start()
    {
        Options.gameObject.SetActive(false);
    }


    public void Next5()
    {
        SceneManager.LoadScene(9);
    }
}