using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void StartGameLevel(int levelIndex)
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + levelIndex);

    }
}
