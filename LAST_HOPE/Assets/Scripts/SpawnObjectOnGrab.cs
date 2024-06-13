using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;

// Spawns spawnableObject in front of the player when an object with this script is grabbed
public class SpawnObjectOnGrab : MonoBehaviour
{
    public GameObject spawnablePrefab;  // Reference to the prefab that will be instantiated
    private GameObject spawnedObject; // Reference to the spawned object
    private GameObject player;  // Reference to the player object

    private void Awake()
    {
        player = GameObject.FindWithTag("MainCamera");
    }

    // This function will be triggered when the object is grabbed
    public void OnGrab()
    {
        Debug.Log("Object was grabbed!");
        Debug.Log(player.transform.position);

        // Calculate the spawn position above the interactable object
        Vector3 spawnPosition = player.transform.position + Vector3.forward;

        // Instantiate the popup object
        spawnedObject = Instantiate(spawnablePrefab, spawnPosition, Quaternion.identity);
    }

}
