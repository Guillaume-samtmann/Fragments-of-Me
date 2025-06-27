using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public string itemName;
    public GameObject heldVersion;

    public bool isHeld = false;

    public void PickUp()
    {
        SetRenderersActive(false);
        heldVersion.SetActive(true);
        isHeld = true;
    }

    public void Drop(Vector3 position)
    {
        heldVersion.SetActive(false);
        SetRenderersActive(true);
        transform.position = position;
        isHeld = false;
    }

    private void SetRenderersActive(bool state)
    {
        // Active ou désactive tous les MeshRenderers des enfants
        foreach (MeshRenderer renderer in GetComponentsInChildren<MeshRenderer>())
        {
            renderer.enabled = state;
        }
    }
}
