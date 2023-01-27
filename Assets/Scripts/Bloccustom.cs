using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bloccustom : MonoBehaviour
{
    [SerializeField] private float vitesse = 2.0f; // Pour contr�ler la vitesse de d�placement du cube
                                                   // La valeur par d�faut est 2.0. Elle peut �tre modifi�e dans l'inspecteur�
                                                   // ATTENTION: si la vitesse est de z�ro, alors le cube ne bougera pas
 


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Lecture de la direction
        float horizontal = Input.GetAxis("Horizontal") * vitesse * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * vitesse * Time.deltaTime;

        // Calcul des nouvelles positions
        float positionX = transform.position.x + horizontal;
        float positionZ = transform.position.z + vertical;



        if (positionX >= -7 && positionX <= 7 && positionZ >= -14.9 && positionZ < 15)
        {
            transform.position = new Vector3(positionX, 0.13f, positionZ);
        }

        if (positionZ > 15 && positionZ <= 54.875f && positionX <= 14.875f && positionX >= -14.875f)
        {
            transform.position = new Vector3(positionX, 0.13f, positionZ);
        }



        if (Input.GetKey(KeyCode.Alpha1))
        {
            transform.position = new Vector3(0, transform.position.y, 16);
        }



        if (Input.GetKey(KeyCode.Alpha2))
        {
            transform.position = new Vector3(0, transform.position.y, 46);
        }




    }




    void OnTriggerEnter(Collider other) {
        // Lecture de la direction
        float horizontal = Input.GetAxis("Horizontal") * vitesse * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * vitesse * Time.deltaTime;

        // Calcul des nouvelles positions
        float positionX = transform.position.x + horizontal;
        float positionZ = transform.position.z + vertical;

        if (positionZ < 15)
        {

            transform.position = new Vector3(0, transform.position.y, -14) ; 
        

        }


        if (positionZ > 15 && positionZ < 44)
        {
            transform.position = new Vector3(0, transform.position.y, 16);


        }



    }

}
