using UnityEngine;
using DG.Tweening;

public class Button : MonoBehaviour
{
    [SerializeField] private ExplosionManager _explosionManager;

    private void OnTriggerEnter(Collider other)
    {
        transform.DOLocalMoveY(-1.4f, 0.2f);
        _explosionManager.CreateBomb();
    }

    private void OnTriggerExit(Collider other)
    {
        transform.DOLocalMoveY(-1.1f, 0.2f);
    }
}
