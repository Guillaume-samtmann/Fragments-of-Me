using UnityEngine;
using System.Collections;

public class uiLettreManager : MonoBehaviour
{
    public AudioSource voixOff1;
    private bool voixOffJouee = false;
    public MonoBehaviour FirstPersonScript;
    public GameObject TabInventaireLettre;
    public GameObject BoxPere;
    public GameObject introduction;

    public void loadLettreMere()
    {
        voixOff1.Play();
        StartCoroutine(AttendreFinAudio());
        voixOffJouee = true;
    }

    public void loadLettrePere()
    {
        voixOff1.Play();
        StartCoroutine(AttendreFinAudio2());
        voixOffJouee = true;
    }

    IEnumerator AttendreFinAudio()
    {
        yield return new WaitForSeconds(voixOff1.clip.length);
        BoxPere.SetActive(true);
    }

    IEnumerator AttendreFinAudio2()
    {
        yield return new WaitForSeconds(voixOff1.clip.length);
        introduction.SetActive(true);
        TabInventaireLettre.SetActive(false);
    }

    public void close()
    {
        TabInventaireLettre.SetActive(false);
        FirstPersonScript.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
