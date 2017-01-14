using UnityEngine;

namespace Character.Ai
{
    public class AiSpawner : Movement
    {
        [SerializeField]
        private GameObject[] _spawnedAis;
        [SerializeField]
        private float _spawnRate;

        private Vector3 _spawnPoint;
        private float _nextSpawn;

        void FixedUpdate() {
            _spawnPoint = transform.position;

            if (Time.time > _nextSpawn + _spawnRate / 100) {
                _nextSpawn = Time.time;

                Instantiate(_spawnedAis[Random.Range(0, _spawnedAis.Length)], _spawnPoint, Quaternion.identity);
            }
        }
    }
}
