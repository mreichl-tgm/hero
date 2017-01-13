namespace Assets.Scripts.Item
{
    public class ItemModel : MonoBehaviour {
	
        [SerializeField]
        private ItemType type;
        [SerializeField]
        private string description;

        public int damage;
    }
}