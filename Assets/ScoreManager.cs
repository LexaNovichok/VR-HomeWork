using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 10; 
    public Text scoreText; 
    public float speed = 10f;
    public GameObject cube;
    public Camera camera1;
    public Camera camera2;

    private Camera activeCamera;

    void Start()
    {
        activeCamera = camera1;
        camera1.enabled = true;
        camera2.enabled = false;
    }

    void Update()
    {
        if (score == 0 && activeCamera != camera2)
        {
            SwitchCamera(camera2);
        }
        else if (score != 0 && activeCamera != camera1)
        {
            SwitchCamera(camera1);
        }
    }

    void SwitchCamera(Camera newActiveCamera)
    {
        activeCamera.enabled = false;
        newActiveCamera.enabled = true;
        activeCamera = newActiveCamera;
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 5*speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 5*speed * Time.deltaTime);
        }

        
        scoreText.text = score.ToString();
        if (score == 0)
        {
            cube.SetActive(false);
        }
    }


    public void ButtonClick()
    {
        cube.transform.position = new Vector3(3, 1, 0);
        cube.transform.rotation = Quaternion.Euler(0, 0, 0);

        Rigidbody rb = cube.GetComponent<Rigidbody>();
        rb.Sleep();
    }


    private void OnCollisionEnter(Collision collision)
    {
        score--;
    }



}
