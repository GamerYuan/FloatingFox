using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;
    public static LevelChanger instance;

    private int levelToLoad;

    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    public void FadeToNextLevel()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToLevel(int levelIndex) 
    {

        levelToLoad = levelIndex;
        animator.SetTrigger("Fade Out");
        Time.timeScale = 0;
    }

    public void OnFadeComplete()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(levelToLoad);
    }
}
