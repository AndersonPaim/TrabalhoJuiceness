using System.Collections;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] private float _destroyDelay;

    private void Awake()
    {
        StartCoroutine(DestroyObject());
    }

    private IEnumerator DestroyObject()
    {
        yield return new WaitForSeconds(_destroyDelay);
        Object.DestroyImmediate(gameObject);
    }
}
