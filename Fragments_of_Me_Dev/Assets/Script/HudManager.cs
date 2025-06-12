using System.Collections;
using UnityEngine;

public class HudManager : MonoBehaviour
{
    public GameObject zqdsDeplacement;
    public GameObject instruction1;
    public GameObject instruction2;
    public GameObject parole;

    [Header("Parole enfant")]
    public GameObject enfantParole1;
    public GameObject enfantParole2;
    public GameObject enfantParole3;
    public GameObject enfantParole4;

    [Header("Scene d'ouverture")]
    public GameObject ouverture;

    public bool endFirstTalk = false;
    public bool endTalk = false;
    private bool coroutineLancee = false;

    public TriggeurDeclencheur triggeurDeclencheur;
    public TriggeurDeclencheur triggeurFleur;

    private void Start()
    {
        StartCoroutine(HiddenZqsd());
    }

    IEnumerator HiddenZqsd()
    {
        yield return new WaitForSeconds(2);
        ouverture.SetActive(false);
        yield return new WaitForSeconds(2);
        zqdsDeplacement.SetActive(false);
    }

    private void Update()
    {
        if (!endFirstTalk && triggeurDeclencheur.isCollTriggeur)
        {
            HiddenInstruction1();

            if (!coroutineLancee)
            {
                StartCoroutine(paroleManager());
                coroutineLancee = true;
            }
        }

        if (!endTalk)
        {
            HiddenInstruction2();
        }
    }

    private void HiddenInstruction1()
    {
        if (triggeurDeclencheur.isCollTriggeur)
        {
            instruction1.SetActive(false);
            parole.SetActive(true);
        }
    }

    IEnumerator paroleManager()
    {
        enfantParole1.SetActive(true);
        yield return new WaitForSeconds(1);

        enfantParole1.SetActive(false);
        enfantParole2.SetActive(true);
        yield return new WaitForSeconds(4);

        enfantParole2.SetActive(false);
        enfantParole3.SetActive(true);
        yield return new WaitForSeconds(4);

        enfantParole3.SetActive(false);
        instruction2.SetActive(true);
        endFirstTalk = true;
    }

    private void HiddenInstruction2()
    {
        if (triggeurFleur.fleurIsColl)
        {
            instruction2.SetActive(false);
            bool coroutineRun = false;
            if(!coroutineRun)
            {
                coroutineRun = true;
                StartCoroutine(parole4Manager());
            }
        }
    }

    IEnumerator parole4Manager()
    {
        yield return new WaitForSeconds(1);
        enfantParole4.SetActive(true);
        endTalk = true;
    }

}
