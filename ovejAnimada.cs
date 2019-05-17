using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ovejAnimada : MonoBehaviour
{
    public Animator Anim2;
    public Transform MiTransform2;
    public float VelocidadMovimiento2 = 2;
    private bool caminar;
    private int x;
    private int tiempo;
    private int duracion;
    public float velocidad;
    private float distan;
    private float rot;
    //parte de Carmen
    // Start is called before the first frame update
    void Start()
    {
        Anim2 = GetComponent<Animator>();
        MiTransform2 = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Num: " + x);
        //Debug.Log(caminar);
        if (!caminar) x = Random.Range(0, 200);
        if (x == 0 && !caminar)
        {
            tiempo  = Random.Range(180, 300);
            duracion = 0;
            caminar = true;
        }
            //Anim2.SetBool("isIdle", true);
        if (transform.position.y > 0)
        {
            Anim2.SetBool("isAire",true);
            Anim2.SetBool("isCaminar", false);
            caminar = false;
        }
        else if (caminar)
        {
            distan = velocidad * Time.deltaTime;
            MiTransform2.transform.Translate(Vector3.forward * distan, Space.Self);
            rot = Random.Range(1, 4);
            int y = Random.Range(0, 2);
            if (y == 0) rot *= -1;
            int rotar = Random.Range(0, 20);
            if(rotar == 0) MiTransform2.transform.Rotate(0, rot, 0, Space.Self);
            //Debug.Log("Dur: " + duracion);
            Anim2.SetBool("isCaminar", true);
            if (duracion > tiempo)
            {
                caminar = false;
                Anim2.SetBool("isCaminar", false);
            }
            duracion++;
        }
        else if (transform.position.y < 0)
        {
            Anim2.SetBool("isAire", false);
        }
    }
}
