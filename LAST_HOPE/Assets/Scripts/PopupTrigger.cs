using Microsoft.MixedReality.Toolkit.UI;
using UnityEngine;

public class PopupTrigger : MonoBehaviour
{
    public float spawnHeight = 1.0f;
    public GameObject popupObject; // Assign your popup here

    public void Start()
    {
        popupObject.SetActive(false);
    }

    public void OnGrab()
    {
        Debug.Log("Object was grabbed!");
        popupObject.SetActive(true);
    }

    public void OnRelease()
    {
        popupObject.SetActive(false);
    }
}
