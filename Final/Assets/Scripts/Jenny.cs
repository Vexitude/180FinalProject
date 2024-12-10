using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

/*
 * Name: Alan Buell
 * Date: 12/10/024
 * Des: Allows Jenny (dateable character) to blink, working on her reactions
 */
public class Jenny : MonoBehaviour
{
    public GameObject JennyOpen;
    public GameObject JennyClosed;
    public int BlinkInterval = 5;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("JennyBlink", 1, BlinkInterval);
    }

    private void Update()
    {
        
    }

    private void JennyBlink()
    {

        StartCoroutine(WaitToBlink());
    }
    

    private IEnumerator WaitToBlink()
    {
        JennyClosed.SetActive(true);

        yield return new WaitForSeconds(0.25f);
        JennyClosed.SetActive(false);

    }

}
