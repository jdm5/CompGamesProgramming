﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour { 


    public Animator transition;
    public float transitionTime = 1f;

    public void PlayGame()
    {
        LoadNextLevel();
    }

    public void QuitGame()
    {   
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
        //play anim
        //wait
        //load scene
    }




}
