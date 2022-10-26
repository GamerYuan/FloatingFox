using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    public Animator animator;
    public static LevelChanger instance;

    private int levelToLoad;

    // Update is called once per frame
    void Awake()
    {
        instance = this;
    }

    public void FadeToNextLevel()
    {
        FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FadeToLevel(int levelIndex) 
    {
        levelToLoad = levelIndex;
        animator.SetTrigger("Fade Out");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
