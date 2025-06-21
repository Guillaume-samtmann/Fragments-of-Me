using UnityEngine;
using System.Collections;

public class LoadIntro : MonoBehaviour
{
    public CamRaycast camRaycast;
    public AudioSource voixOff1;
    public PickupItem pickupItem;
    private bool voixOffJouee = false;
    public MonoBehaviour FirstPersonScript;
    public GameObject introduction;

    void Update()
    {
        if (pickupItem.isHeld && !voixOffJouee)
        {
            camRaycast.canDrop = false;
            if (voixOff1 == null)
            {
                voixOff1 = GetComponent<AudioSource>();
            }
            voixOff1.Play();
            StartCoroutine(AttendreFinAudio());
            voixOffJouee = true;
            FirstPersonScript.enabled = false;
        }
    }

    IEnumerator AttendreFinAudio()
    {
        yield return new WaitForSeconds(voixOff1.clip.length);
        pickupItem.heldVersion.SetActive(false);
        FirstPersonScript.enabled = true;
        introduction.SetActive(true);
    }
}
