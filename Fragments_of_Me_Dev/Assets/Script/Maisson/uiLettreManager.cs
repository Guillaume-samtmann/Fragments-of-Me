using UnityEngine;
using System.Collections;

public class uiLettreManager : MonoBehaviour
{
    public AudioSource voixOff1;
    private bool voixOffJouee = false;
    public MonoBehaviour FirstPersonScript;
    public GameObject TabInventaireLettreMere;

    public void loadLettreMere()
    {
        voixOff1.Play();
        StartCoroutine(AttendreFinAudio());
        voixOffJouee = true;
        FirstPersonScript.enabled = false;
    }

    IEnumerator AttendreFinAudio()
    {
        yield return new WaitForSeconds(voixOff1.clip.length);
        FirstPersonScript.enabled = true;
    }

    public void close()
    {
        TabInventaireLettreMere.SetActive(false);
        FirstPersonScript.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
