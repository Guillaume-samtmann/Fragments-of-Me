using UnityEngine;

public class DoorManager : MonoBehaviour
{
    private Animator m_Animator;
    public bool canOpen = false;

    private void Start()
    {
        m_Animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canOpen = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canOpen = false;
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && canOpen)
        {
            if (!m_Animator.GetBool("isOpen"))
            {
                m_Animator.SetBool("isOpen", true);
            }
            else
            {
                m_Animator.SetBool("isOpen", false);
            }
        }
    }
}
