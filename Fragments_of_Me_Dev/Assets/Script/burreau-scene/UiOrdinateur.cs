using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiOrdinateur : MonoBehaviour
{
    public GameObject panelAccueil;
    public GameObject panelMail;
    public GameObject panelExcel;
    public GameObject discussion;

    public GameObject btnExcel;

    public InputOrdinateur inputOrdinateur;

    private bool loadCoroutine = true;

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    private void Update()
    {
        if(panelMail.activeInHierarchy)
        {
            inputOrdinateur.showNotif.SetActive(false);

            if (inputOrdinateur.mailReprocheLecture.activeInHierarchy)
            {
                if (loadCoroutine)
                {
                    StartCoroutine(loadDiscussion());
                }
            }
        }
    }

    public void ShowMailInterface()
    {
        inputOrdinateur.loadCoroutine = false;
        inputOrdinateur.allComplete = false;
        inputOrdinateur.showNotif.SetActive(false);

        panelMail.SetActive(true);
        panelAccueil.SetActive(false);
        panelExcel.SetActive(false);
    }


    public void ShowAccueil()
    {
        panelAccueil.SetActive(true);
        panelMail.SetActive(false);
        panelExcel.SetActive(false);
    }

    public void QuitOrdi()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenExcelFile()
    {
        btnExcel.SetActive(true);
        panelExcel.SetActive(true);
        panelMail.SetActive(false);
    }

    IEnumerator loadDiscussion()
    {
        loadCoroutine = false;
        yield return new WaitForSeconds(25);
        discussion.SetActive(true);
        yield return new WaitForSeconds(5);
        discussion.SetActive(false);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);
    }
}
