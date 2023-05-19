using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartController : MonoBehaviour
{
    
    [SerializeField] private GameObject restartMenu;

    public void Pause()
    {
        restartMenu.SetActive(true);

        Time.timeScale = 0f;
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        restartMenu.SetActive(false);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        

    }

    public void MainMenu()
    {
        //SceneManager.LoadScene(0); // Jak bedzie zrobione Main Menu
    }


    public void CloseGame()
    {
        Application.Quit();
    }
}
