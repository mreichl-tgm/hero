using Attributes;
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

            other.gameObject.GetComponent<Health>().GetDamage(gameObject.transform.root.GetComponent<Damage>().Value);
            Destroy(gameObject);
        }
    }
}