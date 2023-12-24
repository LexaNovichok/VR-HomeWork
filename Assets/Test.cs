using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject CUBE;
    // Start is called before the first frame update
    void Start()
    {
        //CUBE.transform.position = new Vector3(3, 0.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    } 

    public void ButtonClick()
    {
        if (CUBE.activeSelf)
        {
            CUBE.SetActive(false);
        }
        else
        {
            CUBE.SetActive(true);
        }
    }
}
