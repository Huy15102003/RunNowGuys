using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public static GroundSpawner Instance;
    private Vector3 nextSpawnerPoint;
    public GameObject groundTile;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        for(int i=0; i<20; i++)
        {
            SpawnTile();
        }
    }
    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundTile, nextSpawnerPoint, Quaternion.identity);
        nextSpawnerPoint = temp.transform.GetChild(1).position;
    }

}
