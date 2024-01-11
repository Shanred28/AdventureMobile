using UnityEngine;
using UnityEngine.EventSystems;

public class VirtualJoystick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    //TODO
    public static Vector2 Value { get; private set; }

    [SerializeField] private RectTransform _stickArea;
    [SerializeField] private RectTransform _stick;

    public void OnPointerDown(PointerEventData eventData)
    {
        Move(eventData.position);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _stick.anchoredPosition = Vector2.zero;
        Value = Vector2.zero;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Move(eventData.position);
    }

    private void Move(Vector2 newPosition)
    { 
        _stick.position = newPosition;
        if (_stick.anchoredPosition.magnitude > _stickArea.sizeDelta.x / 2)
        {
            _stick.anchoredPosition = _stick.anchoredPosition.normalized * (_stickArea.sizeDelta.x / 2);
        }

        Value = new Vector2(_stick.anchoredPosition.x, _stick.anchoredPosition.y).normalized;
    }
}
