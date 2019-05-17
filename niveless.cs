using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class niveless : MonoBehaviour
{

    public Image inicio;
    public Image tuto;
    public Image tuto2;
    public Image tuto3;
    public Button button;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button1tras;
    public Button button2tras;
    public Button button3tras;

    // Start is called before the first frame update
    void Start()
    {
        tuto.enabled = false;
        tuto2.enabled = false;
        tuto3.enabled = false;
        button1.enabled = false;
        button2.enabled = false;
        button3.enabled = false;
        button1tras.enabled = false;
        button2tras.enabled = false;
        button3tras.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void destruir()
    {
        inicio.enabled = false;
        tuto.enabled = true;
        button.enabled = false;
        button1.enabled = true;
        button3.enabled = false;
        button1tras.enabled = true;
        button2tras.enabled = false;
        button3tras.enabled = false;
    }

    public void destruir2()
    {
        tuto.enabled = false;
        tuto2.enabled = true;
        button1.enabled = false;
        button2.enabled = true;
        button1tras.enabled = false;
        button2tras.enabled = true;
    }

    public void volver2()
    {
        inicio.enabled = true;
        tuto.enabled = false;
        button.enabled = true;

    }

    public void destruir3()
    {
        tuto2.enabled = false;
        tuto3.enabled = true;
        button2.enabled = false;
        button3.enabled = true;
        button3tras.enabled = true;
    }

    public void volver3()
    {
        tuto2.enabled = false;
        tuto.enabled = true;
        button2.enabled = true;
        button3.enabled = false;
        button1tras.enabled = true;
    }

    public void volver4()
    {
        tuto3.enabled = false;
        tuto2.enabled = true;
        
    }

    public void irAjuego()
    {
        SceneManager.LoadScene(1);
    }

}
