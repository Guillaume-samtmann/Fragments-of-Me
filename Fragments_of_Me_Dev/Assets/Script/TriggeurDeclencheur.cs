using UnityEngine;
using UnityEngine.UI;

public class TriggeurDeclencheur : MonoBehaviour
{
    public bool isCollTriggeur = false;
    public bool fleurIsColl = false;

    public HudManager hudManager;
    public CamRaycast camRaycast;

    public Text objTxt;
    public PickupItem currentItem;

    private void Start()
    {
        camRaycast.canDrop = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isCollTriggeur = true;
            Debug.Log("Entrer dans le triggeur");
        }
        if(hudManager.endFirstTalk)
        {
            camRaycast.canDrop = true;
            if(other.gameObject.name == "flower01")
            {
                fleurIsColl = true;
                Debug.Log("Fleur déposer");
            }
        }
        else
        {
            Debug.Log("Impossible de le déposer maintenant");
            camRaycast.canDrop = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (currentItem.isHeld)
        {
            objTxt.text = "(F) relacher";
        }
        else
        {
            objTxt.text = "";
        }
    }
    private void OnTriggerExit(Collider other)
    {
        camRaycast.canDrop = true;
    }
}
