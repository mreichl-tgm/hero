using UnityEngine;

namespace Effects.ActivatableEffects
{
    [RequireComponent(typeof(Collider2D))]
    public class ProjectileController : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D other)
        {
            if (!other.gameObject.CompareTag("Projectile") &&
                !other.gameObject.CompareTag(gameObject.transform.root.tag))
            {
                Destroy(other.gameObject);
                Destroy(gameObject);
            }
        }
    }
}