using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class palillosAnimado : MonoBehaviour
{
    public Animator Anim;
    private Transform MiTransform;
    public float VelocidadMovimiento = 2;

    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        MiTransform = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        //Movimientos();
        if (Input.GetMouseButton(0))
        {
            cerrarPalillos();
        }
   
        else
        {
           // Anim.SetBool("isIdle", false);
            Anim.SetBool("isCierre", false);
        }
    }
  
    public void cerrarPalillos()
    {
        Anim.SetBool("isCierre", true);
    }
   /* public void Movimientos(){
        if (Input.GetKey(KeyCode.W))
        {
            MiTransform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * VelocidadMovimiento);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            MiTransform.Translate(new Vector3(0, 0, -1) * Time.deltaTime * VelocidadMovimiento);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            MiTransform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * VelocidadMovimiento);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            MiTransform.Translate(new Vector3(1, 0, 0) * Time.deltaTime * VelocidadMovimiento);
        }
    }*/

}

