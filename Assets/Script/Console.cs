using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Console : MonoBehaviour
{
    public Transform Consoles;
    void Start()
    {
        Consoles.gameObject.SetActive(false);
    }

    public void ConsoleSetting()
    {
        Consoles.gameObject.SetActive(true);
    }

    public void ConsoleBack()
    {
        Consoles.gameObject.SetActive(false);
    }

}

