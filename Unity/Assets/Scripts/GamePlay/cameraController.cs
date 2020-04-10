﻿using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Build.Player;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public float rotationSpeed;
    public Transform target;
    private float mouseX, mouseY;

    // Update is called once per frame
    void LateUpdate()
    {

        if (GameManager.gameOver == true)
        {
            this.enabled = false;
            return;
        }
        
        mouseX += rotationSpeed * Input.GetAxis("Mouse X");
        mouseY -= rotationSpeed * Input.GetAxis("Mouse Y");
        mouseY = Mathf.Clamp(mouseY, -60f, 30f);
        
        transform.LookAt(target);
        target.rotation = Quaternion.Euler(mouseY, mouseX, 0f);

        if (Time.timeScale == 0)
        {
            mouseX = 0;
            mouseY = 0;
            transform.LookAt(target);
            target.rotation = Quaternion.Euler(mouseY, mouseX, 0f);
        }
        
        
    }
}
