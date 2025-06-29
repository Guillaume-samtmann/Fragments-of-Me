using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanOpenBoxTriggeur : MonoBehaviour
{
    public CamRaycast camRaycast;
    public PickupItem currentItem;

    private bool isCollTriggeur = false;
    public bool boxIsColl = false;

    public Text objText;
    public TextMeshProUGUI inscrution;
    public GameObject triggeurBox;

    private void Start()
    {
        camRaycast.canDrop = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isCollTriggeur = true;
            camRaycast.canDrop = true;
        }

        if (other.gameObject.name == "box-mere")
        {
            boxIsColl = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (currentItem.isHeld)
        {
            objText.text = "(F) relacher";
        }else
        {
            objText.text = "";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        camRaycast.canDrop = true;
    }

    private void Update()
    {
        if(boxIsColl)
        {
            triggeurBox.SetActive(true);
        }
    }
}
