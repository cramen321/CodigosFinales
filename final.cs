using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class final : MonoBehaviour
{
    void Start()
    {
        Invoke("irAfinal", 2550 * Time.deltaTime);
    }
    public void irAfinal()
    {
        SceneManager.LoadScene(2);
    }
}
