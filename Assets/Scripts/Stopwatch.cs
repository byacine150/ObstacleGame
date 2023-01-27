using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stopwatch : MonoBehaviour
{

    float timer;
    float seconds;
    float minutes;
    bool finnished = false;

    [SerializeField] public Text stopWatchText;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (finnished)
        {
            return;
        }

        StopWatchCalcul();
    }

    public void Finnish()
    {
        finnished = true;
        stopWatchText.color = Color.blue;

    }

    void StopWatchCalcul()
    {
        timer += Time.deltaTime;
        seconds = (int)(timer % 60);
        minutes = (int)(timer / 60);

        stopWatchText.text = minutes.ToString("0") + ":" + seconds.ToString("00");


    }
}
