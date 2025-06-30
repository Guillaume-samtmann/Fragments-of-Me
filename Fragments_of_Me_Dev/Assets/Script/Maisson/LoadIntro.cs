using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadIntro : MonoBehaviour
{
    private void Start()
    {
        if(gameObject.activeInHierarchy)
        {
            StartCoroutine(loadIsland());
        }
    }

    IEnumerator loadIsland()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(4);
    }
}
