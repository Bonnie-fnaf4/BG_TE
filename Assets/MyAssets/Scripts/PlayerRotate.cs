using System;
using DG.Tweening;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    [SerializeField] private PlayerMove _playerMove;

    private void OnTriggerEnter(Collider other)
    {
        var point =  other.transform.GetComponentInParent<PointToRotate>();

        if (point != null)
        {
            _playerMove.StopMove();
            _playerMove.transform.DORotate(point.vectorRotate, 1).OnComplete(() =>
            {
                _playerMove.StartMove();
            });
        }
    }
}
