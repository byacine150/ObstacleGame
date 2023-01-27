using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train1 : MonoBehaviour
{
   bool deplacement = true;
     [SerializeField]  float speed = 2.0f;
    float minimum;
    float maximum;

    // Start is called before the first frame update

    

    void Start()
    {
     

      

    }

    // Update is called once per frame
    void Update()
    {
       
       
        float longueur2;
        float minimum;
        float maximum;


        longueur2 = transform.localScale.x / 2.0f;

      
        maximum = 15 - longueur2;
        minimum = longueur2 - 15;


        speed = 40 - (longueur2 * 4);

        if (deplacement)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime);

        if (transform.position.x >= maximum)
        {
            deplacement = false;
        }

        if (transform.position.x <= minimum)
        {
            deplacement = true;

        }

    }






}

