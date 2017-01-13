using UnityEngine;

namespace Character.Ai
{
    public class AiSpawner : MonoBehaviour {

        [SerializeField]
        private GameObject[] _targets;
        [SerializeField]
        private float _spawnRate;

        private Vector3 _spawnPoint;
        private float _last;

        void FixedUpdate() {
            _spawnPoint = transform.position;

            if (Time.time > _last + _spawnRate / 100) {
                _last = Time.time;

                Instantiate(_targets [Random.Range(0, _targets.Length)], _spawnPoint, Quaternion.identity);
            }
        }
    }
}
