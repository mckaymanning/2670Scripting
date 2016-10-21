using UnityEngine;
using System.Collections;

public class StarPopulator : MonoBehaviour
{

    public Transform[] populateLocations;
    public GameObject[] Objects;
    public float spawnTime = 1.5f;

    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }


    void Spawn()
    {
        int popIndex = Random.Range(0, populateLocations.Length);
        int objectIndex = Random.Range(0, Objects.Length);

        Instantiate(Objects[objectIndex], populateLocations[popIndex].position, populateLocations[popIndex].rotation);
    }

}