using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset; //it stores 3 floats

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(player.position);  //to see the position of the player in the console
        // transform.position = player.position;    //fisrt person camera
        transform.position = player.position + offset;  //it adds the offset from the main camera to the player position

    }
}
