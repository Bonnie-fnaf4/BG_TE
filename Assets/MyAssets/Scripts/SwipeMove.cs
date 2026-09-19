using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeMove : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public float sensitivity = 1.0f;

    public Vector2 swipe;
    private Vector2 oldSwipe = Vector2.zero;

    private Vector2 dragStartPosition;
    
    private float _endL = 2f; 
    private float _endR = 2f;

    public void SetEnd(float endL, float endR)
    {
        _endL = endL;
        _endR = endR;
    }
    
    public void OnBeginDrag(PointerEventData eventData)
    {
        dragStartPosition = eventData.position;
    }
    
    public void OnDrag(PointerEventData eventData)
    {
        Vector2 currentDelta = (eventData.position - dragStartPosition) * sensitivity;
        swipe = new Vector2(Mathf.Clamp(currentDelta.x + oldSwipe.x, -_endL, _endR), 0);
    }
    
    public void OnEndDrag(PointerEventData eventData)
    {
        oldSwipe = swipe;
    }
}
