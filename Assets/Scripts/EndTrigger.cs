using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public gameManager gManager;
    void OnTriggerEnter()
    {
        gManager.CompleteLevel();
    }
}
