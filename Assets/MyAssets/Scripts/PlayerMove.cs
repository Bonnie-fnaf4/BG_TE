using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private bool isWalk = true;
    [SerializeField] private float speed = 5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void StopMove()
    {
        isWalk = false;
    }

    public void StartMove()
    {
        isWalk = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isWalk) transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
