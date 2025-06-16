using UnityEngine;
public class takeBook : MonoBehaviour
{
    public GameObject HeldLivre;
    public MonoBehaviour FirstPersonScript;
    void Update()
    {
        if(HeldLivre.activeInHierarchy)
        {
            FirstPersonScript.enabled = false;
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = true;
        }
    }
}
