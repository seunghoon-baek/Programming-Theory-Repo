using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody playerRb;
    [SerializeField] float playerSpeed;
    Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        playerSpeed = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        RotatePlayer();
    }

    void MovePlayer ()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * playerSpeed * horizontalInput * Time.deltaTime, Space.World);
        transform.Translate(Vector3.forward * playerSpeed * verticalInput * Time.deltaTime, Space.World);
    }

    void Shot()
    {
        
    }

    void RotatePlayer()
    {
        mousePos = Input.mousePosition;
        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);

        float diff_x = (objectPos.x - mousePos.x);
        float diff_y = (objectPos.y - mousePos.y);
        float angle = Mathf.Atan2(diff_y, diff_x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 270 - angle, 0));       
        
    }
}
