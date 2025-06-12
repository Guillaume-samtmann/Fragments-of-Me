using UnityEngine;

public class TriggeurDeclencheur : MonoBehaviour
{
    public bool isCollTriggeur = false;
    public bool fleurIsColl = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isCollTriggeur = true;
            Debug.Log("Entrer dans le triggeur");
        }
        if(other.gameObject.name == "flower01")
        {
            fleurIsColl = true;
            Debug.Log("Fleur déposer");
        }
    }
}
