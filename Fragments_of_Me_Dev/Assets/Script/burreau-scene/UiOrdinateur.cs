using UnityEngine;
using UnityEngine.SceneManagement;

public class UiOrdinateur : MonoBehaviour
{
    public GameObject panelAccueil;
    public GameObject panelMail;

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void ShowMailInterface()
    {
        panelMail.SetActive(true);
        panelAccueil.SetActive(false);
    }

    public void ShowAccueil()
    {
        panelAccueil.SetActive(true);
        panelMail.SetActive(false);
    }

    public void QuitOrdi()
    {
        SceneManager.LoadScene(1);
    }
}
