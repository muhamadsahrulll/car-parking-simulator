using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SimpleInputButtonUI : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public string buttonName = "Vertical";
    public float buttonValue = 1f;

    private SimpleInput.AxisInput axis;

    private void Awake()
    {
        axis = new SimpleInput.AxisInput(buttonName);
    }

    private void OnEnable()
    {
        axis.StartTracking();
    }

    private void OnDisable()
    {
        axis.StopTracking();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        axis.value = buttonValue;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        axis.value = 0f;
    }
}
