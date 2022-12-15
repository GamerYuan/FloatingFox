using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public int level;
    // Start is called before the first frame update
    public void LoadScene()
    {
        SceneManager.LoadScene("Level " + level.ToString());
        DeathCounter.instance.ResetDeathCount();
    }
    
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

    public void LevelMenu() 
    {
        SceneManager.LoadScene(5);
    }
}
