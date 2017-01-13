namespace Assets.Scripts.Character.AI
{
    public class AISpawner : MonoBehaviour {

        [SerializeField]
        private GameObject[] targets;
        [SerializeField]
        private float spawnRate;

        private Vector3 spawnPoint;
        private float last;

        void FixedUpdate() {
            spawnPoint = transform.position;

            if (Time.time > last + spawnRate / 100) {
                last = Time.time;

                Instantiate(targets [Random.Range(0, targets.Length)], spawnPoint, Quaternion.identity);
            }
        }
    }
}
