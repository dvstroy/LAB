using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public bool DockKey, LivingKey, OfficeKey, ObserveKey;
    public GameObject DockKeyObject, LivingKeyObject, OfficeKeyObject, ObserveKeyObject;
    
    // Start is called before the first frame update
    void Start()
    {
        DockKey = false;
        LivingKey = false;
        OfficeKey = false;
        ObserveKey = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
