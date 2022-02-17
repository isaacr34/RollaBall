using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUI : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("BallGame");
    }

    public void NewLevelButton()
    {
        SceneManager.LoadScene("LevelTwo");
    }
}
