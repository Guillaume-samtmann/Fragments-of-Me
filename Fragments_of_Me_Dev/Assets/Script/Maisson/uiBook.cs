using TMPro;
using UnityEngine;

public class uiBook : MonoBehaviour
{
    public TextMeshProUGUI textInset;
    public TextMeshProUGUI choix1;
    public TextMeshProUGUI choix2;


    public void choix01()
    {
        textInset.text = choix1.text;
    }

    public void choix02()
    {
        textInset.text = choix2.text;
    }

    public void test()
    {
        Debug.Log("rzes");
    }
}
