using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject[] spawnPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        int randNum = Random.Range(0, spawnPrefabs.Length);
        GameObject spawnObj = spawnPrefabs[randNum];

        Instantiate(spawnObj, transform.position, Quaternion.identity);
    }
}
