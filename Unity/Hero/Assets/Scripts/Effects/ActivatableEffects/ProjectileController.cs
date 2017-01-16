using UnityEngine;

namespace Effects.ActivatableEffects
{
    [RequireComponent(typeof(Collider2D))]
    public class ProjectileController : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Projectile") ||
                other.gameObject.CompareTag(gameObject.transform.root.tag)) return;

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}