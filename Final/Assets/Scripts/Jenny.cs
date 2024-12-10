using System.Collections;
using System.Collections.Generic;
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



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("JennyBlink", 0.5f, 0.5f);
    }

    private void Update()
    {
        
    }
    private void JennyBlink()
    {
        int randNum = Random.Range(0, 2);

        if(randNum == 0)
        {
            Instantiate(JennyOpen,transform.position, Quaternion.identity);
        }
        else if (randNum == 1)
        {
            Instantiate(JennyClosed, transform.position, Quaternion.identity);
        }
    }
}
