using TMPro;
using UnityEngine;

public class uiBook : MonoBehaviour
{
    public TextMeshProUGUI textInset;
    public GameObject choix_01;
    public TextMeshProUGUI choix1;
    public TextMeshProUGUI choix2;
    public GameObject text2;


    public void choix01()
    {
        textInset.text = choix1.text;
        choix_01.SetActive(false);
        text2.SetActive(true);
    }

    public void choix02()
    {
        textInset.text = choix2.text;
        choix_01.SetActive(false);
        text2.SetActive(true);
    }

    public void test()
    {
        Debug.Log("rzes");
    }
}
