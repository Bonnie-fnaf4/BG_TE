using System;
using UnityEngine;

public class CollectItem : MonoBehaviour
{
    [SerializeField] private Transform visual;
    [SerializeField] private ParticleSystem particles;
    [SerializeField] private float speedRotate = 0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        visual.localRotation = Quaternion.Euler(new Vector3(visual.localRotation.eulerAngles.x + speedRotate * Time.deltaTime, visual.localRotation.eulerAngles.y, 0));
    }

    private void OnTriggerEnter(Collider other)
    {
        visual.gameObject.SetActive(false);
        Instantiate(particles, transform.position, transform.rotation);
        Destroy(gameObject, 5);
    }
}
