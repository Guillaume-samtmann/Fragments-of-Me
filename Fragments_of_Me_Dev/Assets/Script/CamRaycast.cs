using UnityEngine;
using UnityEngine.UI;

public class CamRaycast : MonoBehaviour
{
    private GameObject previousHittedObject;
    private GameObject hittedObject;
    public Text objTxt;

    [Header("item")]
    private PickupItem currentItem;

    [Header("Condition")]
    private bool canPickUp = false;

    public bool canDrop = true;


    private void HighlightObject(GameObject obj, bool highlight)
    {
        Outline outline = obj.GetComponent<Outline>();
        if (outline != null)
        {
            outline.enabled = highlight;
        }
    }

    private void FixedUpdate()
    {
        RaycastHit hit;
        float raycastDistance = 2.0f;

        if(Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, raycastDistance))
        {
            hittedObject = hit.transform.gameObject;
            PickupItem item = hittedObject.GetComponent<PickupItem>();

            if(item != null && !item.isHeld) 
            {
                currentItem = item;
                canPickUp = true;
                objTxt.text = item.itemName + (" (E)");
                Debug.Log("Appuie sur E pour ramasser : " + item.itemName);
            }
            else
            {
                //currentItem = null;
                canPickUp = false;
                objTxt.text = "";
            }
        }
        else
        {
            hittedObject = null;
            //currentItem = null;
            canPickUp = false;
            objTxt.text = "";
        }

        if (previousHittedObject != hittedObject)
        {
            if (previousHittedObject != null)
            {
                HighlightObject(previousHittedObject, false);
            }
            previousHittedObject = hittedObject;
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && canPickUp && currentItem != null)
        {
            currentItem.PickUp();
        }

        if(Input.GetKeyDown(KeyCode.F) && currentItem.isHeld && canDrop)
        {
            Vector3 dropPosition = Camera.main.transform.position + Camera.main.transform.forward * 1f;
            currentItem.Drop(dropPosition);
        }
    }
}
