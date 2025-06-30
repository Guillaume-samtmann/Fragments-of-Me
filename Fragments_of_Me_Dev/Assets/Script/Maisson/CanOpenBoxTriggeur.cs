using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CanOpenBoxTriggeur : MonoBehaviour
{
    public CamRaycast camRaycast;
    public PickupItem currentItemMere;
    public PickupItem currentItemPere;

    private bool isCollTriggeurMere = false;
    public bool boxIsCollMere = false;
    private bool inCollidMere = false;
    public GameObject triggeurBoxMere;

    private bool isCollTriggeurPere = false;
    public bool boxIsCollPere = false;
    private bool inCollidPere = false;
    public GameObject triggeurBoxPere;

    public Text objText;
    public TextMeshProUGUI inscrution;
    

    private void Start()
    {
        camRaycast.canDrop = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isCollTriggeurMere = true;
            camRaycast.canDrop = true;
        }

        if (other.gameObject.name == "box-mere")
        {
            boxIsCollMere = true;
        }

        if (other.gameObject.name == "box-pere")
        {
            boxIsCollPere = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (currentItemMere.isHeld)
        {
            objText.text = "(F) relacher";
        }else if (currentItemPere.isHeld)
        {
            objText.text = "(F) relacher";
        }
        else
        {
            objText.text = "";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        camRaycast.canDrop = true;
        objText.text = "";
    }

    private void Update()
    {
        if(boxIsCollMere && !inCollidMere)
        {
            triggeurBoxMere.SetActive(true);
            inCollidMere = true;
        }

        if (boxIsCollPere && !inCollidPere)
        {
            triggeurBoxPere.SetActive(true);
            inCollidPere = true;
        }
    }
}
