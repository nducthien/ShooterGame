﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public void PlayGameButton(){
        Application.LoadLevel("SampleScene");
    }

    public void QuitGameButton(){

        Application.Quit();

    }
}
