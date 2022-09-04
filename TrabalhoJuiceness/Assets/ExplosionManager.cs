using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class ExplosionManager : MonoBehaviour
{
    [SerializeField] private GameObject _bombObj;
    [SerializeField] private Transform _bombSpawnPos;
    [SerializeField] private CinemachineVirtualCamera _camera;
    [SerializeField] private float _cameraShakeAmplitude;
    [SerializeField] private float _cameraShakeFrequency;
    [SerializeField] private float _cameraShakeStartDelay;
    [SerializeField] private float _cameraShakeStopDelay;
    private CinemachineBasicMultiChannelPerlin _cameraNoise;

    public void CreateBomb()
    {
        Instantiate(_bombObj, _bombSpawnPos);
        StartCoroutine(CameraShake());
    }

    private void Start()
    {
        Initialize();
    }

    private void Initialize()
    {
        _cameraNoise = _camera.GetCinemachineComponent<Cinemachine.CinemachineBasicMultiChannelPerlin>();
    }

    private IEnumerator CameraShake()
    {
        yield return new WaitForSeconds(_cameraShakeStartDelay);
        _cameraNoise.m_AmplitudeGain = _cameraShakeAmplitude;
        _cameraNoise.m_FrequencyGain = _cameraShakeFrequency;

        yield return new WaitForSeconds(_cameraShakeStopDelay);
        _cameraNoise.m_AmplitudeGain = 0;
        _cameraNoise.m_FrequencyGain = 0;
    }
}
