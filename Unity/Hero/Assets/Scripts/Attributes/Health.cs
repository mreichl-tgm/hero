namespace Attributes
{
    public class Health : Attribute
    {
        public void GetDamage(int dmg)
        {
            Value -= dmg;

            if (Value <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}