using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.5f;

    [SerializeField] private float _heightRange = 0.45f;

    [SerializeField] private GameObject _pipe;

    private float _timer;
    
    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    private void SpawnPipe()
    {
        Vector3 spawnPosition = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange));
        GameObject pipe = Instantiate(_pipe, spawnPosition, Quaternion.identity);
        
        Destroy(pipe, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer > _maxTime)
        {
            SpawnPipe();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }
}
