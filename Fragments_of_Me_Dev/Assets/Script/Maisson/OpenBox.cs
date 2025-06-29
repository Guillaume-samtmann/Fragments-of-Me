using UnityEngine;
using UnityEngine.UI;

public class OpenBox : MonoBehaviour
{
    private bool canOpen = false;
    public Text objText;

    public GameObject couvercle;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canOpen = true;
            objText.text = "(E) Ouvrir la boite";
        }
    }

    private void Update()
    {
        if(canOpen && Input.GetKeyDown(KeyCode.E))
        {
            couvercle.SetActive(false);
        }
    }


}
