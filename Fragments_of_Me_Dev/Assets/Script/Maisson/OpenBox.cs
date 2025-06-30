using UnityEngine;
using UnityEngine.UI;

public class OpenBox : MonoBehaviour
{
    private bool canOpen = false;
    public Text objText;

    public GameObject couvercle;
    public GameObject lettreMere;
    public GameObject OpenBoxTrig;
    public GameObject TabInventaireLettreMere;
    public MonoBehaviour FirstPersonScript;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canOpen = true;
            objText.text = "(E) Ouvrir la boite";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        canOpen = false;
    }

    private void Update()
    {
        if(canOpen && Input.GetKeyDown(KeyCode.E))
        {
            couvercle.SetActive(false);
            //lettreMere.transform.SetParent(null);
            //OpenBoxTrig.SetActive(false);
            //rbBox.useGravity = false;
            TabInventaireLettreMere.SetActive(true);
            FirstPersonScript.enabled = false;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
            Debug.Log(canOpen);
        }
    }
}
