using UnityEngine;

namespace Characters.Ai
{
    public class AiSpawner : Movement
    {
        [SerializeField]
        private GameObject[] _spawnedAis;
        [SerializeField]
        private float _spawnRate;

        private Vector3 _spawnPoint;
        private float _nextSpawn;

        private void FixedUpdate() {
            _spawnPoint = transform.position;

            if (!(Time.time > _nextSpawn + _spawnRate / 100)) return;
            _nextSpawn = Time.time;

            Instantiate(_spawnedAis[Random.Range(0, _spawnedAis.Length)], _spawnPoint, Quaternion.identity);
        }
    }
}
