using UnityEngine;
public class takeBook : MonoBehaviour
{
    public GameObject HeldLivre;
    public MonoBehaviour FirstPersonScript;
    public GameObject bookPanel;
    void Update()
    {
        if(HeldLivre.activeInHierarchy)
        {
            FirstPersonScript.enabled = false;
            bookPanel.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
    }
}
