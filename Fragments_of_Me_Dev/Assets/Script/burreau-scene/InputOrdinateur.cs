using System.Collections;
using TMPro;
using UnityEngine;

public class InputOrdinateur : MonoBehaviour
{
    public TMP_InputField inputReport;
    public TMP_InputField inputImmoCorpo;
    public TMP_InputField inputChargeDiv1;
    public TMP_InputField inputChargeDiv2;
    public TMP_InputField inputCompteLiv;
    public TMP_InputField inputCaisse;
    public TMP_InputField inputEdf1;
    public TMP_InputField inputEdf2;

    public bool complete1 = false;
    private bool complete2 = false;
    private bool complete3 = false;
    private bool complete4 = false;
    private bool complete5 = false;
    private bool complete6 = false;
    private bool complete7 = false;
    private bool complete8 = false;
    private bool canLook = true;

    public bool allComplete = false;
    public bool loadCoroutine = true;

    public GameObject fishExecl;

    public GameObject excelInterface;
    public GameObject mailActive;
    public GameObject mailActiveReproche;
    public GameObject mailInactiveUrg;
    public GameObject mailReprocheLecture;
    public GameObject mailUrgLecture;
    public GameObject showNotif;

    private void Update()
    {
        CompleteInput();
        if(complete1 && complete2 && complete3 && complete4 && complete5 && complete6 && complete7 && complete8)
        {
            allComplete = true;
            canLook = false;
        }

        if (loadCoroutine)
        {
            StartCoroutine(fishMissionExcel());
        }

        if (allComplete)
        {
            mailActive.SetActive(false);
            mailActiveReproche.SetActive(true);
            mailInactiveUrg.SetActive(true);
            mailReprocheLecture.SetActive(true);
            mailUrgLecture.SetActive(false);
            showNotif.SetActive(true);
        }

        if(!excelInterface.activeInHierarchy)
        {
            complete1 = false;
            complete2 = false;
            complete3 = false;
            complete4 = false;
            complete5 = false;
            complete6 = false;
            complete7 = false;
            complete8 = false;
            allComplete = false;
        }
    }

    public void CompleteInput()
    {
        if(!allComplete && canLook)
        {
            if (inputReport.text == "10000" || inputReport.text == "10 000")
            {
                Debug.Log("Input1 complete ok");
                complete1 = true;
            }
            if (inputImmoCorpo.text == "60000" || inputImmoCorpo.text == "60 000")
            {
                Debug.Log("Input2 complete ok");
                complete2 = true;
            }
            if (inputChargeDiv1.text == "3000" || inputChargeDiv1.text == "3 000")
            {
                Debug.Log("Input3 complete ok");
                complete3 = true;
            }
            if (inputChargeDiv2.text == "3000" || inputChargeDiv2.text == "3 000")
            {
                Debug.Log("Input4 complete ok");
                complete4 = true;
            }
            if (inputCompteLiv.text == "23 000" || inputCompteLiv.text == "23000")
            {
                Debug.Log("Input5 complete ok");
                complete5 = true;
            }
            if (inputCaisse.text == "10 000" || inputCaisse.text == "10000")
            {
                Debug.Log("Input6 complete ok");
                complete6 = true;
            }
            if (inputEdf1.text == "1 000" || inputEdf1.text == "1000")
            {
                Debug.Log("Input7 complete ok");
                complete7 = true;
            }
            if (inputEdf2.text == "60" || inputEdf2.text == "60")
            {
                Debug.Log("Input8 complete ok");
                complete8 = true;
            }
        }
    }

    IEnumerator fishMissionExcel()
    {
        if (allComplete)
        {
            fishExecl.SetActive(true);
            yield return new WaitForSeconds(3);
            fishExecl.SetActive(false);
            loadCoroutine = false;
            canLook = false;
        }
    }
}
