using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Message : MonoBehaviour
{

    [SerializeField] public Text Arrive;


    public void Arrived()
    {
        // Arrive.transform.position = new Vector3(538, 360, 30);
        Arrive.text = "Épreuve réussie !";
    }


    // Start is called before the first frame update
    void Start()
    {
        Arrive.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
