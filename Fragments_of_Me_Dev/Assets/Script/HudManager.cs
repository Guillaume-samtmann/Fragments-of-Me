using System.Collections;
using UnityEngine;

public class HudManager : MonoBehaviour
{
    public GameObject zqdsDeplacement;

    private void Start()
    {
        StartCoroutine(HiddenZqsd());
    }


    IEnumerator HiddenZqsd()
    {
        yield return new WaitForSeconds(2);
        zqdsDeplacement.SetActive(false);
    }

}
