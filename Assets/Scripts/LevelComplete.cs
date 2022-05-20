using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel() {
        
        //when it reaches the final level it returns back to the main menu 
        if (SceneManager.sceneCountInBuildSettings <= (SceneManager.GetActiveScene().buildIndex + 1))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - SceneManager.sceneCountInBuildSettings + 1);

        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
}
