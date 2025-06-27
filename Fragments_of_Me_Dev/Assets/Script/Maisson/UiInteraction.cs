using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiInteraction : MonoBehaviour
{
    public GameObject boxMereHeld;
    public TextMeshProUGUI inscrution;

    public void DropBox()
    {
        if(boxMereHeld.activeInHierarchy)
        {
            inscrution.text = "Déposer la boite sur le burreau";
        }
    }   

    private void FixedUpdate()
    {
        DropBox();
    }
}
