using Attributes;
using UnityEngine;

namespace Effects.ActivatableEffects
{
    [RequireComponent(typeof(Collider2D))]
    public class ProjectileController : MonoBehaviour
    {
        [SerializeField] private Attribute _damage;

        public Attribute Damage { get { return _damage; } }

        private void OnTriggerEnter2D(Collider2D other)
        {

            if (other.gameObject.CompareTag("Projectile") ||
                other.gameObject.CompareTag(gameObject.transform.root.tag)) return;

            Destroy(gameObject);
        }
    }
}