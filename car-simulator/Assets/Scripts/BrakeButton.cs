using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BrakeButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public CarController carController; // Drag CarController dari Inspector

    public void OnPointerDown(PointerEventData eventData)
    {
        if (carController != null)
        {
            carController.SetBraking(true);
            Debug.Log("rem");
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (carController != null)
        {
            carController.SetBraking(false);
            Debug.Log("lepas rem");
        }
    }
}
