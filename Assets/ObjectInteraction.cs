using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using System.Collections.Generic;

public class ObjectInteraction : MonoBehaviour
{
    public GameObject uiMessage;

    
    public void OpenUI()
    {
        if (uiMessage != null)
        {
            uiMessage.SetActive(true);
            Debug.Log("Discount claimed!");
        }
    }
    
}