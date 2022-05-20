using UnityEngine;
using System.Collections.Generic;

public class GroundManager : MonoBehaviour
{
    public GameObject[] GroundPrefabs;
    private float zSpawn = 47;
    private float groundLength = 100;
    private int numberOfGrounds = 3;
    public Transform playerTransform;
    private List<GameObject> activeGrounds = new List<GameObject>();
    

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 2; i++) {
            SpawnGround(Random.Range(0, GroundPrefabs.Length));
        }

       // player1=player1.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.z - 188 > zSpawn - (numberOfGrounds * groundLength)) {
            SpawnGround(Random.Range(0, GroundPrefabs.Length));
            DeleteGround();
        }
    }
    public void SpawnGround(int groundIndex) {
        GameObject go = Instantiate(GroundPrefabs[groundIndex], transform.forward * zSpawn, transform.rotation);
        activeGrounds.Add(go);
        zSpawn += groundLength;
    }

    private void DeleteGround() {
        Destroy(activeGrounds[0]);
        activeGrounds.RemoveAt(0);
    }
}
