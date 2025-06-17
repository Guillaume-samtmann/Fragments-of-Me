using UnityEngine;
public class takeBook : MonoBehaviour
{
    public GameObject HeldLivre;
    public MonoBehaviour FirstPersonScript;
    public GameObject bookPanel;
    public MeshRenderer Livre;

    public PickupItem pickupItem;
    void Update()
    {
        if(HeldLivre.activeInHierarchy)
        {
            FirstPersonScript.enabled = false;
            bookPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
            if(Input.GetKeyUp(KeyCode.Tab)) 
            {
                bookPanel.SetActive(false);
                FirstPersonScript.enabled = true;
                Cursor.visible = false;
                HeldLivre.SetActive(false);
                pickupItem.isHeld = false;
                Livre.enabled = true;
            }
        }
    }
}
