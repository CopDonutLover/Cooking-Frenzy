using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
    // Sub-Main Methods

    // Main Methods

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void LoadScene(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }
}
