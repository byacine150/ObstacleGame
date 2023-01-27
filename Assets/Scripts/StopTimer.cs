using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTimer : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Find("Stopwatch").SendMessage("Finnish");
        GameObject.Find("Arrive").SendMessage("Arrived");
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
