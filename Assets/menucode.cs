﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menucode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void tryAgain()
    {
        Application.LoadLevel(1);
    }

    public void start()
    {
        Application.LoadLevel(1);
    }

    public void exitgame()
    {
        Application.Quit();
    }
}
