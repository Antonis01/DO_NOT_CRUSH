using UnityEngine;
using UnityEngine.SceneManagement;
public class gameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    public void CompleteLevel() {
        Debug.Log("LEVEL WON!");
        completeLevelUI.SetActive(true);
    }

    public void EndGame() {

        if (gameHasEnded == false) {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            //Restart game
            //Restart();
            Invoke("Restart", restartDelay);
        }
    }

    private void Restart()
    {
        //SceneManager.LoadScene("Leve0l");   //to restart from the first level
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //restart from active scene
    }
}
