using UnityEngine;
using UnityEngine.SceneManagement;

public class UiOrdinateur : MonoBehaviour
{
    public GameObject panelAccueil;
    public GameObject panelMail;
    public GameObject panelExcel;

    public GameObject btnExcel;

    public InputOrdinateur inputOrdinateur;

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void ShowMailInterface()
    {
        panelMail.SetActive(true);
        panelAccueil.SetActive(false);
        panelExcel.SetActive(false);
        inputOrdinateur.showNotif.SetActive(false);
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
    }
}
