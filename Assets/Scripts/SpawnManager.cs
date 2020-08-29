using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float startDelay;
    public float spawnDelay;
    public GameObject[] animals;
    public float positionLow;
    public float positionHigh;
    public float positionY;
    public float positionZ;
    
    private int randVal;
    private Vector3 randPos;

    private void Start()
    {
        InvokeRepeating("SpawnAnimal", startDelay, spawnDelay);
    }

    private void SpawnAnimal()
    {
        randVal = Random.Range(0, animals.Length);
        randPos.Set(Random.Range(positionLow, positionHigh), positionY, positionZ);
        animals[randVal].transform.position = randPos;
        Instantiate(animals[randVal]);
    }
}
