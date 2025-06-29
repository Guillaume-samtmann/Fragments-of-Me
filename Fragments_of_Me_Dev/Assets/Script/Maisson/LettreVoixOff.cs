using UnityEngine;
using System.Collections;

public class LettreVoixOff : MonoBehaviour
{
    public CamRaycast camRaycast;
    public AudioSource voixOff1;
    public PickupItem pickupItem;
    private bool voixOffJouee = false;

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
            //FirstPersonScript.enabled = false;
        }
    }

    IEnumerator AttendreFinAudio()
    {
        yield return new WaitForSeconds(voixOff1.clip.length);
        pickupItem.heldVersion.SetActive(false);
        //FirstPersonScript.enabled = true;
    }
}
