using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poutres : MonoBehaviour
{

    [SerializeField] private Vector3 axeRotation;
    [SerializeField] private float vitesseRotation;
    int sens;


    // Start is called before the first frame update
    void Start()
    {
      

        int angleInitial = Random.Range(1, 361); // retourne 1, 2 ou 3
        transform.Rotate(angleInitial, 0, 0);

        vitesseRotation = Random.Range(120,170); // retourne 1, 2 ou 3

        sens = Random.Range(1, 3);
        

    }

    // Update is called once per frame
    void Update()
    {
        float angle = vitesseRotation * Time.deltaTime;
        if (sens == 1)
        {
            transform.Rotate(axeRotation, angle);
        }

        if (sens == 2)
        {
            transform.Rotate(axeRotation, -angle);
        }
    }
}
