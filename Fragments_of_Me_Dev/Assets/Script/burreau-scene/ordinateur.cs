using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ordinateur : MonoBehaviour
{
    private bool allumerOrdinateur = false;
    public Text objTxt;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            allumerOrdinateur = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            objTxt.text = "Allez a l'ordinateur (E)";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            allumerOrdinateur = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && allumerOrdinateur)
        {
            SceneManager.LoadScene(2);
        }
    }
}
