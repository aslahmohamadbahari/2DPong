using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("149251970101-211-Aslah Mohamad Bahari");
    }
    public void backToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void creadiScene()
    {
        SceneManager.LoadScene("CreaditScene");
    }
}
