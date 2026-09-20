using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class CollectItem : MonoBehaviour
{
    [SerializeField] private Transform visual;
    [SerializeField] private ParticleSystem particles;
    [SerializeField] private AudioSource audioSource;

    [SerializeField] private bool isMoney;
    
    private float speedRotate = 15f;
    void Start()
    {
        speedRotate = Random.Range(15f, 30f);
    }

    // Update is called once per frame
    void Update()
    {
        visual.localRotation = Quaternion.Euler(new Vector3(visual.localRotation.eulerAngles.x, visual.localRotation.eulerAngles.y + speedRotate * Time.deltaTime, 0));
    }

    private void OnTriggerEnter(Collider other)
    {
        visual.gameObject.SetActive(false);
        Instantiate(particles, transform.position, transform.rotation);
        
        audioSource.Play();

        if (isMoney)
        {
            var collectMoney = FindFirstObjectByType<CoinCollect>();
        
            collectMoney.AddCollect();   
        }
        
        Destroy(gameObject, 5);
    }
}
