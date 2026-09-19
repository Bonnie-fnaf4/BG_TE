using UnityEngine;

public class PlayerHorizontalMove : MonoBehaviour
{
    [SerializeField] private SwipeMove _swipeMove; 
    
    [SerializeField] private float _endL = 2f; 
    [SerializeField] private float _endR = 2f;
    
    [SerializeField] private float _smoothSpeed = 20f;
    private float _currentLocalX = 0f;

    void Start()
    {
        _swipeMove.SetEnd(_endL, _endR);
        _currentLocalX = transform.localPosition.x;
    }

    void Update()
    {
        float deltaX = _swipeMove.swipe.x;
        
        _currentLocalX = deltaX;
        
        _currentLocalX = Mathf.Clamp(_currentLocalX, -GetEndL(), GetEndR());
        
        Vector3 targetLocalPos = new Vector3(_currentLocalX, transform.localPosition.y, transform.localPosition.z);

        transform.localPosition = Vector3.Lerp(transform.localPosition, targetLocalPos, _smoothSpeed * Time.deltaTime);
    }
    
    public float GetEndR()
    {
        return _endR;
    }

    public float GetEndL()
    {
        return _endL;
    }
}