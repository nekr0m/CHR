using UnityEngine;
using UnityEngine.EventSystems;

public class buttons : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool Press = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        Press = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        Press = false;
    }
}
