using UnityEngine;
using DG.Tweening;

public class Button : MonoBehaviour
{
    [SerializeField] private ExplosionManager _explosionManager;
    [SerializeField] private ParticleSystem _buttonParticle;

    private void OnTriggerEnter(Collider other)
    {
        transform.DOLocalMoveY(-1.4f, 0.2f);
        _explosionManager.CreateBomb();
        _buttonParticle.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        transform.DOLocalMoveY(-1.1f, 0.2f);
    }
}
