using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;     //a reference to player movement script

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle") { //tha elexei gia ola ta objects p ehun tag Obstacle
            
            Debug.Log("We hit an obstacle");
            movement.enabled = false;       //Disable the player movement
            FindObjectOfType<gameManager>().EndGame();
                    }
    }

  
}
