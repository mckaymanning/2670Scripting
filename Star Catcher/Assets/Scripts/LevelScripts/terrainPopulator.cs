using UnityEngine;
using System.Collections;

public class terrainPopulator : MonoBehaviour
{

    public Transform[] populateLocations;
    public GameObject[] Objects;





    void OnTriggerEnter()
    {
        int popIndex = Random.Range(0, populateLocations.Length);
        int objectIndex = Random.Range(0, Objects.Length);

        Instantiate(Objects[objectIndex], populateLocations[popIndex].position, populateLocations[popIndex].rotation);
    }

}