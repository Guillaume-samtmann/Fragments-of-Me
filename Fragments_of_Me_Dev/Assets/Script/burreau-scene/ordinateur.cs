using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ordinateur : MonoBehaviour
{
    private bool allumerOrdinateur = false;
    public Text objTxt;
    public GameObject txtInsruction1;

    public GameObject ouverture;

    private void Start()
    {
        //PlayerPrefs.DeleteAll();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;

        if (PlayerPrefs.HasKey("OuvertureSceneBurreau"))
        {
            //Debug.Log("Intro déjà jouée : on cache ouverture");
            ouverture.SetActive(false);
        }
        else
        {
            //Debug.Log("Première fois : on lance l'intro");
            StartCoroutine(hiddenOuverture());
        }
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

    IEnumerator hiddenOuverture()
    {
        yield return new WaitForSeconds(4);
        ouverture.SetActive(false);
        txtInsruction1.SetActive(true);
        yield return new WaitForSeconds(3);
        txtInsruction1.SetActive(false);
        PlayerPrefs.SetInt("OuvertureSceneBurreau", 1);
        PlayerPrefs.Save();
    }
}
