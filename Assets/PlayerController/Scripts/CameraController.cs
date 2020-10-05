using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CameraController : MonoBehaviour
{
   
    [Header("Camera target position")]
    public Transform Target;

    [Header("Camera Aim Settings")]
    public float VerticalSensitivity;
    public float HorizontalSensitivity;
    public float MaxLookUpAngle;
    public float MinLookUpAngle;
    public float FOV;
    Vector2 mouseInput;
    float rotX=0, rotY=0;
    bool aimingDownSights = false;
    float Xsensitivity;
    float Ysensitivity;
    Camera main;
    public PlayerInputController playerInputController;
    

    void Start()
    {
        main = GetComponent<Camera>();
       
    }

    private void Update()
    {
        #region CameraMovement
        mouseInput = playerInputController.inputActions.Player.Look.ReadValue<Vector2>();
        rotX += mouseInput.x * Xsensitivity;
        rotY += mouseInput.y * Ysensitivity;
        rotY = Mathf.Clamp(rotY, MinLookUpAngle, MaxLookUpAngle);
        transform.localRotation = Quaternion.Euler(-rotY, rotX, -0.5f);
        main.fieldOfView = Mathf.Lerp(main.fieldOfView, FOV, 0);
        Xsensitivity = HorizontalSensitivity;
        Ysensitivity = VerticalSensitivity;
        #endregion


    }
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Target.position;
    }
}
