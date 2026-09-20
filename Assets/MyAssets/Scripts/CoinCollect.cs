using DG.Tweening;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public int coin = 10;
    [SerializeField] private  Animator animator;
    [SerializeField] private GameObject Color1, Color2, Color3;


    public void AddCollect()
    {
        coin += 1;

        if (coin > 30)
        {
            Color1.SetActive(false);
            Color2.SetActive(true);
            Color3.SetActive(false);
            animator.SetTrigger("Walk");
        }
        
        if(coin >= 50)
        {
            Color3.SetActive(true);
            Color2.SetActive(false);
            animator.SetTrigger("HappyWalk");
        }
    }
}
